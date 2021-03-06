﻿using System;

namespace Arrays {
    class Program {
        static void Main(string[] args) {
            var randomnumbers = new int[5]; //define variable 'randomnumbers'. set equal to 5 integers. 
            randomnumbers[0] = 123;
            randomnumbers[1] = 456;
            randomnumbers[2] = 789;
            randomnumbers[3] = 1;
            randomnumbers[0] = 0; //if value of integer isn't assigned it will equate to 0 in array.

            var sum = randomnumbers[0] + randomnumbers[1] + randomnumbers[2];
            //Console.WriteLine(sum);

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int total = 0;
            foreach (var num in numbers) {
                if ((num % 3 == 0) || (num % 5 == 0)) {continue;} //if statement + {continue;} -- excludes num if divisible by 3 or 5
                    total += num * 3;
                }
            Console.WriteLine(total);

            //Break; stops a loop when a condition is met
            
        }
    }
}
