public class Solution
{
    private int numRows;
    private int numCols;
    private char[][] grid;

    public int NumIslands(char[][] grid)
    {
        if(grid.Length < 1)
        {
            return 0;
        }

        this.numRows = grid.Length;
        this.numCols = grid[0].Length;
        this.grid = grid;

        int numIslands = 0;

        // iterate through 2d jagged array:
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                if (this.grid[row][col] == '1')
                {
                    numIslands++;

                    // trigger BFS in order to mark island as 'visited':
                    BreadthFirstIslandTraversal(new Coordinate
                    {
                        X = row,
                        Y = col
                    });
                }
            }
        }

        return numIslands;
    }

    private void BreadthFirstIslandTraversal(Coordinate start)
    {
        this.grid[start.X][start.Y] = '0'; // visited

        Queue<Coordinate> queue = new Queue<Coordinate>();
        queue.Enqueue(start);

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            // check neighbors:
            if (current.X > 0 && this.grid[current.X - 1][current.Y] == '1') // check up
            {
                queue.Enqueue(new Coordinate
                {
                    X = current.X - 1,
                    Y = current.Y
                });
                this.grid[current.X - 1][current.Y] = '0'; // visited
            }
            if (current.X < this.numRows - 1 && this.grid[current.X + 1][current.Y] == '1') // check down
            {
                queue.Enqueue(new Coordinate
                {
                    X = current.X + 1,
                    Y = current.Y
                });
                this.grid[current.X + 1][current.Y] = '0'; // visited
            }
            if (current.Y > 0 && this.grid[current.X][current.Y - 1] == '1') // check left
            {
                queue.Enqueue(new Coordinate
                {
                    X = current.X,
                    Y = current.Y - 1
                });
                this.grid[current.X][current.Y - 1] = '0'; // visited
            }
            if (current.Y < this.numCols - 1 && this.grid[current.X][current.Y + 1] == '1') // check right
            {
                queue.Enqueue(new Coordinate
                {
                    X = current.X,
                    Y = current.Y + 1
                });
                this.grid[current.X][current.Y + 1] = '0'; // visited
            }
        }
    }

    public class Coordinate
    {
        public int X { get; set; } // corresponds to row

        public int Y { get; set; } // corresponds to column
    }
}