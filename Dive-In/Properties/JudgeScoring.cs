using System;
namespace DiveIn.Properties

{

    public partial class JudgeScoring : Gtk.Window
    {
        public JudgeScoring() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            textviewCurrentDiver.Buffer.Text = "Tester Testinsson:\n Örebro SHK:\n Tripple flip with Double Cork:\n-----------------------------------------------";

        }
        
        double data;
        void TextJudge(double score)
        {
            data = score;
            string s = "E04";
            Math.Round(score);
            string scoreString = score.ToString(s);
            scoreString = scoreString.Substring(0, 3);
            string outString = "You have Entered the score:\n" + scoreString + "\npress Save score to register score";
            textviewJudge.Buffer.Text = outString;

        }

        protected void OnScoreZeroClicked(object sender, EventArgs e)
        {
            TextJudge(0);
        }

        protected void OnScore1Clicked(object sender, EventArgs e)
        {
            TextJudge(1);

        }

        protected void OnScoreZeroFivePressed(object sender, EventArgs e)
        {
            TextJudge(0.5);

        }

        protected void OnScore1fiveClicked(object sender, EventArgs e)
        {
            TextJudge(1.5);

        }

        protected void OnScore2Clicked(object sender, EventArgs e)
        {
            TextJudge(2);

        }

        protected void OnScore25Clicked(object sender, EventArgs e)
        {
            TextJudge(2.5);

        }

        protected void OnScore3Clicked(object sender, EventArgs e)
        {
            TextJudge(3);

        }

        protected void OnScore35Clicked(object sender, EventArgs e)
        {
            TextJudge(3.5);

        }

        protected void OnScore4Clicked(object sender, EventArgs e)
        {
            TextJudge(4);

        }

        protected void OnScore45Clicked(object sender, EventArgs e)
        {
            TextJudge(4.5);

        }

        protected void OnScore5Clicked(object sender, EventArgs e)
        {
            TextJudge(5);

        }

        protected void OnScore55Clicked(object sender, EventArgs e)
        {
            TextJudge(5.5);

        }

        protected void OnScore6Clicked(object sender, EventArgs e)
        {
            TextJudge(6);

        }

        protected void OnScore65Clicked(object sender, EventArgs e)
        {
            TextJudge(6.5);

        }

        protected void OnScore7Clicked(object sender, EventArgs e)
        {
            TextJudge(7);
        }

        protected void OnScore75Clicked(object sender, EventArgs e)
        {
            TextJudge(7.5);

        }

        protected void OnScore8Clicked(object sender, EventArgs e)
        {
            TextJudge(8);

        }

        protected void OnScore85Clicked(object sender, EventArgs e)
        {
            TextJudge(8.5);

        }

        protected void OnScore9Clicked(object sender, EventArgs e)
        {
            TextJudge(9);

        }

        protected void OnScore95Clicked(object sender, EventArgs e)
        {
            TextJudge(9.5);

        }

        protected void OnScore10Clicked(object sender, EventArgs e)
        {
            TextJudge(10);
        }

        protected void OnSaveScoreClicked(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
