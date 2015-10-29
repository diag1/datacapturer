using System;
using Newtonsoft.Json;

namespace datacapturer
{
	public class Writer
	{
		public Writer (Session session)
		{
			string json = JsonConvert.SerializeObject(session, Formatting.Indented);
		
		}

	}
}

