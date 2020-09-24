﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Matrix
{
	public class MatrixTrace
	{
		private double[,] matrix ;
		private readonly int n;
		private readonly int m;
		private double minValue = 0;
		private double maxValue = 100.0001;
		private double sum;


		public MatrixTrace(int n, int m)
		{
			this.n = n;
			this.m = m;
			this.matrix = new double[n,m];

			Random random = new Random();
			
			for (int i = 0; i < n; i++)	
			{
				for (int j = 0; j < m; j++)
				{
					this.matrix[i, j] = random.NextDouble() * (maxValue - minValue) + minValue;
					if (this.matrix[i, j] > 100)
						this.matrix[i, j] -= 100;
				}
			}

		}

		public void Print()
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					if (i == j)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(" {0} ", matrix[i, j]);
						Sum += matrix[i, j];
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.White;
						Console.Write(" {0} ", matrix[i, j]);
					}
				}
				Console.WriteLine();
			}
		}

		public double Sum {
			get {
				return sum;
			}
			set {
				this.sum = value;
			}
		}
		public double[,] Matrix {
			get {
				return matrix;
			}
			set {
				this.matrix = value;
			}
		}
	}
}
