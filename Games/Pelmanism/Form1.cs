using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pelmanism {
    public partial class FormGame : Form {
        private Card[] playingCards;//遊ぶカードの束
        private Player player;//プレイヤー
        private int gameSec;//ゲーム時間
        private int duration = 5;
        public FormGame() {
            InitializeComponent();
        }

        /// <summary>
        /// card生成
        /// </summary>
        /// <param name="cards">カード配列への参照</param>
        private void CreateCards(ref Card[] cards) {
            Image[] picture = {Image.FromFile(@"C:\Users\infosys\Downloads\a.jpg"), Image.FromFile(@"C:\Users\infosys\Downloads\b.jpg"),
            Image.FromFile(@"C:\Users\infosys\Downloads\d.jpg"),Image.FromFile(@"C:\Users\infosys\Downloads\e.jpg"),
            Image.FromFile(@"C:\Users\infosys\Downloads\g.jpg"),Image.FromFile(@"C:\Users\infosys\Downloads\k.jpg"),
            Image.FromFile(@"C:\Users\infosys\Downloads\l.jpg"),Image.FromFile(@"C:\Users\infosys\Downloads\m.jpg"),
            Image.FromFile(@"C:\Users\infosys\Downloads\n.jpg"),Image.FromFile(@"C:\Users\infosys\Downloads\o.jpg"),
            Image.FromFile(@"C:\Users\infosys\Downloads\p.jpg"),Image.FromFile(@"C:\Users\infosys\Downloads\q.jpg"),};

            //カードのインスタンスの生成
            cards = new Card[picture.Length * 2];
            for (int i = 0, j = 0; i < cards.Length; i += 2, j++) {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
        }

        private void FormGame_Load(object sender, EventArgs e) {
            //カードの生成
            CreateCards(ref playingCards);
            //playerの生成
            player = new Player();
            //cardをformに動的に配置
            SuspendLayout();

            const int offsetX = 30, offsetY = 50;
            for (int i = 0; i < playingCards.Length; i++) {
                //card(button)のプロパティを設定する
                playingCards[i].Name = "card" + i;
                int sizeW = playingCards[i].Size.Width;
                int sizeH = playingCards[i].Size.Height;
                playingCards[i].Location = new Point(offsetX + i % 8 * sizeW,
                                                     offsetY + i / 8 * sizeH);
                playingCards[i].Click += CardButtons_Click;
            }

            Controls.AddRange(playingCards);
            ResumeLayout(false);
            labelGuidance.Text = "スタートボタンをクリックしてゲームを開始してください。";
        }

        private void CardButtons_Click(object sender, EventArgs e) {
            //めくるのは1枚目か？
            if (player.OpenCounter == 0) {
                //前回のカードが不一致ならカードを伏せる
                int b1 = player.BeforeOpenCardIndex1;
                int b2 = player.BeforeOpenCardIndex2;
                if (b1 != -1 && b2 != -1 && !MatchCard(playingCards,b1,b2)) {
                    playingCards[b1].Close();
                    playingCards[b2].Close();
                }

                //clickしたボタンのNameからカードの添え字を取得する。
                int n1 = int.Parse(((Button)sender).Name.Substring(4));
                //1枚目のカードを開く
                playingCards[n1].Open();
                //開いたカードの添え字を格納
                player.NowOpenCardIndex1 = n1;
                labelGuidance.Text = "もう一枚めくってください。";
                //めくるのは2枚目か？
            } else if (player.OpenCounter == 1) {
                //clickしたボタンのNameからカードの添え字を取得する。
                int n2 = int.Parse(((Button)sender).Name.Substring(4));
                //2枚目のカードを開く
                playingCards[n2].Open();
                //開いたカードの添え字を格納
                player.NowOpenCardIndex2 = n2;

                //一枚目と二枚目のカードは一致したか？
                if (MatchCard(playingCards,player.NowOpenCardIndex1,player.NowOpenCardIndex2)) {
                    labelGuidance.Text = "カードは一致しました。次のカードをめくってください。";
                } else {
                    labelGuidance.Text = "カードは不一致です。次のカードをめくってください。";
                }

                //プレイヤーのカード情報をリセットする。
                player.Reset();
                //全カードをめくったか？
                if (AllOpenCard(playingCards)) {
                    labelGuidance.Text = "全部のカードが一致しました。お疲れさまでした。";
                    timer1.Stop();
                    buttonStart.Enabled = true;//スタートボタン選択可能
                }
            }

        }

        /// <summary>
        /// カードが全部開いたかチェック
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        /// <returns>true:全部表 false:1枚以上の裏のカードがある</returns>
        private bool AllOpenCard(Card[] playingCards) {
            foreach (Card card in playingCards) {
                if (!card.State) return false;
            }
            return true;
        }

        /// <summary>
        /// カードの一致チェック
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        /// <param name="nowOpenCardIndex1">1枚目にめくったカードの添え字</param>
        /// <param name="nowOpenCardIndex2">2枚目にめくったカードの添え字</param>
        /// <returns>true:一致 false:不一致</returns>
        private bool MatchCard(Card[] cards, int index1, int index2) {
            if (index1 < 0 || index1 >= cards.Length || 
                index2 < 0 || index2 >= cards.Length) {
                return false;
            }
            if (cards[index1].Picture.Equals(cards[index2].Picture)) {
                return true;
            } else {
                return false;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 1000;
            timer1.Start();
            labelSec.Text = "あと" + duration.ToString() + "秒";
            //card シャッフル
            ShuffleCard(playingCards);
            //全部のカードを伏せる
            foreach (var card in playingCards) {
                card.Close();
            }
            buttonStart.Enabled = false;//スタートボタン選択不可
            gameSec = 0;
            timer1.Start();

            labelGuidance.Text = "クリックしてカードをめくってください。";
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            if (duration == 0) {
                timer1.Stop();
                labelGuidance.Text = "Game Over"; 
                labelSec.Text = "時間切れ";
                //this.Close();
            } else if (duration > 0) {
                duration--;
                labelSec.Text = "あと" + duration.ToString() + "秒";
            }
        }

        /// <summary>
        /// カードを混ぜる
        /// </summary>
        /// <param name="playingCards">カードの配列</param>
        private void ShuffleCard(Card[] playingCards) {
            Random r = new Random();
            int a = playingCards.Length;

            for (int i = a-1; i > 0; i--) {
                a--;
                int shuffle = r.Next(a + 1);
                var nesting = playingCards[shuffle].Picture;
                playingCards[shuffle].Picture = playingCards[a].Picture;
                playingCards[a].Picture = nesting;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            gameSec++;
            labelSec.Text = gameSec + "秒経過";
        }
    }
}
