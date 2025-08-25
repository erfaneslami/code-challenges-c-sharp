namespace CodeChallenges.LeetCode._36_Valid_Sudoku;


public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        var isValid = true;
        var memo = new Dictionary<char, EachNumberInfo>();
        for (int i = 1; i <= 9; i++)
        {
           memo.Add(char.Parse(i.ToString()), new EachNumberInfo()); 
        }

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                var cell = board[i][j];
                if (cell == '.') continue;
                var cellInfo = memo[cell];

                var subBoxIndex = GetSubBoxNum(i, j);
                if (cellInfo.Rows[i] == 1 || cellInfo.Cols[j] == 1 || cellInfo.SubBoxes[subBoxIndex] == 1)
                {
                    isValid = false;
                    break;
                }
                
                cellInfo.Rows[i] = 1;
                cellInfo.Cols[j] = 1;
                cellInfo.SubBoxes[subBoxIndex] = 1;
            } 
            
            if (!isValid) break;
        }
        return isValid;
    }

    private int GetSubBoxNum(int row, int col)
    {
        if (col is >= 0 and < 3)
        {
            if (row is >= 0 and < 3)
            {
                return 0;
            }
            
            if (row is >= 3 and < 6)
            {
                return 3;
            }
            
            
            if (row is >= 6 and < 9)
            {
                return 6;
            }
        }
        
        if (col is >= 3 and < 6)
        {
            if (row is >= 0 and < 3)
            {
                return 1;
            }
            
            if (row is >= 3 and < 6)
            {
                return 4;
            }
            
            
            if (row is >= 6 and < 9)
            {
                return 7;
            }
        }
        
        if (col is >= 6 and < 9)
        {
            if (row is >= 0 and < 3)
            {
                return 2;
            }
            
            if (row is >= 3 and < 6)
            {
                return 5;
            }
            
            
            if (row is >= 6 and < 9)
            {
                return 8;
            }
        }

        return -1;
    }
    private class EachNumberInfo
    {
        public EachNumberInfo()
        {
            
        }
        public int[] Cols { get; set; } = new int[9];
        public int[] Rows { get; set; } = new int[9];
        public int[] SubBoxes { get; set; } = new int[9]; 
        
    }
}