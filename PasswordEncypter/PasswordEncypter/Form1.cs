using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Security.Cryptography;
using System.Diagnostics;

namespace EncriptPassword
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);


            }

        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x39000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        public Form1()
        {
            InitializeComponent();
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Pleas Enter your password" , "Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            txtResult.Text = Encrypt(txtPassword.Text);
        }

        private void PanelStartLblVersion_Click(object sender, EventArgs e)
        {
            Process.Start(github.REPO_RELEASE_URL);
        }

        private void PanelStartPicGithub_Click(object sender, EventArgs e)
        {
            Process.Start(github.GITHUB_REPO_URL);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            f1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(github.GITHUB_PROFILE_URL);
        }
    }
}
