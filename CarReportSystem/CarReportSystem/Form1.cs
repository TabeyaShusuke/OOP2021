using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public fmMain() {
            InitializeComponent();
            dgvRegistData.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//application終了
        }

        //開く
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        //削除
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //追加
        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                MessageBox.Show("error");
                return;
            }
            
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
            };
            
            listCarReport.Add(carReport);//1レコード追加
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
        }

        private CarReport.MakerGroup selectedGroup() {
            
            
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                } 
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者セット
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
            
        }

        //combbox carname
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

    }
}
