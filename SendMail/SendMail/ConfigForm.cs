using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class ConfigForm : Form {
        Settings settings = new Settings();
        public ConfigForm() {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = true;
        }

        private void btOk_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btApply_Click(object sender, EventArgs e) {
            Settings settings = new Settings();
            settings.Host = tbPass.Text;
            settings.Port = int.Parse(tbHost.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;

        }
    }
}
