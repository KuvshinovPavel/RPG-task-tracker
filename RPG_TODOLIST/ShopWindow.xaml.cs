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

namespace RPG_TODOLIST
{

    public partial class ShopWindow : Window
    {
        MainWindow mainWindow;
        
        public ShopWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            

            mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void BuyBackground(object sender, RoutedEventArgs e)
        {

            if (rB1.IsChecked==true && MainWindow.cash>=10)
            {
                
                MainWindow.backgroundImagePath = "background_kanash.jpg";
                boughtBtn.IsEnabled = false;
            }
            else if(rB2.IsChecked==true&& MainWindow.cash>=20) 
            {
                MainWindow.backgroundImagePath = "background_сheboksary.jpg";
            }
        }

    }
}
