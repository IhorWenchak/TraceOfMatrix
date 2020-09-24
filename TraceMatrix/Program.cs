using System;

namespace Matrix
{
	public class Program
	{
		static int colCount = 0;
		static int rowCount = 0;

		static void Main(string[] args)
		{
			Console.Write("Enter the number of lines: ");
			string row = Console.ReadLine();
			
			Console.Write("Enter the number of colums: ");
			string col = Console.ReadLine();

			if (!IsCorrectlyOnly(row, col))
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("You have set an incorrect number of lines or number of colums.");
				Console.ResetColor();
				Console.ReadKey();
				System.Environment.Exit(0);
			}

			MatrixTrace matrixTrace = new MatrixTrace(rowCount, colCount);

			Console.WriteLine();
			Console.WriteLine("Matrix:	");
			Console.WriteLine();
			matrixTrace.Print(); 
			Console.WriteLine();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Matrix Trace:	");
			Console.WriteLine();
			Console.WriteLine(matrixTrace.Sum);
			Console.ReadLine();
		}

		public static bool IsCorrectlyOnly(string row, string col)
		{
			if (String.IsNullOrEmpty(row) || String.IsNullOrEmpty(col))
				return false;

			if ((!int.TryParse(row, out rowCount)) || (!int.TryParse(col, out colCount)))
				return false;

			if ((rowCount <= 0) || (colCount <= 0))
				return false;

			return true;
		}
	}
}
