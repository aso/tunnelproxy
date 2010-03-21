using System;
using System.Threading;
using System.Windows.Forms;

namespace TunnelProxy.Client.App
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Configuration());
		}	
	}
}
