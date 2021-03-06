﻿using System;
using Gtk;
namespace datacapturer{

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		build ();
	}
	private void build(){
		SetDefaultSize(250, 200);
		vBoxMain = new Gtk.VBox (false, 5);
		//widgets
		this.lb1 = new Gtk.Label("Put your records");
		//vBox
		vBoxMain.PackStart(this.lb1,true,false,5);
		this.DeleteEvent += (o, args) => this.OnClose() ;

		var a =  new Gtk.VBox (false, 5);
		this.vBoxMain.Visible = true;
		a.PackStart (vBoxMain);

		this.Add (a);
		a.ShowAll ();
		//events
		this.DeleteEvent += (o, args) => this.OnClose() ;
	}

	private Gtk.Label lb1;
	private Gtk.VBox vBoxMain;


	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}

}