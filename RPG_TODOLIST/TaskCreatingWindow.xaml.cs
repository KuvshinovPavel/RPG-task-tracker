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
        public List<String> difficulties = new List<String> { 
        "Легкая","Средняя","Сложная"};
        public TaskCreatingWindow()
        {

            InitializeComponent();

            for (int i = 0; i < difficulties.Count; i++)
            {
                diffsLB.Items.Add(difficulties[i]);
            }
            
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
