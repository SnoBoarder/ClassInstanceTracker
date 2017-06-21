using System;
using System.Windows.Forms;

namespace ClassInstanceTracker
{
	/// <summary>
	/// Level Up Code Challenge By Brian Tran [06/21/2017]
	/// </summary>
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
