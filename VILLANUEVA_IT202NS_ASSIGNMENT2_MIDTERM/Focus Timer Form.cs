using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VILLANUEVA_IT202NS_ASSIGNMENT2_MIDTERM
{
    public partial class Focus_Timer_Form : Form
    {

        private Timer timer;
        private int secondsRemaining = 0;

        private void Start_Click(object sender, EventArgs e)
        {

            int minutes;

            if (int.TryParse(TextBox1.Text, out minutes))
            {
                secondsRemaining = minutes * 60;
                UpdateLabel();
                timer.Start();
            }
            else
            {
                MessageBox.Show("Enter a valid number!");
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            secondsRemaining = 0;
            lblTime.Text = "00:00:00";
        }

        public Focus_Timer_Form()
        {
            InitializeComponent();
        }

        private void Focus_Timer_Form_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;

            lblTime.Text = "00:00:00";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
  

        private void lblTime_Click(object sender, EventArgs e)
        {
           timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (secondsRemaining > 0)
            {
                secondsRemaining--;
                UpdateLabel();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Time's up!");
            }
        }

        private void UpdateLabel()
        {
            TimeSpan time = TimeSpan.FromSeconds(secondsRemaining);
            lblTime.Text = time.ToString(@"hh\:mm\:ss");
        }


    }
}
