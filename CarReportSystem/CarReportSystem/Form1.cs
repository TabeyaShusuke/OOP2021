﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) return;

            //選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];
            
            //取得したデータ項目
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            foreach (var rb in gbMaker.Controls) {
                if ((CarReport.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag)) == selectedCar.Maker) {
                    ((RadioButton)rb).Checked = true;
                    break;
                }
            }
            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }

        private void btDataDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvRegistData.CurrentRow.Index); 
            

        }

        private void btDataCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value,
                                                            cbAuthor.Text, selectedGroup(),
                                                            cbCarName.Text, tbReport.Text, pbPicture.Image);
            dgvRegistData.Refresh();//controlの強制再描画
        }

        private void btSave_Click(object sender, EventArgs e) {
            if(sfdFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdFileSave.FileName,FileMode.Create)) {
                        bf.Serialize(fs, listCarReport);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
            try {
                 //バイナリ形式で逆シリアル化
                 var bf = new BinaryFormatter();
                 using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                 //逆シリアル化
                 listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                 dgvRegistData.DataSource = null;
                 dgvRegistData.DataSource = listCarReport;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            //読み込んだデータを各コンボボックスに登録する。
                    foreach (var item in listCarReport) {
                        setCbAuthor(item.Auther);
                        setCbCarName(item.CarName);
                    }

                //dgvから取り出す
                //for (int i = 0; i < dgvRegistData.RowCount; i++) {
                //    setCbCarName(dgvRegistData.Rows[i].Cells[1].Value.ToString());
                //    setCbCarName(dgvRegistData.Rows[i].Cells[3].Value.ToString());
                //}
            }
        }

        private void fmMain_Load(object sender, EventArgs e) {
            dgvRegistData.Columns[5].Visible = false;
        }
    }
}