using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tomatodo.tomatoIF
{
	public interface ITomatoDataSource
	{
		TUser Login(string no, string pwd);
		bool Insert(TodoItem[] items);
		TCatagory[] GetCatagories(int userId);
		TUser[] GetUsers();
	}
}
