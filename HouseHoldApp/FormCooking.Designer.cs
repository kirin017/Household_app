namespace HouseHoldApp
{
    partial class FormCooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCooking));
            panel_1 = new Panel();
            label4 = new Label();
            txtCost = new TextBox();
            panel2 = new Panel();
            comboBoxNumDish = new ComboBox();
            button1 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel_1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_1
            // 
            panel_1.BackColor = Color.FromArgb(180, 230, 225);
            panel_1.Controls.Add(label4);
            panel_1.Controls.Add(txtCost);
            panel_1.Controls.Add(panel2);
            panel_1.Controls.Add(panel1);
            panel_1.Dock = DockStyle.Fill;
            panel_1.Location = new Point(0, 0);
            panel_1.Name = "panel_1";
            panel_1.Size = new Size(914, 600);
            panel_1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(555, 114);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 4;
            label4.Text = "Total Cost";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(672, 107);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(97, 27);
            txtCost.TabIndex = 3;
            txtCost.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(comboBoxNumDish);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(536, 198);
            panel2.Name = "panel2";
            panel2.Size = new Size(247, 300);
            panel2.TabIndex = 2;
            // 
            // comboBoxNumDish
            // 
            comboBoxNumDish.FormattingEnabled = true;
            comboBoxNumDish.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "more" });
            comboBoxNumDish.Location = new Point(46, 137);
            comboBoxNumDish.Name = "comboBoxNumDish";
            comboBoxNumDish.Size = new Size(151, 28);
            comboBoxNumDish.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(16, 226, 238);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(32, 231);
            button1.Name = "button1";
            button1.Size = new Size(120, 44);
            button1.TabIndex = 3;
            button1.Text = "Choose Now";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(32, 87);
            label8.Name = "label8";
            label8.Size = new Size(180, 20);
            label8.TabIndex = 1;
            label8.Text = "Select Number of Dishes:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 53);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 1;
            label7.Text = "From 50$/Job";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(49, 234, 228);
            label6.Location = new Point(32, 15);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 0;
            label6.Text = "Cooking Service";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(50, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 414);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(122, 122, 122);
            label3.Location = new Point(16, 94);
            label3.Name = "label3";
            label3.Size = new Size(209, 70);
            label3.TabIndex = 0;
            label3.Text = "Customers are very important, customers will be pursued by customers. It's the land of the land, it's the evidence, it's not the body of the land, it's the lion's pillow.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 48);
            label2.Name = "label2";
            label2.Size = new Size(196, 31);
            label2.TabIndex = 0;
            label2.Text = "Our Pricing plan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(49, 234, 228);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Best Price";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 167);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 247);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormCooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel_1);
            Name = "FormCooking";
            Text = "FormCooking";
            panel_1.ResumeLayout(false);
            panel_1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_1;
        private Label label4;
        private TextBox txtCost;
        private Panel panel2;
        private Button button1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox comboBoxNumDish;
    }
}