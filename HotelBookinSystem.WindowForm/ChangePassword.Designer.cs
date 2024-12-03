namespace HotelBookinSystem.WindowForm
{
    partial class ChangePassword
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
            txtNewPassword = new TextBox();
            label1 = new Label();
            label3 = new Label();
            txtConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(566, 337);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 7;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 177);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 6;
            label2.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(483, 174);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(123, 27);
            txtNewPassword.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 27);
            label1.Name = "label1";
            label1.Size = new Size(380, 46);
            label1.TabIndex = 4;
            label1.Text = "Change New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 261);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 9;
            label3.Text = "Repeat Password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(483, 258);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(123, 27);
            txtConfirmPassword.TabIndex = 8;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(txtConfirmPassword);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtNewPassword);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox txtNewPassword;
        private Label label1;
        private Label label3;
        private TextBox txtConfirmPassword;
    }
}