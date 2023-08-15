namespace PersonelKontrol
{
    public class Yönetim
    {
        //y a =123
        //y b = 123  

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
            //18
            //5
            //5
            //5 
            //3
            int count = 0;
            int grupNumara = 1;
            List<Grup> gruplar = new List<Grup>(); 
            Grup temp = new Grup(); 
            for (int i = 0; i < personeller.Count; i++)
            {
                //7 
                //count 0 1 2 3 4 | count 2
                //list  1 2 3 4 5 | 6 7
                if (count < 5)
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

            if (count != 0)
            {
                gruplar.Add(temp);
                temp.GrupAdı = "grup " + grupNumara;
            }

            return gruplar; 
        }

    }


}
