using System.ComponentModel;

namespace TetrisWPF
{
    public class GameGrid
    {
        private readonly GridValue[,] _grid;
        
        public int Rows { get; }
        public int Cols { get; }

        public GridValue this[int r, int c]
        {
            get => _grid[r, c];
            set => _grid[r, c] = value;
        }

        public GameGrid(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            _grid = new GridValue[rows, cols];
        }

        public bool IsInside(int r, int c)
        {
            return r >= 0 && r < Rows && c >= 0 && c < Cols;
        }

        public bool IsEmpty(int r, int c)
        {
            return IsInside(r, c) && _grid[r, c] == GridValue.Empty;
        }

        public bool IsRowFull(int r)
        {
            for (int c = 0; c < Cols; c++)
            {
                if (_grid[r, c] == GridValue.Empty)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsRowEmpty(int r)
        {
            for (int c = 0; c < Cols; c++)
            {
                if (_grid[r, c] != GridValue.Empty)
                {
                    return false;
                }
            }

            return true;
        }

        private void ClearRow(int r)
        {
            for (int c = 0; c < Cols; c++)
                _grid[r, c] = GridValue.Empty;
        }

        private void MoveRowDown(int r, int numRows)
        {
            for (int c = 0; c < Cols; c++)
            {
                _grid[r + numRows, c] = _grid[r, c];
                _grid[r, c] = GridValue.Empty;
            }
        }

        public int ClearFullRows()
        {
            int cleared = 0;

            for (int r = Rows - 1; r >= 0; r--)
            {
                if (IsRowFull(r))
                {
                    ClearRow(r);
                    cleared++;
                }
                else if (cleared > 0)
                {
                    MoveRowDown(r, cleared);
                }
            }

            return cleared;
        }
    }
}
