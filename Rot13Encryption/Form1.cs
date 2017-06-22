using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Rot13Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ArrayList getInput()
        {
            ArrayList input = new ArrayList();
            // fill array
            for (int i = 0; i < txtInput.TextLength; i++)
            {
                input.Add(txtInput.Text[i].ToString());
            }
            return input;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            ArrayList input = getInput();

            for (int i = 0; i < input.Count; i++)
            {
                // convert current letter to char
                char c = Convert.ToChar(input[i]);
                // increment char by 13
                // check if current char is between 65-122 (= a letter)
                if (c >= 65 && c <= 122)
                {
                    input[i] = c = (char)('a' + (c - 'a' + 13) % 26);
                }
                else
                {
                    input[i] = c;
                }
            }
            showResult(input);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            ArrayList input = getInput();

            for (int i = 0; i < input.Count; i++)
            {
                // convert current letter to char
                char c = Convert.ToChar(input[i]);
                // decrement char by 13
                // check if current char is between 65-122 (= a letter)
                if (c >= 65 && c <= 122)
                {
                    input[i] = c = (char)('a' + (c - 'a' + 13) % 26);
                }
                else
                {
                    input[i] = c;
                }
            }
            showResult(input);
        }

        private void showResult(ArrayList ar)
        {
            string output = "";
            // reassemble string
            foreach (Char c in ar)
            {
                output += c;
            }
            // display output
            txtOutput.Text = output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADJSGIHADSJGHADHSG");
        }
    }
}
