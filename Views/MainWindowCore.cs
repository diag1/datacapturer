using System;

namespace datacapturer
{
	public partial class MainWindow
	{
		private void OnClose(){
			Gtk.Application.Quit ();
		}
	}
}

