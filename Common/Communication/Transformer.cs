using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Common.Communication
{
	public class Transformer
	{
		public static T TransformisiJson<T>(object json)
		{
			JsonElement jsonArgument = (JsonElement)json;
			string jsonString = jsonArgument.GetRawText();
			return JsonSerializer.Deserialize<T>(jsonString);
		}
	}
}
