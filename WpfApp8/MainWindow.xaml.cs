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

namespace WpfApp8
{ 
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object text;

        public MainWindow()
        {
            InitializeComponent();
        } 

        private void BtnOK_Click(object sender,RoutedEventArgs e)
        {
          
           
             int b = int.Parse(TbNumberA.Text);
            if (b > 0)
            {
                b = b - 8;
            }
            else if (b < 0)
            {
                b = b ;
            }
            
            MessageBox.Show($" b ={b}", "ответ");


        }

       
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TbNumberA_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            
        }
    }
    }

