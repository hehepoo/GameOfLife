using System.Text;

namespace GameOfLife.Writers
{
    public class StringWriter : IWritable
    {
        #region - Fields -
        private StringBuilder _sb = new StringBuilder();
        #endregion

        #region - Properties -
        public bool[,] CurrentUniverse { get; set; }
        #endregion

        #region Public Methods -
        public void Write(bool[,] universe)
        {
            int columns = universe.GetLength(0);
            int rows = universe.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                    _sb.Append(string.Format("{0} ", universe[col, row] ? 1 : 0));

                _sb.AppendLine("");
            }
        }

        public override string ToString()
        {
            return _sb.ToString();
        }

        #endregion
    }
}
