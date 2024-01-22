using System;

namespace Messing
{
    class Helpers
    {
        public int[] Messing(int[] arr, int a, int b)
        {
            int diff = a - b;
            int[] list = {};

            for(int i = a; i < b; i++)
            {
                for(int j = 0; j <= diff; j++)
                {
                    list[j] = arr[i];
                }
            }

            return list;
        }
    }
}