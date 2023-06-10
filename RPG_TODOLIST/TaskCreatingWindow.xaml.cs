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
    /// <summary>
    /// Interaction logic for TaskCreatingWindow.xaml
    /// </summary>
    public partial class TaskCreatingWindow : Window
    {
      
        public TaskCreatingWindow()
        {

            InitializeComponent();

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void changeDate(object sender, SelectionChangedEventArgs e)
        {
            date.Text = cal.SelectedDate.Value.ToShortDateString();
        }
    }
}
