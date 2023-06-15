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
        MainWindow mainWindow;
        public TaskCreatingWindow()
        {

            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string difficulty = diffsLB.SelectedItem.ToString().Split(':')[1].Trim();
            string difficultyColor="green";
            if (difficulty == "Легкая")
            {
                difficultyColor = "#77DD77";   
            }
            else if (difficulty == "Средняя")
            {
                difficultyColor = "#FFDD5B";   
            }
            else if (difficulty == "Сложная")
            {
                difficultyColor = "red";
            }

            App.TodoDB.AddTodo(new Models.Todo
            {
                TodoDescription = todoDescriptionTB.Text,
                Difficulty = difficulty,
                DifficultyColor = difficultyColor,
                CompletionDate = DateTime.Parse(dateTB.Text)
            });
            mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
            
            
        }

        private void changeDate(object sender, SelectionChangedEventArgs e)
        {
            dateTB.Text = cal.SelectedDate.Value.ToShortDateString();
        }
    }
}
