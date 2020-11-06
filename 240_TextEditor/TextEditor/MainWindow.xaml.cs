using System;
using System.Collections.Generic;
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

        public MainWindow() {
            InitializeComponent();
        }

        //Меню - Файл
        private void newFile_Click(object sender, RoutedEventArgs e) {

        }

        private void openFile_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void saveFile_Click(object sender, RoutedEventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
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
    }
}
