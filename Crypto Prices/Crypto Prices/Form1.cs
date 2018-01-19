using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;

namespace Crypto_Prices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblBTC.BackColor = System.Drawing.Color.Transparent;
            lblBCH.BackColor = System.Drawing.Color.Transparent;
            lblETH.BackColor = System.Drawing.Color.Transparent;
            lblZEC.BackColor = System.Drawing.Color.Transparent;
            lblBTG.BackColor = System.Drawing.Color.Transparent;
            getPrices();
            InitTimer();
        }

        void getPrices()
        {
            string BTCstring;
            string BCHstring;
            string ETHstring;
            string ZECstring;
            string BTGstring;

            string URLString = "https://min-api.cryptocompare.com/data/pricemulti?fsyms=BTC,BCH,ETH,ZEC,BTG&tsyms=USD";

            string jsonString;


            using (var wc = new WebClient())
            {
                jsonString = wc.DownloadString(URLString);
            }

            string[] CoinArray = jsonString.Split(',');

            BTCstring = CoinArray[0];
            BCHstring = CoinArray[1];
            ETHstring = CoinArray[2];
            ZECstring = CoinArray[3];
            BTGstring = CoinArray[4];

            Regex notNumbers = new Regex("[^$0-9.]");

            BTCstring = notNumbers.Replace(BTCstring,"");
            BCHstring = notNumbers.Replace(BCHstring, "");
            ETHstring = notNumbers.Replace(ETHstring, "");
            ZECstring = notNumbers.Replace(ZECstring, "");
            BTGstring = notNumbers.Replace(BTGstring, "");

            //"{\"BTC\":{\"USD\":8174.85},\"BCH\":{\"USD\":1650.4},\"ETH\":{\"USD\":409.26},\"ZEC\":{\"USD\":305.31}}"

            lblBTC.Text = "Bitcoin Price:      $" + BTCstring;
            lblBCH.Text = "Bitcoin Cash Price:      $" + BCHstring;
            lblETH.Text = "Ethereum Price:      $" + ETHstring;
            lblZEC.Text = "Z Cash Price:      $" + ZECstring;
            lblBTG.Text = "Bitcoin Gold Price:      $" + BTGstring;



        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            getPrices();
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 30000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            getPrices();
        }



    }
}
