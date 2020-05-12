
// This file has been generated by the GUI designer. Do not modify.
namespace DiveIn.Properties
{
	public partial class CreateCompetition
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Entry CompNameEntry;

		private global::Gtk.Entry LocationEntry;

		private global::Gtk.Calendar calendar1;

		private global::Gtk.Button CreateComp;

		private global::Gtk.HSeparator hseparator2;

		protected virtual void Build()
		{
            global::Stetic.Gui.Initialize(this);
			// Widget DiveIn.Properties.CreateCompetition
			this.Name = "DiveIn.Properties.CreateCompetition";
			this.Title = global::Mono.Unix.Catalog.GetString("CreateCompetition");
			this.Icon = global::Stetic.IconLoader.LoadIcon(this, "gtk-color-picker", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child DiveIn.Properties.CreateCompetition.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.CompNameEntry = new global::Gtk.Entry();
			this.CompNameEntry.CanFocus = true;
			this.CompNameEntry.Name = "CompNameEntry";
			this.CompNameEntry.Text = global::Mono.Unix.Catalog.GetString("Competition name...");
			this.CompNameEntry.IsEditable = true;
			this.CompNameEntry.InvisibleChar = '●';
			this.vbox2.Add(this.CompNameEntry);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.CompNameEntry]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.LocationEntry = new global::Gtk.Entry();
			this.LocationEntry.CanFocus = true;
			this.LocationEntry.Name = "LocationEntry";
			this.LocationEntry.Text = global::Mono.Unix.Catalog.GetString("Location...");
			this.LocationEntry.IsEditable = true;
			this.LocationEntry.InvisibleChar = '●';
			this.vbox2.Add(this.LocationEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.LocationEntry]));
			w2.Position = 1;
			w2.Padding = ((uint)(15));
			// Container child vbox2.Gtk.Box+BoxChild
			this.calendar1 = new global::Gtk.Calendar();
			this.calendar1.WidthRequest = 100;
			this.calendar1.CanFocus = true;
			this.calendar1.Name = "calendar1";
			this.calendar1.DisplayOptions = ((global::Gtk.CalendarDisplayOptions)(35));
			this.vbox2.Add(this.calendar1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.calendar1]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.CreateComp = new global::Gtk.Button();
			this.CreateComp.CanFocus = true;
			this.CreateComp.Name = "CreateComp";
			this.CreateComp.UseUnderline = true;
			this.CreateComp.Label = global::Mono.Unix.Catalog.GetString("Create competition");
			this.vbox1.Add(this.CreateComp);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.CreateComp]));
			w5.Position = 1;
			w5.Padding = ((uint)(8));
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator2 = new global::Gtk.HSeparator();
			this.hseparator2.Name = "hseparator2";
			this.vbox1.Add(this.hseparator2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator2]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 524;
			this.DefaultHeight = 348;
			this.Show();
			this.CreateComp.Clicked += new global::System.EventHandler(this.OnCreateCompetitionClicked);
		}
	}
}
