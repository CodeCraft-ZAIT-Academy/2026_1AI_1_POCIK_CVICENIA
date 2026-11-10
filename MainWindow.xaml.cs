
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

namespace CviceniaBattleSimulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Hero MyHero { get; set; }
        public Monster MyMonster { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MyHero = new Hero(100, 20);
            MyMonster = new Monster(200, 40);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button_Attack_Hp.Content = MyMonster.Health.ToString();
            MyMonster.Health -= 10;
            if (MyMonster.Health <= -10)
            {

                Button_Attack_Hp.Content = "Hero is dead";
                Button_Attack_Hp.IsEnabled = false;
                ProgressBar_Hero.Value = MyMonster.Health;

            }

        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button_Monster.Content = MyHero.Health.ToString();
            MyHero.Health -= 20;
            if (MyHero.Health <= -20)
            {

                Button_Monster.Content = "Monster is dead";
                Button_Monster.IsEnabled = false;
                ProgressBar_Monster.Value = MyHero.Health;

            }
        }

        private void ProgressBar_Hero_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void ProgressBar_Monster_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
