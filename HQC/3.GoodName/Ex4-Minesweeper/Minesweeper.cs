namespace Minesweeper
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Mine
    {
        public static void Main()
        {
            string gameCommand = string.Empty;
            char[,] gameField = CreateGameField();
            char[,] mines = PutMine();
            int finalPoints = 0;
            bool isMineExplode = false;
            List<GamePoints> championsInGame = new List<GamePoints>(6);
            int row = 0;
            int col = 0;
            bool startGame = true;
            bool endGame = false;
            const int MAX = 35;

            do
            {
                if (startGame)
                {
                    StringBuilder wellcomeText = new StringBuilder();
                    wellcomeText.AppendLine("Let's play “Minesweeper”! Try your luck to find fields without mines.");
                    wellcomeText.AppendLine("Command menu:");
                    wellcomeText.AppendLine("rating: show RankList");
                    wellcomeText.AppendLine("restart: restart game");
                    wellcomeText.AppendLine("exit: exit from game");
                    Console.WriteLine(wellcomeText);
                    PrintGameField(gameField);
                    startGame = false;
                }

                Console.Write("Please insert row and col separated by blankSpace: ");
                gameCommand = Console.ReadLine().Trim();

                if (gameCommand.Length >= 3)
                {
                    if (int.TryParse(gameCommand[0].ToString(), out row) &&
                    int.TryParse(gameCommand[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        gameCommand = "turn";
                    }
                }

                switch (gameCommand)
                {
                    case "rating":
                        RankList(championsInGame);
                        break;
                    case "restart":
                        gameField = CreateGameField();
                        mines = PutMine();
                        PrintGameField(gameField);
                        isMineExplode = false;
                        startGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Thank you for choosing our game! Have a nice day.");
                        break;
                    case "turn":
                        {
                            if (mines[row, col] != '*')
                            {
                                if (mines[row, col] == '-')
                                {
                                    YourTurn(gameField, mines, row, col);
                                    finalPoints++;
                                }

                                if (MAX == finalPoints)
                                {
                                    endGame = true;
                                }
                                else
                                {
                                    PrintGameField(gameField);
                                }
                            }
                            else
                            {
                                isMineExplode = true;
                            }

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nInvalide command!\n");
                            break;
                        }
                }

                if (isMineExplode)
                {
                    PrintGameField(mines);
                    Console.Write("\n GameOver: {0} points. Please, write your nickname: ", finalPoints);
                    string nickname = Console.ReadLine();
                    GamePoints player = new GamePoints(nickname, finalPoints);
                    if (championsInGame.Count < 5)
                    {
                        championsInGame.Add(player);
                    }
                    else
                    {
                        for (int curPlayer = 0; curPlayer < championsInGame.Count; curPlayer++)
                        {
                            if (championsInGame[curPlayer].Points < player.Points)
                            {
                                championsInGame.Insert(curPlayer, player);
                                championsInGame.RemoveAt(championsInGame.Count - 1);
                                break;
                            }
                        }
                    }

                    championsInGame.Sort((GamePoints playerOne, GamePoints playerTwo) => playerTwo.Name.CompareTo(playerOne.Name));
                    championsInGame.Sort((GamePoints playerOne, GamePoints playerTwo) => playerTwo.Points.CompareTo(playerOne.Points));
                    RankList(championsInGame);

                    gameField = CreateGameField();
                    mines = PutMine();
                    finalPoints = 0;
                    isMineExplode = false;
                    startGame = true;
                }

                if (endGame)
                {
                    Console.WriteLine("\nCongratulations! You open all {0} cells.", MAX);
                    PrintGameField(mines);
                    Console.WriteLine("Please, write your name: ");
                    string name = Console.ReadLine();
                    GamePoints points = new GamePoints(name, finalPoints);
                    championsInGame.Add(points);
                    RankList(championsInGame);
                    gameField = CreateGameField();
                    mines = PutMine();
                    finalPoints = 0;
                    endGame = false;
                    startGame = true;
                }
            }
            while (gameCommand != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }

        private static void RankList(List<GamePoints> rankPoints)
        {
            Console.WriteLine("\nPoints:");
            if (rankPoints.Count > 0)
            {
                for (int position = 0; position < rankPoints.Count; position++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", position + 1, rankPoints[position].Name, rankPoints[position].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Rank list!\n");
            }
        }

        private static void YourTurn(char[,] gameField, char[,] mines, int row, int col)
        {
            char minesCounter = CountMines(mines, row, col);
            mines[row, col] = minesCounter;
            gameField[row, col] = minesCounter;
        }

        private static void PrintGameField(char[,] gameField)
        {
            int numRow = gameField.GetLength(0);
            int numCol = gameField.GetLength(1);

            StringBuilder printField = new StringBuilder();
            printField.AppendLine("\n    0 1 2 3 4 5 6 7 8 9");
            printField.AppendLine("   ---------------------");

            for (int row = 0; row < numRow; row++)
            {
                printField.AppendFormat("{0} | ", row);

                for (int col = 0; col < numCol; col++)
                {
                    printField.AppendFormat("{0} ", gameField[row, col]);
                }

                printField.AppendLine("|");
            }

            printField.AppendLine("   ---------------------");
             
            Console.WriteLine(printField);
        }

        private static char[,] CreateGameField()
        {
            int gameFieldRows = 5;
            int gameFieldColumns = 10;
            char[,] gameField = new char[gameFieldRows, gameFieldColumns];
            for (int row = 0; row < gameFieldRows; row++)
            {
                for (int col = 0; col < gameFieldColumns; col++)
                {
                    gameField[row, col] = '?';
                }
            }

            return gameField;
        }

        private static char[,] PutMine()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    gameField[row, col] = '-';
                }
            }

            List<int> listOfMines = new List<int>();
            while (listOfMines.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!listOfMines.Contains(randomNumber))
                {
                    listOfMines.Add(randomNumber);
                }
            }

            foreach (int mine in listOfMines)
            {
                int col = mine / cols;
                int row = mine % cols;

                if (row == 0 && mine != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void Calculation(char[,] gameField)
        {
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (gameField[row, col] != '*')
                    {
                        char numberOfMines = CountMines(gameField, row, col);
                        gameField[row, col] = numberOfMines;
                    }
                }
            }
        }

        private static char CountMines(char[,] mines, int row, int col)
        {
            int counter = 0;
            int rows = mines.GetLength(0);
            int cols = mines.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mines[row - 1, col] == '*')
                {
                    counter++;
                }
            }

            if (row + 1 < rows)
            {
                if (mines[row + 1, col] == '*')
                {
                    counter++;
                }
            }

            if (col - 1 >= 0)
            {
                if (mines[row, col - 1] == '*')
                {
                    counter++;
                }
            }

            if (col + 1 < cols)
            {
                if (mines[row, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (mines[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (mines[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (mines[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (mines[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }

            return char.Parse(counter.ToString());
        }
    }
}