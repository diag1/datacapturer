using System;
using System.IO;
using System.Collections.Generic;

namespace datacapturer
{
	public class Functions:Fachada
	{
		

		public double setAverageSpeed (double distance, double time)
		{
			return (distance/time);
		}


	}
}

