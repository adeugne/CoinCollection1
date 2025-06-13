using CoinCollection.Models;
using CoinCollection.Managers;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CoinCollection
{
    public partial class FormUser : Form
    {
        public FormUser(User user, List<Coin> coins)
        {
            InitializeComponent();
            labelUserName.Text = user.name;
            labelUserEmail.Text = user.email;
            labelUserPhone.Text = user.phone;
            labelUserCountry.Text = user.country;


            foreach (Coin c in coins)
            {
                dataGridViewOwn.Rows.Add(c.name, c.path, c.country, c.year, c.price, c.metal, c.mintage);
            }
        }


        private void buttonUserClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
