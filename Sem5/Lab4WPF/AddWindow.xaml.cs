using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
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

namespace WPFLab4
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow(ObservableCollection<Person> list)
        {
            People = list;
            InitializeComponent();
            DataContext = this;
        }
        public ObservableCollection<Person> People { get; set; }
        public Uri Photo { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(TBoxYear.Text, out int year) && listBox.SelectedItem != null)
            {
                Person p = (Person)listBox.SelectedItem;
                p.Name = TBoxName.Text;
                p.Surname = TBoxSurname.Text;
                p.City = TBoxCity.Text;
                p.Year = year;
                p.Photo = Photo;
                
            }
            else
                MessageBox.Show("Niepoprawne dane", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(TBoxYear.Text, out int year))
            {

                Person p = new Person(TBoxName.Text, TBoxSurname.Text, TBoxCity.Text, year);
                p.Photo = Photo;
                
                People.Add(p);
            }
            else
                MessageBox.Show("Niepoprawne dane", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void BttnImage_Click(object sender, RoutedEventArgs e)
        {

            if (listBox.SelectedItem != null)
            {
                Person p = (Person)listBox.SelectedItem;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg)|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() ?? false)
                {
                    p.Photo = new Uri(openFileDialog.FileName);
                }
                else p.Photo = null;
                
            }


        }

        private void BttnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(TBoxYear_Copy.Text, out int year))
            {

                Person p = new Person(TBoxName_Copy.Text, TBoxSurname_Copy.Text, TBoxCity_Copy.Text, year);
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg)|*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() ?? false)
                {
                    p.Photo = new Uri(openFileDialog.FileName);
                }
                else p.Photo = null;
                People.Add(p);
            }
            else
                MessageBox.Show("Niepoprawne dane", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
