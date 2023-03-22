﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv07
{
    public class Extremes
    {
        public static T Largest<T>(T[] values) where T : IComparable
        {
            T max = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }
            return max;
        }

        public static T Smallest<T>(T[] values) where T : IComparable
        {
            T min = values[0];
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].CompareTo(min) < 0) 
                { 
                    min = values[i]; 
                }
            }
            return min;
        }
    }
}
