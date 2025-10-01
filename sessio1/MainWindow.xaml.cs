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

namespace sessio1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid elmeuGrid = new Grid();
            this.Content = elmeuGrid;
            Button btn = new Button();
            elmeuGrid.Children.Add(btn);
            btn.Foreground = Brushes.Green;
            WrapPanel elMeuWrapPanel = new WrapPanel();
            TextBlock txt1 = new TextBlock();
            TextBlock txt2 = new TextBlock();
            TextBlock txt3 = new TextBlock();
            txt1.FontSize = 30;
            //txt1.Background = Brushes.Khaki;
            txt1.Foreground = Brushes.Magenta;
            txt1.Text = "Hola   ";
            txt2.FontSize = 20;
            txt2.Foreground = Brushes.Brown;
            txt2.Text = "Mon    ";
            txt2.FontSize = 40;
            txt2.Foreground = Brushes.YellowGreen;
            txt3.Text = "Hello ";
            elMeuWrapPanel.Children.Add(txt1);
            elMeuWrapPanel.Children.Add(txt2);
            elMeuWrapPanel.Children.Add(txt3);
            btn.Width = 450;
            btn.Height = 100;
            btn.Content = elMeuWrapPanel;
        }
    }
}
