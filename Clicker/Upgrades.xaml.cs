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
                            changeIsEnabled(SetStandartBack, true);
                            //SetStandartBack.IsEnabled = true;
                        }
                        else
                        {
                            changeIsEnabled(SetStandartBack, false);
                            //SetStandartBack.IsEnabled = false;
                        }
                        
                    }
                    if (i == 1)
                    {
                        if (instBG[i] != 1)
                        {
                            changeIsEnabled(SetWoodBack, true);
                            //SetWoodBack.IsEnabled = true;
                        }
                        else
                        {
                            changeIsEnabled(SetWoodBack, false);
                            //SetWoodBack.IsEnabled = false;
                        }
                    }
                    else if (i == 2)
                    {
                        if (instBG[i] != 1)
                        {
                            changeIsEnabled(SetSeaBack, true);
                            //SetSeaBack.IsEnabled = true;
                        }
                        else
                        {
                            changeIsEnabled(SetSeaBack, false);
                            //SetSeaBack.IsEnabled = false;
                        }
                    }
                    else if (i == 3)
                    {
                        if (instBG[i] != 1)
                        {
                            changeIsEnabled(SetSkyBack, true);
                            //SetSkyBack.IsEnabled = true;
                        }
                        else
                        {
                            changeIsEnabled(SetSkyBack, false);
                            //SetSkyBack.IsEnabled = false;
                        }
                    }

                }
            }
            
        }

        public void changeIsEnabled(Button btn, bool value)
        {
            btn.IsEnabled = value;// changes Button(btn) isEnable field 
        }

        public void changeIsEnabled(CheckBox chB, bool value)
        {
            chB.IsEnabled = value;// changes CheckBox(chB) isEnable field 
        }



        private void upgradeBought()
        {
            int[] BG = BackGrounds.BG;
            
            for (int i = 0; i < BG.Length; i++)
            {
                if (BG[i] == 1)
                {
                    if (i == 1)
                    {
                        changeIsEnabled(WoodChB, false);
                        //WoodChB.IsEnabled = false;
                    }
                    else if (i == 2)
                    {
                        changeIsEnabled(SeaChB, false);
                        //SeaChB.IsEnabled = false;
                    }
                    else if (i == 3)
                    {
                        changeIsEnabled(SkyChB, false);
                        //SkyChB.IsEnabled = false;
                    }

                }
            }
        }

        private void WoodChB_Checked(object sender, RoutedEventArgs e)
        {
            PlusSumAndPurchases(88, 1);
        }

        private void sumEdit()
        {
            sumLabel.Content = sum.ToString() + " 💰";
            if(sum > Money.Balance)
            {
                sumLabel.Foreground = new SolidColorBrush(Colors.Red);
                changeIsEnabled(buyBtn, false);
                //buyBtn.IsEnabled = false;
            }
            else
            {
                sumLabel.Foreground = new SolidColorBrush(Colors.Green);
                changeIsEnabled(buyBtn, true);
                //buyBtn.IsEnabled = true;
            }
        }

        private void SeaChB_Checked(object sender, RoutedEventArgs e)
        {
            
            PlusSumAndPurchases(377, 2);
        }

        private void SkyChB_Checked(object sender, RoutedEventArgs e)
        {
            
            PlusSumAndPurchases(444, 3);
        }

        private void WoodChB_Unchecked(object sender, RoutedEventArgs e)
        {
            
            MinusSumAndPurchases(88, 1);
        }

        private void SeaChB_Unchecked(object sender, RoutedEventArgs e)
        {
            
            MinusSumAndPurchases(377, 2);
        }

        private void SkyChB_Unchecked(object sender, RoutedEventArgs e)
        {
            
            MinusSumAndPurchases(444, 3);
        }

        private void MinusSumAndPurchases(int itemPrice, int indOfItem)
        {
            sum -= itemPrice;
            Sbought[indOfItem] = 0; // removes the purchase
            sumEdit();
        }

        private void PlusSumAndPurchases(int itemPrice, int indOfItem)
        {
            sum += itemPrice;
            Sbought[indOfItem] = 1;// add the purchase
            sumEdit();
        }

        private void buyBtn_Click(object sender, RoutedEventArgs e)
        {
            if(sum > 0)
            {
                Money.Balance -= sum;
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

                //buyBtn.IsEnabled = false;
                changeIsEnabled(buyBtn, false);
                warningPatternWindow warning = new warningPatternWindow();
                warning.warning.Text = "Вы совершили покупку!";
                warning.Show();
                this.Close();
                
                
            }
            
        }
        

        private void balanceLabel_Initialized(object sender, EventArgs e)
        {
            balanceLabel.Content = "Баланс: " + Money.Balance + " 💰";
        }

        private void SetWoodBack_Click(object sender, RoutedEventArgs e)
        {
            SetBack(1);
        }

        private void SetStandartBack_Click(object sender, RoutedEventArgs e)
        {
            SetBack(0);
        }

        private void SetArrayElementsToZero(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }
        private void SetBack(int ind)
        {
            int instBGLen = BackGrounds.installedBG.Length;
            SetArrayElementsToZero(BackGrounds.installedBG);
            
            BackGrounds.installedBG[ind] = 1;
            Owner.Show();
            this.Close();
        }
        private void SetSeaBack_Click(object sender, RoutedEventArgs e)
        {
            SetBack(2);
        }

        private void SetSkyBack_Click(object sender, RoutedEventArgs e)
        {
            SetBack(3);
        }
    }
}
