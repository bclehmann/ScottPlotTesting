using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ScottPlot.Avalonia;

namespace AvaloniaTesting
{
	public class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
#if DEBUG
			this.AttachDevTools();
#endif
		}

		private void InitializeComponent()
		{
			AvaloniaXamlLoader.Load(this);

			this.Find<AvaPlot>("avaplot").plt.PlotScatter(new double[] { 1, 2, 3 }, new double[] { 1, 2, 1 });
			this.Find<AvaPlot>("avaplot").Render();
		}
	}
}
