using CoinCollection.Managers;
using CoinCollection.Models;

using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.Json;  
using System.Windows.Forms;
using System.Xml.Linq;

using MyUser = CoinCollection.Models.User;

namespace CoinCollection
{

    public partial class FormMain : Form
    {
        private string jsonFilePathUsers = "users.json";
        private string jsonFilePathCoins = "coins.json";
        private CoinsManager _coinsManager;
        private UsersManager _usersManager;

        private Own _own;
        private MyUser _ownUser;
        private string _coinPicturePath;

        public FormMain()
        {
            InitializeComponent();

            _coinsManager = new CoinsManager(jsonFilePathCoins);
            _usersManager = new UsersManager(jsonFilePathUsers);



            LoadDataAsync();
        }

        private async void LoadCoins()
        {
            await _coinsManager.LoadAsync();
            UpdateCoinsList();
            Console.WriteLine("Coins updated");
        }

        private async void LoadUsers()
        {
            await _usersManager.LoadAsync();
            UpdateUsersList();
            Console.WriteLine("Users updated");
        }

        private async void LoadDataAsync()
        {
            Console.WriteLine("Load Coins start");
            LoadCoins();
            Console.WriteLine("Load Users start");
            LoadUsers();

            if (File.Exists("own.json"))
            {
                string json = await File.ReadAllTextAsync("own.json");
                _own = JsonSerializer.Deserialize<Own>(json);

                if (_own != null)
                {
                    // ��������� ����������� �� Uuid 
                    _ownUser = _usersManager.Users.FirstOrDefault(u => u.uuid == _own.Uuid);

                    UpdateMainTab();
                }
            }
        }

        private void UpdateCoinsList()
        {
            dataGridViewCoins.Rows.Clear();
            foreach (var coin in _coinsManager.Coins)
            {
                dataGridViewCoins.Rows.Add(coin.name, coin.path, coin.country, coin.year, coin.price, coin.metal, coin.mintage);
            }
        }

        private void UpdateMainTab()
        {
            if (_ownUser != null)
            {
                label1OwnName.Text = "³����, " + _ownUser.name;
                labelOwnEmail.Text = _ownUser.email;
                labelOwnPhone.Text = _ownUser.phone;
                labelOwnCountry.Text = _ownUser.country;

                List<Coin> coins = new List<Coin>();

                foreach (String uuid in _ownUser.coins)
                {
                    coins.Add(_coinsManager.GetCoin(uuid));

                }

                dataGridViewOwn.Rows.Clear();

                foreach (Coin c in coins)
                {
                    dataGridViewOwn.Rows.Add(c.name, c.path, c.country, c.year, c.price, c.metal, c.mintage);
                }

                //MessageBox.Show($"����������� ��������: {_ownUser.name}");
            }
            else
            {
                MessageBox.Show("�������� �� �������� � ������ ������������.");
            }
        }

        private void UpdateUsersList()
        {
            // ������� ���� ���
            dataGridViewUser.Rows.Clear();

            // ������ ��� ��� � UsersManager
            foreach (var user in _usersManager.Users)
            {
                dataGridViewUser.Rows.Add(user.name, user.email, user.phone, user.country);
            }
        }



        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            String name = textBoxUserName.Text;
            String email = textBoxUserEmail.Text;
            String phone = textBoxUserPhone.Text;
            String country = textBoxUserCountry.Text;

            if (name.Length == 0 || email.Length == 0 || phone.Length == 0 || country.Length == 0)
            {
                MessageBox.Show("��� �� ������ ���� �������!");
                return;
            }

            var newUser = new MyUser
            {
                name = name,
                uuid = Guid.NewGuid().ToString(),
                country = country,
                email = email,
                phone = phone,
                coins = new List<string>()
            };
            _usersManager.AddUser(newUser);
            UpdateUsersList();
        }

