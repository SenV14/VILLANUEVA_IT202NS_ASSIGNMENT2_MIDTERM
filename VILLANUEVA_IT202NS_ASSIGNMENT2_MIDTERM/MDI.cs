using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VILLANUEVA_IT202NS_ASSIGNMENT2_MIDTERM
{
    public partial class MDIProductivityDashboard : Form
    {
        public MDIProductivityDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void heToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Form aboutForm = new About_Form();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Form aboutForm = new About_Form();
            aboutForm.MdiParent = this;
            aboutForm.Show();
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIProductivityDashboard dashboardForm = new MDIProductivityDashboard();
            dashboardForm.MdiParent = this;
            dashboardForm.Show();
        }

        private void dailyPlannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DailyPlannerForm dailyPlannerForm = new DailyPlannerForm();
            dailyPlannerForm.MdiParent = this;
            dailyPlannerForm.Show();
        }

        private void habitTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HabitTrackerForm habitTrackerForm = new HabitTrackerForm();
            habitTrackerForm.MdiParent = this;
            habitTrackerForm.Show();

        }

        private void focusTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Focus_Timer_Form focusTimerForm = new Focus_Timer_Form();
            focusTimerForm.MdiParent = this;
            focusTimerForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MDIProductivityDashboard dashboardForm = new MDIProductivityDashboard();
            dashboardForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DailyPlannerForm dailyPlannerForm = new DailyPlannerForm();
            dailyPlannerForm.MdiParent = this;
            dailyPlannerForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            HabitTrackerForm habitTrackerForm = new HabitTrackerForm();
            habitTrackerForm.MdiParent = this;
            habitTrackerForm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Notes notes  = new Notes();
            notes.MdiParent = this;
            notes.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Focus_Timer_Form focus_Timer_Form = new Focus_Timer_Form();
            focus_Timer_Form.MdiParent = this;
            focus_Timer_Form.Show();
        }
    }
}
