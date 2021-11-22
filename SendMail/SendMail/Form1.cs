using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace SendMail {
    public partial class Form1 : Form {

        //設定画面
        private ConfigForm ConfigForm = new ConfigForm();
        //設定情報
        private Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
        }
        
        private void btSend_Click(object sender, EventArgs e) {
            if (!Settings.Set) {
                MessageBox.Show("送信情報を設定してください");
                return;
            }
            
            try {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先（TO）
                if (tbTo.Text == "") {
                    MessageBox.Show("アドレス未入力");
                } else {
                    mailMessage.To.Add(tbTo.Text);
                }
                
                if (tbCc.Text != "") {
                    mailMessage.CC.Add(tbCc.Text);
                }

                if (tbBcc.Text != "") {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                
                //件名(タイトル)
                mailMessage.Subject = tbTitle.Text;
                //本文
                if (string.IsNullOrWhiteSpace(tbMessage.Text) || string.Empty == tbMessage.Text) {
                    MessageBox.Show("本文未入力");
                    btSend.Enabled = true;
                    return;
                } else {
                    mailMessage.Body = tbMessage.Text;
                }
                

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //mail送信のための認証情報設定(user,password)
                smtpClient.Credentials = new NetworkCredential(settings.MailAddr, settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage,userState);

                btSend.Enabled = false;
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            if (e.Error != null) {
                MessageBox.Show(e.Error.Message);
            } else {
                MessageBox.Show("送信完了");
                Clear();
                btSend.Enabled = true;
            }
        }

        private void btConfig_Click(object sender, EventArgs e) {
            ConfigForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //起動時に送信情報が未設定の場合設定画面を表示する
            if (!Settings.Set) {
                ConfigForm.ShowDialog();
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 新規作成NToolStripMenuItem_Click(object sender, EventArgs e) {
            Clear();
        }

        private void Clear() {
            tbTo.Clear();
            tbCc.Clear();
            tbBcc.Clear();
            tbTitle.Clear();
            tbMessage.Clear();
        }
    }
}