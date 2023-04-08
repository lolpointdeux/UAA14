using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ACT7
{
    class Chien
    {
        private int _longueurPiste,_numChien;
        private int[] _positionCourante;
        private bool _gagne;
        private Image _imageChien;

        public Image ImageChien
        {
            get { return _imageChien; }
            set { _imageChien = value; }
        }




        public  int LongueurPiste
        {
            get { return _longueurPiste; }
            set { _longueurPiste = value; }
        }

        public int NumChien
        {
            get { return _numChien; }
            set { _numChien = value; }
        }

        public int[] PositionCourante
        {
            get { return _positionCourante; }
            set { _positionCourante = value; }
        }
        

        public  bool Gagne
        {
            get { return _gagne; }
            set { _gagne = value; }
        }

        public Chien(int longueurPiste, int numChien, int[] positionCourante, bool gagne)
        {
            _longueurPiste = longueurPiste;
            _numChien = numChien;
            _positionCourante = positionCourante;
            _gagne = gagne;

            BitmapImage imageChien = new BitmapImage();
            imageChien.BeginInit();
            imageChien.UriSource = new Uri("img/dog.png", UriKind.Relative);
            imageChien.EndInit();

            _imageChien = new Image();
            _imageChien.Source = imageChien;
            _imageChien.Stretch = System.Windows.Media.Stretch.None;





        }






    }
}
