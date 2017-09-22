using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using tomatodo.tomatoIF;
using Newtonsoft.Json.Linq;

namespace HInfoIF
{
	class HInfoRequest
	{
		private const string HANDLE_LOGIN = "login";
		private const string HANDLE_RELATED_CATAGORY_LIST = "relatedcatagorylist";
		private const string HANDLE_USER_LIST = "userlist";
		private const string HANDLE_ADD_TODOITEMS = "addtodoitems";
		
		private static string doRequest(UrlArgs args)
		{
			WebRequest req = HttpWebRequest.Create("http://localhost:81/hinfo/handle.php");
			req.Method = "POST";
			req.ContentType = "application/x-www-form-urlencoded;charset=utf-8";
			req.ContentLength = args.Length;

			Stream stream = req.GetRequestStream();
			stream.Write(args.Buffer, 0, args.Length);

			HttpWebResponse webResponse = (HttpWebResponse)req.GetResponse();
			Stream reader = webResponse.GetResponseStream();
			StreamReader respStreamReader = new StreamReader(reader, Encoding.UTF8);

			string resStr = respStreamReader.ReadToEnd();

			return resStr;
		}

		internal static TUser Login(string no, string pwd)
		{
			UrlArgs args = new UrlArgs(HANDLE_LOGIN);
			args.Append("no", no);
			args.Append("password", pwd);
			return HInfoResponseParser.ParseLoginResponse(doRequest(args));
		}

		internal static TCatagory[] GetCatagories(int userId)
		{
			UrlArgs args = new UrlArgs(HANDLE_RELATED_CATAGORY_LIST);
			args.Append("user_id", userId);
			return HInfoResponseParser.ParseCatagoryListResponse(doRequest(args));
		}

		internal static TUser[] GetUsers()
		{
			UrlArgs args = new UrlArgs(HANDLE_USER_LIST);
			return HInfoResponseParser.ParseUserListResponse(doRequest(args));
		}

		internal static bool InsertTodoItems(TodoItem[] items)
		{
			UrlArgs args = new UrlArgs(HANDLE_ADD_TODOITEMS);
			args.Append("list", HInfoRequestArgsEncoder.EncodeTodoItemJSON(items));
			return HInfoResponseParser.ParseNormalResponse(doRequest(args));
		}
	}
}
