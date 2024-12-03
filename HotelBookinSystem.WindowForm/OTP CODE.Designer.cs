namespace HotelBookinSystem.WindowForm
{
    partial class OTP_CODE
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
            button1 = new Button();
            label2 = new Label();
            txtOtp = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(738, 488);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 7;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 135);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 6;
            label2.Text = "OPT :";
            // 
            // txtOtp
            // 
            txtOtp.Location = new Point(435, 131);
            txtOtp.Margin = new Padding(3, 4, 3, 4);
            txtOtp.Name = "txtOtp";
            txtOtp.Size = new Size(123, 27);
            txtOtp.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(333, 46);
            label1.TabIndex = 4;
            label1.Text = "One Time Password";
            // 
            // OTP_CODE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtOtp);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OTP_CODE";
            Text = "OTP_CODE";
            Load += OTP_CODE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox txtOtp;
        private Label label1;
    }
}