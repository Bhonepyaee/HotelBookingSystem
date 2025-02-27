﻿namespace HotelBookinSystem.WindowForm
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txtMaxOccupants = new TextBox();
            label4 = new Label();
            txtRoomType = new TextBox();
            label3 = new Label();
            txtRoomNumber = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(63, 80);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(135, 39);
            button2.TabIndex = 61;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(318, 77);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(747, 524);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(135, 39);
            button1.TabIndex = 59;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMaxOccupants
            // 
            txtMaxOccupants.BackColor = Color.Silver;
            txtMaxOccupants.BorderStyle = BorderStyle.None;
            txtMaxOccupants.ForeColor = Color.Black;
            txtMaxOccupants.Location = new Point(490, 377);
            txtMaxOccupants.Margin = new Padding(3, 4, 3, 4);
            txtMaxOccupants.Name = "txtMaxOccupants";
            txtMaxOccupants.Size = new Size(118, 20);
            txtMaxOccupants.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(358, 377);
            label4.Name = "label4";
            label4.Size = new Size(121, 20);
            label4.TabIndex = 53;
            label4.Text = "MaxOccupants";
            label4.Click += label4_Click;
            // 
            // txtRoomType
            // 
            txtRoomType.BackColor = Color.Silver;
            txtRoomType.BorderStyle = BorderStyle.None;
            txtRoomType.ForeColor = Color.Black;
            txtRoomType.Location = new Point(490, 301);
            txtRoomType.Margin = new Padding(3, 4, 3, 4);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(118, 20);
            txtRoomType.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(362, 301);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 51;
            label3.Text = "RoomType";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.BackColor = Color.Silver;
            txtRoomNumber.BorderStyle = BorderStyle.None;
            txtRoomNumber.ForeColor = Color.Black;
            txtRoomNumber.Location = new Point(490, 225);
            txtRoomNumber.Margin = new Padding(3, 4, 3, 4);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(118, 20);
            txtRoomNumber.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(362, 225);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 49;
            label2.Text = "RoomNumber";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(387, 77);
            label1.Name = "label1";
            label1.Size = new Size(259, 42);
            label1.TabIndex = 48;
            label1.Text = "Select ROOM";
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 30, 54);
            ClientSize = new Size(914, 600);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtMaxOccupants);
            Controls.Add(label4);
            Controls.Add(txtRoomType);
            Controls.Add(label3);
            Controls.Add(txtRoomNumber);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RoomForm";
            Text = "RoomForm";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox txtMaxOccupants;
        private Label label4;
        private TextBox txtRoomType;
        private Label label3;
        private TextBox txtRoomNumber;
        private Label label2;
        private Label label1;
    }
}