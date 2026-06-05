namespace TarihliHatirlatmalarUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tarih = txtTarihEkle.Text.Trim();
            string not = txtNot.Text.Trim();

            string satir = tarih + "|" + not;
            File.AppendAllText("hatirlatmalar.txt", satir + "\n");

            MessageBox.Show("Not kaydedildi.");
            //txtTarihEkle.Clear();
            txtNot.Clear();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string aranan = txtTarih1.Text.Trim();

            string[] notlar = File.ReadAllLines("hatirlatmalar.txt");

            foreach (var item in notlar)
            {
                string[] notDizisi = item.Split('|');
                if (notDizisi[0] == aranan)
                {
                    listBox1.Items.Add(notDizisi[1]);
                }
            }
        }
    }
}
