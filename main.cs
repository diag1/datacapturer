using System;
using Gtk;

namespace datacapturer
{
	public class main
	{
		public static void Main (string[] args)
		{
			Gtk.Application.Init ();
			var wMain = new MainWindow ();
			wMain.Show ();
			Gtk.Application.Run ();
		}
	}
}
