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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFLab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ColorAnimation animation;
            animation = new ColorAnimation();
            animation.From = Colors.White;
            animation.To = Colors.DeepSkyBlue;
            animation.Duration = new Duration(TimeSpan.FromSeconds(10));
            animation.AutoReverse = true;
            animation.RepeatBehavior = RepeatBehavior.Forever;
            this.Background = new SolidColorBrush(Colors.White);
            this.Background.BeginAnimation(SolidColorBrush.ColorProperty, animation);
        }

        private void Layout_Click(object sender, RoutedEventArgs e)
        {
            TransformGroup myTransformGroup = new TransformGroup();
            ScaleTransform scaleT = new ScaleTransform();
            RotateTransform rotateT = new RotateTransform();
            SkewTransform skewT = new SkewTransform();
            double SizeX=1,SizeY=1,Angle=0,AngleX=0,AngleY=0,OffsetX=0,OffsetY=0;
            if ((bool)Scale.IsChecked)
            {
                if (double.TryParse(TextBoxSizeX.Text, out  SizeX) && double.TryParse(TextBoxSizeY.Text, out SizeY))
                {
                    scaleT.ScaleX = SizeX;
                    scaleT.ScaleY = SizeY;
                    myTransformGroup.Children.Add(scaleT);
                }
            }
            if ((bool)Rotate.IsChecked)
            {
                if(double.TryParse(TextBoxAngle.Text, out  Angle))
                {
                     rotateT.Angle = Angle;
                     myTransformGroup.Children.Add(rotateT);
                } 
            }
            if ((bool)Skew.IsChecked)
            {
                if (double.TryParse(TextBoxAngleX.Text, out  AngleX) && double.TryParse(TextBoxAngleY.Text, out  AngleY))
                {
                    skewT.AngleX = AngleX;
                    skewT.AngleY = AngleY;
                    myTransformGroup.Children.Add(skewT);
                }

            }
            if ((bool)Translate.IsChecked)
            {
                if (double.TryParse(TextBoxOffsetX.Text, out  OffsetX) && double.TryParse(TextBoxOffsetY.Text, out  OffsetY))
                {
                    var Transform = new TranslateTransform(OffsetX, OffsetY);
                    myTransformGroup.Children.Add(Transform);
                }

            }

            switch (sender.GetType().Name)
            {
                case "Button":
                    (sender as Button).LayoutTransform = myTransformGroup;
                    break;
                case "Label":
                    (sender as Label).LayoutTransform = myTransformGroup;
                    break;
                case "Image":
                    (sender as Image).LayoutTransform = myTransformGroup;
                    break;
            }
            if ((bool)Anim.IsChecked)
            {
                DoubleAnimation scaleXAnim = new DoubleAnimation();
                scaleXAnim.From = 1;
                scaleXAnim.To = SizeX;
                scaleXAnim.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    scaleXAnim.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    scaleXAnim.RepeatBehavior = RepeatBehavior.Forever;
                scaleT.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnim);

                DoubleAnimation scaleYAnim = new DoubleAnimation();
                scaleYAnim.From = 1;
                scaleYAnim.To = SizeX;
                scaleYAnim.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    scaleYAnim.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    scaleYAnim.RepeatBehavior = RepeatBehavior.Forever;
                scaleT.BeginAnimation(ScaleTransform.ScaleYProperty, scaleYAnim);

                DoubleAnimation rotateAnimation = new DoubleAnimation();
                rotateAnimation.From = 0;
                rotateAnimation.To = Angle;
                rotateAnimation.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    rotateAnimation.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    rotateAnimation.RepeatBehavior = RepeatBehavior.Forever;
                rotateT.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);

                DoubleAnimation skewXAnimation = new DoubleAnimation();
                skewXAnimation.From = 0;
                skewXAnimation.To = AngleX;
                skewXAnimation.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    skewXAnimation.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    skewXAnimation.RepeatBehavior = RepeatBehavior.Forever;
                skewT.BeginAnimation(SkewTransform.AngleXProperty, skewXAnimation);

                DoubleAnimation skewYAnimation = new DoubleAnimation();
                skewYAnimation.From = 0;
                skewYAnimation.To = AngleX;
                skewYAnimation.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    skewYAnimation.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    skewYAnimation.RepeatBehavior = RepeatBehavior.Forever;
                skewT.BeginAnimation(SkewTransform.AngleYProperty, skewYAnimation);

            }

        }

        private void Render_Click(object sender, RoutedEventArgs e)
        {

            TransformGroup myTransformGroup = new TransformGroup();
            ScaleTransform scaleT = new ScaleTransform();
            RotateTransform rotateT = new RotateTransform();
            SkewTransform skewT = new SkewTransform();
            TranslateTransform translateT = new TranslateTransform();
            double SizeX = 1, SizeY = 1, Angle = 0, AngleX = 0, AngleY = 0, OffsetX = 0, OffsetY = 0;
            if ((bool)Scale.IsChecked)
            {
                if (double.TryParse(TextBoxSizeX.Text, out SizeX) && double.TryParse(TextBoxSizeY.Text, out SizeY))
                {
                    scaleT.ScaleX = SizeX;
                    scaleT.ScaleY = SizeY;
                    myTransformGroup.Children.Add(scaleT);
                }
            }
            if ((bool)Rotate.IsChecked)
            {
                if (double.TryParse(TextBoxAngle.Text, out Angle))
                {
                    rotateT.Angle = Angle;
                    myTransformGroup.Children.Add(rotateT);
                }
            }
            if ((bool)Skew.IsChecked)
            {
                if (double.TryParse(TextBoxAngleX.Text, out AngleX) && double.TryParse(TextBoxAngleY.Text, out AngleY))
                {
                    skewT.AngleX = AngleX;
                    skewT.AngleY = AngleY;
                    myTransformGroup.Children.Add(skewT);
                }

            }
            if ((bool)Translate.IsChecked)
            {
                if (double.TryParse(TextBoxOffsetX.Text, out OffsetX) && double.TryParse(TextBoxOffsetY.Text, out OffsetY))
                {
                    translateT.X = OffsetX;
                    translateT.Y = OffsetY;
                    myTransformGroup.Children.Add(translateT);
                }

            }
            switch (sender.GetType().Name)
            {
                case "Button":
                    (sender as Button).RenderTransform = myTransformGroup;
                  //  (sender as Button).Opacity = 
                    break;
                case "Label":
                    (sender as Label).RenderTransform = myTransformGroup;
                    break;
                case "Image":
                    (sender as Image).RenderTransform = myTransformGroup;
                    break;
            }
            if ((bool)Anim.IsChecked)
            {
                DoubleAnimation scaleXAnim = new DoubleAnimation();
                scaleXAnim.From = 1;
                scaleXAnim.To = SizeX;
                scaleXAnim.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    scaleXAnim.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    scaleXAnim.RepeatBehavior = RepeatBehavior.Forever;
                scaleT.BeginAnimation(ScaleTransform.ScaleXProperty, scaleXAnim);

                DoubleAnimation scaleYAnim = new DoubleAnimation();
                scaleYAnim.From = 1;
                scaleYAnim.To = SizeX;
                scaleYAnim.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    scaleYAnim.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    scaleYAnim.RepeatBehavior = RepeatBehavior.Forever;
                scaleT.BeginAnimation(ScaleTransform.ScaleYProperty, scaleYAnim);

                DoubleAnimation rotateAnimation = new DoubleAnimation();
                rotateAnimation.From = 0;
                rotateAnimation.To = Angle;
                rotateAnimation.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    rotateAnimation.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    rotateAnimation.RepeatBehavior = RepeatBehavior.Forever;
                rotateT.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);

                DoubleAnimation skewXAnimation = new DoubleAnimation();
                skewXAnimation.From = 0;
                skewXAnimation.To = AngleX;
                skewXAnimation.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    skewXAnimation.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    skewXAnimation.RepeatBehavior = RepeatBehavior.Forever;
                skewT.BeginAnimation(SkewTransform.AngleXProperty, skewXAnimation);

                DoubleAnimation skewYAnimation = new DoubleAnimation();
                skewYAnimation.From = 0;
                skewYAnimation.To = AngleX;
                skewYAnimation.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    skewYAnimation.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    skewYAnimation.RepeatBehavior = RepeatBehavior.Forever;
                skewT.BeginAnimation(SkewTransform.AngleYProperty, skewYAnimation);

                DoubleAnimation translateXAnim = new DoubleAnimation();
                translateXAnim.From = 0;
                translateXAnim.To = OffsetX;
                translateXAnim.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    translateXAnim.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    translateXAnim.RepeatBehavior = RepeatBehavior.Forever;
                translateT.BeginAnimation(TranslateTransform.XProperty, translateXAnim);

                DoubleAnimation translateYAnim = new DoubleAnimation();
                translateYAnim.From = 0;
                translateYAnim.To = OffsetY;
                translateYAnim.Duration = new Duration(TimeSpan.Parse(TextBoxTimeSpan.Text));
                if ((bool)AutoReverse.IsChecked)
                    translateYAnim.AutoReverse = true;
                if ((bool)CBRepeatBehavior.IsChecked)
                    translateYAnim.RepeatBehavior = RepeatBehavior.Forever;
                translateT.BeginAnimation(TranslateTransform.YProperty, translateYAnim);
            }

        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
