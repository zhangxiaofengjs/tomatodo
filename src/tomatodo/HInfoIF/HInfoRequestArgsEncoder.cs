using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tomatodo.tomatoIF;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;

namespace HInfoIF
{
	class HInfoRequestArgsEncoder
	{
		public static string EncodeTodoItemJSON(TodoItem[] items)
		{
			StringWriter sw = new StringWriter();
			JsonTextWriter jwt = new JsonTextWriter(sw);

			jwt.WriteStartArray();

			JArray jarray = new JArray();
			foreach (TodoItem item in items)
			{
				jwt.WriteStartObject();

				jwt.WritePropertyName("catagory");
				jwt.WriteStartObject();
				jwt.WritePropertyName("id");
				jwt.WriteValue(item.Catagory.Id);
				jwt.WriteEndObject();

				jwt.WritePropertyName("from_user");
				jwt.WriteStartObject();
				jwt.WritePropertyName("id");
				jwt.WriteValue(item.FromUser.Id);
				jwt.WriteEndObject();

				jwt.WritePropertyName("to_user");
				jwt.WriteStartObject();
				jwt.WritePropertyName("id");
				jwt.WriteValue(item.ToUser.Id);
				jwt.WriteEndObject();

				jwt.WritePropertyName("detail");
				jwt.WriteValue(item.Detail);

				jwt.WritePropertyName("dead_time");
				jwt.WriteValue(item.DeadDate.ToString("yyyy-MM-dd HH:mm:ss"));

				jwt.WritePropertyName("is_done_memo_required");
				jwt.WriteValue(item.IsDoneMemoRequired);

				jwt.WriteEndObject();
			}

			jwt.WriteEndArray();

			return sw.GetStringBuilder().ToString();
		}
	}
}
