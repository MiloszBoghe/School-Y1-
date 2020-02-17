using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace CyberspaceInvader
{
    public partial class Game : Window
    {
        private Player player;
        private Alien alien;

        private LaserCollection lasers;
        private BombCollection bombs;

        private DispatcherTimer animationTimer;
        private DispatcherTimer bombTimer;
        
        public Game()
        {
            InitializeComponent();

            player = new Player();
            player.DisplayOn(gameCanvas);

            alien = new Alien();
            alien.DisplayOn(gameCanvas);

            bombs = new BombCollection();
            lasers = new LaserCollection();

            animationTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(50)
            };
            animationTimer.Tick += animationTimer_Tick;
            animationTimer.Start();


            bombTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(2)
            };
            bombTimer.Tick += bombTimer_Tick;
            bombTimer.Start();
        }

        private void bombTimer_Tick(object sender, EventArgs e)
        {
            alien.DropBomb(bombs);
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            alien.Move();
            lasers.Move();
            bombs.Move();
            bombs.CheckHit(player);
            lasers.CheckHit(alien);

            if (alien.IsDead)
            {
                EndGame("player");
            }

            if (player.IsDead)
            {
                EndGame("alien");
            }
        }

        private void gameCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            var targetX = (int) (e.GetPosition(gameCanvas).X - player.Width / 2.0);
            player.Move(targetX);
        }

        private void gameCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            player.ShootLaser(lasers);
        }

        private void EndGame(string winner)
        {
            animationTimer.Stop();
            bombTimer.Stop();
            MessageBox.Show($"game over - {winner} wins");
            Environment.Exit(0);
        }
    }
}
