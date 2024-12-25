namespace CarWashTudo
{
    partial class Servies
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            DeleteBtn = new Guna.UI2.WinForms.Guna2Button();
            EditBtn = new Guna.UI2.WinForms.Guna2Button();
            SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            ServiceDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label11 = new Label();
            label10 = new Label();
            PriceTb = new TextBox();
            SNameTb = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(578, 126);
            label8.Name = "label8";
            label8.Size = new Size(175, 30);
            label8.TabIndex = 1;
            label8.Text = "가격.(숫자 입력)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(204, 126);
            label7.Name = "label7";
            label7.Size = new Size(131, 30);
            label7.TabIndex = 1;
            label7.Text = "서비스 이름";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(EditBtn);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(PriceTb);
            panel2.Controls.Add(SNameTb);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(234, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1098, 762);
            panel2.TabIndex = 7;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.close;
            pictureBox8.Location = new Point(1055, 6);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Purple;
            DeleteBtn.BorderRadius = 15;
            DeleteBtn.CustomizableEdges = customizableEdges1;
            DeleteBtn.DisabledState.BorderColor = Color.DarkGray;
            DeleteBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteBtn.FillColor = Color.White;
            DeleteBtn.Font = new Font("Segoe UI", 9F);
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(491, 224);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DeleteBtn.Size = new Size(152, 59);
            DeleteBtn.TabIndex = 5;
            DeleteBtn.Text = "Delete";
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Purple;
            EditBtn.BorderRadius = 15;
            EditBtn.CustomizableEdges = customizableEdges3;
            EditBtn.DisabledState.BorderColor = Color.DarkGray;
            EditBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            EditBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            EditBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            EditBtn.FillColor = Color.White;
            EditBtn.Font = new Font("Segoe UI", 9F);
            EditBtn.ForeColor = Color.Black;
            EditBtn.Location = new Point(317, 224);
            EditBtn.Name = "EditBtn";
            EditBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            EditBtn.Size = new Size(152, 59);
            EditBtn.TabIndex = 5;
            EditBtn.Text = "Edit";
            EditBtn.Click += EditBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.Purple;
            SaveBtn.BorderRadius = 15;
            SaveBtn.CustomizableEdges = customizableEdges5;
            SaveBtn.DisabledState.BorderColor = Color.DarkGray;
            SaveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            SaveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SaveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SaveBtn.FillColor = Color.White;
            SaveBtn.Font = new Font("Segoe UI", 9F);
            SaveBtn.ForeColor = Color.Black;
            SaveBtn.Location = new Point(141, 224);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SaveBtn.Size = new Size(152, 59);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "Save";
            SaveBtn.Click += SaveBtn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(ServiceDGV);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(29, 295);
            panel4.Name = "panel4";
            panel4.Size = new Size(1051, 454);
            panel4.TabIndex = 4;
            // 
            // ServiceDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ServiceDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ServiceDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ServiceDGV.ColumnHeadersHeight = 35;
            ServiceDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ServiceDGV.DefaultCellStyle = dataGridViewCellStyle3;
            ServiceDGV.GridColor = Color.FromArgb(231, 229, 255);
            ServiceDGV.Location = new Point(15, 47);
            ServiceDGV.Name = "ServiceDGV";
            ServiceDGV.RowHeadersVisible = false;
            ServiceDGV.RowHeadersWidth = 62;
            ServiceDGV.Size = new Size(1019, 393);
            ServiceDGV.TabIndex = 0;
            ServiceDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ServiceDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            ServiceDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ServiceDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ServiceDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ServiceDGV.ThemeStyle.BackColor = Color.White;
            ServiceDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ServiceDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ServiceDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ServiceDGV.ThemeStyle.HeaderStyle.Font = new Font("맑은 고딕", 9F);
            ServiceDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ServiceDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ServiceDGV.ThemeStyle.HeaderStyle.Height = 35;
            ServiceDGV.ThemeStyle.ReadOnly = false;
            ServiceDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            ServiceDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ServiceDGV.ThemeStyle.RowsStyle.Font = new Font("맑은 고딕", 9F);
            ServiceDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ServiceDGV.ThemeStyle.RowsStyle.Height = 33;
            ServiceDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ServiceDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            ServiceDGV.CellContentClick += ServiceDGV_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(409, 5);
            label11.Name = "label11";
            label11.Size = new Size(86, 32);
            label11.TabIndex = 3;
            label11.Text = "서비스";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(423, 52);
            label10.Name = "label10";
            label10.Size = new Size(101, 38);
            label10.TabIndex = 3;
            label10.Text = "서비스";
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(578, 165);
            PriceTb.Name = "PriceTb";
            PriceTb.PlaceholderText = "숫자 입력";
            PriceTb.Size = new Size(204, 31);
            PriceTb.TabIndex = 1;
            PriceTb.TextChanged += SNameTb_TextChanged;
            // 
            // SNameTb
            // 
            SNameTb.Location = new Point(204, 165);
            SNameTb.Name = "SNameTb";
            SNameTb.PlaceholderText = "서비스 이름 입력";
            SNameTb.Size = new Size(299, 31);
            SNameTb.TabIndex = 1;
            SNameTb.TextChanged += SNameTb_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 762);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(72, 364);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 8;
            label1.Text = "로그아웃";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(94, 305);
            label4.Name = "label4";
            label4.Size = new Size(79, 30);
            label4.TabIndex = 9;
            label4.Text = "서비스";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(64, 253);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 10;
            label3.Text = "고객 관리";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(15, 181);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 11;
            label2.Text = "직원 계정 생성";
            label2.Click += label2_Click_1;
            // 
            // Servies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 775);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Servies";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servies";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label8;
        private Label label7;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button DeleteBtn;
        private Guna.UI2.WinForms.Guna2Button EditBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2DataGridView ServiceDGV;
        private Label label11;
        private Label label10;
        private TextBox SNameTb;
        private PictureBox pictureBox8;
        private Panel panel1;
        private TextBox PriceTb;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}