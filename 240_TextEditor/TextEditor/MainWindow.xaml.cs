﻿using System;
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


            textArea.Background = Brushes.White;
            backWhite.IsChecked = true;
            textArea.Foreground = Brushes.Black;
            textBlack.IsChecked = true;
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
    }
}
