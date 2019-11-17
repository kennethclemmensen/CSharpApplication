using Entity;
using Logic;
using Logic.Exceptions;
using System;
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
        /// Handle the close command event
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event arguments</param>
        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) {
            Close();
        }

        /// <summary>
        /// Handle the button click event
        /// </summary>
        /// <param name="sender">The sender of the event</param>
        /// <param name="e">The event arguments</param>
        private void Button_Click(object sender, RoutedEventArgs e) {
            var wordLogic = new WordLogic();
            var word = TextBox.Text.ToString();
            try {
                wordLogic.AddWord(new Word { Term = word });
                MessageBox.Show(word.IsPalindrome().ToString());
            } catch(EmptyStringException ex) {
                MessageBox.Show(ex.Message);
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}