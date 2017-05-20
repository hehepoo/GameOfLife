using GameOfLife.Entities;
using GameOfLife.Writers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class GameOfLifeForm : Form
    {
        #region - Fields -
        private readonly Universe _universe = new Universe();
        private int _columns;
        private int _rows;
        #endregion

        #region - Ctors. -
        public GameOfLifeForm()
        {
            InitializeComponent();
        }
        #endregion

        #region - Event Handlers -
        private void btnInit_Click(object sender, EventArgs e)
        {
            var initForm = new GameInitForm();
            btnRandomSeed.Enabled = false;
            btnTick.Enabled = false;
            btnAutoTick.Enabled = false;
            btnRandomSeed.Enabled = false;

            if (initForm.ShowDialog() == DialogResult.OK)
            {
                _columns = initForm.Columns;
                _rows = initForm.Rows;
                btnRandomSeed.Enabled = true;
                btnManualSeed.Enabled = true;
            }
        }
        private void btnManualSeed_Click(object sender, EventArgs e)
        {
            var manualSeedForm = new ManualSeedForm();

            // disable buttons
            btnTick.Enabled = false;
            btnAutoTick.Enabled = false;
            btnRandomSeed.Enabled = false;
            btnShowResultInArray.Enabled = false;

            if (manualSeedForm.ShowDialog() == DialogResult.OK)
            {
                _universe.SetUniverse(manualSeedForm.InitialUniverse);

                // Show the grid in the output window
                var debugWriter = new DebugWriter();
                _universe.WriteAllCells(debugWriter);


                // Refresh Paintbox
                pbUniverse.Invalidate();
            }

            btnRandomSeed.Enabled = true;

            // enable buttons
            if (_universe.CurrentUniverse != null)
            {
                btnTick.Enabled = true;
                btnAutoTick.Enabled = true;
                btnShowResultInArray.Enabled = true;
            }
        }

        private void btnRandomSeed_Click(object sender, EventArgs e)
        {
            bool[,] universe = new bool[_columns, _rows];
            Random random = new Random();

            // Set random value to each cell
            for (int col = 0; col < _columns; col++)
                for (int row = 0; row < _rows; row++)
                {
                    universe[col, row] = random.Next(0, 100) % 2 == 0;
                }

            _universe.SetUniverse(universe);

            // Show the grid in the output window
            var debugWriter = new DebugWriter();
            _universe.WriteAllCells(debugWriter);

            // Refresh Paintbox
            pbUniverse.Invalidate();
            btnAutoTick.Enabled = true;
            btnTick.Enabled = true;
            btnShowResultInArray.Enabled = true;
        }

        private void btnTick_Click(object sender, EventArgs e)
        {
            // generate new universe.
            _universe.MoveToNextGeneration();

            // refresh output
            pbUniverse.Invalidate();
        }

        private void btnAutoTick_Click(object sender, EventArgs e)
        {
            if (btnAutoTick.Text == "Stop")
            {
                //Enable buttons
                btnAutoTick.Text = "Auto Tick/Sec";
                btnTick.Enabled = true;
                btnInit.Enabled = true;
                btnManualSeed.Enabled = true;
                btnRandomSeed.Enabled = true;

                // stop timer and unregister the callback func.
                timer1.Stop();
                timer1.Tick -= Timer1_Tick;
            }
            else
            {
                //disable buttons
                btnAutoTick.Text = "Stop";
                btnTick.Enabled = false;
                btnInit.Enabled = false;
                btnManualSeed.Enabled = false;
                btnRandomSeed.Enabled = false;

                // start timer and register the callback func
                // set interval to 1 sec.
                timer1.Interval = 1000;
                timer1.Tick += Timer1_Tick;
                timer1.Start();
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            // generate new universe.
            _universe.MoveToNextGeneration();

            // refresh output
            pbUniverse.Invalidate();
        }

        private void pbUniverse_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            bool[,] universe = _universe.CurrentUniverse;

            if (universe == null)
                return;

            int cellSize = 32;
            Pen p = new Pen(Color.Black);
            SolidBrush b = new SolidBrush(Color.Black);

            // rendor cell info to picture box control
            for (int col = 0; col < _columns; col++)
                for (int row = 0; row < _rows; row++)
                {
                    // if a cell is alive, draw a filled rect, otherwise rect without filled.
                    if (universe[col, row]) 
                        g.FillRectangle(b, new Rectangle(col * cellSize, row * cellSize, cellSize, cellSize));
                    else
                        g.DrawRectangle(p, col * cellSize, row * cellSize, cellSize, cellSize);
                }
        }

        private void btnShowResultInArray_Click(object sender, EventArgs e)
        {
            var writer = new StringWriter();
            _universe.WriteAllCells(writer);

            MessageBox.Show(writer.ToString());
        }

        #endregion
    }
}
