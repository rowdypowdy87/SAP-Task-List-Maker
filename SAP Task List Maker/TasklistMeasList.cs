using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SAP_Task_List_Maker
{
    public partial class TasklistMeasList : Form
    {
        public List<int> UpdatedList { get; set; }
        public Tasklist ParentList;

        public TasklistMeasList(List<int> L, Tasklist P)
        {
            UpdatedList = L;
            ParentList  = P;
            InitializeComponent();

            // Position in centre of parent window
            Left = P.ParentWindow.Left + (P.ParentWindow.Width/2) - (Width/2);
            Top  = P.ParentWindow.Top + (P.ParentWindow.Height / 2) - (Height / 2);
        }

        private void TasklistMeasList_Load(object sender, EventArgs e)
        {
            MobilityMeasurement Meas;

            // Add to list box    
            for(int i = 0; i < UpdatedList.Count; i++)
            {
                Meas = ParentList.ParentWindow.MeasurementManager.GetMeasurement(UpdatedList[i]);

                if (Meas.Position.Length > 0)
                    MeasurementsLB.Items.Add($"{Meas.Position} - {Meas.Description}");
                else
                    MeasurementsLB.Items.Add($"{Meas.Description}");
            }
                
        }

        private void MeasUpBTN_Click(object sender, EventArgs e)
        {

        }

        private void MeasDownBTN_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            MobilityMeasurement Meas;
            int CurSel;

            if (MeasurementsLB.SelectedIndex >= 0)
            {
                UpdatedList.RemoveAt(MeasurementsLB.SelectedIndex);

                CurSel = MeasurementsLB.SelectedIndex;

                MeasurementsLB.Items.Clear();

                // Add to list box    
                for (int i = 0; i < UpdatedList.Count; i++)
                {
                    Meas = ParentList.ParentWindow.MeasurementManager.GetMeasurement(UpdatedList[i]);

                    if (Meas.Position.Length > 0)
                        MeasurementsLB.Items.Add($"{Meas.Position} - {Meas.Description}");
                    else
                        MeasurementsLB.Items.Add($"{Meas.Description}");
                }

                if(CurSel > 0)
                    MeasurementsLB.SetSelected(CurSel-1, true);
            }
        }
    }
}
