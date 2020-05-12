using System;
using System.Collections.Generic;
using Gtk;
using DiveIn.Properties;

public partial class MainWindow : Gtk.Window
{
    static int windowSelect = 0;
    static int diverSelect = 0;
    void updateCurrentDiver()
    {
        int numOfDivers = RegisterDivers.diverList.Count;
        textviewLeaderboard.Buffer.Text = "" + numOfDivers + "\n" + diverSelect;
        if (numOfDivers > diverSelect)
        {
            Diver currentDiver = RegisterDivers.diverList[diverSelect];
            textviewCurrentDiver.Buffer.Text = currentDiver.Name + ":\n"
            + currentDiver.Club + "\n" + currentDiver.Jump1 +
             " :\n-----------------------------------------------";
        }
    }

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        if (windowSelect == 0)
        {
            windowSelect++;
            Window createLoadShow = new CreateLoadShow();
        }
        else
        {
            Build();
            updateCurrentDiver();
        }
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    //BUTTONS

    protected void OnJudge1Clicked(object sender, EventArgs e)
    {
        Window openJudgeWindow = new JudgeScoring();
    }

    protected void OnJudge2Clicked(object sender, EventArgs e)
    {
        Window openJudgeWindow = new JudgeScoring();
    }

    protected void OnJudge3Clicked(object sender, EventArgs e)
    {
        Window openJudgeWindow = new JudgeScoring();
    }

    protected void OnJudge4Clicked(object sender, EventArgs e)
    {
        Window openJudgeWindow = new JudgeScoring();
    }

    protected void OnJudge5Clicked(object sender, EventArgs e)
    {
        Window openJudgeWindow = new JudgeScoring();
    }

    protected void OnJudge6Clicked(object sender, EventArgs e)
    {
        Window openJudgeWindow = new JudgeScoring();
    }

    protected void OnJudge7Clicked(object sender, EventArgs e)
    {
        Window openJudgeWindow = new JudgeScoring();
    }

    protected void OnNextDiverClicked(object sender, EventArgs e)
    {
        diverSelect++;
        updateCurrentDiver();
        //Window openMain = new MainWindow();
        //this.Destroy();

    }
}
