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
        private readonly Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();

            ProgressBar_Hero.Maximum = MyHero.MaxHp;
            ProgressBar_Hero_Mana.Maximum = 100;
            ProgressBar_Enemy.Maximum = MyEnemy.MaxHP;
            ProgressBar_XP.Maximum = 100;
            UpdateUI();
        }

        public void UpdateUI()
        {
            if (MyHero.HP <= 0)
            {
                MyHero.HP = 0;
                MessageBox.Show("Prehral si");
            }

            if (MyEnemy.Health <= 0)
            {
                MessageBox.Show("Vyhral si");
                MyEnemy.Revive();
                MyHero.XP += 50;
            }

            if (MyHero.XP >= 100)
            {
                MyHero.XP -= 100;
                LevelUpPanel.Visibility = Visibility.Visible;
            }

            ProgressBar_Hero.Maximum = MyHero.MaxHp;
            ProgressBar_Enemy.Maximum = MyEnemy.MaxHP;

            ProgressBar_Hero.Value = MyHero.HP;
            ProgressBar_Hero_Mana.Value = MyHero.Mana;
            ProgressBar_Enemy.Value = MyEnemy.Health;
            ProgressBar_XP.Value = MyHero.XP;

            Label_Hero.Content = $"HP: {MyHero.HP} / {MyHero.MaxHp}";
            Label_Hero_Mana.Content = $"Mana: {MyHero.Mana} / {(int)ProgressBar_Hero_Mana.Maximum}";
            Label_Hero_XP.Content = $"XP: {MyHero.XP} / 100";
            Label_Hero_DMG.Content = $"DMG: {MyHero.DMG}";

            Label_Enemy_HP.Content = $"Enemy HP: {MyEnemy.Health} / {MyEnemy.MaxHP}";
            Label_Enemy_DMG.Content = $"Enemy DMG: {MyEnemy.Demage}";

            LightAttack.IsEnabled = MyHero.Mana >= 13;
            MediumAttack.IsEnabled = MyHero.Mana >= 35;
            HeavyAttack.IsEnabled = MyHero.Mana >= 65;
        }

        private void Btn_UpgradeDMG_Click(object sender, RoutedEventArgs e)
        {
            MyHero.DMG += 5;
            LevelUpPanel.Visibility = Visibility.Collapsed;
            UpdateUI();
        }

        private void Btn_UpgradeHP_Click(object sender, RoutedEventArgs e)
        {
            MyHero.MaxHp += 25;
            MyHero.HP += 25;
            LevelUpPanel.Visibility = Visibility.Collapsed;
            UpdateUI();
        }

        private void Btn_UpgradeMana_Click(object sender, RoutedEventArgs e)
        {
            ProgressBar_Hero_Mana.Maximum += 20;
            MyHero.Mana += 20;
            if (MyHero.Mana > ProgressBar_Hero_Mana.Maximum)
            {
                MyHero.Mana = (int)ProgressBar_Hero_Mana.Maximum;
            }
            LevelUpPanel.Visibility = Visibility.Collapsed;
            UpdateUI();
        }

        private void LightAttack_Click(object sender, RoutedEventArgs e)
        {
            if (MyHero.Mana < 13)
            {
                MessageBox.Show("Nemas dostatok many");
                UpdateUI();
                return;
            }

            MyEnemy.Health -= 5;
            MyHero.HP -= MyEnemy.Demage;
            MyEnemy.Demage -= MyHero.DMG;
            MyHero.Mana -= 13;

            UpdateUI();
        }

        private void MediumAttack_Click(object sender, RoutedEventArgs e)
        {
            if (MyHero.Mana < 35)
            {
                MessageBox.Show("Nemas dostatok many");
                UpdateUI();
                return;
            }

            MyEnemy.Health -= 15;
            MyHero.HP -= MyEnemy.Demage;
            MyEnemy.Demage -= MyHero.DMG;
            MyHero.Mana -= 35;

            UpdateUI();
        }

        private void HeavyAttack_Click(object sender, RoutedEventArgs e)
        {
            if (MyHero.Mana < 65)
            {
                MessageBox.Show("Nemas dostatok many");
                UpdateUI();
                return;
            }

            MyEnemy.Health -= 25;
            MyHero.HP -= MyEnemy.Demage;
            MyEnemy.Demage -= MyHero.DMG;
            MyHero.Mana -= 65;

            UpdateUI();
        }

        private void ProgressBar_Hero_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ProgressBar_Hero.Value = (double)e.NewValue;
        }

        private void Button_Sleep_Click(object sender, RoutedEventArgs e)
        {
            MyHero.Mana += 45;
            if (MyHero.Mana > ProgressBar_Hero_Mana.Maximum)
            {
                MyHero.Mana = (int)ProgressBar_Hero_Mana.Maximum;
            }

            UpdateUI();
        }

        private void ProgressBar_Enemy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ProgressBar_Enemy.Value = (double)e.NewValue;
        }

        private void ProgressBar_XP_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ProgressBar_XP.Value = (double)e.NewValue;
        }

        private void Button_Kocka_Click(object sender, RoutedEventArgs e)
        {
            int roll = random.Next(100); 

            if (roll < 90)
            {
               
                int polovicnyDmg = MyHero.HP / 2;
                MyHero.HP -= polovicnyDmg;
                if (MyHero.HP < 0)
                {
                    MyHero.HP = 0;
                }
            }
            else
            {
               
                MyEnemy.Health = 0;
                MyEnemy.Revive();
                MyHero.XP += 50;
            }

            UpdateUI();
        

       
        }
    }
}


