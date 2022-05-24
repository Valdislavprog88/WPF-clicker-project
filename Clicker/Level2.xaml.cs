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
using System.Windows.Media.Animation;

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

        private int moneyToCompleteLevel { get; } = 400;

        private void clickerBtn_Click(object sender, RoutedEventArgs e)
        {
            // balanceTB level2 animation begin
            ColorAnimation colorAnimation = new ColorAnimation();
            colorAnimation.From = Colors.Black;
            colorAnimation.To = Colors.LimeGreen;
            colorAnimation.Duration = TimeSpan.FromSeconds(0.18);
            PowerEase powerEase = new PowerEase();
            powerEase.Power = 2;
            powerEase.EasingMode = EasingMode.EaseInOut;
            colorAnimation.EasingFunction = powerEase;
            balanceTB.Foreground = new SolidColorBrush();
            balanceTB.Foreground.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);

            if (Convert.ToInt32(balanceTB.Text) % 10 == 0)
            {
                balanceTB.FontSize += 0.5;
            }
            // balanceTB level2 animation end

            if (Convert.ToInt32(balanceTB.Text) >= moneyToCompleteLevel)
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
            BGupdate();
            upgrades.Close();
        }

        

        public void BGupdate()
        {
            ImageBrush myBrush = new ImageBrush();
            
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
                        //this.Background = new SolidColorBrush(Colors.Red);
                        myBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/img/backgrounds/wood.jpg", UriKind.Absolute));
                        this.Background = myBrush;
                    }
                    else if (i == 2)
                    {
                        //this.Background = new SolidColorBrush(Colors.Blue);
                        myBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/img/backgrounds/sea.jpg", UriKind.Absolute));
                        this.Background = myBrush;
                    }
                    else if (i == 3)
                    {
                        //this.Background = new SolidColorBrush(Colors.Pink);
                        myBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/Resources/img/backgrounds/sky.jpg", UriKind.Absolute));
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
