using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncriptPassword
{
    public partial class About : MaterialSkin.Controls.MaterialForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(github.GITHUB_PROFILE_URL);
        }

        private void PanelStartLblVersion_Click(object sender, EventArgs e)
        {
            Process.Start(github.REPO_RELEASE_URL);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(github.GITHUB_PROFILE_URL);
        }

        private void PanelStartPicGithub_Click(object sender, EventArgs e)
        {
            Process.Start(github.GITHUB_REPO_URL);
        }
    }
}
