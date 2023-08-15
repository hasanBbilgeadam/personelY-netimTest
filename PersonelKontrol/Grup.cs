namespace PersonelKontrol
{
    public class Grup
    {
        private int _GrupNumarası;
        public int GrupNumarası { get { return _GrupNumarası; }  }
        public string GrupAdı { get; set; }

        public List<Personel> Personeller { get; set; }

        public Grup()
        {
            Personeller = new List<Personel>(); 
            _GrupNumarası = Helper.SayiÜret();
        }

    }






}
