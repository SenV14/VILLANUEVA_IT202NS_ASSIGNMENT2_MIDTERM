namespace VILLANUEVA_IT202NS_ASSIGNMENT2_MIDTERM
{
    partial class Focus_Timer_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(115, 257);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(99, 84);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(262, 257);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(99, 84);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(197, 139);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(100, 37);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "label1";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(115, 6);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(271, 130);
            this.TextBox1.TabIndex = 3;
            // 
            // Focus_Timer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(482, 392);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "Focus_Timer_Form";
            this.Text = "Focus_Timer_Form";
            this.Load += new System.EventHandler(this.Focus_Timer_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox TextBox1;
    }
}