
// public class Solution {
//     public double MyPow(double x, int n) {
//         long exp = n;

//         if (exp < 0) {
//             x = 1.0 / x;
//            // exp = -exp;
//         }

//         double ans=1.0;

//         while (exp>0)
//         {
//             if(exp%2!=0)
//             {
//                 ans*=x;
//             }
//             x*=x;
//             exp/=2;

//         }
//         return ans;
//     }

   
// }


// below need to check and correct



public class Solution {
    public double MyPow(double x, int n) {
        long exponent = n;

        if (exponent < 0) {
            return 1.0 / Power(x, -exponent);
        }

        return Power(x, exponent);
    }

    private double Power(double x, long n) {
        if (n == 0) {
            return 1.0;
        }

        double half = Power(x, n / 2);

        if (n % 2 == 0) {
            return half * half;
        }

        return half * half * x;
    }
}



