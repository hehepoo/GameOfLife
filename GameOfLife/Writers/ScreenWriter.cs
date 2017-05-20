using System;

namespace GameOfLife.Writers
{
    public class ScreenWriter : IWritable
    {
        public bool[,] CurrentUniverse { get; set; }

        public void Write(bool[,] universe)
        {
            int columns = universe.GetLength(0);
            int rows = universe.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                    Console.Write(string.Format("{0} ", universe[col, row] ? 1 : 0));

                Console.WriteLine();
            }
        }
    }
}
