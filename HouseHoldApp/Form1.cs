using System.Drawing;
using System.Drawing.Drawing2D;

namespace HouseHoldApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnCleaning.MouseEnter += OnMouseEnterBtnCleaning;
            btnCleaning.MouseLeave += OnMouseLeaveBtnCleaning;
            btnCooking.MouseEnter += OnMouseEnterBtnCooking;
            btnCooking.MouseLeave += OnMouseLeaveBtnCooking;
            btnWashing.MouseEnter += OnMouseEnterBtnWashing;
            btnWashing.MouseLeave += OnMouseLeaveBtnWashing;
            btnAccount.MouseEnter += OnMouseEnterBtnAccount;
            btnAccount.MouseLeave += OnMouseLeaveBtnAccount;
            btnPromo.MouseEnter += OnMouseEnterBtnPromo;
            btnPromo.MouseLeave += OnMouseLeaveBtnPromo;
            foreach (Control control in this.Controls)
            {
                // #2
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    // #3
                    client.BackColor = Color.FromArgb(180, 230, 225);
                    // 4#
                    break;
                }
            }
        }

        private void OnMouseEnterBtnCleaning(object sender, EventArgs e)
        {
            btnCleaning.BackColor = Color.FromArgb(116, 130, 168);
        }
        private void OnMouseLeaveBtnCleaning(Object sender, EventArgs e)
        {
            btnCleaning.BackColor = Color.FromArgb(1, 168, 142);
        }

        private void OnMouseEnterBtnCooking(object sender, EventArgs e)
        {
            btnCooking.BackColor = Color.FromArgb(116, 130, 168);
        }
        private void OnMouseLeaveBtnCooking(Object sender, EventArgs e)
        {
            btnCooking.BackColor = Color.FromArgb(1, 168, 142);
        }
        private void OnMouseEnterBtnWashing(object sender, EventArgs e)
        {
            btnWashing.BackColor = Color.FromArgb(116, 130, 168);
        }
        private void OnMouseLeaveBtnWashing(Object sender, EventArgs e)
        {
            btnWashing.BackColor = Color.FromArgb(1, 168, 142);
        }
        private void OnMouseEnterBtnAccount(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(116, 130, 168);
        }
        private void OnMouseLeaveBtnAccount(Object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(1, 168, 142);
        }
        private void OnMouseEnterBtnPromo(object sender, EventArgs e)
        {
            btnPromo.BackColor = Color.FromArgb(116, 130, 168);
        }
        private void OnMouseLeaveBtnPromo(Object sender, EventArgs e)
        {
            btnPromo.BackColor = Color.FromArgb(1, 168, 142);
        }
        private void ParentForm_Load(object sender, EventArgs e)
        {
            // Thiết lập màu nền cho Form cha
            this.BackColor = Color.LightBlue; // Thay đổi màu nền thành màu xanh nhạt
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm formRegister = new RegisterForm();
            formRegister.ShowDialog();
            this.Show();
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FormCleaning"))
            {

                FormCleaning formCleaning = new FormCleaning();
                formCleaning.TopLevel = false;
                panelControl1.Hide();
                panelMain.Controls.Add(formCleaning);
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                formCleaning.FormBorderStyle = FormBorderStyle.None;
                formCleaning.MdiParent = this;
                formCleaning.Dock = DockStyle.Fill;
                formCleaning.Show();
            }
            else
                ActiveChildForm("FormCleaning");
        }

        private void FormCleaning_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true; break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btnCooking_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            if (!CheckExistForm("FormCooking"))
            {
                FormCooking formCooking = new FormCooking();
                formCooking.TopLevel = false;
                panelMain.Controls.Add(formCooking);
                panelControl1.Hide();
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                formCooking.FormBorderStyle = FormBorderStyle.None;
                formCooking.MdiParent = this;
                formCooking.Dock = DockStyle.Fill;
                formCooking.Show();
            }
            else
                ActiveChildForm("FormCooking");
        }
        private void btnWashing_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            if (!CheckExistForm("WashingForm"))
            {
                WashingForm formWashing = new WashingForm();
                formWashing.TopLevel = false;
                panelMain.Controls.Add(formWashing);
                panelControl1.Hide();
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                formWashing.FormBorderStyle = FormBorderStyle.None;
                formWashing.MdiParent = this;
                formWashing.Dock = DockStyle.Fill;
                formWashing.Show();
            }
            else
                ActiveChildForm("WashingForm");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            this.Show();
            this.panelControl1.Show();
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            if (!CheckExistForm("PromoForm"))
            {
                PromoForm formPromo = new PromoForm();
                formPromo.TopLevel = false;
                panelMain.Controls.Add(formPromo);
                panelControl1.Hide();
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                formPromo.FormBorderStyle = FormBorderStyle.None;
                formPromo.MdiParent = this;
                formPromo.Dock = DockStyle.Fill;
                formPromo.Show();
            }
            else
                ActiveChildForm("PromoForm");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            if (!CheckExistForm("AccountForm"))
            {
                AccountForm formAccount = new AccountForm();
                formAccount.TopLevel = false;
                panelMain.Controls.Add(formAccount);
                panelControl1.Hide();
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }
                formAccount.FormBorderStyle = FormBorderStyle.None;
                formAccount.MdiParent = this;
                formAccount.Dock = DockStyle.Fill;
                formAccount.Show();
            }
            else
                ActiveChildForm("PromoAccount");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatBoxForm formChatBox = new ChatBoxForm();
            formChatBox.ShowDialog();
            
        }
    }
}