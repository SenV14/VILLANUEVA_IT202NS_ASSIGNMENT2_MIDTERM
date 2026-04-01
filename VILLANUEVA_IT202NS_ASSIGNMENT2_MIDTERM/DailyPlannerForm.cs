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
    public partial class DailyPlannerForm : Form
    {
        public DailyPlannerForm()
        {
            InitializeComponent();
        }

        private void DailyPlannerForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) 
            {
                button1.Enabled = true;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                string task1 = textBox1.Text;
                string task2 = textBox2.Text;
                double Numval = 0;
                bool exist = false;
                for (int i = 0; i < listbox_Daily.Items.Count; i++)
                {
                    if (listbox_Daily.Items[i].ToString().Normalize().Equals(task1))
                    {
                       exist = true;
                        break;
                    }
                }
                if (exist)
                {
                   MessageBox.Show("Task already exists in the list.", "Duplicate Task", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int taskNumber = listbox_Daily.Items.Count + 1;
                    string Final_task = ($"Task {taskNumber}: {task1}, Priority: {task2}");
                    listbox_Daily.Items.Add(Final_task);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding tasks: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
