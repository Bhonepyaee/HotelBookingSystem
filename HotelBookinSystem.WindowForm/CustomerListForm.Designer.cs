namespace HotelBookinSystem.WindowForm
{
    partial class CustomerListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerListForm));
            label1 = new Label();
            button7 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(801, 40);
            label1.TabIndex = 1;
            label1.Text = "CUSTOMER RECORDS";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(24, 30, 54);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(726, 1);
            button7.Name = "button7";
            button7.Size = new Size(24, 28);
            button7.TabIndex = 5;
            button7.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(24, 30, 54);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(764, 5);
            button5.Name = "button5";
            button5.Size = new Size(25, 22);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.LightSlateGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(801, 409);
            dataGridView1.TabIndex = 7;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(24, 30, 54);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(683, 10);
            button6.Name = "button6";
            button6.Size = new Size(25, 10);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = false;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 444);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerListForm";
            Text = "CustomerListForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button button7;
        private Button button5;
        private DataGridView dataGridView1;
        private Button button6;
    }
}