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
            dateTB.Text = DateTime.Today.ToShortDateString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBoxItem selectedDifficulty = (ListBoxItem)diffsLB.SelectedItem;
            string difficulty = selectedDifficulty?.Content.ToString();
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
            else if(string.IsNullOrWhiteSpace(difficulty))
            {
                difficulty = "Без сложности";
                difficultyColor = "white";
            }
            DateTime selectedDate;
            try
            {
               selectedDate = DateTime.Parse(dateTB.Text);
            }
            catch
            {
                selectedDate = DateTime.Today.AddDays(1);
            }
            if (todoDescriptionTB.Text.Length < 1)
            {
                todoDescriptionTB.Text = "Описание задачи отсуствует";
            }
            App.TodoDB.AddTodo(new Models.Todo
            {
                TodoDescription = todoDescriptionTB.Text,
                Difficulty = difficulty,
                DifficultyColor = difficultyColor,
                CompletionDate = selectedDate
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
