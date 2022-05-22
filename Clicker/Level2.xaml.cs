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
    /// Логика взаимодействия для Level1.xaml
    /// </summary>
    public partial class Level2 : Window
    {
        public Level2()
        {
            InitializeComponent();
        }

        

        private void balanceTB_Loaded(object sender, RoutedEventArgs e)
        {
            updateBalanceClick();
        }

        private void updateBalanceClick()
        {
            balanceTB.Text = Money.balance.ToString();
        }

        private int moneyToCompleteLevel { get; } = 600;

        private void clickerBtn_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToInt32(balanceTB.Text) >= moneyToCompleteLevel)
            {
                warningPatternWindow levelComplete = new warningPatternWindow();
                Levelss.isLevel2Passed = true;
                levelComplete.warning.Text = "Ура! Вы завершили уровень!";
                levelComplete.ShowDialog();

                

                Levels levels = new Levels();
                levels.Show();
                this.Close();
            }
            Money.balance += Money.increase_ratio;
            balanceTB.Text = Money.balance.ToString();
        }


        private void backToMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {   
            Levels levels = new Levels();
            levels.Show();
            this.Close();
            
        }

        private void upgradesBtn_Click(object sender, RoutedEventArgs e)
        {
            Upgrades upgrades = new Upgrades();
            upgrades.Owner = this;
            upgrades.ShowDialog();
            updateBalanceClick();
        }

        public void editLevelsBackground()
        {

        }

        public void BGupdate()
        {
            ImageBrush myBrush = new ImageBrush();
            // levelGrid.Background = new ImageBrush(new BitmapImage(new Uri("Resouces/img/backgrounds/wood.jpg", UriKind.Relative)));
            for (int i = 0; i < 4; i++)
            {
                int[] instBG = BackGrounds.installedBG;
                if (instBG[i] == 1)
                {
                    if (i == 0)
                    {
                        this.Background = new SolidColorBrush(Colors.White);
                    }
                    else if (i == 1)
                    {
                        this.Background = new SolidColorBrush(Colors.Red);
                    }
                    else if (i == 2)
                    {
                        myBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/img/backgrounds/sea.jpg", UriKind.Absolute));
                        this.Background = myBrush;
                    }
                    else if (i == 3)
                    {
                        myBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/img/backgrounds/sea.jpg", UriKind.Absolute));
                        this.Background = myBrush;
                    }
                }
            }
        }

            private void level2Grid_Loaded(object sender, RoutedEventArgs e)
            {
                BGupdate();
            }
    }
}
