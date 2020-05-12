using System;
using System.Collections;
using System.Collections.Generic;
using Gtk;


namespace DiveIn.Properties
{
    public partial class RegisterDivers : Gtk.Window
    {
        public RegisterDivers() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        static public List<Diver> diverList = new List<Diver>();
        protected void OnRegisterDiverClicked(object sender, EventArgs e)
        {

            Diver diver = new Diver();
            diver.Name = diverNameEntry.Text;
            diver.Club = clubEntry.Text;
            diver.Jump1 = jump1Entry.Text;
            diver.Jump2 = jump2Entry.Text;
            diver.Jump3 = jump3Entry.Text;

            diverList.Add(diver);
            this.Destroy();
            this.Build();


        }

        protected void OnStartCompButtonClicked(object sender, EventArgs e)
        {
            Window MainWindow = new MainWindow();
            this.Destroy();
        }
    }
}
