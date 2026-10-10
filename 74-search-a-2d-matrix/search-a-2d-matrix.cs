public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

        int m=matrix.Length;
        int n=matrix[0].Length;

        int l=0;
        int r=m-1;
        int row=-1;

        while(l<=r)
        {
            int mid=l+(r-l)/2;

            if (matrix[mid][0]<=target && matrix[mid][n-1]>=target )
            {
               row=mid;
               break;
            }
            else if(matrix[mid][0]<target)
            {
                l=mid+1;
            }
            else
            {
                r=mid-1;
            }
        }

        if(row==-1) return false;
        

        int l1=0;
        int r1=n-1;

        while(l1<=r1)
        {
            int mid1=l1+(r1-l1)/2;

            if(matrix[row][mid1]==target)
            {
                return true;
            }
            else if(matrix[row][mid1]<target)
            {
                l1=mid1+1;
            }
            else
            {
                r1=mid1-1;
            }
        }
        return false;
    }
}