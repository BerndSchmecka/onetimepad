using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneTimePad
{
    public partial class MainWindow : Form
    {
        static Random random;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            btnGenerate.Click += new EventHandler(this.onClickGenerate);
            rtbInput.TextChanged += new EventHandler(this.onInputChanged);
        }

        public void onClickGenerate(Object sender, EventArgs e){
            byte[] inputTxt = Encoding.UTF8.GetBytes(rtbInput.Text); //Using UTF8 here
            int length = inputTxt.Length;
            byte[] rndBytes = new byte[length];
            random.NextBytes(rndBytes);
            //rtbCode.Text = BitConverter.ToString(rndBytes);
            rtbCode.Text = Convert.ToBase64String(rndBytes);

            byte[] xor = new byte[length];
            for(int i = 0; i<length; i++){
                xor[i] = (byte)(inputTxt[i] ^ rndBytes[i]);
            }

            //rtbCipher.Text = BitConverter.ToString(xor);
            rtbCipher.Text = Convert.ToBase64String(xor);
        }

        public void onInputChanged(Object sender, EventArgs e){
            byte[] inputTxt = Encoding.UTF8.GetBytes(rtbInput.Text); //Again using UTF8 here
            //rtbHexInput.Text = BitConverter.ToString(inputTxt);
            rtbHexInput.Text = Convert.ToBase64String(inputTxt);
        }

    }
}
