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
using Prog4._2.ViewModel;

namespace Prog4._2 {
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window {
        public ListWindow() {
            InitializeComponent();
        }
        public ListWindow(ISPVIewModel model) : this() {
            DataContext = null;
            DataContext = model;
        }
    }
}
