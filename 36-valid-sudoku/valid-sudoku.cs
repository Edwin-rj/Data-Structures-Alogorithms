public class Solution {
    public bool IsValidSudoku(char[][] board) {
        try{ 
        HashSet<char> char1 = new();
        HashSet<char> char2 = new();
        HashSet<char>[] box = new HashSet<char>[9];

        for (int k = 0; k < 9; k++)
        {
            box[k] = new HashSet<char>();
        } 
            for(int i = 0;i<board.Length;i++)
            {
                for(int j = 0;j< board[i].Length;j++)
                {
                    if(board[i][j] != '.')
                       if (!char1.Add(board[i][j]))
                        return false;
                    
                if (board[i][j] != '.')
                {
                    int boxIndex = (i / 3) * 3 + (j / 3);

                    if (!box[boxIndex].Add(board[i][j]))
                         return false;
                }  
            }
                char1 = new HashSet<char>();
            }

            int count = board.Max(x=>x.Length);
            for(int i = 0;i<count;i++)
            {
                for(int j = 0;j< board.Length;j++)
                {
                    if(board[j][i] != '.')
                      if(!char2.Add(board[j][i]))
                         return false;
                }
                char2 = new HashSet<char>();
            }

            return true;
        }
        catch(Exception ex)
        {
            return false;
        }
    }
}