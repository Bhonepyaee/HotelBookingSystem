namespace HotelBookinSystem.WindowForm
{
    partial class CreatCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatCustomerForm));
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            txtPhoneNo = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            BtnBack = new Button();
            txtDateOfBirth = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(243, 54);
            label1.Name = "label1";
            label1.Size = new Size(322, 264);
            label1.TabIndex = 1;
            label1.Text = "Create New Customer\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(315, 142);
            label2.Name = "label2";
            label2.Size = new Size(69, 16);
            label2.TabIndex = 2;
            label2.Text = "FirstName";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.Silver;
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(396, 142);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(103, 16);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.Silver;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(396, 178);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(103, 16);
            txtLastName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(315, 178);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 4;
            label3.Text = "LastName";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.BackColor = Color.Silver;
            txtPhoneNo.BorderStyle = BorderStyle.None;
            txtPhoneNo.ForeColor = Color.Black;
            txtPhoneNo.Location = new Point(396, 216);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(103, 16);
            txtPhoneNo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(315, 216);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 6;
            label4.Text = "Phone No.";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Silver;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(396, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(103, 16);
            txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(315, 253);
            label5.Name = "label5";
            label5.Size = new Size(41, 16);
            label5.TabIndex = 8;
            label5.Text = "Email\r\n";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.Silver;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.ForeColor = Color.Transparent;
            txtAddress.Location = new Point(396, 288);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(103, 16);
            txtAddress.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(315, 287);
            label6.Name = "label6";
            label6.Size = new Size(58, 16);
            label6.TabIndex = 10;
            label6.Text = "Address";
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(632, 381);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 14;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(191, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // BtnBack
            // 
            BtnBack.Image = (Image)resources.GetObject("BtnBack.Image");
            BtnBack.ImageAlign = ContentAlignment.MiddleRight;
            BtnBack.Location = new Point(24, 56);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(118, 29);
            BtnBack.TabIndex = 16;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += button2_Click;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.BackColor = Color.Silver;
            txtDateOfBirth.BorderStyle = BorderStyle.None;
            txtDateOfBirth.ForeColor = Color.Transparent;
            txtDateOfBirth.Location = new Point(396, 321);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(103, 16);
            txtDateOfBirth.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(315, 321);
            label7.Name = "label7";
            label7.Size = new Size(75, 16);
            label7.TabIndex = 30;
            label7.Text = "DateOfBirth";
            // 
            // CreatCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(800, 450);
            Controls.Add(txtDateOfBirth);
            Controls.Add(label7);
            Controls.Add(BtnBack);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(txtPhoneNo);
            Controls.Add(label4);
            Controls.Add(txtLastName);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreatCustomerForm";
            Text = "CreatCustomerForm";
            Load += CreatCustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtPhoneNo;
        private Label label4;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private Button button1;
        private PictureBox pictureBox1;
        private Button BtnBack;
        private TextBox txtDateOfBirth;
        private Label label7;
    }
}