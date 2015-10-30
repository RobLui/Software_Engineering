using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeTeerling
{
    public partial class ScoreBoardView : UserControl
    {
        ScoreBoardController _controller;
        public ScoreBoardView( ScoreBoardController controller )
        {
            _controller = controller;
            InitializeComponent();
        }

        private void ScoreBoardView_Load(object sender, EventArgs e)
        {
            label2.Text = "Huidige score: 0";
            label1.Text = "Highscore: 0";
        }

        public void UpdateUI()
        {
            label2.Text = "Huidige score: " + _controller._model.Score.ToString();
        }

        public void UpdateUIHighscore()
        {
            label1.Text = "Highscore: " + _controller._model.HighScore;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
