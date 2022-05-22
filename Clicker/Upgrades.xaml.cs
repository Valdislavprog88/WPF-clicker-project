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
    /// Логика взаимодействия для Upgrades.xaml
    /// </summary>
    public partial class Upgrades : Window
    {
        public Upgrades()
        {
            InitializeComponent();
        }

        private int sum = 0;
        private int[] Sbought = new int[4] {0,0,0,0};
        private void backToMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        

        private void upgradesWindow_Loaded(object sender, RoutedEventArgs e)
        {
            int[] BG = BackGrounds.BG;
            int[] instBG = BackGrounds.installedBG;
            upgradeBought();
            setsUpgrade();
            
        }

        private void setsUpgrade()
        {
            int[] BG = BackGrounds.BG;
            int[] instBG = BackGrounds.installedBG;
            for (int i = 0; i < BG.Length; i++)
            {
                if (BG[i] == 1)
                {
                    if (i == 0)
                    {
                        if(instBG[i] != 1)
                        {
                            SetStandartBack.IsEnabled = true;
                        }
                        else
                        {
                            SetStandartBack.IsEnabled = false;
                        }
                        
                    }
                    if (i == 1)
                    {
                        if (instBG[i] != 1)
                        {
                            SetWoodBack.IsEnabled = true;
                        }
                        else
                        {
                            SetWoodBack.IsEnabled = false;
                        }
                    }
                    else if (i == 2)
                    {
                        if (instBG[i] != 1)
                        {
                            SetSeaBack.IsEnabled = true;
                        }
                        else
                        {
                            SetSeaBack.IsEnabled = false;
                        }
                    }
                    else if (i == 3)
                    {
                        if (instBG[i] != 1)
                        {
                            SetSkyBack.IsEnabled = true;
                        }
                        else
                        {
                            SetSkyBack.IsEnabled = false;
                        }
                    }

                }
            }
            //int[] BG = BackGrounds.BG;
            //int[] instBG = BackGrounds.installedBG;
            //for (int i = 0; i < instBG.Length; i++)
            //{

            //    if (instBG[i] == 1)
            //    {
            //        if (i == 0)
            //        {
            //            SetStandartBack.IsEnabled = false;
            //        }
            //        else if (i == 1)
            //        {
            //            SetWoodBack.IsEnabled = false;
            //        }
            //        else if (i == 2)
            //        {
            //            SetSeaBack.IsEnabled = false;
            //        }
            //        else if (i == 3)
            //        {
            //            SetSkyBack.IsEnabled = false;
            //        }

            //    }
                
            //}
            
        }

        private void upgradeBought()
        {
            int[] BG = BackGrounds.BG;
            //int[] instBG = BackGrounds.installedBG;
            for (int i = 0; i < BG.Length; i++)
            {
                if (BG[i] == 1)
                {
                    if (i == 1)
                    {
                        WoodChB.IsEnabled = false;
                    }
                    else if (i == 2)
                    {
                        SeaChB.IsEnabled = false;
                    }
                    else if (i == 3)
                    {
                        SkyChB.IsEnabled = false;
                    }

                }
            }
        }

        private void WoodChB_Checked(object sender, RoutedEventArgs e)
        {
            sum += 88;
            Sbought[1] = 1;
            sumEdit();
        }

        private void sumEdit()
        {
            sumLabel.Content = sum.ToString() + " 💰";
            if(sum > Money.balance)
            {
                sumLabel.Foreground = new SolidColorBrush(Colors.Red);
                buyBtn.IsEnabled = false;
            }
            else
            {
                sumLabel.Foreground = new SolidColorBrush(Colors.Green);
                buyBtn.IsEnabled = true;
            }
        }

        private void SeaChB_Checked(object sender, RoutedEventArgs e)
        {
            sum += 377;
            Sbought[2] = 1;
            sumEdit();
        }

        private void SkyChB_Checked(object sender, RoutedEventArgs e)
        {
            sum += 444;
            Sbought[3] = 1;
            sumEdit();

        }

        private void WoodChB_Unchecked(object sender, RoutedEventArgs e)
        {
            sum -= 88;
            Sbought[1] = 0;
            sumEdit();

        }

        private void SeaChB_Unchecked(object sender, RoutedEventArgs e)
        {
            sum -= 377;
            Sbought[2] = 0;
            sumEdit();
        }

        private void SkyChB_Unchecked(object sender, RoutedEventArgs e)
        {
            sum -= 444;
            Sbought[3] = 0;
            sumEdit();
        }

        private void buyBtn_Click(object sender, RoutedEventArgs e)
        {
            if(sum > 0)
            {
                Money.balance -= sum;
                int[] BG = BackGrounds.BG;
                for (int i = 0; i < 4; i++)
                {
                    if (Sbought[i] == 1)
                    {
                        BackGrounds.BG[i] = 1;
                    }
                }
                upgradeBought();
                setsUpgrade();

                buyBtn.IsEnabled = false;
                warningPatternWindow warning = new warningPatternWindow();
                warning.warning.Text = "Вы совершили покупку!";
                warning.Show();
                this.Close();
                
                //Levels levels = new Levels();
                //levels.Show();
            }
            
        }
        

        private void balanceLabel_Initialized(object sender, EventArgs e)
        {
            balanceLabel.Content = "Баланс: " + Money.balance + " 💰";
        }

        private void SetWoodBack_Click(object sender, RoutedEventArgs e)
        {
            int[] instBG = BackGrounds.installedBG;
            for (int i = 0; i < instBG.Length; i++)
            {
                BackGrounds.installedBG[i] = 0;
            }
            BackGrounds.installedBG[1] = 1;
            Owner.Show();
            this.Close();

        }

        private void SetStandartBack_Click(object sender, RoutedEventArgs e)
        {
            int[] instBG = BackGrounds.installedBG;
            for (int i = 0; i < instBG.Length; i++)
            {
                BackGrounds.installedBG[i] = 0;
            }
            BackGrounds.installedBG[0] = 1;
            Owner.Show();
            this.Close();
        }

        private void SetSeaBack_Click(object sender, RoutedEventArgs e)
        {
            int[] instBG = BackGrounds.installedBG;
            for (int i = 0; i < instBG.Length; i++)
            {
                BackGrounds.installedBG[i] = 0;
            }
            BackGrounds.installedBG[2] = 1;
            Owner.Show();
            this.Close();
        }

        private void SetSkyBack_Click(object sender, RoutedEventArgs e)
        {
            int[] instBG = BackGrounds.installedBG;
            for (int i = 0; i < instBG.Length; i++)
            {
                BackGrounds.installedBG[i] = 0;
            }
            BackGrounds.installedBG[3] = 1;
            Owner.Show();
            this.Close();
        }
    }
}
