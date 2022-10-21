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

namespace ImageViever
{
    public partial class MainWindow : Window
    {
        List<string> files = new List<string>();
        List<int> marks = new List<int>();
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            DirectoryInfo directoryInfo = new DirectoryInfo("..\\..\\..\\img");
            foreach (var file in directoryInfo.GetFiles())
            {
                files.Add(file.ToString());
                marks.Add(0);
            }
            MyImage.Source = new BitmapImage(new Uri(files[0]));
            Mark.Content = Convert.ToString(marks[0]);
        }

        private void First_Click(object sender, RoutedEventArgs e)
        {
            MyImage.Source = new BitmapImage(new Uri(files[0]));
            counter = 0;
            Mark.Content = Convert.ToString(marks[counter]);
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            if (counter - 1 >= 0)
                counter--;
            MyImage.Source = new BitmapImage(new Uri(files[counter]));
            Mark.Content = Convert.ToString(marks[counter]);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            if (counter + 1 < files.Count)
                counter++;
            MyImage.Source = new BitmapImage(new Uri(files[counter]));
            Mark.Content = Convert.ToString(marks[counter]);
        }

        private void Last_Click(object sender, RoutedEventArgs e)
        {
            counter = files.Count - 1;
            MyImage.Source = new BitmapImage(new Uri(files[counter]));
            Mark.Content = Convert.ToString(marks[counter]);
        }

        private void FirstCheck_Checked(object sender, RoutedEventArgs e)
        {
            SecondCheck.IsChecked = false;
            ThirdCheck.IsChecked = false;
            FourthCheck.IsChecked = false;
            FifthCheck.IsChecked = false;
            marks[counter] = Convert.ToInt16(FirstCheck.Content);
            Mark.Content = Convert.ToString(marks[counter]);
            FirstCheck.IsChecked = false;
        }

        private void SecondCheck_Checked(object sender, RoutedEventArgs e)
        {
            FirstCheck.IsChecked = false;
            ThirdCheck.IsChecked = false;
            FourthCheck.IsChecked = false;
            FifthCheck.IsChecked = false;
            marks[counter] = Convert.ToInt16(SecondCheck.Content);
            Mark.Content = Convert.ToString(marks[counter]);
            SecondCheck.IsChecked = false;
        }

        private void ThirdCheck_Checked(object sender, RoutedEventArgs e)
        {

            FirstCheck.IsChecked = false;
            SecondCheck.IsChecked = false;
            FourthCheck.IsChecked = false;
            FifthCheck.IsChecked = false;
            marks[counter] = Convert.ToInt16(ThirdCheck.Content);
            Mark.Content = Convert.ToString(marks[counter]);
            ThirdCheck.IsChecked = false;
        }

        private void FourthCheck_Checked(object sender, RoutedEventArgs e)
        {
            FirstCheck.IsChecked = false;
            SecondCheck.IsChecked = false;
            ThirdCheck.IsChecked = false;
            FifthCheck.IsChecked = false;
            marks[counter] = Convert.ToInt16(FourthCheck.Content);
            Mark.Content = Convert.ToString(marks[counter]);
            FourthCheck.IsChecked = false;
        }

        private void FifthCheck_Checked(object sender, RoutedEventArgs e)
        {
            FirstCheck.IsChecked = false;
            SecondCheck.IsChecked = false;
            ThirdCheck.IsChecked = false;
            FourthCheck.IsChecked = false;
            marks[counter] = Convert.ToInt16(FifthCheck.Content);
            Mark.Content = Convert.ToString(marks[counter]);
            FifthCheck.IsChecked = false;
        }
    }
}
