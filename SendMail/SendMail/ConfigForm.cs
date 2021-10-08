using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class ConfigForm : Form {

        private Settings settings = Settings.getInstance();

        public ConfigForm() {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e) {
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = settings.bSsl();
            tbSender.Text = settings.sMailAddr();
        }

        private void btOk_Click(object sender, EventArgs e) {
            //settingオブジェクトに入力データを渡して登録を行うB
            btApply_Click(sender,e);
            this.Close();
        }

        private void btApply_Click(object sender, EventArgs e) {
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text,
                                    cbSsl.Checked);
        }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        
        

        private void ConfigForm_Load(object sender, EventArgs e) {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.MailAddr;
        }
    }
}
