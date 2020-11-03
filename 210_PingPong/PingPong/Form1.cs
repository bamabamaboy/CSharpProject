using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong {
    public partial class Form1 : Form {

        private int horizontalBallSpeed = 2;
        private int verticalBallSpeed = 2;
        int panelSpeed = 50;

        private int score = 0;

        public Form1() {
            InitializeComponent();

            timer.Enabled = true;

            //Основные настройки окна
            this.FormBorderStyle = FormBorderStyle.None;    //Убрать меню вокруг окна
            this.TopMost = true;                            //Делать окно поверх всех приложений
            Cursor.Hide();                                  //Скрывать курсор в окне

            //Растянуть окно на весь экран (получить размеры экрана, и растянуть всё окно на размер экрана)
            this.Bounds = Screen.PrimaryScreen.Bounds;

            gamePanel.Top = background.Bottom - (background.Bottom / 10);   //Положение Панели (10% снизу)


            gameBall.Left = 50;
            gameBall.Top = 50;
            gamePanel.Left = (background.Width / 2) - (gamePanel.Width / 2);


            gameOver.Left = (background.Width / 2) - (gameOver.Width / 2);
            gameOver.Top = (background.Height / 2) - (gameOver.Height / 2);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) this.Close();     //При нажатие на Esc будет закрывать окно

            //Клавиша Пробел - Рестар игры
            if (e.KeyCode == Keys.Space && timer.Enabled == false) {
                gameBall.Left = 50;
                gameBall.Top = 50;
                gamePanel.Left = (background.Width / 2) - (gamePanel.Width / 2);
                gamePanel.Top = background.Bottom - (background.Bottom / 10);

                horizontalBallSpeed = 2;
                verticalBallSpeed = 2;

                gameOver.Visible = false;
                result.Text = "RESULT: 0";
                score = 0;
                timer.Enabled = true;
            }

            //Клавиша P - Остановить игру
            if (e.KeyCode == Keys.P && timer.Enabled == true) {

                timer.Enabled = false;
                gameBall.Visible = false;
                gamePanel.Visible = false;

                gameOver.Text = "PAUSE";
                gameOver.Left = (background.Width / 2) - (gameOver.Width / 2);
                gameOver.Visible = true;
            }

            //Клавиша G - Продолжить игру
            if (e.KeyCode == Keys.G && timer.Enabled == false) {

                timer.Enabled = true;
                gameBall.Visible = true;
                gamePanel.Visible = true;

                gameOver.Text = "GAME OVER";
                gameOver.Left = (background.Width / 2) - (gameOver.Width / 2);
                gameOver.Visible = false;
            }

            if (timer.Enabled == true) {
                //Клавиша A - Влево
                if (e.KeyCode == Keys.A && gamePanel.Left >= background.Left) {
                    gamePanel.Left -= panelSpeed;
                }

                //Клавиша D - Вправо
                if (e.KeyCode == Keys.D && gamePanel.Right <= background.Right) {
                    gamePanel.Left += panelSpeed;
                }

                //Клавиша W - Вверх до возможного придела
                int panelTopBorder = background.Bottom - ((background.Bottom / 10) * 5);

                if (e.KeyCode == Keys.W && gamePanel.Top > panelTopBorder) {
                    gamePanel.Top -= panelSpeed;
                }

                //Клавиша S - Вниз до возможного придела
                int panelBottomBorder = background.Bottom - (background.Bottom / 10);

                if (e.KeyCode == Keys.S && gamePanel.Bottom < panelBottomBorder) {
                    gamePanel.Top += panelSpeed;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e) {
            //Управление курсором мышки
            //gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);

            gameBall.Left += horizontalBallSpeed;
            gameBall.Top += verticalBallSpeed;

            if (gameBall.Left <= background.Left) {
                horizontalBallSpeed *= -1;
            }

            if (gameBall.Right >= background.Right) {
                horizontalBallSpeed *= -1;
            }

            if (gameBall.Top <= background.Top) {
                verticalBallSpeed *= -1;
            }

            if (gameBall.Bottom >= background.Bottom) {
                timer.Enabled = false;

                gameOver.Visible = true;
            }

            if (gameBall.Bottom >= gamePanel.Top 
                && gameBall.Bottom <= gamePanel.Bottom
                && gameBall.Left >= gamePanel.Left
                && gameBall.Right <= gamePanel.Right) {

                horizontalBallSpeed += 1;
                verticalBallSpeed += 1;

                verticalBallSpeed *= -1;

                score++;
                result.Text = "RESULT: " + score;

                Random randomColor = new Random();
                gameBall.BackColor = Color.FromArgb(randomColor.Next(100, 200), randomColor.Next(100, 200), randomColor.Next(100, 200));
            }

        }
    }
}
