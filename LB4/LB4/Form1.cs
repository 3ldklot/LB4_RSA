using System.Numerics;
using System.Security.Cryptography;

namespace LB4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBoxpValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxqValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBoxeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 pValue;
            Int32 qValue;
            if (!RSAEncryption.Miller_Rabin(Convert.ToInt32(textBoxpValue.Text), 20) || !RSAEncryption.Miller_Rabin(Convert.ToInt32(textBoxqValue.Text), 20))
            {
                MessageBox.Show("Entered numbers are not simple. Try again");
                textBoxpValue.Text = "";
                textBoxqValue.Text = "";
            }
            else if (textBoxpValue.Text == textBoxqValue.Text)
            {
                MessageBox.Show("Entered numbers are equal");
                textBoxpValue.Text = "";
                textBoxqValue.Text = "";
            }
            else
            {
                pValue = Convert.ToInt32(textBoxpValue.Text);
                qValue = Convert.ToInt32(textBoxqValue.Text);
                if (!RSAEncryption.e_check(Convert.ToInt32(textBoxeValue.Text), Convert.ToInt32(RSAEncryption.euler_f(pValue, qValue)), pValue, qValue))
                {
                    MessageBox.Show("Entered e value is not correct");
                    textBoxeValue.Text = "";
                }
                else
                {
                    BigInteger d = RSAEncryption.d_find(Convert.ToInt32(textBoxeValue.Text), Convert.ToInt32(RSAEncryption.euler_f(pValue, qValue)));
                    textBoxdValue.Text = d.ToString();
                    textBoxdValueOut.Text = d.ToString();
                    textBoxeValueOut.Text = textBoxeValue.Text;
                    textBoxnValueOut.Text = RSAEncryption.n_module(pValue, qValue).ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 pValue = Convert.ToInt32(textBoxpValue.Text);
            Int32 qValue = Convert.ToInt32(textBoxqValue.Text);
            textBoxRead.Text = File.ReadAllText("in.txt");

            StreamWriter swEncrypted = new StreamWriter("out1.txt");

            List<string> encrypted = new List<string>();

            for (int i = 0; i < textBoxRead.Text.Length; i++)
            {
                encrypted.Add(RSAEncryption.RSA_encrypt(textBoxRead.Text[i], Convert.ToInt32(textBoxeValue.Text), Convert.ToInt32(textBoxnValueOut.Text)).ToString());
                swEncrypted.WriteLine(RSAEncryption.RSA_encrypt((int)(textBoxRead.Text[i]), Convert.ToInt32(textBoxeValue.Text), Convert.ToInt32(RSAEncryption.n_module(pValue, qValue))).ToString());
            }
            swEncrypted.Close();

            StreamWriter swDecrypted = new StreamWriter("out2.txt");
            for (int i = 0; i < encrypted.Count(); i++)
            {
                string encryptedKey = encrypted[i];
                int encryptedKeyConv = Convert.ToInt32(encryptedKey);
                textBoxDecrypted.Text += RSAEncryption.RSA_decrypt(encryptedKeyConv, Convert.ToInt64(textBoxdValue.Text), Convert.ToInt32(textBoxnValueOut.Text));

            }
            swDecrypted.WriteLine(textBoxDecrypted.Text);
            swDecrypted.Close();

        }
    }
}