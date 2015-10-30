using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeTeerling
{
    // Vergeet niet de controller op public te zetten
    // Zo kan de view die de controller als argument meekrijgt aan de properties
    public class TeerlingController
    {
        static int seeder = new Random().Next();

        Random random = new Random(++seeder);

        private TeerlingView _view;
        public TeerlingModel _model;

        public TeerlingController()
        {
            _view = new TeerlingView( this );

            _model = new TeerlingModel();
        }

        public TeerlingView getView()
        {
            return _view;
        }

        public void werpTeerling()
        {
            int teerlingGetal = random.Next(1, 7);
            _model.AantalOgen = teerlingGetal;
        }

        public void updateUI()
        {
            _view.updateUI();
        }
    }
}
