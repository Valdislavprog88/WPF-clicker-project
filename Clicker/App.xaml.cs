using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;

namespace Clicker
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public class Money
    {
        public static int Balance = 0;
        public static int Increase_ratio = 1;
        
        //public static string Surname { get; set; }
    }
    public class Levelss
    {
        public static bool isLevel1Passed = false;
        public static bool isLevel2Passed = false;
    }
    public class BackGrounds
    {
        public static int[] BG = new int[4] {1, 0, 0, 0};
        public static int[] installedBG = new int[4] { 1, 0, 0, 0 };
    }
    public partial class App : Application
    {
        
    }
}
