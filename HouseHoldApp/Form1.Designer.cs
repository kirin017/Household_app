namespace HouseHoldApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            btnPromo = new Button();
            btnAccount = new Button();
            btnWashing = new Button();
            btnCooking = new Button();
            btnCleaning = new Button();
            panel1 = new Panel();
            btnHome = new Button();
            panelMain = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            btnSignIn = new Button();
            btnSignUp = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label7 = new Label();
            panelControl1 = new Panel();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(1, 168, 142);
            panelMenu.Controls.Add(btnPromo);
            panelMenu.Controls.Add(btnAccount);
            panelMenu.Controls.Add(btnWashing);
            panelMenu.Controls.Add(btnCooking);
            panelMenu.Controls.Add(btnCleaning);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(246, 702);
            panelMenu.TabIndex = 0;
            // 
            // btnPromo
            // 
            btnPromo.BackColor = Color.FromArgb(1, 168, 142);
            btnPromo.BackgroundImageLayout = ImageLayout.Center;
            btnPromo.Dock = DockStyle.Bottom;
            btnPromo.FlatAppearance.BorderSize = 0;
            btnPromo.FlatStyle = FlatStyle.Popup;
            btnPromo.ForeColor = SystemColors.HighlightText;
            btnPromo.Image = (Image)resources.GetObject("btnPromo.Image");
            btnPromo.ImageAlign = ContentAlignment.MiddleLeft;
            btnPromo.Location = new Point(0, 516);
            btnPromo.Name = "btnPromo";
            btnPromo.RightToLeft = RightToLeft.No;
            btnPromo.Size = new Size(246, 93);
            btnPromo.TabIndex = 5;
            btnPromo.Text = "    Promo";
            btnPromo.TextAlign = ContentAlignment.MiddleLeft;
            btnPromo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPromo.UseVisualStyleBackColor = false;
            btnPromo.Click += btnPromo_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(1, 168, 142);
            btnAccount.BackgroundImageLayout = ImageLayout.Center;
            btnAccount.Dock = DockStyle.Bottom;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Popup;
            btnAccount.ForeColor = SystemColors.HighlightText;
            btnAccount.Image = (Image)resources.GetObject("btnAccount.Image");
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 609);
            btnAccount.Name = "btnAccount";
            btnAccount.RightToLeft = RightToLeft.No;
            btnAccount.Size = new Size(246, 93);
            btnAccount.TabIndex = 4;
            btnAccount.Text = "    Account";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnWashing
            // 
            btnWashing.BackColor = Color.FromArgb(1, 168, 142);
            btnWashing.BackgroundImageLayout = ImageLayout.Center;
            btnWashing.Dock = DockStyle.Top;
            btnWashing.FlatAppearance.BorderSize = 0;
            btnWashing.FlatStyle = FlatStyle.Popup;
            btnWashing.ForeColor = SystemColors.HighlightText;
            btnWashing.Image = (Image)resources.GetObject("btnWashing.Image");
            btnWashing.ImageAlign = ContentAlignment.MiddleLeft;
            btnWashing.Location = new Point(0, 266);
            btnWashing.Name = "btnWashing";
            btnWashing.RightToLeft = RightToLeft.No;
            btnWashing.Size = new Size(246, 93);
            btnWashing.TabIndex = 3;
            btnWashing.Text = "    Washing";
            btnWashing.TextAlign = ContentAlignment.MiddleLeft;
            btnWashing.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWashing.UseVisualStyleBackColor = false;
            btnWashing.Click += btnWashing_Click;
            // 
            // btnCooking
            // 
            btnCooking.BackColor = Color.FromArgb(1, 168, 142);
            btnCooking.BackgroundImageLayout = ImageLayout.Center;
            btnCooking.Dock = DockStyle.Top;
            btnCooking.FlatAppearance.BorderSize = 0;
            btnCooking.FlatStyle = FlatStyle.Popup;
            btnCooking.ForeColor = SystemColors.HighlightText;
            btnCooking.Image = (Image)resources.GetObject("btnCooking.Image");
            btnCooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnCooking.Location = new Point(0, 173);
            btnCooking.Name = "btnCooking";
            btnCooking.RightToLeft = RightToLeft.No;
            btnCooking.Size = new Size(246, 93);
            btnCooking.TabIndex = 2;
            btnCooking.Text = "    Cooking";
            btnCooking.TextAlign = ContentAlignment.MiddleLeft;
            btnCooking.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCooking.UseVisualStyleBackColor = false;
            btnCooking.Click += btnCooking_Click;
            // 
            // btnCleaning
            // 
            btnCleaning.BackColor = Color.FromArgb(1, 168, 142);
            btnCleaning.BackgroundImageLayout = ImageLayout.Center;
            btnCleaning.Dock = DockStyle.Top;
            btnCleaning.FlatAppearance.BorderSize = 0;
            btnCleaning.FlatStyle = FlatStyle.Popup;
            btnCleaning.ForeColor = SystemColors.HighlightText;
            btnCleaning.Image = (Image)resources.GetObject("btnCleaning.Image");
            btnCleaning.ImageAlign = ContentAlignment.MiddleLeft;
            btnCleaning.Location = new Point(0, 80);
            btnCleaning.Name = "btnCleaning";
            btnCleaning.RightToLeft = RightToLeft.No;
            btnCleaning.Size = new Size(246, 93);
            btnCleaning.TabIndex = 1;
            btnCleaning.Text = "    Cleaning";
            btnCleaning.TextAlign = ContentAlignment.MiddleLeft;
            btnCleaning.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCleaning.UseVisualStyleBackColor = false;
            btnCleaning.Click += btnCleaning_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 135, 119);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(panelMain);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 80);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(55, 135, 119);
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = SystemColors.ControlLight;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(246, 80);
            btnHome.TabIndex = 11;
            btnHome.Text = "          Home";
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(246, 80);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(906, 619);
            panelMain.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.AccessibleRole = AccessibleRole.None;
            panel2.BackColor = Color.FromArgb(38, 38, 38);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSignIn);
            panel2.Controls.Add(btnSignUp);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(246, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(906, 80);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(296, 24);
            label1.Name = "label1";
            label1.Size = new Size(285, 31);
            label1.TabIndex = 2;
            label1.Text = "Smart Household Service";
            label1.Click += label1_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(122, 169, 60);
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(672, 20);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(97, 39);
            btnSignIn.TabIndex = 1;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(234, 215, 214);
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Location = new Point(786, 20);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(97, 38);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Register";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(122, 210, 196);
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(561, 120);
            label3.Name = "label3";
            label3.Size = new Size(201, 202);
            label3.TabIndex = 1;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(561, 364);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Contact:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(561, 403);
            label5.Name = "label5";
            label5.Size = new Size(217, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone number: +843567889";
            label5.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(561, 442);
            label6.Name = "label6";
            label6.Size = new Size(185, 20);
            label6.TabIndex = 4;
            label6.Text = "Email: kirin@gmail.com";
            label6.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(63, 189, 171);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(601, 509);
            button1.Name = "button1";
            button1.Size = new Size(119, 39);
            button1.TabIndex = 5;
            button1.Text = "Live Chat";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(85, 53);
            label7.Name = "label7";
            label7.Size = new Size(358, 495);
            label7.TabIndex = 6;
            // 
            // panelControl1
            // 
            panelControl1.BackColor = Color.FromArgb(180, 230, 225);
            panelControl1.Controls.Add(button1);
            panelControl1.Controls.Add(label7);
            panelControl1.Controls.Add(label6);
            panelControl1.Controls.Add(label3);
            panelControl1.Controls.Add(label5);
            panelControl1.Controls.Add(label4);
            panelControl1.Location = new Point(316, 104);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(792, 569);
            panelControl1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1152, 702);
            Controls.Add(panel2);
            Controls.Add(panelMenu);
            Controls.Add(panelControl1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnCleaning;
        private Button btnWashing;
        private Button btnCooking;
        private Panel panel2;
        private Button btnSignUp;
        private Button btnSignIn;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label7;
        private Panel panelControl1;
        private Button btnAccount;
        private Button btnPromo;
        private Panel panel1;
        private Panel panelMain;
        private Button btnHome;
    }
}