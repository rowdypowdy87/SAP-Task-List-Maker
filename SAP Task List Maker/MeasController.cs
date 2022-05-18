using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public class MeasController
    {
        // Global variables
        public List<MobilityMeasurement> ExistingMeasures;
        public List<MobilityMeasurement> NewMeasures;
        public MainWindow                WinParent;
        public AUTOSAP                   Session;

        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="wParent"></param>
        public MeasController(MainWindow wParent)
        {
            WinParent   = wParent;
            Session     = new(WinParent);
            ExistingMeasures = new List<MobilityMeasurement>();
            NewMeasures = new List<MobilityMeasurement>();  
        }

        /// <summary>
        /// Load measurements from SAP
        /// </summary>
        /// <param name="EqNumber">Equipment number to use</param>
        public SAPERROR LoadMeasurements(string EqNumber)
        {
            if (Session.GetSession())
            {
                // Get measurement data
                DataTable ImportMeas = Session.GetMeasurementPoints(EqNumber);

                // Add to existing measurement list
                for(int i = 0; i < ImportMeas.Rows.Count; i++)
                {
                    MobilityMeasurement MeasToAdd = new()
                    {
                        Description     = ImportMeas.Rows[i]["Description"].ToString(),
                        Number          = ImportMeas.Rows[i]["Measurement Point"].ToString(),
                        Position        = ImportMeas.Rows[i]["Position"].ToString(),
                        CharCode        = ImportMeas.Rows[i]["Characteristic Name"].ToString(),
                        Decimals        = ImportMeas.Rows[i]["Decimal Places"].ToString(),
                        CodeGroup       = ImportMeas.Rows[i]["Code Group"].ToString(),
                        TargetValue     = ImportMeas.Rows[i]["Target Value"].ToString(),
                        LowerLimit      = ImportMeas.Rows[i]["Lower Limit"].ToString(),
                        UpperLimit      = ImportMeas.Rows[i]["Upper Limit"].ToString(),
                        IsValueCodeSuff = ImportMeas.Rows[i]["ValueCode Sufficient"].ToString(),
                        IsCounter       = ImportMeas.Rows[i]["Is Counter"].ToString(), 
                        TargetText      = ImportMeas.Rows[i]["Text"].ToString(),
                        UpdateMethod    = MEAS_UPDATE.NONE
                    };

                    ExistingMeasures.Add(MeasToAdd);
                }

                ImportMeas.Dispose();

                RefreshMeasurementTree();

                return SAPERROR.NONE;
            }
            else
                return SAPERROR.SAP_NOT_CONNECTED;
        }

        /// <summary>
        /// Add a new measurement to the list
        /// </summary>
        /// <param name="NewMeasurement"></param>
        public void AddNewMeasurment(MobilityMeasurement NewMeasurement)
        {
            NewMeasures.Add(NewMeasurement);
            RefreshMeasurementTree();
        }

        /// <summary>
        /// Get measurement from existing list
        /// </summary>
        /// <param name="index">Index of list</param>
        /// <returns></returns>
        public MobilityMeasurement GetExistingMeasurement(int index)
        {
            return ExistingMeasures[index];
        }

        public void SetExistingMeasurement(MobilityMeasurement NewMeas, int index)
        {
            ExistingMeasures[index] = NewMeas;
        }

        /// <summary>
        /// Update the tree
        /// </summary>
        public void RefreshMeasurementTree()
        {
            // Clear the children from the two root nodes
            WinParent.MeasPointsTree.Nodes[0].Nodes.Clear();
            WinParent.MeasPointsTree.Nodes[1].Nodes.Clear();


            for (int i = 0; i < ExistingMeasures.Count; i++)
            {
                TreeNode NodeToAdd;

                if (ExistingMeasures[i].Position != null && ExistingMeasures[i].Position != "")
                    NodeToAdd = new TreeNode($"[{ExistingMeasures[i].Number}] - {ExistingMeasures[i].Position} - {ExistingMeasures[i].Description}");
                else
                    NodeToAdd = new TreeNode($"[{ExistingMeasures[i].Number}] - {ExistingMeasures[i].Description}");

                WinParent.MeasPointsTree.Nodes[0].Nodes.Add(NodeToAdd);
            }
        }

        
    }
}
