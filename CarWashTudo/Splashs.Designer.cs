namespace CarWashTudo
{
    partial class Splashs
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Myprogress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Myprogress
            // 
            Myprogress.FillColor = Color.FromArgb(200, 213, 218, 223);
            Myprogress.Font = new Font("Segoe UI", 12F);
            Myprogress.ForeColor = Color.White;
            Myprogress.Location = new Point(131, 60);
            Myprogress.Minimum = 0;
            Myprogress.Name = "Myprogress";
            Myprogress.ProgressThickness = 10;
            Myprogress.ShadowDecoration.CustomizableEdges = customizableEdges1;
            Myprogress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Myprogress.Size = new Size(611, 611);
            Myprogress.TabIndex = 1;
            Myprogress.Text = "guna2CircleProgressBar1";
            Myprogress.ValueChanged += Myprogress_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(365, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 45);
            label1.TabIndex = 2;
            label1.Text = "로딩 중....";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(351, 684);
            label2.Name = "label2";
            label2.Size = new Size(180, 45);
            label2.TabIndex = 2;
            label2.Text = "기달려줘요";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Splashs
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(881, 738);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Myprogress);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splashs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splashs";
            Load += Splashs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleProgressBar Myprogress;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}