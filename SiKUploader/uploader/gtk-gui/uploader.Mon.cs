
// This file has been generated by the GUI designer. Do not modify.
namespace uploader
{
	public partial class Mon
	{
		private global::Gtk.VBox vbox1;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.TextView text_Monitor;
		private global::Gtk.Statusbar status_Monitor;
		private global::Gtk.CheckButton check_Autoscroll;
		private global::Gtk.Button button_Clear;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget uploader.Mon
			this.Name = "uploader.Mon";
			this.Title = global::Mono.Unix.Catalog.GetString ("SiK Serial Monitor");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child uploader.Mon.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.text_Monitor = new global::Gtk.TextView ();
			this.text_Monitor.CanFocus = true;
			this.text_Monitor.Name = "text_Monitor";
			this.text_Monitor.Editable = false;
			this.text_Monitor.CursorVisible = false;
			this.scrolledwindow1.Add (this.text_Monitor);
			this.vbox1.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.scrolledwindow1]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.status_Monitor = new global::Gtk.Statusbar ();
			this.status_Monitor.Name = "status_Monitor";
			this.status_Monitor.Spacing = 6;
			// Container child status_Monitor.Gtk.Box+BoxChild
			this.check_Autoscroll = new global::Gtk.CheckButton ();
			this.check_Autoscroll.Name = "check_Autoscroll";
			this.check_Autoscroll.Label = global::Mono.Unix.Catalog.GetString ("autoscroll");
			this.check_Autoscroll.Active = true;
			this.check_Autoscroll.DrawIndicator = true;
			this.check_Autoscroll.UseUnderline = true;
			this.check_Autoscroll.FocusOnClick = false;
			this.status_Monitor.Add (this.check_Autoscroll);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.status_Monitor [this.check_Autoscroll]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Padding = ((uint)(2));
			// Container child status_Monitor.Gtk.Box+BoxChild
			this.button_Clear = new global::Gtk.Button ();
			this.button_Clear.Name = "button_Clear";
			this.button_Clear.UseUnderline = true;
			this.button_Clear.Label = global::Mono.Unix.Catalog.GetString (" Clear ");
			this.status_Monitor.Add (this.button_Clear);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.status_Monitor [this.button_Clear]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add (this.status_Monitor);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.status_Monitor]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 570;
			this.DefaultHeight = 252;
			this.Show ();
		}
	}
}
