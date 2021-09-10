using System;
using System.Collections;
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

namespace WpfSelectiveControl {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();

            var items = Enumerable.Range(1, 10)
                .Select(i => new Person() { Name = i + "郎",Age = 20 + i,  });

            this.comboBox.ItemsSource = items;
            this.comboBoxEditable.ItemsSource = items;
            this.listBox.ItemsSource = items;
            }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) {
            this.textblock.Text = "オン";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e) {
            this.textblock.Text = "オフ";
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e) {
            this.textblock.Text = "その他";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e) {
            var radioButton = (RadioButton)sender;
            this.textBlockSelected.Text = radioButton.Content.ToString();
        }
    }
}
