using System;
using System.Windows.Forms;

namespace GameOfLife
{
    /// <summary>
    /// Manual Seed Form
    /// </summary>
    public partial class ManualSeedForm : Form
    {
        #region - Fields -
        /// <summary>
        /// # of columns
        /// </summary>
        private int _columns;
        /// <summary>
        /// # of rows
        /// </summary>
        private int _rows;
        /// <summary>
        /// two demensional bool array, each cell represents life of cell.
        /// </summary>
        private bool[,] _universe;
        #endregion

        #region - Ctors. -
        public ManualSeedForm()
        {
            InitializeComponent();
        }
        #endregion

        #region - Properties -
        /// <summary>
        /// the initial universe.
        /// </summary>
        public bool[,] InitialUniverse
        {
            get
            {
                return _universe.Clone() as bool[,];
            }
        }
        #endregion

        #region - Event Handlers -
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                for (int row = 0; row < txtInput.Lines.Length; row++)
                {
                    if (row == 0)
                    {
                        var arr = Array.ConvertAll(txtInput.Lines[row].Split(new[] { ' ' }), Int32.Parse);
                        _columns = arr[0];
                        _rows = arr[1];

                        if (_rows != txtInput.Lines.Length - 1)
                            throw new Exception("Provided not enough rows.");

                        _universe = new bool[_columns, _rows];
                        continue;
                    }

                    var eachRow = Array.ConvertAll(txtInput.Lines[row].Split(new[] { ' ' }), Int32.Parse);
                    for (int col = 0; col < eachRow.Length; col++)
                    {
                        // because row 0 has N x M info, the correct row is row - 1.
                        _universe[col, row - 1] = eachRow[col] == 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input data is wrong. Please try again." + ex);
                return;
            }
        } 
        #endregion
    }
}
