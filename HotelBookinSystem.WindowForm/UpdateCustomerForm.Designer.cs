namespace HotelBookinSystem.WindowForm
{
    partial class UpdateCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCustomerForm));
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtDateOfBirth = new TextBox();
            label7 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPhoneNo = new TextBox();
            label4 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(31, 43);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 32;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(229, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(649, 378);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 30;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDateOfBirth
            // 
            txtDateOfBirth.BackColor = Color.Silver;
            txtDateOfBirth.BorderStyle = BorderStyle.None;
            txtDateOfBirth.ForeColor = Color.Transparent;
            txtDateOfBirth.Location = new Point(409, 321);
            txtDateOfBirth.Name = "txtDateOfBirth";
            txtDateOfBirth.Size = new Size(103, 16);
            txtDateOfBirth.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(328, 321);
            label7.Name = "label7";
            label7.Size = new Size(75, 16);
            label7.TabIndex = 28;
            label7.Text = "DateOfBirth";
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.Silver;
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.ForeColor = Color.Transparent;
            txtAddress.Location = new Point(409, 288);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(103, 16);
            txtAddress.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(328, 287);
            label6.Name = "label6";
            label6.Size = new Size(58, 16);
            label6.TabIndex = 26;
            label6.Text = "Address";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Silver;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(409, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(103, 16);
            txtEmail.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(328, 253);
            label5.Name = "label5";
            label5.Size = new Size(41, 16);
            label5.TabIndex = 24;
            label5.Text = "Email\r\n";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.BackColor = Color.Silver;
            txtPhoneNo.BorderStyle = BorderStyle.None;
            txtPhoneNo.ForeColor = Color.Black;
            txtPhoneNo.Location = new Point(409, 216);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(103, 16);
            txtPhoneNo.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(328, 216);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 22;
            label4.Text = "Phone No.";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.Silver;
            txtLastName.BorderStyle = BorderStyle.None;
            txtLastName.ForeColor = Color.Black;
            txtLastName.Location = new Point(409, 178);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(103, 16);
            txtLastName.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(328, 178);
            label3.Name = "label3";
            label3.Size = new Size(69, 16);
            label3.TabIndex = 20;
            label3.Text = "LastName";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.Silver;
            txtFirstName.BorderStyle = BorderStyle.None;
            txtFirstName.ForeColor = Color.Black;
            txtFirstName.Location = new Point(409, 142);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(103, 16);
            txtFirstName.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(329, 142);
            label2.Name = "label2";
            label2.Size = new Size(69, 16);
            label2.TabIndex = 18;
            label2.Text = "FirstName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(290, 38);
            label1.Name = "label1";
            label1.Size = new Size(258, 330);
            label1.TabIndex = 17;
            label1.Text = "Update Customer\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtDateOfBirth);
            Controls.Add(label7);
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
            Name = "UpdateCustomerForm";
            Text = "UpdateCustomerForm";
            Load += UpdateCustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtDateOfBirth;
        private Label label7;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPhoneNo;
        private Label label4;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtFirstName;
        private Label label2;
        private Label label1;
    }
}