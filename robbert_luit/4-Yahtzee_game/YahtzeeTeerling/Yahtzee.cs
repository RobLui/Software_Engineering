using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class Yahtzee : Form
    {
        // Maak een lijst aan waarin de teerlingen worden opgevangen
        private List<TeerlingController> teerlingen = new List<TeerlingController>();
        YahtzeeController yahtzee = new YahtzeeController();
        ScoreBoardController scoreBoard = new ScoreBoardController();
        TeerlingController teerling = new TeerlingController();


        public Yahtzee()
        {
            InitializeComponent();
        }

        private void Yahtzee_Load(object sender, EventArgs e)
        {
            resetBtn.Enabled = false;
            // Aantal teerlingen dat getoond moet worden
            Controls.Add(scoreBoard.getView());

            // Maak instanties van de teerlingen aan en voeg deze toe aan de list
            for ( int teerlingNummer = 0; teerlingNummer < teerling._model.AantalTeerlingen; ++teerlingNummer )
            {
                // maak nieuwe instantie van teerling controller;
                TeerlingController nieuweTeerling = new TeerlingController();

                // Voeg controller toe aan teerlingen lijst
                teerlingen.Add(nieuweTeerling);
            }

            // Maak instanties van de teerlingen aan en voeg deze toe aan de list
            for (int teerlingNummer = 0; teerlingNummer < teerling._model.AantalTeerlingen; ++teerlingNummer)
                {
                    // Haal de teerling op basis van de key uit de teerlingen list 
                    TeerlingController huidigeTeerling = teerlingen[teerlingNummer];

                    // Haal de teerling view uit de teerling controller
                    TeerlingView huidigeTeerlingview = huidigeTeerling.getView();

                // Bepaald de huidige x positie (horizontaal) van de teerling
                int xPos = huidigeTeerlingview.Width * teerlingNummer;

                    // Zet de locatie van de teerling op basis van de x pos
                    huidigeTeerlingview.Location = new Point(xPos, 0);

                    // Voeg de view toe aan de huidige view
                    Controls.Add(huidigeTeerlingview);

            Controls.Add(yahtzee.getView());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yahtzee._model.AantalWorpen < teerling._model.MaxAantal)
            {
       
                for (int teerlingNummer = 0; teerlingNummer < teerling._model.AantalTeerlingen; ++teerlingNummer)
                {
                   TeerlingController huidigeTeerling = teerlingen[teerlingNummer];
                    if (huidigeTeerling._model.Click)
                    {
                        huidigeTeerling.werpTeerling();
                        huidigeTeerling.updateUI();
                        scoreBoard._model.Score += huidigeTeerling._model.AantalOgen;
                    }
                }

                yahtzee._model.AantalWorpen++;
                yahtzee.UpdateUI();
                scoreBoard.UpdateUI();
            }

            if(yahtzee._model.AantalWorpen == teerling._model.MaxAantal)
            {
                button1.Enabled = false;
                resetBtn.Enabled = true;
                if(scoreBoard._model.Score > scoreBoard._model.HighScore)
                {
                    scoreBoard._model.HighScore = scoreBoard._model.Score;
                    scoreBoard.UpdateUIHighscore();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scoreBoard._model.Score = 0;
            yahtzee._model.AantalWorpen = 0;
            yahtzee.getView().aantal_worpen = yahtzee._model.Aantal_worpen;
            
            resetBtn.Enabled = false;
            button1.Enabled = true;
            yahtzee.UpdateUI();

        }
    }
}
