using System;
using Gtk;

namespace DiveIn.Properties
{
    public partial class CreateLoadShow : Gtk.Window
    {
        public CreateLoadShow() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnCreateClicked(object sender, EventArgs e)
        {
            Window openCreateCompetiti0on = new CreateCompetition();
            this.Destroy();
        }

    }


}
