using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tomatodo.tomatoIF
{
	public class TodoItem
	{
		public TCatagory Catagory;
		public string Detail;
		public TUser FromUser;
		public TUser ToUser;
		public DateTime DeadDate;
		public bool IsDoneMemoRequired;
	}
}
