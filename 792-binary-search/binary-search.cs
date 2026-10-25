// public class Solution {
//     public int Search(int[] nums, int target) {

//         int l=0;
//         int r=nums.Length-1;

//         while(l<=r)
//         {
//             int mid=l+(r-l/2);

//             if (nums[mid]==target)
//             {
//                 return mid;
//             }
//             else if(nums[mid]<target)
//             {
//                 l=mid+1;
//             }
//             else
//             {
//                 r=mid-1;
//             }
//         }
//         return -1;
        
//     }
// }



// below is recursive 

public class Solution {
    public int Search(int[] nums, int target) {


        return binarysearch(nums,0,nums.Length-1,target);     
    }

    private int binarysearch(int [] nums,int l , int r ,int target )
    {
        int mid=l+(r-l/2);

        if (l>r)
        {
            return -1;
        }

        if (nums[mid]==target)
        {
            return mid;
        }
        if(nums[mid]<target)
        {
            return binarysearch(nums,mid+1,r,target);
        }

        return binarysearch(nums,l,mid-1,target);
    }


}
