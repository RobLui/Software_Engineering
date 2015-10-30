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
    public partial class TeerlingView : UserControl
    {
        TeerlingController _controller;

        // Constructor met bovenliggende controller als parameter
        public TeerlingView( TeerlingController controller)
        {
            // Vang het controller argument op zodat de rest van de view-methodes
            // de controller-methodes kunnen aanspreken
            _controller = controller;
            InitializeComponent();
        }

        private void TeerlingView_Load(object sender, EventArgs e)
        {
        }

        private void werpButton_Click(object sender, EventArgs e)
        {
                _controller.werpTeerling();

                teerlingLabel.Text = _controller._model.AantalOgen.ToString();
        }

        private void teerlingLabel_Click(object sender, EventArgs e)
        {
            if(_controller._model.Click)
            {
                teerlingLabel.BackColor = System.Drawing.Color.IndianRed;
                werpButton.Enabled = false;
                _controller._model.Click = false;
            } else
            {
                teerlingLabel.BackColor = System.Drawing.Color.Transparent;
                werpButton.Enabled = true;
                _controller._model.Click = true;
            }
        }

        public void updateUI()
        {
            teerlingLabel.Text = _controller._model.AantalOgen.ToString();
        }
    }
}
