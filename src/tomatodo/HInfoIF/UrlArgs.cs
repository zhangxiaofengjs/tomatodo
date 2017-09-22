using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HInfoIF
{
	class UrlArgs
	{
		private StringBuilder _args = new StringBuilder();
		private byte[] _buff = null;
		
		public int Length
		{
			get
			{

				return Buffer.Length;
			}
		}

		public byte[] Buffer
		{
			get
			{
				if (_buff == null)
					_buff = Encoding.UTF8.GetBytes(_args.ToString());

				return _buff;
			}
		}

		public UrlArgs(string handle)
		{
			Append("handle", handle);
		}

		public void Append(string key, string value)
		{
			if (_args.Length != 0)
			{
				_args.Append("&");
			}
			_args.AppendFormat("&{0}={1}", key, value);

			_buff = null;
		}

		internal void Append(string key, int value)
		{
			Append(key, value.ToString());
		}
	}
}
