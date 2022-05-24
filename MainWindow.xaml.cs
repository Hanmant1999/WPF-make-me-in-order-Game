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
using System.Collections;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        static ArrayList arr = new ArrayList() {"1", "2", "3", "4", "5", "6", "7", "8" ," "};
        static ArrayList arr4 = new ArrayList() { "1", "2", "3", "4", "5", "6", "7", "8", " " };
        string[] arr2 = new string[9] { "first", "second", "third", "fourth", "fifth","sixth", "seventh", "eightth", "nineth" };
        static int Count = 0;

        private void start_Click_1(object sender, RoutedEventArgs e)
        {
            Random rd = new Random();
            for (int i = 0; i < 9; i++)
            {
                Button obj = this.FindName(arr2[i]) as Button;
                int num = rd.Next(0, 9 - i);
                obj.Content = arr[num];
                arr.RemoveAt(num);
            }


            (this.FindName("start") as Button).IsEnabled = false;



        }

        private void swapevent(string name)
        {
            int num = Array.IndexOf(arr2,name);
            int[] arr3 = new int[] { -3, -1, 1, 3 };
            foreach(int i in arr3)
            {
                if((num-i)>=0 && (num - i) <9)
                {
                    if (Convert.ToString((this.FindName(arr2[num-i]) as Button ).Content)==" ")
                    {
                        (this.FindName(arr2[num-i]) as Button).Content = Convert.ToString((this.FindName(arr2[num]) as Button).Content);
                        (this.FindName(arr2[num]) as Button).Content = " ";
                        Count++;
                        flip.Content = Convert.ToString(Count);
                        Checksequence();
                    }
                }
            }

        }
        private void Checksequence()
        {
            int same = 0;
            for (int i = 0; i < 9; i++)
            {
                Button obj = this.FindName(arr2[i]) as Button;
                if (Convert.ToString(obj.Content) == Convert.ToString(arr4[i]))
                {

                    same++;
                }
            }
            if (same == 9)
            {
                MessageBox.Show("Scorecard", "You won in {0}" + Count);
            }

        }
// Buttons click functions 
        private void first_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            swapevent(name);


        }

        private void second_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            swapevent(name);

        }

        private void third_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            swapevent(name);

        }

        private void fourth_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            swapevent(name);

        }

        private void fifth_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            swapevent(name);

        }

        private void sixth_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            swapevent(name);

        }

        private void seventh_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            swapevent(name);

        }

        private void eightth_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            swapevent(name);

        }

        private void nineth_Click(object sender, RoutedEventArgs e)
        {
            string name = (sender as Button).Name;
            swapevent(name);

        }
        
    }
}
