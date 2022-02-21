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

namespace WPFHelloUser
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

        private void greetButton_Click(object sender, RoutedEventArgs e)
        {
            if (firstNameText.Text == "")
            {
                MessageBox.Show("Please Enter A First Name", "Error");
                return;
            }
            if (lastNameText.Text == "")
            {
                MessageBox.Show("Please Enter A Last Name", "Error");
                return;
            }

            MessageBox.Show($"Hello {firstNameText.Text} {lastNameText.Text}");
        }
    }
}
