﻿using System;
using System.Collections.Generic;

namespace Dominion
{
    public static class Extensions
    {
        private static Random rng = new Random();
        /// <summary>
        /// Shuffles a generic list
        /// </summary>
        /// <param name="list">The generic list</param>
        /// <remarks>Code provided by Rob Thijssen (stack overflow)</remarks>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}