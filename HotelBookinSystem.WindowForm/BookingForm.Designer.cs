namespace HotelBookinSystem.WindowForm
{
    partial class BookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            txtStatus = new TextBox();
            label7 = new Label();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtBookingDate = new TextBox();
            label6 = new Label();
            txtCheckOutDate = new TextBox();
            label5 = new Label();
            txtCheckInDate = new TextBox();
            label4 = new Label();
            txtRoomId = new TextBox();
            label3 = new Label();
            txtCustomerId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.Silver;
            txtStatus.BorderStyle = BorderStyle.None;
            txtStatus.ForeColor = Color.Transparent;
            txtStatus.Location = new Point(416, 336);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(103, 16);
            txtStatus.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(327, 336);
            label7.Name = "label7";
            label7.Size = new Size(44, 16);
            label7.TabIndex = 46;
            label7.Text = "Status";
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(43, 60);
            button2.Name = "button2";
            button2.Size = new Size(118, 29);
            button2.TabIndex = 45;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(237, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(651, 395);
            button1.Name = "button1";
            button1.Size = new Size(118, 29);
            button1.TabIndex = 43;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBookingDate
            // 
            txtBookingDate.BackColor = Color.Silver;
            txtBookingDate.BorderStyle = BorderStyle.None;
            txtBookingDate.ForeColor = Color.Transparent;
            txtBookingDate.Location = new Point(416, 302);
            txtBookingDate.Name = "txtBookingDate";
            txtBookingDate.Size = new Size(103, 16);
            txtBookingDate.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(313, 302);
            label6.Name = "label6";
            label6.Size = new Size(86, 16);
            label6.TabIndex = 41;
            label6.Text = "BookingDate";
            // 
            // txtCheckOutDate
            // 
            txtCheckOutDate.BackColor = Color.Silver;
            txtCheckOutDate.BorderStyle = BorderStyle.None;
            txtCheckOutDate.ForeColor = Color.Black;
            txtCheckOutDate.Location = new Point(416, 268);
            txtCheckOutDate.Name = "txtCheckOutDate";
            txtCheckOutDate.Size = new Size(103, 16);
            txtCheckOutDate.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(307, 268);
            label5.Name = "label5";
            label5.Size = new Size(94, 16);
            label5.TabIndex = 39;
            label5.Text = "CheckOutDate";
            // 
            // txtCheckInDate
            // 
            txtCheckInDate.BackColor = Color.Silver;
            txtCheckInDate.BorderStyle = BorderStyle.None;
            txtCheckInDate.ForeColor = Color.Black;
            txtCheckInDate.Location = new Point(416, 232);
            txtCheckInDate.Name = "txtCheckInDate";
            txtCheckInDate.Size = new Size(103, 16);
            txtCheckInDate.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(311, 231);
            label4.Name = "label4";
            label4.Size = new Size(84, 16);
            label4.TabIndex = 37;
            label4.Text = "CheckInDate";
            label4.Click += label4_Click;
            // 
            // txtRoomId
            // 
            txtRoomId.BackColor = Color.Silver;
            txtRoomId.BorderStyle = BorderStyle.None;
            txtRoomId.ForeColor = Color.Black;
            txtRoomId.Location = new Point(416, 193);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.Size = new Size(103, 16);
            txtRoomId.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(314, 192);
            label3.Name = "label3";
            label3.Size = new Size(55, 16);
            label3.TabIndex = 35;
            label3.Text = "RoomId";
            label3.Click += label3_Click;
            // 
            // txtCustomerId
            // 
            txtCustomerId.BackColor = Color.Silver;
            txtCustomerId.BorderStyle = BorderStyle.None;
            txtCustomerId.ForeColor = Color.Black;
            txtCustomerId.Location = new Point(416, 157);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(103, 16);
            txtCustomerId.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(314, 156);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 33;
            label2.Text = "CustomerId";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(294, 58);
            label1.Name = "label1";
            label1.Size = new Size(256, 297);
            label1.TabIndex = 32;
            label1.Text = "Make To Booking\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(800, 450);
            Controls.Add(txtStatus);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtBookingDate);
            Controls.Add(label6);
            Controls.Add(txtCheckOutDate);
            Controls.Add(label5);
            Controls.Add(txtCheckInDate);
            Controls.Add(label4);
            Controls.Add(txtRoomId);
            Controls.Add(label3);
            Controls.Add(txtCustomerId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookingForm";
            Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStatus;
        private Label label7;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtBookingDate;
        private Label label6;
        private TextBox txtCheckOutDate;
        private Label label5;
        private TextBox txtCheckInDate;
        private Label label4;
        private TextBox txtRoomId;
        private Label label3;
        private TextBox txtCustomerId;
        private Label label2;
        private Label label1;
    }
}