using CoinCollection.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coin = CoinCollection.Models.Coin;

namespace CoinCollection
{
    public partial class FormCoin : Form
    {


        public FormCoin(Coin coin)
        {
            InitializeComponent();
            labelCoinName.Text = coin.name;
            labelCoinDescription.Text = coin.description;
            labelCoinPrice.Text = coin.price.ToString();
            labelCoinMintage.Text = coin.mintage.ToString();
            labelCoinYear.Text = coin.year.ToString();
            if (coin.path != null && coin.path.Length > 0)
                pictureBox1.Load(coin.path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
