using System;

// Jack Parkison
// CST-250// Date
// I used the following video for help on the calculateLiveNeighbors method starting at 43:40 of this video: https://www.youtube.com/watch?v=HBrF8LJ0Hfg 
// I used the following video for help on the setupLiveNeighbors method starting at 38:00 of this video: https://www.youtube.com/watch?v=HBrF8LJ0Hfg 
// Code for those two methods was not just copied, but the same concepts were used. The rest of the code is my work. 


namespace Minesweeper

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Minesweeper!");
            Console.WriteLine();

            int selectedDifficulty;
            int boardSize;
            while (true)
            {
                Console.WriteLine("Please enter the size of the board you would like to play on (between 5-20):");
                string input = Console.ReadLine();

                // checks to make sure the input is valid
                if (int.TryParse(input, out boardSize))
                {
                    if (boardSize >= 5 && boardSize <= 20)
                    {
                        Console.WriteLine("The gameboard will be " + boardSize + " x " + boardSize);
                        break;
                    }
                    Console.WriteLine("Please enter a valid number");
                }
            }
            GameBoard gameBoard = new GameBoard(boardSize);

            
            while (true)
            {
                Console.WriteLine("Please select a difficulty: 1: Easy, 2: Medium, 3: Hard");
                string input = Console.ReadLine();

                // checks to make sure the input is valild
                if (int.TryParse (input, out selectedDifficulty))
                {
                    if (selectedDifficulty >= 1 && selectedDifficulty <= 3)
                    {
                        // switch statement with cases for each option for difficulty
                        switch (selectedDifficulty)
                        {
                            case (1):
                                gameBoard.Difficulty = 5.0;
                                Console.WriteLine("You chose: Easy");
                                break;
                            case (2):
                                gameBoard.Difficulty = 4.0;
                                Console.WriteLine("You chose: Medium");
                                break;
                            case (3):
                                gameBoard.Difficulty = 3.0;
                                Console.WriteLine("You chose: Hard");
                                break;
                        }
                        break;
                    }
                    Console.WriteLine("Please enter '1', '2', or '3'");
                }

            }

            gameBoard.SetupLiveNeighbors();
            gameBoard.CalculateLiveNeighbors();
            PrintBoard(gameBoard);

        }

        /// <summary>
        /// This method prints the gameboard after the methods within the GameBoard class were called, so the bombs
        /// and live neighbors have already been calculated and placed within the grid, now we just need to print
        /// the grid
        /// </summary>
        /// <param name="board"></param>
        public static void PrintBoard(GameBoard board)
        {
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    Console.Write("+---");
                }
                Console.WriteLine("+");
                for (int j = 0; j < board.Size; j++)
                {
                    Cell cell = board.Grid[i, j];
                    if (cell.IsLive)
                    {
                        Console.Write("| * ");
                    }
                    else
                    {
                        //Console.Write("|   ");
                        Console.Write($"| {cell.LiveNeighbors} ");
                    }
                }
                Console.WriteLine("|");
            }
            for (int j = 0; j < board.Size; j++)
            {
                Console.Write("+---");
            }
            Console.WriteLine("+");
        }

    }
}