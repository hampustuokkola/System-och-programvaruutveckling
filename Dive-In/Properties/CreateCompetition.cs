using System;
using Gtk;
namespace DiveIn.Properties
{
    public partial class CreateCompetition : Gtk.Window
    {
        public CreateCompetition() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnCreateCompetitionClicked(object sender, EventArgs e)
        {

            Competition Competition = new Competition();
            Competition.name = CompNameEntry.Text;
            Competition.location = LocationEntry.Text;
            Competition.date = calendar1.GetDate().ToString("MM/dd/yyyy");

            // open window to register divers.
            Window openRegister = new RegisterDivers();
            this.Destroy();
            
        }
    }
}
