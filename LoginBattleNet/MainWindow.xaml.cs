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

namespace LoginBattleNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_MouseLeftButtonDown_cross(object sender, MouseButtonEventArgs e)
        {
            window.Close();
        }
        private void ExitButton_MouseLeftButtonDown_dash(object sender, MouseButtonEventArgs e)
        {
            window.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                window.DragMove();
            }
        }

        private void Grid_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                window.DragMove();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // если второй грид открыт - надо закрыть
            if (grid2.Visibility == Visibility.Visible)
            {
                grid2.Visibility = Visibility.Hidden;
            }

            if (grid1.Visibility == Visibility.Visible)
            {
                grid1.Visibility = Visibility.Hidden;
            }
            else
            {
                grid1.Visibility = Visibility.Visible;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            // если второй грид открыт - надо закрыть
            if (grid1.Visibility == Visibility.Visible)
            {
                grid1.Visibility = Visibility.Hidden;
            }

            if (grid2.Visibility == Visibility.Visible)
            {
                grid2.Visibility = Visibility.Hidden;
            }
            else
            {
                grid2.Visibility = Visibility.Visible;
            }
        }

        private void Grid_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            grid1.Visibility = Visibility.Hidden;
            grid2.Visibility = Visibility.Hidden;
            FocusManager.SetFocusedElement(FocusManager.GetFocusScope(textbox_in_grid), null);
            Keyboard.ClearFocus();
        }

        private void textbox_in_grid_GotFocus(object sender, RoutedEventArgs e)
        {
            textbox_in_grid.MaxLength = 100;
        }

        private void textbox_in_grid2_GotFocus(object sender, RoutedEventArgs e)
        {
            textbox_in_grid2.MaxLength = 100;
        }

        //buttons in grid_1
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            region_block.Text = ((TextBlock)((Button)sender).Content).Text;
            grid1.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            region_block.Text = ((TextBlock)((Button)sender).Content).Text;
            grid1.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            region_block.Text = ((TextBlock)((Button)sender).Content).Text;
            grid1.Visibility = Visibility.Hidden;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            region_block.Text = ((TextBlock)((Button)sender).Content).Text;
            grid1.Visibility = Visibility.Hidden;
        }
    }
}
