using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace salvi.matteo._4h.GUIDb;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
