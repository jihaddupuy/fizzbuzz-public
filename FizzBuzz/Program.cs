﻿using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz!");
        }
    }
	public class FizzBuzz
	{
		public string Get(int num)
		{
			if (IsMultipleOf3(num))
			{
				return "Fizz";
            }
            
			if (IsMultipleOf5(num))
			{
					return "Buzz";
			}
			return num.ToString();
		}

		private bool IsMultipleOf3(int numberToCheck)
		{
			return numberToCheck % 3 == 0;
		}
	
		private bool IsMultipleOf5(int numberToCheck)
		{
		return numberToCheck % 5 == 0;
		}
	}
}
