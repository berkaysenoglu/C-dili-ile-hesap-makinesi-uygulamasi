namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        int secim;
        double sayi1, sayi2, sonuc;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonlar(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = " ";
            textBox1.Text += ((Button)sender).Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "-";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            secim = 2;
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "*";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            secim = 3;
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + " /";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            secim= 4;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text= "0";
            label1.Text= "";
            secim= 0;
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",")<1)
                  textBox1.Text += ",";
        }

        private void btnNP_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "0")
            {
                if (textBox1.Text.StartsWith("-"))
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                }
                else if (textBox1.Text.StartsWith(""))
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(textBox1.Text);
            if(secim==1)
            {
                sonuc = sayi1 + sayi2;
                secim = 0;
            }
            if(secim==2)
            {
                sonuc = sayi1- sayi2;
                secim = 0;
            }
            if(secim==3)
            {
                sonuc=sayi1 * sayi2;
                secim = 0;
            }
            if(secim==4)
            {
                sonuc=sayi1 / sayi2;
                secim = 0;
            }
            textBox1.Text = Convert.ToString(sonuc);
            label1.Text=Convert.ToString(sonuc);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 2)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
                textBox1.Text = "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + "+";
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            secim = 1;
            
            
        }
    }
}