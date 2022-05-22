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

namespace Clicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startGameBtn_Click(object sender, RoutedEventArgs e)
        {
            Levels levelsWindow = new Levels();
            //levelsWindow.Owner = this;
            levelsWindow.Name = "Уровни";
            levelsWindow.Show();
            
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void aboutGameBtn_Click(object sender, RoutedEventArgs e)
        {
            aboutClicker aboutClicker = new aboutClicker();
            aboutClicker.Show();
            aboutClicker.Owner = this;
        }

        private void loreBtn_Click(object sender, RoutedEventArgs e)
        {
            ClickerLore lore = new ClickerLore();
            lore.Show();
            lore.Owner = this;
        }
    }
}
