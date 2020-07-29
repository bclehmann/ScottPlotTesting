using ScottPlot;
using System;
using System.Diagnostics;
using System.Linq;

namespace ScottPlotTesting
{
	class Program
	{
		static void Main(string[] args)
		{
			//double[] xs = { 1, 2, 3, 4, 5, 6, 7 };
			//double[] ys = { 2, 2, 3, 3, 3.8, 4.2, 4 };

			//ScottPlot.Statistics.LinearRegressionLine model = new ScottPlot.Statistics.LinearRegressionLine(xs, ys);

			//Console.WriteLine(model.slope);
			//Console.WriteLine(model.offset);

			//Console.WriteLine(model.GetValueAt(3));
			//for (int i = 0; i < xs.Length; i++)
			//{
			//	Console.WriteLine(model.GetValues()[i]);
			//	Console.WriteLine(model.GetResiduals()[i]);
			//}


			//Console.Read();

			Console.WriteLine("Hello World!");

			int count = 400;
			double step = 0.01;

			double[] dataR = new double[count];
			double[] dataTheta = new double[count];
			double[] dataX = new double[count];
			double[] dataY = new double[count];

			for (int i = 0; i < dataR.Length; i++)
			{
				dataR[i] = 1 + (double)i * step;
				dataTheta[i] = i * 2 * Math.PI * step;
			}
			var plt = new ScottPlot.Plot(600, 400);

			(dataX, dataY) = ScottPlot.Tools.ConvertPolarCoordinates(dataR, dataTheta);

			plt.PlotScatter(dataX, dataY);
			string filename = "qucikstart.png";
			plt.SaveFig(filename);

			using (Process process = new Process())
			{//So the photo opens automatically (you need to use xdg-open on Linux)
				process.StartInfo.FileName = filename;
				process.StartInfo.UseShellExecute = true;
				process.Start();
			}
		}
	}
}
