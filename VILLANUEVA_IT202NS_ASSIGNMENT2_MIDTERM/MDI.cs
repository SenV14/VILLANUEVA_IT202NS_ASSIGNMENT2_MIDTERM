using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            try
            {
                if (About_Form.ActiveForm != null)
                {
                    MessageBox.Show("The About form is already open. Please close the existing form before opening a new one.", "Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    About_Form aboutForm = new About_Form();
                    aboutForm.MdiParent = this;
                    aboutForm.Show();
                }
            }
            catch(Exception ex)  
            {
                MessageBox.Show("An error occurred while trying to open the About form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MDIProductivityDashboard.ActiveForm != null)
                {
                    MessageBox.Show("A dashboard is already open. Please close the existing dashboard before opening a new one.", "Dashboard Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MDIProductivityDashboard dashboardForm = new MDIProductivityDashboard();
                    dashboardForm.MdiParent = this;
                    dashboardForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                            
        }

        private void dailyPlannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                if(dailyPlannerToolStripMenuItem != null)
                {
                    MessageBox.Show("A Daily Planner is already open. Please close the existing Daily Planner before opening a new one.", "Daily Planner Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DailyPlannerForm dailyPlannerForm = new DailyPlannerForm();
                    dailyPlannerForm.MdiParent = this;
                    dailyPlannerForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Daily Planner: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void habitTrackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                if(HabitTrackerForm.ActiveForm != null)
                {
                    MessageBox.Show("A Habit Tracker is already open. Please close the existing Habit Tracker before opening a new one.", "Habit Tracker Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    HabitTrackerForm habitTrackerForm = new HabitTrackerForm();
                    habitTrackerForm.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Habit Tracker: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void focusTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Focus_Timer_Form.ActiveForm != null)
                {
                    MessageBox.Show("A Focus Timer is already open. Please close the existing Focus Timer before opening a new one.", "Focus Timer Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Focus_Timer_Form focusTimerForm = new Focus_Timer_Form();
                    focusTimerForm.MdiParent = this;
                    focusTimerForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Focus Timer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MDIProductivityDashboard.ActiveForm != null)
                {
                    MessageBox.Show("A dashboard is already open. Please close the existing dashboard before opening a new one.", "Dashboard Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MDIProductivityDashboard dashboardForm = new MDIProductivityDashboard();
                    dashboardForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the dashboard: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dailyPlannerToolStripMenuItem != null)
                {
                    MessageBox.Show("A Daily Planner is already open. Please close the existing Daily Planner before opening a new one.", "Daily Planner Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DailyPlannerForm dailyPlannerForm = new DailyPlannerForm();
                    dailyPlannerForm.MdiParent = this;
                    dailyPlannerForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Daily Planner: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (HabitTrackerForm.ActiveForm != null)
                {
                    MessageBox.Show("A Habit Tracker is already open. Please close the existing Habit Tracker before opening a new one.", "Habit Tracker Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    HabitTrackerForm habitTrackerForm = new HabitTrackerForm();
                    habitTrackerForm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Habit Tracker: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try 
            {
                if (Notes.ActiveForm != null)
                {
                    MessageBox.Show("A Notes form is already open. Please close the existing Notes form before opening a new one.", "Notes Form Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Notes notes = new Notes();
                    notes.MdiParent = this;
                    notes.Show();
                }
                
            }
            catch
            {
                MessageBox.Show("An error occurred while trying to open the Notes form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Focus_Timer_Form.ActiveForm != null)
                {
                    MessageBox.Show("A Focus Timer is already open. Please close the existing Focus Timer before opening a new one.", "Focus Timer Already Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Focus_Timer_Form focusTimerForm = new Focus_Timer_Form();
                    focusTimerForm.MdiParent = this;
                    focusTimerForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Focus Timer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
