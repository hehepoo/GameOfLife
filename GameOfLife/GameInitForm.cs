using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class GameInitForm : Form
    {
        private int _columns;
        private int _rows;

        public GameInitForm()
        {
            InitializeComponent();
        }

        #region - Properties -
        /// <summary>
        /// Columns Count
        /// </summary>
        public int Columns { get { return _columns; } }

        /// <summary>
        /// Rows Count
        /// </summary>
        public int Rows { get { return _rows; } } 
        #endregion

        private void btnGenerateCells_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(txtColumns.Text, out _columns))
            {
                MessageBox.Show("Please provide columns.");
                return;
            }
            if (!Int32.TryParse(txtRows.Text, out _rows))
            {
                MessageBox.Show("Please provide rows.");
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
