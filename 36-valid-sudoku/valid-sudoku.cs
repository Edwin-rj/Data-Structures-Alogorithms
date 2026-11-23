public class Solution {
    public bool IsValidSudoku(char[][] board) {


        int[] rows = new int[9];
        int[] cols = new int[9];
        int[] boxes = new int[9];


        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {


                char num = board[i][j];


                if (num == '.')
                    continue;


                int n = num - '1';
                int mask = 1 << n;


                int boxIndex = (i / 3) * 3 + (j / 3);


                if ((rows[i] & mask) != 0 ||
                    (cols[j] & mask) != 0 ||
                    (boxes[boxIndex] & mask) != 0) {
                    return false;
                }


                rows[i] |= mask;
                cols[j] |= mask;
                boxes[boxIndex] |= mask;
            }
        }


        return true;
    }
}