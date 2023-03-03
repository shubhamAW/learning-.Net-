namespace training_basic_csharp {
    class ChessBoard {
        public static int BlockSize { get; set; }
    }
    class Program {
        static void Main() {
            ChessBoard.BlockSize = 100;
            int blockSize = ChessBoard.BlockSize;
        }
    }
}
