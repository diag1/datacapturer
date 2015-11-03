using System;
using Newtonsoft.Json;

namespace datacapturer
{
	public class Writer
	{
		public Writer (Session session)
		{
			string json = JsonConvert.SerializeObject(session, Formatting.Indented);
			System.IO.File.WriteAllText (@"..\professionalTrainerRecords.json", json); // trying to save data to a file.
		}
	}
}

