using Matrix;
using System;
using Xunit;

namespace XUnitTestMatrix
{
	public class UnitTest1
	{
		[Fact]
		public void TestCorrectly1()
		{
			bool result = Program.IsCorrectlyOnly("10", null);

			bool expected = false;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestCorrectly2()
		{
			bool result = Program.IsCorrectlyOnly("10", "X");

			bool expected = false;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestCorrectly3()
		{
			bool result = Program.IsCorrectlyOnly("10", "12.1");

			bool expected = false;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void TestCorrectly4()
		{
			bool result = Program.IsCorrectlyOnly("10", "0");

			bool expected = false;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void Test_MatrixTrace_Random()
		{
			MatrixTrace mt = new MatrixTrace(10, 10);

			double[,] matrix = mt.Matrix;

			bool expected = true;

			bool result = true;

			for (int i = 0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					if ((matrix[i, j] < 0) || (matrix[i, j] > 100))
						result = false;
				}
			}

			Assert.Equal(expected, result);
		}

		[Fact]
		public void Test_MatrixTrace_Sum()

		{

			MatrixTrace mt = new MatrixTrace(2, 2);

			double expected = mt.Matrix[0, 0] + mt.Matrix[1, 1];

			mt.Print();

			double result = mt.Sum;

			Assert.Equal(expected, result);
		}

		[Fact]
		public void Test_MatrixTrace_Sum1()

		{
			MatrixTrace trace = new MatrixTrace(3, 3);

			trace.Matrix = new double[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } };

			double expected = 12;

			trace.Print();

			double result = trace.Sum;

			Assert.Equal(expected, result);
		}
	}
}
