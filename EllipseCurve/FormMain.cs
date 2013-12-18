using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Numerics;

namespace EllipseCurve
{
    public partial class FormMain : Form
    {
        EGroup group;
        int M = 61;
        public FormMain()
        {
            InitializeComponent();
            group = new EGroup(M,25,13);
            lb_group.Text = group.ToString();
        }

        public static BigInteger ModInverse(BigInteger a, BigInteger n)
        {
            BigInteger i = n, v = 0, d = 1;
            while (a > 0)
            {
                BigInteger t = i / a, x = a;
                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }
            v %= n;
            if (v < 0)
            {
                v = (v + n) % n;
            }
            return v;
        }

        private void bt_generateSignature_Click(object sender, EventArgs e)
        {
            int s = 0;
            int r = 0;
            SHA1Managed sha1 = new SHA1Managed();
            Random random = new Random();
            int Na = Int32.Parse(tb_na.Text);
            EPoint G = group.GetGeneratingPoint();
            int q = G.Degree();
            EPoint Pa = G * Na;
            byte[] hash = sha1.ComputeHash(Encoding.Default.GetBytes(rtb_message.Text));
            BigInteger h = BigInteger.Abs(new BigInteger(hash));
            do
            {
                int k = random.Next(1,q - 1);
                EPoint temp = G * k;
                r = temp.X % q;
                if (r == 0)
                {
                    continue;
                }
                int kModInverse = Int32.Parse(ModInverse(k, q).ToString());
                s = Int32.Parse(((kModInverse * (h + Na * r)) % q).ToString());
                if (s == 0)
                {
                    continue;
                }
                break;
            } while (true);
            tb_pa.Text = Pa.ToString();
            tb_r.Text = r.ToString();
            tb_s.Text = s.ToString();
        }

        private void bt_changeGroup_Click(object sender, EventArgs e)
        {
            group = new EGroup(M);
            lb_group.Text = group.ToString();
        }

        private void bt_exchangeKeys_Click(object sender, EventArgs e)
        {
            string result = "";
            Random random = new Random();
            EPoint G = group.GetGeneratingPoint();
            int Na = 0, Nb = 0;
            EPoint Pa, Pb;
            bool isNaCheck = false, isNbCheck = false;
            do
            {
                if (!isNaCheck)
                    Na = random.Next(1, M - 1);
                if (!isNbCheck)
                    Nb = random.Next(1, M - 1);
                Pa = G * Na;
                Pb = G * Nb;
                if (group.FindPoint(Pa.ToString()) as Object != null)
                    isNaCheck = true;
                if (group.FindPoint(Pb.ToString()) as Object != null)
                    isNbCheck = true;
            } while (!(isNaCheck && isNbCheck));
            EPoint K1 = Pa * Nb;
            EPoint K2 = Pb * Na;
            result += "G = " + G.ToString() + " \n";
            result += "User A choose private key Na = " + Na + " \n";
            result += "User B choose private key Nb = " + Nb + " \n";
            result += "User A generate public key Pa = " + Pa.ToString() + " \n";
            result += "User B generate public key Pb = " + Pb.ToString() + " \n";
            result += "User A generate common private key K = " + K2.ToString() + " \n";
            result += "User B generate common private key K = " + K1.ToString() + " \n";
            rtb_exchangeKeys.Text = result;
        }

        private void bt_checkSignature_Click(object sender, EventArgs e)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.Default.GetBytes(rtb_message.Text));
            BigInteger h = BigInteger.Abs(new BigInteger(hash));
            EPoint G = group.GetGeneratingPoint();
            int q = G.Degree();
            EPoint Pa = group.FindPoint(tb_pa.Text);
            int r = Int32.Parse(tb_r.Text);
            int s = Int32.Parse(tb_s.Text);
            if ((r > 1 && r < q - 1) && (s > 1 && s < q - 1))
            {
                int w = Int32.Parse(ModInverse(s,q).ToString());
                int u1 = Int32.Parse(((h * w) % q).ToString());
                int u2 = (r * w) % q;
                EPoint X = G * u1 + Pa * u2;
                int R = X.X % q;
                if (R == r)
                    MessageBox.Show("Signature is correct");
                else
                    MessageBox.Show("Signature isn't correct");
            }
            else
                MessageBox.Show("Signature isn't correct");
        }
    }
}
