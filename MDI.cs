using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ims
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (File.Exists(Path + "\\connect"))
            {
                login log = new login();
                MainClass.showwindow(log, this);
            }
            else
            {
                settings set = new settings();
                MainClass.showwindow(set, this);

            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            settings set = new settings();
            MainClass.showwindow(set, this);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.logoutToolStripMenuItem.Enabled = false;

            login set = new login();
            MainClass.showwindow(set, this);
            
        }
    }
}
