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

namespace Cvicenie_pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Hero MyHero { get; set; } = new Hero();
        public Enemy MyEnemy { get; set; } = new Enemy(50, 50, 10);
        public MainWindow()
        {
            InitializeComponent();

            ProgressBar_Enemy.Maximum = MyEnemy.MaxHP;
            ProgressBar_Hero.Maximum = MyHero.MaxHp;
            ProgressBar_Hero_Mana.Maximum = 100;
            UpdateUI();
        }

        public void UpdateUI()
        {

            if (MyHero.HP <= 0)
            {
                MessageBox.Show("Prehral si");
            }
            if(MyEnemy.Health <= 0)
            {
                MessageBox.Show("Vyhral si");
            }
            ProgressBar_Hero.Value = MyHero.HP;
            ProgressBar_Hero_Mana.Value=MyHero.Mana;
        }

        private void LightAttack_Click(object sender, RoutedEventArgs e)
        {
            MyEnemy.Health -= 5;
            MyHero.HP -= MyEnemy.Demage;
            MyEnemy.Demage -= MyHero.DMG;
            MyHero.Mana -= 13;


            UpdateUI();

            if(MyHero.Mana <= 13)
            {
                MessageBox.Show("Nemas dostatok many");
               LightAttack.IsEnabled = false;
            }



        }

        private void MediumAttack_Click(object sender, RoutedEventArgs e)
        {
            MyEnemy.Health -= 10;

            MyHero.HP -= MyEnemy.Demage * 2;
            MyEnemy.Demage -= MyHero.DMG;
            MyHero.Mana -= 35;


            UpdateUI();

            if (MyHero.Mana <= 35)
            {
                MessageBox.Show("Nemas dostatok many");
                MediumAttack.IsEnabled = false;
            }

        }

        private void HeavyAttack_Click(object sender, RoutedEventArgs e)
        {
            MyEnemy.Health -= 15;

            MyHero.HP -= MyEnemy.Demage * 3;
            MyEnemy.Demage -= MyHero.DMG;
            MyHero.Mana -= 65;


            UpdateUI();

            if (MyHero.Mana <= 65)
            {
                MessageBox.Show("Nemas dostatok many");
                HeavyAttack.IsEnabled = false;
            }
        }
      

        private void ProgressBar_Hero_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ProgressBar_Hero.Value = (double)e.NewValue;
        }

        private void Button_Sleep_Click(object sender, RoutedEventArgs e)
        {
            MyHero.Mana += 45;
            if(MyHero.Mana >=100)
            {
                MyHero.Mana = 100;
            }
            
            UpdateUI();
        }

        private void ProgressBar_Enemy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ProgressBar_Enemy.Value = (double)e.NewValue;
        }
    }
}