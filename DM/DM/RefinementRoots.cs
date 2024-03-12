using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM
{
	public delegate double Function(double x);
	static class RefinementRoots
	{
		public static double HalfDivisionMethod(double inaccuracy, double left, double right, Function func) // погрешность, левая и правая границы
		{
			double fX, fA, x;
			x = (left + right) / 2;
			while (Math.Abs(right - left) > inaccuracy)
			{
				fX = func(x);
				fA = func(left);

				if (fA * fX > 0) left = x;
				else right = x;
				x = (left + right) / 2;
			}
			return (left + right) / 2;
		}
		public static double ChordMethod(double inaccuracy, double left, double right, Function func)
		{
			double fX, fA, fB, x, xL; // x - xt, xL - x(t-1)
			fA = func(left);
			fB = func(right);
			x = (-right * fA + left * fB) / (fB - fA);
			fX = func(x);
			if (fA * fX > 0) left = x; else right = x;
			do
			{
				xL = x;
				fA = func(left);
				fB = func(right);
				x = (-right * fA + left * fB) / (fB - fA);
				fX = func(xL);
				if (fA * fX > 0) left = x;
				else right = x;
			}
			while (Math.Abs(x - xL) > inaccuracy);
			return x;
		}
		static double GetFirstDerivative(Function func, float h, double x)
		{
			return (func(x + h) - func(x)) / h;
		}
		static double GetSecondDerivative(Function func, float h, double x)
		{
			return (func(x + h) - 2 * func(x) + func(x - h)) / Math.Pow(h, 2);
		}
		public static double TangentMethod(double inaccuracy, double left, double right, Function func, float h)
		{
			double x, xL, df, ddf; // x - xt, xL - x(t-1)
			ddf = GetSecondDerivative(func, h, left);
			double dA = func(left);
			x = ddf * dA > 0 ? left : right;
			do
			{
				xL = x;
				df = GetFirstDerivative(func, h, xL);
				x = xL - (func(xL) / df);
			} while (Math.Abs(x - xL) > inaccuracy);
			return x;
		}
		public static double CombinedMethod(double inaccuracy, double left, double right, Function func, float h)
		{
			double fA, fB, df, ddf, a, b; // x - xt, xL - x(t-1), a-at, b - bt, left-a(t-1), right - b(t-1)
			bool mode;
			ddf = GetSecondDerivative(func, h, left);
			df = GetFirstDerivative(func, h, left);
			fA = func(left);
			fB = func(right);
			mode = ddf * fA > 0 ? true : false;
			a = left; b = right;
			do
			{
				left = a; right = b;
				fA = func(left);
				fB = func(right);
				if (mode)
				{
					a = left - (func(left) / GetFirstDerivative(func, h, left));
					b = (-right * fA + left * fB) / (fB - fA);
				}
				else
				{
					b = right - (func(right) / GetFirstDerivative(func, h, right));
					a = (-right * fA + left * fB) / (fB - fA);
				}
			} while (b - a > inaccuracy);
			return (a + b) / 2;
		}
	}
}
