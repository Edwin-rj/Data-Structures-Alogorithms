public class Solution {
    public bool IsValidSudoku(char[][] board) {

        bool[,] rows = new bool[9, 9];
        bool[,] cols = new bool[9, 9];
        bool[,] boxes = new bool[9, 9];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char num = board[i][j];

                if (num == '.')
                    continue;

                int n = num - '1';
                int box = (i / 3) * 3 + (j / 3);

                if (rows[i, n] || cols[j, n] || boxes[box, n])
                    return false;

                rows[i, n] = true;
                cols[j, n] = true;
                boxes[box, n] = true;
            }
        }

        return true;
    }
}