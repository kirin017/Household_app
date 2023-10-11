namespace HouseHoldApp
{
    partial class PromoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromoForm));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(703, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(449, 702);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Trebuchet MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(295, 99);
            label1.TabIndex = 1;
            label1.Text = "DISCOUNT 20%\r\nGET IT NOW\r\n";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(55, 135, 119);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(69, 306);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(142, 55);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOG IN NOW";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // PromoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 230, 225);
            ClientSize = new Size(1152, 702);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "PromoForm";
            Text = "PromoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnLogin;
    }
}