using RPG_TODOLIST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace RPG_TODOLIST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int cash;
        
        public static string backgroundImagePath = "background_beginner.jpg";
        TaskCreatingWindow taskCreatingWindow;
        ShopWindow shopWindow;
        AuthorizationWindow authorizationWindow;
        Binding NameBinding;
        Binding HPBinding;
        Binding DeterminationBinding;
        Binding ExperienceBinding;
        Binding SavingBinding;
        User user = App.UserDB.GetUser();
        public MainWindow()
        {

            InitializeComponent();
            if (user == null)
            {
                authorizationWindow = new AuthorizationWindow();
                authorizationWindow.Show();
                this.Close();
            }
            if (user != null)
            {
                NameBinding = new Binding() { IsAsync = true };
                NameBinding.Mode = BindingMode.OneWay;
                NameBinding.Source = user.Name;
                UserNameLabel.SetBinding(Label.ContentProperty, NameBinding);

                HPBinding = new Binding() { IsAsync = true };
                HPBinding.Mode = BindingMode.OneWay;
                HPBinding.Source = user.HP;
                HealthBar.SetBinding(ProgressBar.ValueProperty, HPBinding);

                ExperienceBinding = new Binding() { IsAsync = true };
                ExperienceBinding.Mode = BindingMode.OneWay;
                ExperienceBinding.Source = user.Experience;
                //ExperienceBar.SetBinding(ProgressBar.ValueProperty, ExperienceBinding);

                SavingBinding = new Binding() { IsAsync = true };
                SavingBinding.Mode = BindingMode.OneWay;
                SavingBinding.Source = user.Savings;
                cash = user.Savings;
                SavingsLabel.SetBinding(Label.ContentProperty, SavingBinding);
            }

            string assetsPath = "pack://application:,,,/assets/"+backgroundImagePath;
            backgroundImage.ImageSource = new BitmapImage(new Uri(assetsPath));
            todos.ItemsSource = App.TodoDB.GetAll().Result;



        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            taskCreatingWindow = new TaskCreatingWindow();
            taskCreatingWindow.Show();
            this.Close();
        }
        private void OpenMarket(object sender, RoutedEventArgs e)
        {
            shopWindow = new ShopWindow();
            shopWindow.Show();
            this.Close();
        }
        private void DeleteTask(object sender, RoutedEventArgs e)
        {
            if (todos.SelectedItem != null)
            {
                Todo selectedTask = (Todo)todos.SelectedItem;
                App.TodoDB.DeleteTodo(selectedTask);
                todos.ItemsSource = App.TodoDB.GetAll().Result;
            }
        }

        private void RefreshTodos(object sender, RoutedEventArgs e)
        {
            todos.Items.Refresh();
        }

        private void CheckTaskAsCompleted(object sender, RoutedEventArgs e)
        {
            int MonetaryReward;
            MessageBoxResult completeresult;

            if (todos.SelectedItem != null)
            {
                completeresult = MessageBox.Show(
                    "Вы желаете объявить о завершении задачи?",
                    "Объявить о завершении задачи?",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Information
                    );

                if (completeresult == MessageBoxResult.Yes)
                {
                    Todo selectedTask = (Todo)todos.SelectedItem;
                    App.TodoDB.DeleteTodo(selectedTask);
                    todos.ItemsSource = App.TodoDB.GetAll().Result;


                    if (selectedTask.Difficulty == "Легкая")
                    {
                        MonetaryReward = 10;


                    }
                    else if (selectedTask.Difficulty == "Средняя")
                    {
                        MonetaryReward = 50;
                    }
                    else if (selectedTask.Difficulty == "Сложная")
                    {
                        MonetaryReward = 100;
                    }
                    else
                    {
                        MonetaryReward = 0;
                    }
                    MessageBox.Show(string.Format("Вы получили {0} рублей", MonetaryReward), "Ваша награда" );
                    App.UserDB.UpdateUser(user, MonetaryReward);
                    cash = int.Parse(SavingsLabel.Content.ToString())+ MonetaryReward;
                    SavingsLabel.Content = cash;
                }


            }
        }
    }

}

