﻿using System;

namespace _011PolePowierzchni70
{
	public class PolePowierzchni
	{
		public PolePowierzchni(double metrKwadratowy) => MetrKwadratowy = metrKwadratowy;

		public double MetrKwadratowy { get; set; }
		public double Ar {
			set => MetrKwadratowy = 100 * value;
			get => MetrKwadratowy / 100;
		}
		public double Hektar {
			set => MetrKwadratowy = 10000 * value;
			get => MetrKwadratowy / 10000;
		}
	}
	class Pole
	{
		static void Main(string[] args)
		{
			PolePowierzchni p1 = new PolePowierzchni(1000);
			Console.WriteLine($"Ar = {p1.Ar}, Hektar = {p1.Hektar}, M2 = {p1.MetrKwadratowy}");
			p1.Ar = 7;
			Console.WriteLine($"Ar = {p1.Ar}, Hektar = {p1.Hektar}, M2 = {p1.MetrKwadratowy}");
			Console.ReadKey();
		}
	}
}
