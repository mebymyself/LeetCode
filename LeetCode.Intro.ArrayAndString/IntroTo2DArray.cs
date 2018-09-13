using System.Collections.Generic;

namespace LeetCode.Intro.ArrayAndString
{
    public class IntroTo2DArray
    {
        public int[] FindDiagonalOrder(int[,] matrix)
        {

            if (matrix == null || matrix.Length == 0) return new int[0];

            var results = new int[matrix.Length];

            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);


            var r = 0;
            var c = 0;
            var i = 0;

            var forward = true;


            while ((r + 1) * (c + 1) < matrix.Length)
            {
                results[i] = matrix[r, c];
                if (forward)
                {

                    if (r == 0 && c < columns - 1) //top border but not corner
                    {
                        forward = false;
                        c++;
                    }
                    else if (c == columns - 1) //right border including corner
                    {
                        forward = false;
                        r++;
                    }
                    else
                    {
                        r--;
                        c++;

                    }
                }
                else
                {
                    if (c == 0 && r < rows - 1) // left border but not corner
                    {
                        forward = true;
                        r++;
                    }
                    else if (r == rows - 1) // bottom
                    {
                        forward = true;
                        c++;
                    }
                    else
                    {
                        r++;
                        c--;
                    }
                }
                i++;
            }

            results[i] = matrix[r, c];

            return results;


        }

        public IList<int> SpiralOrder(int[,] matrix)
        {
            var res = new List<int>();
            var row = matrix.GetLength(0);
            var column = matrix.GetLength(1);

            var left = 0;
            var right = column - 1;
            var top = 0;
            var bottom = row - 1;

            while (true)
            {
                // travel right
                for (int i = left; i <= right; i++) res.Add(matrix[top, i]);
                top++;
                if (left > right || top > bottom) break;

                //travel down
                for (int i = top; i <= bottom; i++) res.Add(matrix[i, right]);
                right--;
                if (left > right || top > bottom) break;

                // travel left
                for (int i = right; i >= left; i--) res.Add(matrix[bottom, i]);
                bottom--;
                if (left > right || top > bottom) break;

                // travel up
                for (int i = bottom; i >= top; i--) res.Add(matrix[i, left]);
                left++;
                if (left > right || top > bottom) break;
            }

            return res;

        }

        public IList<IList<int>> GeneratePascalsTriangle(int numRows)
        {
            var r = new int[numRows][];
            for (int i = 0; i < numRows; i++)
            {
                var c = r[i] = new int[i + 1];
                c[0] = c[i] = 1;
                for (int j = 1; j < i; j++)
                    c[j] = r[i - 1][j - 1] + r[i - 1][j];
            }
            return r;
        }
    }
}