using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using tomatodo.tomatoIF;
using HInfoIF;

namespace THInfo
{
	public class HInfoDataSource : ITomatoDataSource
	{
		public TUser Login(string no, string pwd)
		{
			TUser user1 = HInfoRequest.Login(no, pwd);
			return user1;
		}

		public bool Insert(TodoItem[] items)
		{
			return HInfoRequest.InsertTodoItems(items);
		}

		public TCatagory[] GetCatagories(int userId)
		{
			TCatagory[] list = HInfoRequest.GetCatagories(userId);
			return list;
		}

		public TUser[] GetUsers()
		{
			TUser[] list = HInfoRequest.GetUsers();
			return list;
		}
	}
}
