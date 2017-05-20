using GameOfLife.Writers;

namespace GameOfLife.Entities
{

    /// <summary>
    /// Universe contains N x M cells
    /// </summary>
    public class Universe
    {
        #region - Fields -
        /// <summary>
        /// Its each item in the two demension repsenting each cell.
        /// For each cell, if cell is alive, we set it true.  
        /// Otherwise false.
        /// </summary>
        private bool[,] _universe;

        /// <summary>
        /// It contains _livingSpace's M
        /// </summary>
        private int _columns;

        /// <summary>
        /// It continas _livingSpace's N
        /// </summary>
        private int _rows;

        /// <summary>
        /// Writer that we can write output
        /// </summary>
        private IWritable _writer;
        #endregion

        #region - Ctors. -
        /// <summary>
        /// Default contructor will have a ScreenWriter.
        /// </summary>
        public Universe()
        {
            _writer = new ScreenWriter();
        }

        /// <summary>
        /// constructor with IWrite so that we can output current universe.
        /// </summary>
        /// <param name="writer"></param>
        public Universe(IWritable writer)
        {
            _writer = writer;
        }

        #endregion

        #region - Properties -
        /// <summary>
        /// It returns current copy of the universe.
        /// </summary>
        public bool[,] CurrentUniverse
        {
            get
            {
                return (_universe == null) ? null : _universe.Clone() as bool[,];
            }
        }
        #endregion

        #region - Public Methods -
        /// <summary>
        /// It sets universe data.
        /// </summary>
        /// <param name="universe"></param>
        public void SetUniverse(bool[,] universe)
        {
            _universe = universe.Clone() as bool[,];
            _columns = _universe.GetLength(0);
            _rows = universe.GetLength(1);
        }

        /// <summary>
        /// Show All Universe's cell with writer.
        /// </summary>
        /// <param name="writer"></param>
        public void WriteAllCells(IWritable writer = null)
        {
            if (writer == null)
                writer = _writer;

            writer.Write(CurrentUniverse);
            
        }

        /// <summary>
        /// It generate next universe.
        /// </summary>
        public void MoveToNextGeneration()
        {
            #region Expand it for Rules Description
            // For each cell c[x,y], the rules of life should be applied.
            // Rule 1: Any live cell with one live neighbor will die.
            // Rule 2: Any live cell with 2, 3 neighbors will survive.
            // Rule 3: Any live cell with more than 3 will die.
            // Rule 4: Any dead cell with exact three live neighbors will be newly borned.
            // 
            // In order to make sure to set a cell alive, we check each cell if Rule 4 or Rule 2 is met.
            // Otherwise, it will die. 
            #endregion

            var nextGenerationsInLivingSpace = new bool[_columns, _rows];
            nextGenerationsInLivingSpace = _universe.Clone() as bool[,];

            for (int col = 0; col < _columns; col++)
                for (int row = 0; row < _rows; row++)
                {
                    // Count live nieghbor cells.
                    int neigborCount = CountNeighborsAlive(col, row);

                    // Update current cell based on thoe rules.
                    nextGenerationsInLivingSpace[col, row] = (!_universe[col, row] && neigborCount == 3)                         // Checking Rule 4
                                                           ? true
                                                           : (_universe[col, row] && (neigborCount == 2 || neigborCount == 3))    // Checking Rule 2
                                                                ? true
                                                                : false;                                                             // Otherwise
                }

            _universe = nextGenerationsInLivingSpace.Clone() as bool[,];
        }
        #endregion

        #region - Helper Methods -
        /// <summary>
        /// </summary>
        /// <param name="x">current cell's x coordinate in the _livingSpace</param>
        /// <param name="y">current cell's y coordinate in the _livingSpace</param>
        /// <returns></returns>
        private int CountNeighborsAlive(int col, int row)
        {
            #region Expand it for conditions
            // We need check following X neighbor of O
            // ---------------------------------------------------
            //     X[col-1, row-1]   |   X[col, row-1]   |   X[col+1, row-1]
            // ---------------------------------------------------
            //     X[col-1, row]     |   O[col,row]      |   X[col+1, row]
            // ---------------------------------------------------
            //     X[col-1, row+1]   |   X[col, row+1]   |   X[colx+1, row+1]
            // ---------------------------------------------------
            // 
            // Also, we need to check all boundary check of cell O if it's eigher on the corner or edge of _livingSpace. 
            #endregion

            // Default boudary check
            if (col < 0 || row < 0 || col >= _columns || row >= _rows)
                return 0;

            // It is a counter for neighbors alive
            int count = 0;

            #region ~ Opearion for y - 1 row

            // [col-1, row-1] case
            count += CheckTopLeftCorner(col, row);

            // [col, row -1] case
            count += CheckTopEdge(col, row);

            // [col+1, row -1] case
            count += CheckTopRightCorner(col, row);

            #endregion

            #region ~ Opearion for y row

            // [col-1, row] case
            count += CheckLeftEdge(col, row);

            // [col+1, row] case
            count += CheckRightEdge(col, row);

            #endregion

            #region ~ Opearion for y + 1 row

            // [col-1, row+1] case
            count += CheckBottomLeftCorner(col, row);

            // [col, row+1] case
            count += CheckForBottomEdge(col, row); 

            // [col+1, row+1] case
            count += CheckForBottomRightCorner(col, row); 

            #endregion

            return count;
        }

        private int CheckTopLeftCorner(int col, int row)
        {
            return (col - 1 >= 0 && row - 1 >= 0)         // Check upper left corner
                    && _universe[col - 1, row - 1]        // is alive?
                   ? 1
                   : 0;
        }

        private int CheckTopEdge(int col, int row)
        {
            return (row - 1 >= 0)                       // Check top edge 
                    && _universe[col, row - 1]          // is alive?
                    ? 1
                    : 0;
        }

        private int CheckTopRightCorner(int col, int row)
        {
            return (col + 1 < _columns && row - 1 >= 0)   // Check upper right corner
                    && _universe[col + 1, row - 1]        // is alive?
                    ? 1
                    : 0;
        }

        private int CheckLeftEdge(int col, int row)
        {
            return (col - 1 >= 0)                       // Check left edge
                    && _universe[col - 1, row]          // is alive?
                    ? 1
                    : 0;
        }

        private int CheckRightEdge(int col, int row)
        {
            return (col + 1 < _columns)                 // Check right edge
                    && _universe[col + 1, row]          // is alive?
                    ? 1
                    : 0;
        }

        private int CheckBottomLeftCorner(int col, int row)
        {
            return (col - 1 >= 0 && row + 1 < _rows)      // Check bottom left corner 
                    && _universe[col - 1, row + 1]        // is alive?
                    ? 1
                    : 0;
        }

        private int CheckForBottomEdge(int col, int row)
        {
            return (row + 1 < _rows)                    // Check bottom edge
                    && _universe[col, row + 1]          // is alive?
                    ? 1
                    : 0;
        }

        private int CheckForBottomRightCorner(int col, int row)
        {
            return (col + 1 < _columns && row + 1 < _rows)  // Check bottom right corner 
                    && _universe[col + 1, row + 1]          // is alive?
                    ? 1
                    : 0;
        }
        #endregion
    }
}
