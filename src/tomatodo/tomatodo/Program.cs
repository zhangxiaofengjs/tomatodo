using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace tomatodo
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		[STAThread]
		static void Main()
		{
			//メイン１
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormMiniIn());
			//Application.Run(new FormMain());
		}
	}
}
