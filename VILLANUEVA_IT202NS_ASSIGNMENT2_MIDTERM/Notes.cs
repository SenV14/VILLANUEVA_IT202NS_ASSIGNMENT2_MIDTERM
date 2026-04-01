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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string item = textBox1.Text;
               listBox1.Items.Add(item);
               textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
  
        }
    }
}
