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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Page
    {
        public reg()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.frame.Content = new login();
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
                if (Appconnect.db.User.Count(x => x.Login == Log.Text) > 0)
                {
                    MessageBox.Show("Ess");
                }
                else
                 {
                  using(DataEntities db = new DataEntities())
                    {
                        User users = new User();
                        users.Password = Pass.Password;
                        users.Login = Log.Text;
                        users.Role = "qwe";

                        db.User.Add(users);
                        db.SaveChanges();
                        MessageBox.Show("good reg well dawnn");
                        MainWindow.frame.Content = new login();
                    }
                }
            }
        }
    }
}
