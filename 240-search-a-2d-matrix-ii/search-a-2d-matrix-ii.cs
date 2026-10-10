public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int m=matrix.Length;
        int n=matrix[0].Length;

        int r=0;
        int c=n-1;

        while(c>=0 && r<m)
        {
            if (matrix[r][c]==target)
            {
                return true;
            }
            else if(matrix[r][c]>target)
            {
                c--;
            }
            else
            {
                r++;
            }
        }
        return false;
        
    }
}