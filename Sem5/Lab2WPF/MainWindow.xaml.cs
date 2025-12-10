using Microsoft.Win32;
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

namespace WPFLab2
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

        private void NumCol1_ValueChanged(object sender, EventArgs e)
        {
            Column1.Width = new GridLength(Convert.ToDouble(NumCol1.Value), GridUnitType.Star);
            if (TBoxCol1 != null)
                TBoxCol1.Text = NumCol1.Value.ToString() + "x";
        }

        private void NumCol2_ValueChanged(object sender, EventArgs e)
        {
            Column2.Width = new GridLength(Convert.ToDouble(NumCol2.Value), GridUnitType.Star);
            if (TBoxCol2 != null)
                TBoxCol2.Text = NumCol2.Value.ToString() + "x";
        }

        private void NumCol4_ValueChanged(object sender, EventArgs e)
        {
            Column4.Width = new GridLength(Convert.ToDouble(NumCol4.Value), GridUnitType.Pixel);
            if (TBoxCol4 != null)
                TBoxCol4.Text = NumCol4.Value.ToString() + " px";
        }

        private void NumRow1_ValueChanged(object sender, EventArgs e)
        {
            Row1.Height = new GridLength(Convert.ToDouble(NumRow1.Value), GridUnitType.Star);
            if (TBoxRow1 != null)
                TBoxRow1.Text = NumRow1.Value.ToString() + "x";
        }

        private void NumRow2_ValueChanged(object sender, EventArgs e)
        {
            Row2.Height = new GridLength(Convert.ToDouble(NumRow2.Value), GridUnitType.Star);
            if (TBoxRow2 != null)
                TBoxRow2.Text = NumRow2.Value.ToString() + "x";
        }

        private void NumRow4_ValueChanged(object sender, EventArgs e)
        {
            Row4.Height = new GridLength(Convert.ToDouble(NumRow4.Value), GridUnitType.Pixel);
            if (TBoxRow4 != null)
                TBoxRow4.Text = NumRow4.Value.ToString() + " px";
        }

        private void ButtonLoadImag_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                Img1.Source = new BitmapImage(fileUri);
                Img2.Source = new BitmapImage(fileUri);
                Img3.Source = new BitmapImage(fileUri);
                Img4.Source = new BitmapImage(fileUri);
                Img5.Source = new BitmapImage(fileUri);
                Img6.Source = new BitmapImage(fileUri);
                Img7.Source = new BitmapImage(fileUri);
                Img8.Source = new BitmapImage(fileUri);
                Img9.Source = new BitmapImage(fileUri);
                Img10.Source = new BitmapImage(fileUri);
                Img11.Source = new BitmapImage(fileUri);
                Img12.Source = new BitmapImage(fileUri);
                Img13.Source = new BitmapImage(fileUri);
                Img14.Source = new BitmapImage(fileUri);
                Img15.Source = new BitmapImage(fileUri);
                Img16.Source = new BitmapImage(fileUri);
            }
        }
    }
}
