using System;

namespace datacapturer
{
	public interface Fachada
	{	
		// declare init time in epochlinux format

		double setAverageSpeed (double distance, double time); // distance in meters, time in seconds

	}
}

