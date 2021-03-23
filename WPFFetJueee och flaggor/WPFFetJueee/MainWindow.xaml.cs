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

namespace WPFFetJueee
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

        private void ApaKnapp_Click(object sender, RoutedEventArgs e)
        {
            if (ApaText.Text == "Apa")
            {
                ApaText.Text = "Bepa";
                ApaKnapp.Content = "Apa";
            }
            else if (ApaText.Text == "Bepa")
            {
                var newButton = new Button();
                newButton.Content = "Ny Knapp";
                newButton.Height = 30;
                newButton.Width = 75;
                
                mainGrid.Children.Add(newButton); //children är allt som ligger i griden, lägga till knappen
            }
            else
            {
                ApaText.Text = "Apa";
                ApaKnapp.Content = "Bepa";
            }
            
        }
    }
}
