using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace TextEditor {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window {

        AppContext db;

        public MainWindow() {
            InitializeComponent();

            db = new AppContext();

            loadAllUsers();
            tabUsers.Visibility = Visibility.Collapsed;

            textArea.Background = Brushes.White;
            backWhite.IsChecked = true;
            textArea.Foreground = Brushes.Black;
            textBlack.IsChecked = true;
        }

        //Меню - Файл
        private void newFile_Click(object sender, RoutedEventArgs e) {
            if (textArea.Text != "") {
                saveToFile();
            }

            textArea.Text = "";
        }

        private void openFile_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            
            bool? res = ofd.ShowDialog();

            if(res != false) {
                Stream s;
                if ((s = ofd.OpenFile()) != null) {
                    string fileName = ofd.FileName;
                    string fileText = File.ReadAllText(fileName);
                    textArea.Text = fileText;
                }
            }
        }

        private void saveFile_Click(object sender, RoutedEventArgs e) {
            saveToFile();
        }

        private void saveToFile() {
            SaveFileDialog sfd = new SaveFileDialog();
            bool? res = sfd.ShowDialog();

            if (res != false) {
                using (Stream s = File.Open(sfd.FileName, FileMode.OpenOrCreate)) {
                    using (StreamWriter sw = new StreamWriter(s)) {
                        sw.Write(textArea.Text);
                    }
                }
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        //Меню - Редактировать
        //Меню - Шрифт
        private void fontTimesNewRoman_Click(object sender, RoutedEventArgs e) {
            textArea.FontFamily = new FontFamily("Times New Roman");
            fontVerdane.IsChecked = false;
        }

        private void fontVerdane_Click(object sender, RoutedEventArgs e) {
            textArea.FontFamily = new FontFamily("Verdana");
            fontTimesNewRoman.IsChecked = false;
        }

        //Меню - Вид
        private void backWhite_Click(object sender, RoutedEventArgs e) {
            textArea.Background = Brushes.White;
            backBlack.IsChecked = false;
            backBlue.IsChecked = false;

            if (textArea.Foreground == Brushes.White) {
                textArea.Foreground = Brushes.Black;
                textBlack.IsChecked = true;
                textWhite.IsChecked = false;
                textRed.IsChecked = false;
            }
        }

        private void backBlack_Click(object sender, RoutedEventArgs e) {
            textArea.Background = Brushes.Black;
            backWhite.IsChecked = false;
            backBlue.IsChecked = false;

            if (textArea.Foreground == Brushes.Black) {
                textArea.Foreground = Brushes.White;
                textWhite.IsChecked = true;
                textBlack.IsChecked = false;
                textRed.IsChecked = false;
            }
        }

        private void backBlue_Click(object sender, RoutedEventArgs e) {
            textArea.Background = Brushes.Blue;
            backWhite.IsChecked = false;
            backBlack.IsChecked = false;
        }

        private void textBlack_Click(object sender, RoutedEventArgs e) {
            textArea.Foreground = Brushes.Black;
            textWhite.IsChecked = false;
            textRed.IsChecked = false;

            if (textArea.Background == Brushes.Black) {
                textArea.Background = Brushes.White;
                backWhite.IsChecked = true;
                backBlack.IsChecked = false;
                backBlue.IsChecked = false;
            }
        }

        private void textWhite_Click(object sender, RoutedEventArgs e) {
            textArea.Foreground = Brushes.White;
            textBlack.IsChecked = false;
            textRed.IsChecked = false;

            if (textArea.Background == Brushes.White) {
                textArea.Background = Brushes.Black;
                backBlack.IsChecked = true;
                backWhite.IsChecked = false;
                backBlue.IsChecked = false;
            }
        }

        private void textRed_Click(object sender, RoutedEventArgs e) {
            textArea.Foreground = Brushes.Red;
            textBlack.IsChecked = false;
            textWhite.IsChecked = false;
        }

        private void selectFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string fontSize = selectFontSize.SelectedItem.ToString();

            int i = fontSize.IndexOf(" ");
            if (i != -1) {
                fontSize = fontSize.Substring(i);
                textArea.FontSize = Convert.ToInt32(fontSize);
            }
        }

        private void btnReg_Click(object sender, RoutedEventArgs e) {

            string login = loginField.Text;
            string password = passwordField.Password;

            if (login.Length < 4) {
                loginField.Background = Brushes.Red;
                loginField.ToolTip = "Некорректно заполнено";
            } else if (password.Length < 4) {
                passwordField.Background = Brushes.Red;
                passwordField.ToolTip = "Некорректно заполнено";
            } else {
                loginField.Background = Brushes.Transparent;
                passwordField.Background = Brushes.Transparent;

                /*
                User user = new User(login, password);
                db.Users.Add(user);
                db.SaveChanges();   //Для того, чтобы синхронизировать изменения в БД, чтобы там появилась запись
                */

                User user = null;
                user = db.Users.Where(i => i.Login == login && i.Password == password).FirstOrDefault();

                if (user != null) {

                    tabUsers.Visibility = Visibility.Visible;
                    tabUsers.IsSelected = true;
                    //MessageBox.Show("Пользователь авторизован!");


                } else {
                    user = db.Users.Where(i => i.Login == login).FirstOrDefault();

                    if (user != null) {
                        MessageBox.Show("Данный логин занят, воспользуйтесь другим!");
                    } else {
                        user = new User(login, password);
                        db.Users.Add(user);
                        db.SaveChanges();
                        loadAllUsers();

                        MessageBox.Show($"Новый пользователь({login}) добавлен!");
                    }
                }

            }

        }

        private void loadAllUsers() {
            List<User> users = db.Users.ToList();
            usersList.ItemsSource = users;
        }
    }
}
