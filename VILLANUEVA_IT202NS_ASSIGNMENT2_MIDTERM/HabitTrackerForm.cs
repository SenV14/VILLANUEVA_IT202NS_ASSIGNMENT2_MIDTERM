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
    public partial class HabitTrackerForm : Form
    {
        public HabitTrackerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                checkedListBox1.Items.Add(textBox1.Text);
                checkedListBox1.ClearSelected();
            }
            catch (FormatException) 
            {
                MessageBox.Show("Please enter a valid habit.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
