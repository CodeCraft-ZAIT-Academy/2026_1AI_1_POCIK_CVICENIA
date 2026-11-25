using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cvicenia_Mapa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            var random = new Random();
            for (var i = 0; i < 20; i++)
            {
                





                var button = new Button
                {


                    Background= Brushes.Transparent,
                    BorderBrush = Brushes.Transparent,

                
                    Content = new Image
                    {
                        Source = new BitmapImage(new Uri($"img/Enemy{(i % 3) + 1}.png", UriKind.Relative)),
                        Stretch = Stretch.Uniform
                    },
                    Width = 100,
                    Height = 100,
                    HorizontalAlignment = HorizontalAlignment.Left,
                    VerticalContentAlignment = VerticalAlignment.Top,
                    Margin = new Thickness(random.Next(0,700), random.Next(0,700), 0,0)

                    


                };


              
               

                button.Click += Button_Click;
                MainGrid.Children.Add(button);
                int s = random.Next(0, 101);
                if (s<=100&&s >=40)
                {
                    button.BorderBrush = Brushes.Yellow;
                }
                else if (s<=100 && s >=30)
                {
                    button.BorderBrush = Brushes.Red;

                }
                else if (s<=100&& s >=10)
                {
                    button.BorderBrush = Brushes.Silver;

                }

            }
        }
    
    
    private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Klikol si");
        }
    
    
    
    }

}