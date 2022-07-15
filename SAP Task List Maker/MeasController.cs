using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public class MeasController
    {
        // Global variables
        public List<MobilityMeasurement> Measures;
        public MainWindow                WinParent;
        public AUTOSAP                   Session;

        /// <summary>
        /// Constructor method
        /// </summary>
        /// <param name="wParent"></param>
        public MeasController(MainWindow wParent)
        {
            WinParent           = wParent;
            Session             = new AUTOSAP(WinParent);
            Measures            = new List<MobilityMeasurement>();
        }

        /// <summary>
        /// Load measurements from SAP
        /// </summary>
        /// <param name="EqNumber">Equipment number to use</param>
        public SAPERROR LoadMeasurements(string EqNumber)
        {
            if (Session.GetSession())
            {
                // Get equipnment description
                Session.StartTransaction("IE02");
                Session.GetCTextField("RM63E-EQUNR").Text = EqNumber;
                Session.SendVKey(0);

                if(Session.GetSessionObj().Info.ScreenNumber == 100)
                {
                    MsgBoxs.MsgBox_Warning($"{EqNumber} doesnt exist or is locked by another user!");
                    return SAPERROR.NONE;
                }

                // Set meastree node text
                WinParent.MeasPointsTree.Nodes[0].Text = Session.GetTextField("ITOB-SHTXT").Text;

                // Get measurement data
                DataTable ImportMeas = Session.GetMeasurementPoints(EqNumber);

                // Add to existing measurement list
                for(int i = 0; i < ImportMeas.Rows.Count; i++)
                {
                    MobilityMeasurement MeasToAdd = new MobilityMeasurement()
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

                    //Debug.Print(MeasToAdd.Description);

                    Measures.Add(MeasToAdd);
                }

                ImportMeas.Dispose();

                RefreshMeasurementTree();

                return SAPERROR.NONE;
            }
            else
                return SAPERROR.SAP_NOT_CONNECTED;
        }

        /// <summary>
        /// Get measurement from existing list
        /// </summary>
        /// <param name="index">Index of list</param>
        /// <returns></returns>
        public MobilityMeasurement GetMeasurement(int index)
        {
            return Measures[index];
        }

        public void SetMeasurement(MobilityMeasurement NewMeas, int index)
        {
            Measures[index] = NewMeas;
        }

        /// <summary>
        /// Update the tree
        /// </summary>
        public void RefreshMeasurementTree()
        {
            // Clear the children from the two root nodes
            WinParent.MeasPointsTree.Nodes[0].Nodes.Clear();

            for (int i = 0; i < Measures.Count; i++)
            {
                TreeNode NodeToAdd;

                if (Measures[i].Position != null && Measures[i].Position != "")
                    NodeToAdd = new TreeNode($"{Measures[i].Position} - {Measures[i].Description}");
                else
                    NodeToAdd = new TreeNode($"{Measures[i].Description}");

                WinParent.MeasPointsTree.Nodes[0].Nodes.Add(NodeToAdd);
            }
        } 
    }
}
