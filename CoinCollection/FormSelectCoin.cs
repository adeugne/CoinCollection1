using CoinCollection.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoinCollection.Managers;

namespace CoinCollection
{
    public partial class FormSelectCoin : Form
    {
        private CoinsManager _coinsManager;
        public Coin? SelectedCoin { get; private set; }
        public FormSelectCoin(List<Coin> coins, List<string> userCoinUUIDs, CoinsManager manager)
        {
            InitializeComponent();

            _coinsManager = manager;

            dataGridViewCoinsPreview.AutoGenerateColumns = false;
            dataGridViewCoinsPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "UUID", DataPropertyName = "uuid" });
            dataGridViewCoinsPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Назва", DataPropertyName = "name" });
            dataGridViewCoinsPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Країна", DataPropertyName = "country" });
            dataGridViewCoinsPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Рік", DataPropertyName = "year" });
            dataGridViewCoinsPreview.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ціна", DataPropertyName = "price" });
            dataGridViewCoinsPreview.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Є у користувача", DataPropertyName = "IsInCollection" });

            // Додаємо властивість для DataGridView
            var displayCoins = coins.Select(c => new
            {
                c.uuid,
                c.name,
                c.country,
                c.year,
                c.price,
                c.metal,
                IsInCollection = userCoinUUIDs.Contains(c.uuid)
            }).ToList();

            dataGridViewCoinsPreview.DataSource = displayCoins;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewCoinsPreview.SelectedRows.Count == 1)
            {
                string selectedUuid = dataGridViewCoinsPreview.SelectedRows[0].Cells[0].Value.ToString();
                // Пошук монети за uuid
                SelectedCoin = _coinsManager.GetCoin(selectedUuid);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть монету.");
            }
        }

        private void buttonCancelSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            //Close();
        }
    }
}
