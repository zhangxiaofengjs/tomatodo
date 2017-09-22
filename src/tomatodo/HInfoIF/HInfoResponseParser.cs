using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tomatodo.tomatoIF;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;

namespace HInfoIF
{
	class HInfoResponseParser
	{
		private static JObject ParseResponse(string resStr)
		{
			try
			{
				JObject jObj = JObject.Parse(resStr);
				if (jObj == null)
					return null;

				bool success = jObj["success"].Value<bool>();
				if (!success)
					return null;

				return jObj;
			}
			catch
			{
				return null;
			}
		}

		internal static bool ParseNormalResponse(string resStr)
		{
			JObject jObj = ParseResponse(resStr);
			if (jObj == null)
				return false;

			return true;
		}

		public static TUser ParseLoginResponse(string resStr)
		{
			JObject jObj = ParseResponse(resStr);
			if( jObj == null)
				return null;

			TUser user = new TUser();

			JObject userObj = jObj["user"].Value<JObject>();
			user.Id = userObj["id"].Value<int>();
			user.No = userObj["no"].Value<string>();
			user.Name = userObj["name"].Value<string>();

			return user;
		}

		internal static TCatagory[] ParseCatagoryListResponse(string resStr)
		{
			JObject jObj = ParseResponse(resStr);
			if (jObj == null)
				return null;

			JArray listObj = jObj["catagories"].Value<JArray>();

			TCatagory[] list = new TCatagory[listObj.Count];
			for (int i = 0; i < listObj.Count; i++)
			{
				JObject jC = listObj[i].Value<JObject>();
				
				TCatagory c = new TCatagory();
				c.Id = jC["id"].Value<int>();
				c.Name = jC["catagory"].Value<string>();

				list[i] = c;
			}
			return list;
		}

		internal static TUser[] ParseUserListResponse(string resStr)
		{
			JObject jObj = ParseResponse(resStr);
			if (jObj == null)
				return null;

			JArray listObj = jObj["users"].Value<JArray>();

			TUser[] list = new TUser[listObj.Count];
			for (int i = 0; i < listObj.Count; i++)
			{
				JObject jU = listObj[i].Value<JObject>();

				TUser u = new TUser();
				u.Id = jU["id"].Value<int>();
				u.No = jU["no"].Value<string>();
				u.Name = jU["name"].Value<string>();

				list[i] = u;
			}
			return list;
		}
	}
}
