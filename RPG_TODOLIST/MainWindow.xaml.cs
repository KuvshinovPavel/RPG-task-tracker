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
        TaskCreatingWindow taskCreatingWindow;
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
                SavingsLabel.SetBinding(Label.ContentProperty, SavingBinding);
            }
            todos.ItemsSource = App.TodoDB.GetAll().Result;



        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            taskCreatingWindow = new TaskCreatingWindow();
            taskCreatingWindow.Show();
            this.Close();
        }
        private void DeleteTask(object sender, RoutedEventArgs e)
        {

        }

        private void RefreshTodos(object sender, RoutedEventArgs e)
        {
            todos.Items.Refresh();
        }



        

    }

}

