using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MA
{
    public partial class lzw : Form
    {
        public lzw()
        {
            InitializeComponent();
        }

        public static List<int> Compress(string uncompressed)
        {
            // build the dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < 256; i++)
                dictionary.Add(((char)i).ToString(), i);

            string w = string.Empty;
            List<int> compressed = new List<int>();

            foreach (char c in uncompressed)
            {
                string wc = w + c;
                if (dictionary.ContainsKey(wc))
                {
                    w = wc;
                }
                else
                {
                    // write w to output
                    compressed.Add(dictionary[w]);
                    // wc is a new sequence; add it to the dictionary
                    dictionary.Add(wc, dictionary.Count);
                    w = c.ToString();
                }
            }

            // write remaining output if necessary
            if (!string.IsNullOrEmpty(w))
                compressed.Add(dictionary[w]);

            return compressed;
        }

        public static string Decompress(List<int> compressed)
        {
            // build the dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for (int i = 0; i < 256; i++)
                dictionary.Add(i, ((char)i).ToString());

            string w = dictionary[compressed[0]];
            compressed.RemoveAt(0);
            StringBuilder decompressed = new StringBuilder(w);

            foreach (int k in compressed)
            {
                string entry = null;
                if (dictionary.ContainsKey(k))
                    entry = dictionary[k];
                else if (k == dictionary.Count)
                    entry = w + w[0];

                decompressed.Append(entry);

                // new sequence; add it to the dictionary
                dictionary.Add(dictionary.Count, w + entry[0]);

                w = entry;
            }

            return decompressed.ToString();
        }

        List<int> compressed;

        private void LZW_Encode_Click(object sender, EventArgs e)
        {
            if (txtLZW_result.Visible == false)
            {
                txtLZW_result.Visible = true;
            }
            txtLZW_result.Clear();
            string input = txtLZW.Text;
            compressed = Compress(input);
            txtLZW_result.Text = string.Join(", ", compressed);
        }

        private void LZW_Decode_Click(object sender, EventArgs e)
        {
            if (txtLZW_result.Visible == false)
            {
                txtLZW_result.Visible = true;
            }
            txtLZW_result.Clear();
            string input = txtLZW.Text;
            string decompressed = Decompress(compressed).ToString();
            txtLZW_result.Text = string.Join(", ", decompressed);
        }

        public static double logtwo(double num)
        {
            return Math.Log(num) / Math.Log(2);
        }
        private void LZW_Entropy_Click(object sender, EventArgs e)
        {
            if (txtLZW_result.Visible == false)
            {
                txtLZW_result.Visible = true;
            }
            txtLZW_result.Clear();
            string input = txtLZW.Text;
            double infoC = 0;
            Dictionary<char, double> table = new Dictionary<char, double>();


            foreach (char c in input)
            {
                if (table.ContainsKey(c))
                    table[c]++;
                else
                    table.Add(c, 1);

            }
            double freq;
            foreach (KeyValuePair<char, double> letter in table)
            {
                freq = letter.Value / input.Length;
                infoC += freq * logtwo(freq);
            }
            infoC *= -1;
            txtLZW_result.Text = "The entropy of " + input.ToString() + " is " + infoC.ToString();
        }

        private void txtLZW_TextChanged(object sender, EventArgs e)
        {
            label1.Text = txtLZW.Text.Length.ToString();
            if (label1.Text == 0.ToString())
            {
                label1.Text = "size";
            }
        }
    }
}
