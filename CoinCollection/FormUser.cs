using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinCollection
{
    public partial class FormUser : Form
    {
        public FormUser(string name, string email, string phone, string country)
        {
            InitializeComponent();
            labelUserName.Text = name;
            labelUserEmail.Text = email;
            labelUserPhone.Text = phone;
            labelUserCountry.Text = country;
        }


        private void buttonUserClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
