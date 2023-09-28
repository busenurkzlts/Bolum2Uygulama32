namespace k32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayinin_karesi;
            try
            {
                sayi1 = Convert.ToInt16(textBox1.Text);
                sayinin_karesi = sayi1 * sayi1;
                MessageBox.Show(sayinin_karesi.ToString());
            }
            catch
            {
                MessageBox.Show("hatalý giriþ yaptýnýz!!!!");
            }
            finally
            {
                // Hata olsa da olmasa da çalýþacak kodlar
            }
        }
    }
}