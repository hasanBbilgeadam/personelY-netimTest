using PersonelKontrol;

namespace PersonelYönetimUI
{
    public partial class Form1 : Form
    {

        List<Personel> Personeller;
        List<Grup> gruplar;
        public Form1()
        {
            Personeller = new List<Personel>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personeller.Add(new Personel() { Ad = textBox1.Text, SoyAdı = textBox2.Text });
            lblPersonelCount.Text = Personeller.Count.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Yönetim yönetim = Yönetim.YönetimOluştur();

             gruplar = yönetim.GrupOluştur(Personeller);


            foreach (Grup grup in gruplar)
            {
                comboBox1.Items.Add(grup.GrupAdı);
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboBox cb = (ComboBox)sender;

            //grup 1 
            //grup 2 => personell  => listbox

            string GrupAdı = cb.SelectedItem.ToString();

            listBox1.Items.Clear();
            foreach (var item in gruplar)
            {
                if (item.GrupAdı == GrupAdı)
                {

                    foreach (var p in item.Personeller)
                    {
                        listBox1.Items.Add(p.Ad+" "+p.SoyAdı+" "+p.Numarası);
                    }

                }
            }





        }
    }
}