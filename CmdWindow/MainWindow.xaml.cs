using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

namespace CmdWindow
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

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            readonly System.Windows.Controls.Label MyLabel = new System.Windows.Controls.Label();
            MyLabel.VerticalAlignment = VerticalAlignment.Top;
            MyLabel.HorizontalContentAlignment = HorizontalAlignment.Left;
            Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 255, 255));

            if (e.Key == Key.Enter)
            {
                if (MainStackPanel.Children.Count > 0 && MainTextBox.Text.Length > 0 && MainTextBox.Text == @"\> clear")
                {
                    MainStackPanel.Children.Clear();
                    MyLabel.Content = $@"@:SYS\>OUT\> Operation succeful '{MainTextBox.Text}'";
                    MainTextBox.Text = string.Empty;
                    MainStackPanel.Children.Insert(0, MyLabel);
                }
                else
                {
                    MyLabel.Content = $@"@:SYS\>ERROR\> Keyword or function ({MainTextBox.Text}) could not be found";
                    MainTextBox.Text = string.Empty;
                    MainStackPanel.Children.Insert(0, MyLabel);
                }
            }
        }
    }
}