        private void buttonUserRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("�� ������� � ������ �����!");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewUser.SelectedRows)
            {
                int index = row.Index;
                _usersManager.RemoveUserByIndex(index);
            }


            // ��������� ������ � DataGridView
            UpdateUsersList();

            MessageBox.Show("�����������(��) ��������!");
        }

        private void buttonUserChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count != 1)
            {
                MessageBox.Show("������� ������� ������ ���� �����!");
                return;
            }

            String name = textBoxUserName.Text;
            String email = textBoxUserEmail.Text;
            String phone = textBoxUserPhone.Text;
            String country = textBoxUserCountry.Text;

            int r = dataGridViewUser.SelectedRows[0].Index;
            Console.WriteLine(r);

            dataGridViewUser.Rows[r].Cells[0].Value = name;
            dataGridViewUser.Rows[r].Cells[1].Value = email;
            dataGridViewUser.Rows[r].Cells[2].Value = phone;
            dataGridViewUser.Rows[r].Cells[3].Value = country;
            MessageBox.Show("���� ������ �������!");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await _usersManager.SaveAsync();
            MessageBox.Show("���� ������������ ������ ���������!");
        }

        private void buttonUserShow_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count != 1)
            {
                MessageBox.Show("�� ������ ������� ���� �����!");
                return;
            }

            int rind = dataGridViewUser.SelectedRows[0].Index;

            User user = _usersManager.Users[rind];

            List<Coin> coins = new List<Coin>();

            foreach (String uuid in user.coins)
            {
                coins.Add(_coinsManager.GetCoin(uuid));
            }



            Form form = new FormUser(user, coins);

            form.ShowDialog();


        }

        private void pictureBoxCoin_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string imagesDirectory = Path.Combine(appDirectory, "images");

                // ��������� ����� images, ���� �� �� ����
                if (!Directory.Exists(imagesDirectory))
                {
                    Directory.CreateDirectory(imagesDirectory);
                }

                string fileName = Path.GetFileName(openFileDialog.FileName);
                string relativePath = Path.Combine("images", fileName);

                File.Copy(openFileDialog.FileName, relativePath, true);  // true ����������, ���� ��� ����

                pictureBoxCoin.Image = Image.FromFile(relativePath);
                _coinPicturePath = relativePath;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {


            //��������� ������
            String name = textBoxCoinName.Text;
            String path = _coinPicturePath;
            String country = textBoxCoinCountry.Text;
            String year = textBoxCoinYear.Text;
            String price = textBoxCoinPrice.Text;
            String metal = textBoxCoinMetal.Text;
            String mintage = textBoxCoinMintage.Text;

            var newCoin = new Coin
            {
                uuid = Guid.NewGuid().ToString(),
                name = name,
                path = path,
                country = country,
                year = int.Parse(year),
                price = decimal.Parse(price),
                metal = metal,
                mintage = long.Parse(mintage)
            };
            _coinsManager.AddCoin(newCoin);
            UpdateCoinsList();

        }

        private void buttonCoinRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewCoins.SelectedRows.Count == 1)
            {
                int index = dataGridViewCoins.SelectedRows[0].Index;
                var coin = _coinsManager.Coins[index];

                bool coinExists = false;

                foreach (User user in _usersManager.Users)
                {
                    foreach (String uuid in user.coins)
                    {
                        if (coin.uuid == uuid)
                        {
                            coinExists = true;
                            break;
                        }
                    }

                    if (coinExists)
                    {
                        break;
                    }
                }

                if (coinExists)
                {
                    MessageBox.Show("������ ���������������");
                    return;
                }

                _coinsManager.RemoveCoin(coin.uuid);
                UpdateCoinsList();
            }
            else
            {
                MessageBox.Show("������� ������ ��� ���������!");
            }


        }

        private void buttonCoinView_Click(object sender, EventArgs e)
        {
            if (dataGridViewCoins.SelectedRows.Count != 1)
            {
                MessageBox.Show("������� ������� ������ ���� �����!");
                return;
            }

            int index = dataGridViewCoins.SelectedRows[0].Index;
            Coin selectedCoin = _coinsManager.Coins[index];

            Form formCoins = new FormCoin(selectedCoin);

            formCoins.ShowDialog();
        }

        private async void buttonCoinsSave_Click(object sender, EventArgs e)
        {
            await _coinsManager.SaveAsync();
            MessageBox.Show("���� ����� ������ ���������!");
        }

        private void buttonUserChange_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count != 1)
            {
                MessageBox.Show("������� ������� ���� ����� ��� �����������!");
                return;
            }

            int index = dataGridViewUser.SelectedRows[0].Index;

            if (index < 0 || index >= _usersManager.Users.Count)
            {
                MessageBox.Show("����������� ������ �����������!");
                return;
            }

            // �������� ����������� � ������
            var user = _usersManager.Users[index];

            // ������� ��� �������� � ��������� ���� (��� ����� ���� �����)
            string newName = textBoxUserName.Text;
            string newEmail = textBoxUserEmail.Text;
            string newCountry = textBoxUserCountry.Text;
            string newPhone = textBoxUserPhone.Text;

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newCountry) || string.IsNullOrWhiteSpace(newPhone))
            {
                MessageBox.Show("���� �����, �������� �� ����!");
                return;
            }

            // ��������� ��� �����������
            user.name = newName;
            user.country = newCountry;
            user.phone = newPhone;
            user.email = newEmail;


            // ��������� ����������� ������
            UpdateUsersList();

            MessageBox.Show("����������� ��������!");
        }

        private void buttonCoinChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewCoins.SelectedRows.Count != 1)
            {
                MessageBox.Show("������� ������� ���� ������ ��� �����������!");
                return;
            }

            int index = dataGridViewCoins.SelectedRows[0].Index;

            if (index < 0 || index >= _coinsManager.Coins.Count)
            {
                MessageBox.Show("����������� ������ ������!");
                return;
            }

            // �������� ������ � ������
            var coin = _coinsManager.Coins[index];

            // ������� ��� �������� � ���� �����
            string newName = textBoxCoinName.Text;
            string newPath = pictureBoxCoin.Image?.Tag?.ToString() ?? coin.path;
            string newCountry = textBoxCoinCountry.Text;
            string yearText = textBoxCoinYear.Text;
            string priceText = textBoxCoinPrice.Text;
            string metal = textBoxCoinMetal.Text;
            string mintageText = textBoxCoinMintage.Text;

            if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newCountry) ||
                string.IsNullOrWhiteSpace(yearText) || string.IsNullOrWhiteSpace(priceText) ||
                string.IsNullOrWhiteSpace(metal) || string.IsNullOrWhiteSpace(mintageText))
            {
                MessageBox.Show("���� �����, �������� �� ����!");
                return;
            }

            if (!int.TryParse(yearText, out int newYear) ||
                !decimal.TryParse(priceText, out decimal newPrice) ||
                !long.TryParse(mintageText, out long newMintage))
            {
                MessageBox.Show("��������� ������ ��������!");
                return;
            }

            // ��������� ��� ������
            coin.name = newName;
            coin.path = newPath;
            coin.country = newCountry;
            coin.year = newYear;
            coin.price = newPrice;
            coin.metal = metal;
            coin.mintage = newMintage;


            // ��������� ������ ����� � DataGridView
            UpdateCoinsList();

            MessageBox.Show("��� ������ ������ ��������!");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count != 1)
            {
                MessageBox.Show("������� ������ ����������� ��� ����������!");
                return;
            }

            int index = dataGridViewUser.SelectedRows[0].Index;


            _ownUser = _usersManager.Users[index];

            _own = new Own
            {
                Uuid = _ownUser.uuid,
                Name = _ownUser.name
            };

            UpdateMainTab();

            string json = JsonSerializer.Serialize(_own, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync("own.json", json);

            MessageBox.Show("����������� ��������� � own.json!");
        }

        private void buttonCoinView2_Click(object sender, EventArgs e)
        {
            if (dataGridViewOwn.SelectedRows.Count != 1)
            {
                MessageBox.Show("������� ������� ��� ���� ������ ��� ���������!");
                return;
            }

            int ind = dataGridViewOwn.SelectedRows[0].Index;

            string uuid = _ownUser.coins[ind];

            //������ �� uuid
            Coin? selectedCoin = _coinsManager.GetCoin(uuid);

            if (selectedCoin == null)
            {
                MessageBox.Show("������ �� ��������.");
                return;
            }


            Form formCoins = new FormCoin(selectedCoin);

            formCoins.ShowDialog();
        }

        private void buttonUserAddCoins_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count != 1)
            {
                MessageBox.Show("������� ������� ��� ������ ����������� ��� ���������!");
                return;
            }

            //������ ������ ����������� �� ������� �������� �����
            int selectedIndex = dataGridViewUser.SelectedRows[0].Index;

            var selectedUser = _usersManager.Users[selectedIndex];

            // ��������� � �������� �����
            var formSelect = new FormSelectCoin(_coinsManager.Coins, selectedUser.coins, _coinsManager);
            if (formSelect.ShowDialog() == DialogResult.OK)
            {
                // ���������� ������ ������
                Coin selectedCoin = formSelect.SelectedCoin;
                MessageBox.Show($"�� ������� ������: {selectedCoin.name} ({selectedCoin.uuid})");
                selectedUser.coins.Add(selectedCoin.uuid);
            }
            else
            {
                MessageBox.Show("���� �������.");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
