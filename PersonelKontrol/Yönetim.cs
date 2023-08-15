namespace PersonelKontrol
{
    public class Yönetim
    {

        private static Yönetim _yönetim; 
        private Yönetim()
        {
                
        }

        public static Yönetim YönetimOluştur()
        {

            if (_yönetim == null)
            {
                _yönetim = new Yönetim();
            }
            return _yönetim;

        }


        public List<Grup> GrupOluştur (List<Personel> personeller)
        {

            int count = 0;
            int grupNumara = 1;
            List<Grup> gruplar = new List<Grup>(); 
            Grup temp = new Grup(); 
            for (int i = 0; i < personeller.Count; i++)
            {
                //18
                if (count != 5)
                {
                    temp.Personeller.Add(personeller[i]);
                    ++count;
                }
                else
                {
                    count = 0;
                    temp.GrupAdı = "grup " + grupNumara;
                    ++grupNumara;
                    gruplar.Add(temp);
                    temp = new Grup();
                    temp.Personeller.Add(personeller[i]);
                    ++count;    
                 }

            }


            return gruplar; 
        }

    }


}
