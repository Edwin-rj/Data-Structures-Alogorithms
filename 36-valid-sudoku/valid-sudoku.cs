public class Solution {
    public bool IsValidSudoku(char[][] board) {

        // Rule 1: Check rows
        for (int i = 0; i < 9; i++)
        {
            HashSet<char> row = new();

            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] == '.')
                    continue;

                if (!row.Add(board[i][j]))
                    return false;
            }
        }

        // Rule 2: Check columns
        for (int i = 0; i < 9; i++)
        {
            HashSet<char> col = new();

            for (int j = 0; j < 9; j++)
            {
                if (board[j][i] == '.')
                    continue;

                if (!col.Add(board[j][i]))
                    return false;
            }
        }

        // Rule 3: Check 3x3 boxes
        for (int i = 0; i < 9; i += 3)
        {
            for (int j = 0; j < 9; j += 3)
            {
                HashSet<char> box = new();

                for (int r = i; r < i + 3; r++)
                {
                    for (int c = j; c < j + 3; c++)
                    {
                        if (board[r][c] == '.')
                            continue;

                        if (!box.Add(board[r][c]))
                            return false;
                    }
                }
            }
        }

        return true;
    }
}