namespace CRUD
{
    partial class UpdateBlogForm
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
            btnBack = new Button();
            btnSave = new Button();
            txtBlogAuthor = new TextBox();
            txtBlogContent = new TextBox();
            txtBlogTitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(50, 47);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 26;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(664, 397);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBlogAuthor
            // 
            txtBlogAuthor.Location = new Point(412, 214);
            txtBlogAuthor.Name = "txtBlogAuthor";
            txtBlogAuthor.Size = new Size(87, 23);
            txtBlogAuthor.TabIndex = 24;
            // 
            // txtBlogContent
            // 
            txtBlogContent.Location = new Point(412, 275);
            txtBlogContent.Name = "txtBlogContent";
            txtBlogContent.Size = new Size(87, 23);
            txtBlogContent.TabIndex = 23;
            // 
            // txtBlogTitle
            // 
            txtBlogTitle.Location = new Point(412, 155);
            txtBlogTitle.Name = "txtBlogTitle";
            txtBlogTitle.Size = new Size(87, 23);
            txtBlogTitle.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(306, 222);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 21;
            label4.Text = "BlogAuthor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 163);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 20;
            label3.Text = "BlogTitle:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 283);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 19;
            label2.Text = "BlogContent:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Castellar", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 26);
            label1.Name = "label1";
            label1.Size = new Size(308, 58);
            label1.TabIndex = 18;
            label1.Text = "Edit Blog";
            // 
            // UpdateBlogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtBlogAuthor);
            Controls.Add(txtBlogContent);
            Controls.Add(txtBlogTitle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateBlogForm";
            Text = "UpdateBlogForm";
            Load += UpdateBlogForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnSave;
        private TextBox txtBlogAuthor;
        private TextBox txtBlogContent;
        private TextBox txtBlogTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}