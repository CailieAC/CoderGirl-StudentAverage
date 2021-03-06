﻿using System;

namespace StudentAverage
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }
        
        public int? GetAverage()
        {
            int average = 0;
            int count = 0;
            int total = 0;

            foreach (int score in Scores)
            {
                total += score;
                count++;
            }
            average = (int)Math.Round((double)total / (double)count);
            return average;

        }
    }
}