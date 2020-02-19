using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public class PrimeNumber
    {

        private static int[] prime = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
        public static int GetPrime(int num)
        {

            return prime [num-1];
            //for (int i=0; i<prime.Length; i++)
            //{
            //    if (num == prime[i])
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }
    }
}
