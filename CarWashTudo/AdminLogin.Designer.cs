namespace CarWashTudo
{
    partial class AdminLogin
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
            button1 = new Button();
            AdminPassTb = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(27, 315);
            panel1.TabIndex = 11;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.close;
            pictureBox8.Location = new Point(485, 12);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(25, 25);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            pictureBox8.Click += pictureBox8_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.ForeColor = Color.OrangeRed;
            button1.Location = new Point(115, 191);
            button1.Name = "button1";
            button1.Size = new Size(348, 46);
            button1.TabIndex = 19;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AdminPassTb
            // 
            AdminPassTb.Location = new Point(244, 137);
            AdminPassTb.Name = "AdminPassTb";
            AdminPassTb.PlaceholderText = "비번 : Password";
            AdminPassTb.Size = new Size(219, 31);
            AdminPassTb.TabIndex = 14;
            AdminPassTb.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(115, 138);
            label8.Name = "label8";
            label8.Size = new Size(101, 30);
            label8.TabIndex = 16;
            label8.Text = "비밀번호";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(181, 254);
            label4.Name = "label4";
            label4.Size = new Size(205, 30);
            label4.TabIndex = 17;
            label4.Text = "직원 로그인 페이지";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(103, 43);
            label1.Name = "label1";
            label1.Size = new Size(370, 48);
            label1.TabIndex = 17;
            label1.Text = "관리자 로그인 페이지";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(93, 96);
            label2.Name = "label2";
            label2.Size = new Size(394, 38);
            label2.TabIndex = 20;
            label2.Text = "비밀번호는 Password 입니다.";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(522, 315);
            Controls.Add(label2);
            Controls.Add(pictureBox8);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(AdminPassTb);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox8;
        private Button button1;
        private TextBox AdminPassTb;
        private Label label8;
        private Label label4;
        private Label label1;
        private Label label2;
    }
}