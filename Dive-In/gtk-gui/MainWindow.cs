
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox1;

	private global::Gtk.VBox vbox1;

	private global::Gtk.Frame frame3;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.ScrolledWindow GtkScrolledWindow1;

	private global::Gtk.TextView textviewCurrentDiver;

	private global::Gtk.Label GtkLabel;

	private global::Gtk.Frame frame4;

	private global::Gtk.Alignment GtkAlignment1;

	private global::Gtk.Table table1;

	private global::Gtk.Button button8;

	private global::Gtk.Button judge1;

	private global::Gtk.Button Judge2;

	private global::Gtk.Button Judge3;

	private global::Gtk.Button Judge4;

	private global::Gtk.Button Judge5;

	private global::Gtk.Button judge6;

	private global::Gtk.Button Judge7;

	private global::Gtk.Button nextDiver;

	private global::Gtk.Label GtkLabel10;

	private global::Gtk.Frame frame5;

	private global::Gtk.Alignment GtkAlignment2;

	private global::Gtk.VBox vbox3;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView textviewLeaderboard;

	private global::Gtk.Button button10;

	private global::Gtk.Label GtkLabel12;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.Icon = global::Stetic.IconLoader.LoadIcon(this, "gtk-color-picker", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(3));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame3 = new global::Gtk.Frame();
		this.frame3.Name = "frame3";
		this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame3.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.textviewCurrentDiver = new global::Gtk.TextView();
		this.textviewCurrentDiver.CanFocus = true;
		this.textviewCurrentDiver.Name = "textviewCurrentDiver";
		this.GtkScrolledWindow1.Add(this.textviewCurrentDiver);
		this.GtkAlignment.Add(this.GtkScrolledWindow1);
		this.frame3.Add(this.GtkAlignment);
		this.GtkLabel = new global::Gtk.Label();
		this.GtkLabel.WidthRequest = 250;
		this.GtkLabel.Name = "GtkLabel";
		this.GtkLabel.Xalign = 0F;
		this.GtkLabel.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Curret Diver</b>");
		this.GtkLabel.UseMarkup = true;
		this.frame3.LabelWidget = this.GtkLabel;
		this.vbox1.Add(this.frame3);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame3]));
		w4.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame4 = new global::Gtk.Frame();
		this.frame4.Name = "frame4";
		this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame4.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.table1 = new global::Gtk.Table(((uint)(3)), ((uint)(3)), false);
		this.table1.Name = "table1";
		this.table1.RowSpacing = ((uint)(6));
		this.table1.ColumnSpacing = ((uint)(6));
		// Container child table1.Gtk.Table+TableChild
		this.button8 = new global::Gtk.Button();
		this.button8.WidthRequest = 70;
		this.button8.HeightRequest = 70;
		this.button8.Sensitive = false;
		this.button8.CanFocus = true;
		this.button8.Name = "button8";
		this.button8.UseUnderline = true;
		this.table1.Add(this.button8);
		global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.button8]));
		w5.TopAttach = ((uint)(2));
		w5.BottomAttach = ((uint)(3));
		w5.LeftAttach = ((uint)(1));
		w5.RightAttach = ((uint)(2));
		w5.XOptions = ((global::Gtk.AttachOptions)(4));
		w5.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.judge1 = new global::Gtk.Button();
		this.judge1.WidthRequest = 70;
		this.judge1.HeightRequest = 70;
		this.judge1.CanFocus = true;
		this.judge1.Name = "judge1";
		this.judge1.UseUnderline = true;
		this.judge1.Label = global::Mono.Unix.Catalog.GetString("Judge 1");
		this.table1.Add(this.judge1);
		global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.judge1]));
		w6.XOptions = ((global::Gtk.AttachOptions)(4));
		w6.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.Judge2 = new global::Gtk.Button();
		this.Judge2.CanFocus = true;
		this.Judge2.Name = "Judge2";
		this.Judge2.UseUnderline = true;
		this.Judge2.Label = global::Mono.Unix.Catalog.GetString("Judge 2");
		this.table1.Add(this.Judge2);
		global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.Judge2]));
		w7.LeftAttach = ((uint)(1));
		w7.RightAttach = ((uint)(2));
		w7.XOptions = ((global::Gtk.AttachOptions)(4));
		w7.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.Judge3 = new global::Gtk.Button();
		this.Judge3.CanFocus = true;
		this.Judge3.Name = "Judge3";
		this.Judge3.UseUnderline = true;
		this.Judge3.Label = global::Mono.Unix.Catalog.GetString("Judge 3");
		this.table1.Add(this.Judge3);
		global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.Judge3]));
		w8.LeftAttach = ((uint)(2));
		w8.RightAttach = ((uint)(3));
		w8.XOptions = ((global::Gtk.AttachOptions)(4));
		w8.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.Judge4 = new global::Gtk.Button();
		this.Judge4.WidthRequest = 70;
		this.Judge4.HeightRequest = 70;
		this.Judge4.CanFocus = true;
		this.Judge4.Name = "Judge4";
		this.Judge4.UseUnderline = true;
		this.Judge4.Label = global::Mono.Unix.Catalog.GetString("Judge 4");
		this.table1.Add(this.Judge4);
		global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.Judge4]));
		w9.TopAttach = ((uint)(1));
		w9.BottomAttach = ((uint)(2));
		w9.XOptions = ((global::Gtk.AttachOptions)(4));
		w9.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.Judge5 = new global::Gtk.Button();
		this.Judge5.CanFocus = true;
		this.Judge5.Name = "Judge5";
		this.Judge5.UseUnderline = true;
		this.Judge5.Label = global::Mono.Unix.Catalog.GetString("Judge 5");
		this.table1.Add(this.Judge5);
		global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.Judge5]));
		w10.TopAttach = ((uint)(1));
		w10.BottomAttach = ((uint)(2));
		w10.LeftAttach = ((uint)(1));
		w10.RightAttach = ((uint)(2));
		w10.XOptions = ((global::Gtk.AttachOptions)(4));
		w10.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.judge6 = new global::Gtk.Button();
		this.judge6.CanFocus = true;
		this.judge6.Name = "judge6";
		this.judge6.UseUnderline = true;
		this.judge6.Label = global::Mono.Unix.Catalog.GetString("Judge 6");
		this.table1.Add(this.judge6);
		global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.judge6]));
		w11.TopAttach = ((uint)(1));
		w11.BottomAttach = ((uint)(2));
		w11.LeftAttach = ((uint)(2));
		w11.RightAttach = ((uint)(3));
		w11.XOptions = ((global::Gtk.AttachOptions)(4));
		w11.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.Judge7 = new global::Gtk.Button();
		this.Judge7.WidthRequest = 70;
		this.Judge7.HeightRequest = 70;
		this.Judge7.CanFocus = true;
		this.Judge7.Name = "Judge7";
		this.Judge7.UseUnderline = true;
		this.Judge7.Label = global::Mono.Unix.Catalog.GetString("Judge 7");
		this.table1.Add(this.Judge7);
		global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.Judge7]));
		w12.TopAttach = ((uint)(2));
		w12.BottomAttach = ((uint)(3));
		w12.XOptions = ((global::Gtk.AttachOptions)(4));
		w12.YOptions = ((global::Gtk.AttachOptions)(4));
		// Container child table1.Gtk.Table+TableChild
		this.nextDiver = new global::Gtk.Button();
		this.nextDiver.WidthRequest = 70;
		this.nextDiver.HeightRequest = 70;
		this.nextDiver.CanFocus = true;
		this.nextDiver.Name = "nextDiver";
		this.nextDiver.UseUnderline = true;
		this.nextDiver.FocusOnClick = false;
		this.nextDiver.Label = global::Mono.Unix.Catalog.GetString("Next Diver");
		this.table1.Add(this.nextDiver);
		global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.nextDiver]));
		w13.TopAttach = ((uint)(2));
		w13.BottomAttach = ((uint)(3));
		w13.LeftAttach = ((uint)(2));
		w13.RightAttach = ((uint)(3));
		w13.XOptions = ((global::Gtk.AttachOptions)(4));
		w13.YOptions = ((global::Gtk.AttachOptions)(4));
		this.GtkAlignment1.Add(this.table1);
		this.frame4.Add(this.GtkAlignment1);
		this.GtkLabel10 = new global::Gtk.Label();
		this.GtkLabel10.Name = "GtkLabel10";
		this.GtkLabel10.Xalign = 0F;
		this.GtkLabel10.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Judges</b>");
		this.GtkLabel10.UseMarkup = true;
		this.frame4.LabelWidget = this.GtkLabel10;
		this.vbox1.Add(this.frame4);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame4]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		this.hbox1.Add(this.vbox1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.frame5 = new global::Gtk.Frame();
		this.frame5.WidthRequest = 400;
		this.frame5.Name = "frame5";
		this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame5.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.vbox3 = new global::Gtk.VBox();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textviewLeaderboard = new global::Gtk.TextView();
		this.textviewLeaderboard.CanFocus = true;
		this.textviewLeaderboard.Name = "textviewLeaderboard";
		this.GtkScrolledWindow.Add(this.textviewLeaderboard);
		this.vbox3.Add(this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.GtkScrolledWindow]));
		w19.Position = 0;
		// Container child vbox3.Gtk.Box+BoxChild
		this.button10 = new global::Gtk.Button();
		this.button10.WidthRequest = 70;
		this.button10.HeightRequest = 0;
		this.button10.CanFocus = true;
		this.button10.Name = "button10";
		this.button10.UseUnderline = true;
		this.button10.Label = global::Mono.Unix.Catalog.GetString("End Competition");
		this.vbox3.Add(this.button10);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.button10]));
		w20.Position = 1;
		w20.Expand = false;
		w20.Fill = false;
		this.GtkAlignment2.Add(this.vbox3);
		this.frame5.Add(this.GtkAlignment2);
		this.GtkLabel12 = new global::Gtk.Label();
		this.GtkLabel12.Name = "GtkLabel12";
		this.GtkLabel12.Xalign = 0F;
		this.GtkLabel12.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Leaderboard</b>");
		this.GtkLabel12.UseMarkup = true;
		this.frame5.LabelWidget = this.GtkLabel12;
		this.hbox1.Add(this.frame5);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.frame5]));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		this.Add(this.hbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 669;
		this.DefaultHeight = 528;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.nextDiver.Clicked += new global::System.EventHandler(this.OnNextDiverClicked);
		this.Judge7.Clicked += new global::System.EventHandler(this.OnJudge7Clicked);
		this.judge6.Clicked += new global::System.EventHandler(this.OnJudge6Clicked);
		this.Judge5.Clicked += new global::System.EventHandler(this.OnJudge5Clicked);
		this.Judge4.Clicked += new global::System.EventHandler(this.OnJudge4Clicked);
		this.Judge3.Clicked += new global::System.EventHandler(this.OnJudge3Clicked);
		this.Judge2.Clicked += new global::System.EventHandler(this.OnJudge2Clicked);
		this.judge1.Clicked += new global::System.EventHandler(this.OnJudge1Clicked);
	}
}
