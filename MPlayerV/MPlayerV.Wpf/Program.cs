using System;
using Eto.Forms;

namespace MPlayerV.Wpf
{
	class MainClass
	{
		[STAThread]
		public static void Main(string[] args)
		{
			var platform = new Eto.Wpf.Platform();
			platform.Add<Eto.Gl.GLSurface.IHandler>(() => new Eto.Gl.WPF.WPFWFGLSurfaceHandler());

			new Application(platform).Run(new MainForm());
		}
	}
}
