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
using QazLatyn;

namespace QazLatynConverter.Wpf.Example
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

        private void btnCyrl2Latyn_Click(object sender, RoutedEventArgs e)
        {
            string cyrlText = this.txtCyrl.Text;
            string latynText = QazLatynHelper.Cyrl2Latyn(cyrlText);
            this.txtLatyn.Text = latynText;
        }
    }
}
