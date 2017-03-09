using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums=new int[]{1,2,3,4,5,6,7};
            int k=15;
            
            Solution solu=new Solution();
            solu.Rotate(nums, k);
            foreach(var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
    
    
    public class Solution {
        public void Rotate(int[] nums, int k) {
            //make k<nums.Length
            if(k>nums.Length)
            {
                while(k-nums.Length>=0)
                {
                    k=k-nums.Length;
                }
            }
            
            if(k==0)
            {
                
            }else
            {
                int[] temp=new int[k];
                
                //move to a temp array
                for(var i=temp.Length-1;i>=0;i--)
                {
                    temp[i]=nums[nums.Length-k+i];
                }
                //push to the end
                for(var j=nums.Length-k-1;j>=0;j--)
                {
                    nums[j+k]=nums[j];
                }
                //put the ones in temp array back to the top
                for(var s=0;s<temp.Length;s++)
                {
                    nums[s]=temp[s];
                }
            }
        }
    }
}
