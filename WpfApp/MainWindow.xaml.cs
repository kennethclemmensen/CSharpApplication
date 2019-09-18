using System.Windows;
using System.Windows.Input;

namespace WpfApp {

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        /// <summary>
        /// MainWindow constructor
        /// </summary>
        public MainWindow() {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) {
            Close();
        }
    }
}