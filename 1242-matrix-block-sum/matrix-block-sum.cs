public class Solution {
    public int[][] MatrixBlockSum(int[][] mat, int k) {

        int m=mat.Length;
        int n=mat[0].Length;

        int[,] prefixsum=new int[m+1 ,n+1];

        for (int i=1;i<=m;i++)
        {
            for (int j=1;j<=n;j++)
            {
                prefixsum[i,j]=mat[i-1][j-1]
                                +prefixsum[i-1,j] 
                                +prefixsum[i,j-1]
                                -prefixsum[i-1,j-1];
            }
        }

        int [][] res = new int [m][];
     

        for (int i=0;i<m;i++)
        {
            res[i] = new int[n];
            for (int j=0;j<n;j++)
            {
                    int r2= Math.Min(m-1,i+k);
                    int c2=Math.Min(n-1,j+k);
                    int r1=Math.Max(0,i-k);
                    int c1=Math.Max(0,j-k);
                    
                    r2++;
                    c2++;
                    r1++;
                    c1++;

                    res[i][j]=prefixsum[r2,c2]
                              -prefixsum[r1-1,c2]
                              -prefixsum[r2,c1-1]
                              +prefixsum[r1-1,c1-1];

            }
        }

        return res;
    }
}