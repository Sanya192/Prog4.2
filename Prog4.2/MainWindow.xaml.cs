using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prog4._2.ViewModel;

namespace Prog4._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// This Program Can add new items and change the current item which will be added.
    /// This Program Cannot change the items in the list
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(ISPVIewModel model) :this() {

            DataContext = null;
            DataContext = model;
        }

        private void Button_Click(object sender, RoutedEventArgs e){
            ISPVIewModel model = DataContext as ISPVIewModel;
            //Bad because no logic should be made in a view. Not even a clone
            // If you uncomment it's not gonna compile it is missing something.
            //model.AllServices.Add(model.ActualService.Clone());

            model.CloneTheActualIntoAll();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            ListWindow list = new ListWindow( DataContext as ISPVIewModel);

            list.Show();
        }
    }


}
