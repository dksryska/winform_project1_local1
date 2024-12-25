namespace CarWashTudo
{
    partial class Customers
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
            label10 = new Label();
            CStatusCb = new ComboBox();
            CAddTb = new TextBox();
            CPhoneTb = new TextBox();
            label9 = new Label();
            CNameTb = new TextBox();
            pictureBox8 = new PictureBox();
            panel2 = new Panel();
            guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            panel4 = new Panel();
            CustomersDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label11 = new Label();
            CCarTb = new TextBox();
            label12 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersDGV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(428, 71);
            label10.Name = "label10";
            label10.Size = new Size(129, 38);
            label10.TabIndex = 3;
            label10.Text = "고객관리";
            // 
            // CStatusCb
            // 
            CStatusCb.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            CStatusCb.FormattingEnabled = true;
            CStatusCb.Items.AddRange(new object[] { "보류", "배달" });
            CStatusCb.Location = new Point(415, 172);
            CStatusCb.Name = "CStatusCb";
            CStatusCb.Size = new Size(182, 33);
            CStatusCb.TabIndex = 2;
            CStatusCb.Text = "진행 상태";
            // 
            // CAddTb
            // 
            CAddTb.Location = new Point(853, 170);
            CAddTb.Multiline = true;
            CAddTb.Name = "CAddTb";
            CAddTb.PlaceholderText = "주소 입력";
            CAddTb.Size = new Size(227, 95);
            CAddTb.TabIndex = 1;
            // 
            // CPhoneTb
            // 
            CPhoneTb.Location = new Point(208, 174);
            CPhoneTb.Name = "CPhoneTb";
            CPhoneTb.PlaceholderText = "010-0000-0000";
            CPhoneTb.Size = new Size(173, 31);
            CPhoneTb.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(852, 130);
            label9.Name = "label9";
            label9.Size = new Size(57, 30);
            label9.TabIndex = 1;
            label9.Text = "주소";
            // 
            // CNameTb
            // 
            CNameTb.Location = new Point(29, 174);
            CNameTb.Name = "CNameTb";
            CNameTb.PlaceholderText = "이름 입력";
            CNameTb.Size = new Size(173, 31);
            CNameTb.TabIndex = 1;
            CNameTb.TextChanged += CNameTb_TextChanged;
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
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(guna2Button3);
            panel2.Controls.Add(guna2Button2);
            panel2.Controls.Add(guna2Button1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(CStatusCb);
            panel2.Controls.Add(CAddTb);
            panel2.Controls.Add(CCarTb);
            panel2.Controls.Add(CPhoneTb);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(CNameTb);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(234, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1098, 762);
            panel2.TabIndex = 5;
            // 
            // guna2Button3
            // 
            guna2Button3.BackColor = Color.Purple;
            guna2Button3.BorderRadius = 15;
            guna2Button3.CustomizableEdges = customizableEdges1;
            guna2Button3.DisabledState.BorderColor = Color.DarkGray;
            guna2Button3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button3.FillColor = Color.White;
            guna2Button3.Font = new Font("Segoe UI", 9F);
            guna2Button3.ForeColor = Color.Black;
            guna2Button3.Location = new Point(602, 224);
            guna2Button3.Name = "guna2Button3";
            guna2Button3.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button3.Size = new Size(152, 59);
            guna2Button3.TabIndex = 10;
            guna2Button3.Text = "Delete";
            guna2Button3.Click += guna2Button3_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Purple;
            guna2Button2.BorderRadius = 15;
            guna2Button2.CustomizableEdges = customizableEdges3;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.Font = new Font("Segoe UI", 9F);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(428, 224);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button2.Size = new Size(152, 59);
            guna2Button2.TabIndex = 11;
            guna2Button2.Text = "Edit";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Purple;
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(252, 224);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(152, 59);
            guna2Button1.TabIndex = 12;
            guna2Button1.Text = "Save";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(CustomersDGV);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(29, 303);
            panel4.Name = "panel4";
            panel4.Size = new Size(1051, 454);
            panel4.TabIndex = 9;
            // 
            // CustomersDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            CustomersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            CustomersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            CustomersDGV.ColumnHeadersHeight = 33;
            CustomersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("맑은 고딕", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            CustomersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            CustomersDGV.GridColor = Color.FromArgb(231, 229, 255);
            CustomersDGV.Location = new Point(18, 47);
            CustomersDGV.Name = "CustomersDGV";
            CustomersDGV.RowHeadersVisible = false;
            CustomersDGV.RowHeadersWidth = 62;
            CustomersDGV.Size = new Size(1019, 393);
            CustomersDGV.TabIndex = 4;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            CustomersDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            CustomersDGV.ThemeStyle.BackColor = Color.White;
            CustomersDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            CustomersDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            CustomersDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            CustomersDGV.ThemeStyle.HeaderStyle.Font = new Font("맑은 고딕", 9F);
            CustomersDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            CustomersDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            CustomersDGV.ThemeStyle.HeaderStyle.Height = 33;
            CustomersDGV.ThemeStyle.ReadOnly = false;
            CustomersDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            CustomersDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            CustomersDGV.ThemeStyle.RowsStyle.Font = new Font("맑은 고딕", 9F);
            CustomersDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            CustomersDGV.ThemeStyle.RowsStyle.Height = 33;
            CustomersDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            CustomersDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            CustomersDGV.CellContentClick += CustomersDGV_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(409, 5);
            label11.Name = "label11";
            label11.Size = new Size(118, 32);
            label11.TabIndex = 3;
            label11.Text = "고객 관리";
            // 
            // CCarTb
            // 
            CCarTb.Location = new Point(624, 174);
            CCarTb.Name = "CCarTb";
            CCarTb.PlaceholderText = "자동차 종류 입력";
            CCarTb.Size = new Size(173, 31);
            CCarTb.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label12.ForeColor = Color.DarkSlateGray;
            label12.Location = new Point(624, 135);
            label12.Name = "label12";
            label12.Size = new Size(79, 30);
            label12.TabIndex = 1;
            label12.Text = "자동차";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(208, 135);
            label8.Name = "label8";
            label8.Size = new Size(101, 30);
            label8.TabIndex = 1;
            label8.Text = "전화번호";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(29, 135);
            label7.Name = "label7";
            label7.Size = new Size(57, 30);
            label7.TabIndex = 1;
            label7.Text = "이름";
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
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(82, 380);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 2;
            label1.Text = "로그아웃";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(104, 321);
            label4.Name = "label4";
            label4.Size = new Size(79, 30);
            label4.TabIndex = 3;
            label4.Text = "서비스";
            label4.Click += label4_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(74, 269);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 4;
            label3.Text = "고객 관리";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(22, 199);
            label2.Name = "label2";
            label2.Size = new Size(161, 30);
            label2.TabIndex = 5;
            label2.Text = "직원 계정 생성";
            label2.Click += label2_Click_1;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 775);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersDGV).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label10;
        private ComboBox CStatusCb;
        private TextBox CAddTb;
        private TextBox CPhoneTb;
        private Label label9;
        private TextBox CNameTb;
        private PictureBox pictureBox8;
        private Guna.UI2.WinForms.Guna2DataGridView CustomersDGV;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Panel panel2;
        private Label label8;
        private Label label7;
        private Panel panel1;
        private TextBox CCarTb;
        private Label label12;
        private Panel panel4;
        private Label label11;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}