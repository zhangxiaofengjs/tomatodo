using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tomatodo.tomatoIF
{
	public class TUser
	{
		public int Id { get; set; }
		public string No { get; set; }
		public string Name { get; set; }

		public TUser()
		{
		}
		public TUser(int id, string name)
		{
			this.Id = id; 
			this.Name = name;
		}
	}
}
