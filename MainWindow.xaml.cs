using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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

namespace TicTacToe
{
    public partial class MainWindow : Window
    {

        private readonly Dictionary<Player, ImageSource> ImaageSource = new()
        {
            {Player.X, new BitmapImage(new Uri("pack://application:,,,/Assets/X15.png")) },
            {Player.O, new BitmapImage(new Uri("pack://application:,,,/Assets/O15.png")) }
        };

        private readonly Image[,] imageControls = new Image[3, 3];
        private readonly GameResult gameState = new GameResult();

        public MainWindow()
        {
            InitializeComponent();
            SetupGameGrid();
        }

        private void SetupGameGrid()
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Image imageControl = new Image();
                    GameGrid.Children.Add(imageControl);
                    imageControls[r, c] = imageControl;
                }
            }
        }

        private void OnMoveMade(int r, int c)
        {

        }

        private  void OnGameEnded(GameResult gameResult)
        {

        }

        private void OnGameRestarted()
        {

        }

        private void GameGrid_Mouse(Object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
