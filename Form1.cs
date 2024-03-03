namespace Karar_Yapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = textBox1.Text;
            soyad = textBox2.Text;

            int sinavBir, sinavIki, sinavUc, ortalama;
            sinavBir = Convert.ToInt16(textBox3.Text);
            sinavIki = Convert.ToInt16(textBox4.Text);
            sinavUc = Convert.ToInt16(textBox5.Text);

            listBox1.Items.Add("Öðrenci: " + ad + " " + soyad);

           ortalama = (sinavBir + sinavIki + sinavUc)/3;
            if (ortalama >= 50)
            {
                listBox1.Items.Add("GEÇTÝ");
            }
            else if (ortalama < 50)
            {
                listBox1.Items.Add("KALDI");
            }
            else
            {
                listBox1.Items.Add("YANLIÞ NOT GÝRÝÞÝ!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            textBox1.Focus();

        }
    }
}