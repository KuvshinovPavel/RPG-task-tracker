using RPG_TODOLIST.DB;
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
using System.Windows.Shapes;
using RPG_TODOLIST;
namespace RPG_TODOLIST
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        MainWindow mainWindow;
        public static string playerImagePath = "pack://application:,,,/assets/beginner.png";


        public AuthorizationWindow()
        {
            
            InitializeComponent();
          
         
        }

        private void authorize(object sender, RoutedEventArgs e)
        {


            App.UserDB.AuthorizeUser(new Models.User
            {
                Id = 1,
                Name = userNameTB.Text,
                CurrentLivingPlace = "Шумерля",
                Determination = 50,
                HP = 100,
                Savings = 0,
                PlayerImagePath = playerImagePath,
                BackgroundImagePath = "pack://application:,,,/assets/background_beginner.jpg"
            }
            );

            mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
           
            

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            playerImagePath = "pack://application:,,,/assets/girlMoment.png";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            playerImagePath = "pack://application:,,,/assets/man1.png";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            playerImagePath = "pack://application:,,,/assets/girlMoment.png";
        }
    }
}
