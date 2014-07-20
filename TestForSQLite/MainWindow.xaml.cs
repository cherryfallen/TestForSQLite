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


namespace TestForSQLite
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int size = 5000;
            StaticData[] staticDataArry = new StaticData[size];
            for(int i=0;i<size;i++)
            {
                staticDataArry[i] = new StaticData(Convert.ToString(i), "22", "33", "44", "55", "66", 7, "88", true, false);
            }
            
            BookDAL.CreateStaticData(staticDataArry, this, size);
        
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int size = 5000;
            DynamicData[] dynamicDataArry = new DynamicData[size];
            for (int i = 0; i < size; i++)
            {
                dynamicDataArry[i] = new DynamicData("11", "22", 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, "1999", 20, 21, 22, 23, 24, 25);
            }
            BookDAL.CreateDynamicData(dynamicDataArry, this, size);
        }
    }
}
