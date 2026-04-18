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
            
            try
            {
                About_Form aboutForm = this.MdiChildren.OfType<About_Form>().FirstOrDefault();
                if (aboutForm != null)
                {         
                    aboutForm.Focus(); 
                }
                else
                {
                    aboutForm = new About_Form();
                    aboutForm.MdiParent = this;
                    aboutForm.Show();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the About form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                About_Form aboutForm = this.MdiChildren.OfType<About_Form>().FirstOrDefault();
                if (aboutForm != null)
                {
                    aboutForm.Focus();
                }
                else
                {
                    aboutForm= new About_Form();
                    aboutForm.MdiParent = this;
                    aboutForm.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the About form: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void dashBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //           
        }//

        private void dailyPlannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try 
            {
                DailyPlannerForm dailyPlannerForm = this.MdiChildren.OfType<DailyPlannerForm>().FirstOrDefault();
                if (dailyPlannerForm != null)
                {
                    
                    DailyPlannerForm.ActiveForm.Focus();
                }
                else
                {
                    dailyPlannerForm = new DailyPlannerForm();
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
                HabitTrackerForm habitTrackerForm = this.MdiChildren.OfType<HabitTrackerForm>().FirstOrDefault();
                if (habitTrackerForm != null)
                {
                    habitTrackerForm.Focus();
                }
                else
                {
                    habitTrackerForm = new HabitTrackerForm();
                    habitTrackerForm.MdiParent = this;
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
                DailyPlannerForm dailyPlannerForm = this.MdiChildren.OfType<DailyPlannerForm>().FirstOrDefault();
                if (dailyPlannerForm != null)
                {

                    DailyPlannerForm.ActiveForm.Focus();
                }
                else
                {
                    dailyPlannerForm = new DailyPlannerForm();
                    dailyPlannerForm.MdiParent = this;
                    dailyPlannerForm.Show();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Daily Planner: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                DailyPlannerForm dailyPlannerForm = this.MdiChildren.OfType<DailyPlannerForm>().FirstOrDefault();
                if (dailyPlannerForm != null)
                {

                    DailyPlannerForm.ActiveForm.Focus();
                }
                else
                {
                    dailyPlannerForm = new DailyPlannerForm();
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
                HabitTrackerForm habitTrackerForm = this.MdiChildren.OfType<HabitTrackerForm>().FirstOrDefault();
                if (habitTrackerForm != null)
                {
                    habitTrackerForm.Focus();
                }
                else
                {
                    habitTrackerForm = new HabitTrackerForm();
                    habitTrackerForm.MdiParent = this;
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
                Notes notes = this.MdiChildren.OfType<Notes>().FirstOrDefault();
                if (notes != null)
                {
                    notes.Focus();
                }
                else
                {
                    notes = new Notes();
                    notes.MdiParent = this;
                    notes.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Habit Tracker: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Focus_Timer_Form timer = this.MdiChildren.OfType<Focus_Timer_Form>().FirstOrDefault();
                if (timer != null)
                {
                    timer.Focus();
                }
                else
                {
                    timer = new Focus_Timer_Form();
                    timer.MdiParent = this;
                    timer.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the Habit Tracker: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
