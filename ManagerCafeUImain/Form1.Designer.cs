namespace ManagerCafeUImain
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Location = new Point(377, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(2266, 159);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 255, 128);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(4, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 1505);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(369, 160);
            panel3.Name = "panel3";
            panel3.Size = new Size(2273, 1332);
            panel3.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(8, 548);
            button3.Name = "button3";
            button3.Size = new Size(355, 152);
            button3.TabIndex = 2;
            button3.Text = "CHẤM CÔNG";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(8, 364);
            button2.Name = "button2";
            button2.Size = new Size(355, 152);
            button2.TabIndex = 2;
            button2.Text = "ĐẶT MÓN";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(8, 181);
            button1.Name = "button1";
            button1.Size = new Size(355, 152);
            button1.TabIndex = 1;
            button1.Text = "TRANG CHỦ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 32);
            label1.Name = "label1";
            label1.Size = new Size(352, 72);
            label1.TabIndex = 0;
            label1.Text = "GENG COFFE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(2644, 1504);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Manager Coffe";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
    }
}
