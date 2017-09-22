using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tomatodo.tomatoIF
{
	public class TIFMgr
	{
		public static TUser LoginUser = null;
		public static ITomatoDataSource DataSource = null;

		public static bool Login(string no, string pwd)
		{
			LoginUser = DataSource.Login(no, pwd);

			return LoginUser != null;
		}
	}
}
