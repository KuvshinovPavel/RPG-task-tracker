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
        public MainWindow()
        {
           
            InitializeComponent();
            todos.ItemsSource = App.TodoDB.GetAll().Result;


        }
        
        private void AddTask(object sender, RoutedEventArgs e)
        {
            taskCreatingWindow = new TaskCreatingWindow();
            taskCreatingWindow.Show();
            this.Close();
            }

        private void RefreshTodos(object sender, RoutedEventArgs e)
        {
            todos.Items.Refresh();
        }



        //TextBox title = new TextBox();
        //TextBox date = new TextBox();
        // title.Text = "ПУК СРЕНЬК";
        // date.Text = "до 13.56.44";

        // Image image = new Image
        // {
        //     Source = new ImageSourceConverter().ConvertFromString("../../assets/ruble.png") as ImageSource,
        //   Width = 50,
        // };
        // Canvas c= new Canvas();
        // c.Margin = new Thickness(20, 20, 20, 20);
        // c.Width = 236;
        // c.Height = 108;
        // c.Children.Add(title);
        // c.Children.Add(image);
        // c.Background = new BrushConverter().ConvertFromString("#FFB0F7EF") as Brush; 
        // c.Children.Add(date);

        // Canvas.SetLeft(title, 66);
        // Canvas.SetTop(title, 7);
        // Canvas.SetLeft(date, 169);
        // Canvas.SetTop(date, 80);
        // tasks.Children.Add(c);

    }
        
    }

