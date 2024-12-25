namespace CarWashTudo
{
    partial class Logins
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
            panel1 = new Panel();
            pictureBox8 = new PictureBox();
            label10 = new Label();
            PasswordTb = new TextBox();
            UNameTbl = new TextBox();
            label8 = new Label();
            label7 = new Label();
            button1 = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(19, 371);
            panel1.TabIndex = 0;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.close;
            pictureBox8.Location = new Point(539, 12);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(136, 43);
            label10.Name = "label10";
            label10.Size = new Size(355, 38);
            label10.TabIndex = 4;
            label10.Text = "등록된 직원 로그인 페이지";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(265, 171);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PlaceholderText = "비밀번호 입력";
            PasswordTb.Size = new Size(219, 31);
            PasswordTb.TabIndex = 5;
            // 
            // UNameTbl
            // 
            UNameTbl.Location = new Point(265, 114);
            UNameTbl.Name = "UNameTbl";
            UNameTbl.PlaceholderText = "이름 입력";
            UNameTbl.Size = new Size(219, 31);
            UNameTbl.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(136, 170);
            label8.Name = "label8";
            label8.Size = new Size(101, 30);
            label8.TabIndex = 7;
            label8.Text = "비밀번호";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(158, 115);
            label7.Name = "label7";
            label7.Size = new Size(79, 30);
            label7.TabIndex = 8;
            label7.Text = "아이디";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(136, 235);
            button1.Name = "button1";
            button1.Size = new Size(348, 46);
            button1.TabIndex = 9;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(201, 302);
            label4.Name = "label4";
            label4.Size = new Size(227, 30);
            label4.TabIndex = 8;
            label4.Text = "관리자 로그인 페이지";
            label4.Click += label4_Click;
            // 
            // Logins
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(587, 371);
            Controls.Add(pictureBox8);
            Controls.Add(button1);
            Controls.Add(PasswordTb);
            Controls.Add(UNameTbl);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Logins";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Logins";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label10;
        private TextBox PasswordTb;
        private TextBox UNameTbl;
        private Label label8;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox8;
        private Label label4;
    }
}