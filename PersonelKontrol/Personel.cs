namespace PersonelKontrol
{
    public class Personel
    {

        private int _Numara;
        public string Ad { get; set; }
        public string SoyAdı { get; set; }

        public int Numarası { get { return _Numara; }  }

        public Personel()
        {
            _Numara = Helper.SayiÜret();
        }

    }

}
