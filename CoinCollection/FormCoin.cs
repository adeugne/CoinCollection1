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
            labelCoinPrice.Text = coin.price.ToString();
            labelCoinMintage.Text = coin.mintage.ToString();
            labelCoinYear.Text = coin.year.ToString();
            labelCoinDescription.Text = $" Метал: {coin.metal}; Країна: {coin.country}";
            if (coin.path != null && coin.path.Length > 0)
                pictureBox1.Load(coin.path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void labelCoinDescription_Click(object sender, EventArgs e)
        {

        }

        private void labelCoinName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCoin_Load(object sender, EventArgs e)
        {

        }
    }
}
