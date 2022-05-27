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

namespace Clicker
{
    /// <summary>
    /// Логика взаимодействия для Levels.xaml
    /// </summary>
    public partial class Levels : Window
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void enterLevelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (RBlevel1.IsChecked == true && RBlevel1.IsEnabled == true)
            { 
                Level1 level1 = new Level1();
                level1.Topmost = true;
                level1.Show();
                this.Close();  
            }else if(RBlevel2.IsChecked == true && RBlevel2.IsEnabled == true)
            {
                Level2 level2 = new Level2();
                level2.Topmost = true;
                level2.Show();
                this.Close();
            }
            
        }


        private void balanceLabel_Initialized(object sender, EventArgs e)
        {
            balanceLabel.Content = "Баланс: " + Money.Balance + " 💰";
        }

        private void level1Progress_Loaded(object sender, RoutedEventArgs e)
        {
            if(Levelss.isLevel1Passed == false)
            {
                level1Progress.Value = Money.Balance;
            }
            else
            {
                level1Progress.Value = 110;
            }
            
        }

        private void level2Progress_Loaded(object sender, RoutedEventArgs e)
        {
            if (Levelss.isLevel2Passed == false)
            {
                level2Progress.Value = Money.Balance;
            }
            else
            {
                RBlevel2.IsEnabled = false;
                level2Progress.Value = 400;
            }
        }

        

        private void backToMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void textLevel1Progress_Initialized(object sender, EventArgs e)
        {
            if(Levelss.isLevel1Passed == false)
            {
                textLevel1Progress.Text = Money.Balance + "/100";
            }
            else
            {
                textLevel1Progress.Text = "пройдено!";
                RBlevel2.IsEnabled = true;
                RBlevel1.IsEnabled = false;
            }
            
        }

        private void textLevel2Progress_Initialized(object sender, EventArgs e)
        {
            if (Money.Balance < 400)
            {
                textLevel2Progress.Text = Money.Balance + "/400";
            }
            else
            {
                RBlevel2.IsEnabled = false;
                textLevel2Progress.Text = "пройдено!";
            }
        }
    }
}
