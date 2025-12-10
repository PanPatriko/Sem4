using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFLab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> People { get; set; }
        public Person selectedPerson { get; set; }
        public MainWindow()
        {
            People = new ObservableCollection<Person>() { new Person("Johnny", "Mexico","Nowy Meksyk",1994) };
            InitializeComponent();
            DataContext = this; //?
        }

        private void BttnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddWindow window = new AddWindow(People);
            window.Show();
        }

        private void BttnDel_Click(object sender, RoutedEventArgs e)
        {
            People.Remove((Person)listBox.SelectedItem);
        }

    }
}
