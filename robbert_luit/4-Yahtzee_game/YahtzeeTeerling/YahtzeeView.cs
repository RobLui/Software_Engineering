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
    public partial class YahtzeeView : UserControl
    {
        public int aantal_worpen;
        public YahtzeeController _controller;

        public void UpdateUI()
        {

            if (_controller._model.TijdelijkeMax > 0)
            {
                _controller._model.TijdelijkeMax--;
                lblWorpen.Text = "Aantal Worpen: " + _controller._model.TijdelijkeMax.ToString();
            }
            else
            {
                _controller._model.TijdelijkeMax = 3;
                lblWorpen.Text = "Aantal Worpen: " + _controller._model.TijdelijkeMax.ToString();
            }

        } 

        public YahtzeeView( YahtzeeController controller )
        {
            _controller = controller;
            InitializeComponent();
        }

        private void YahtzeeView_Load(object sender, EventArgs e)
        {

        }
    }
}
