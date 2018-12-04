﻿using System;
using System.Collections.Generic;

namespace adventofcode2018
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = new Dictionary<int, Action>
            {
                {1, () => Day01.Solution() },
                {2, () => Day02.Solution() },
                {3, () => Day03.Solution() },
                {4, () => Day04.Solution() },
            };

            days[Int32.Parse(args[0])]();
        }
    }
}
