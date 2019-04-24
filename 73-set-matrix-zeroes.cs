public class Solution
{
    public void SetZeroesUsingFlags(int[][] matrix)
    {
        int rowCount = matrix.Length;
        int colCount = matrix[0].Length;

        bool topRow = false, topCol = false;

        // analyze zero row, col:
        for(int row = 0; row < rowCount; row++)
        {
            if(matrix[row][0] == 0)
            {
                topRow = true;
            }
        }
        for(int col = 0; col < colCount; col++)
        {
            if(matrix[0][col] == 0)
            {
                topCol = true;
            }
        }

        // record flags, leaving outer row / col unscanned:
        for(int row = 1; row < rowCount; row++)
        {
            for(int col = 1; col < colCount; col++)
            {
                if(matrix[row][col] == 0)
                {
                    matrix[row][0] = 0; // flag row
                    matrix[0][col] = 0; // flag col
                }
            }
        }

        // process row flags, update columns:
        for(int row = 1; row < rowCount; row++)
        {
            if(matrix[row][0] == 0)
            {
                for(int col = 1; col < colCount; col++)
                {
                    matrix[row][col] = 0;
                }
            }
        }

        // process col flags, update rows:
        for(int col = 1; col < colCount; col++)
        {
            if(matrix[0][col] == 0)
            {
                for(int row = 1; row < rowCount; row++)
                {
                    matrix[row][col] = 0;
                }
            }
        }

        // process zero row, col:
        if(topRow)
        {
            for (int row = 0; row < rowCount; row++)
            {
                matrix[row][0] = 0;
            }
        }
        if(topCol)
        {
            for (int col = 0; col < colCount; col++)
            {
                matrix[0][col] = 0;
            }
        }
    }

    public void SetZeroesUsingStructure(int[][] matrix)
    {
        int rowCount = matrix.Length;
        int colCount = matrix[0].Length;

        HashSet<Coord> zeroCoords = new HashSet<Coord>();

        for (int row = 0; row < rowCount; row++)
        {
            for (int col = 0; col < colCount; col++)
            {
                if (matrix[row][col] == 0)
                {
                    zeroCoords.Add(new Coord()
                    {
                        X = row,
                        Y = col
                    });
                }
            }
        }

        foreach (Coord coord in zeroCoords)
        {
            for (int i = 0; i < colCount; i++)
            {
                matrix[coord.X][i] = 0;
            }

            for (int i = 0; i < rowCount; i++)
            {
                matrix[i][coord.Y] = 0;
            }
        }
    }

    public class Coord
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}