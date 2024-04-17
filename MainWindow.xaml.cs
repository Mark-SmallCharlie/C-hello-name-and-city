using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
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
        private void txtcity_TextChanged(object sender, TextChangedEventArgs e)
          {
    
           }
        private Person person;

        

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        private void txtcity_KeyDown(object sender, KeyEventArgs e)
                {
                 if (e.Key == Key.Enter) 
                 {
                      //阻止回车键换行或提交
                  e.Handled = true;
                //调用按钮的点击事件处理函数
                Button_Click(this, null); 
                 }
               }
        private void Button_Click(object sender, RoutedEventArgs? e)
        {
            person = new Person();
            person.name = txtname.Text;
            person.city = txtcity.Text;
            string hello = person.Sayhello();
            txthello.Text = person.Sayhello();
        } 
    }
}
