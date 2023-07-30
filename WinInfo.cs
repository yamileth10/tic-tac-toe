namespace TicTacToe
{
    public class WinInfo
    {
        public WinType Type { get; set; } 
        public int Number { get; set; }
        public WinType MainDiagonal { get; internal set; }
    }
}
