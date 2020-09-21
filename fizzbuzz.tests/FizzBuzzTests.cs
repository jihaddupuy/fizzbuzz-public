using System;
using Xunit;

namespace FizzBuzz.Tests
{
	public class FizzBuzzTests
	{
		[Fact]
		public void Get_Returns_1_for_1()
		{
			var fizzBuzz = new FizzBuzz();

			var result = fizzBuzz.Get(1);

			Assert.Equal("1", result);
		}
		[Fact]
		public void Get_Returns_2_for_2()
		{
			var fizzBuzz = new FizzBuzz();

			var result = fizzBuzz.Get(2);

			Assert.Equal("2", result);
		}
		[Fact]
		public void Get_Returns_Fizz_for_3()
		{
			var fizzBuzz = new FizzBuzz();

			var result = fizzBuzz.Get(3);

			Assert.Equal("Fizz", result);
		}
		[Fact]
		public void Get_Returns_Fizz_for_6()
		{
			var fizzBuzz = new FizzBuzz();

			var result = fizzBuzz.Get(6);

			Assert.Equal("Fizz", result);
		}
		[Fact]                                  //It's a good practice to use blank lines to separate the three phases of each test.
		public void Get_Returns_Buzz_for_5()
		{
			var fizzBuzz = new FizzBuzz(); //arrange - get ready.

			var result = fizzBuzz.Get(5); //act - do the thing you're testing

			Assert.Equal("Buzz", result); // assert - make sure it worked.
		}
		[Fact]
		public void Get_Returns_Buzz_for_10()
		{
			var fizzBuzz = new FizzBuzz();

			var result = fizzBuzz.Get(10);

			Assert.Equal("Buzz", result);

		}
		
		
	}
}
