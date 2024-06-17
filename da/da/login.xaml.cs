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

namespace da
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Page
    {
        public login()
        {
            InitializeComponent();
        }

     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Content = new reg();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Log.Text == "")
            {
                MessageBox.Show("Введите log");
            }
            else if (Pass.Password == "")
            {
                MessageBox.Show("Введи Pas ");
            }
            else
            {

                var userlog = Appconnect.db.User.FirstOrDefault(x => x.Login == Log.Text && x.Password == Pass.Password);
                if (userlog == null)
                {
                    MessageBox.Show("пoльзователя ne");
                }

                else
                {
                    switch (userlog.Role)
                    {
                        case "Admin":
                            MessageBox.Show("Hello Admin");
                            break;

                        case "qwe":
                            MessageBox.Show("Hello");
                            MainWindow.frame.Content = new reg();
                            break;

                    }
                }



            }
        }
    }
}
