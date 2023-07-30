using System;

namespace TicTacToe
{
    public class GameResult
    { 
        public Player Winner { get; set; }
        public WinInfo WinInfo { get; set; }
        public object GameGrid { get; internal set; }
        public Action<int, int> MoveMade { get; internal set; }
        public Action<GameResult> GameEnded { get; internal set; }
        public Action GameRestarted { get; internal set; }
        public Player CurrentPlayer { get; internal set; }

        internal void MakeMove(int row, int col)
        {
            throw new NotImplementedException();
        }
    }
}
