using System.Reflection;
using System.Text.Json;  
using System.Windows.Forms;

namespace CoinCollection
{


    public partial class Form1 : Form
    {
        private string jsonFilePathUsers = "users.json";
        private string jsonFilePathCoins = "coins.json";
        public Form1()
        {
            InitializeComponent();
            LoadDataFromJson<Person>(jsonFilePathUsers, dataGridViewUser);
            LoadDataFromJson<Coins>(jsonFilePathCoins, dataGridViewCoins);
        }


        public class Person
        {
            //для тесту
            public string name { get; set; }
            public string country { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
        }


        public class Coins
        {
            //для тесту
            public string name { get; set; }
            public string path { get; set; }
            public string country { get; set; }
            public string year { get; set; }
            public string price { get; set; }
            public string metal { get; set; }
            public string mintage { get; set; }
        }


        private void LoadDataFromJson<T>(string filePath, DataGridView grid)
        {

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                //List<People> people = JsonSerializer.Deserialize<List<T>>(json);
                List<T> items = JsonSerializer.Deserialize<List<T>>(json);

                // Додаємо рядки
                //foreach (var person in people)
                //{
                //    dataGridViewUser.Rows.Add(person.name, person.email, person.phone, person.country);
                //}

                foreach (var item in items)
                {
                    // Отримаємо значення властивостей для цього рядка
                    PropertyInfo[] properties = typeof(T).GetProperties();
                    object[] values = properties.Select(p => p.GetValue(item)?.ToString()).ToArray();
                    // Додаємо рядок у DataGridView
                    grid.Rows.Add(values);
                }

            }
        }


        private void SaveDataToJson<T>(string filePath, DataGridView grid) where T : new()
        {
            List<T> items = new List<T>();

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow)
                {
                    T obj = new T();  // Створюємо новий об'єкт типу T
                    PropertyInfo[] properties = typeof(T).GetProperties();

                    for (int i = 0; i < properties.Length; i++)
                    {
                        if (row.Cells[i].Value != null)
                        {
                            // Перетворюємо значення клітинки у властивість об'єкта
                            properties[i].SetValue(obj, row.Cells[i].Value.ToString());
                        }
                    }

                    items.Add(obj);
                }
            }

            string json = JsonSerializer.Serialize(items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            MessageBox.Show("Успішно збережено!");
        }




        private void buttonUserAdd_Click(object sender, EventArgs e)
        {
            String name = textBoxUserName.Text;
            String email = textBoxUserEmail.Text;
            String phone = textBoxUserPhone.Text;
            String country = textBoxUserCountry.Text;

            if (name.Length == 0 || email.Length == 0 || phone.Length == 0 || country.Length == 0)
            {
                MessageBox.Show("Дані не можуть бути пустими!");
                return;
            }

            dataGridViewUser.Rows.Add(name, email, phone, country);
        }

        private void buttonUserRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Не виділено ні одного рядка!");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewUser.SelectedRows)
            {
                dataGridViewUser.Rows.Remove(row);
            }
        }

        private void buttonUserChange_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count != 1)
            {
                MessageBox.Show("Потрібно виділити всього один рядок!");
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
            MessageBox.Show("Зміни успішно внесено!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveDataToJson<Person>(jsonFilePathUsers, dataGridViewUser);
        }

        private void buttonUserShow_Click(object sender, EventArgs e)
        {
            if (dataGridViewUser.SelectedRows.Count != 1)
            {
                MessageBox.Show("Ви повинні вибрати один рядок!");
                return;
            }

            int rind = dataGridViewUser.SelectedRows[0].Index;

            String name = dataGridViewUser.Rows[rind].Cells[0].Value.ToString();
            String email = dataGridViewUser.Rows[rind].Cells[1].Value.ToString();
            String phone = dataGridViewUser.Rows[rind].Cells[2].Value.ToString();
            String country = dataGridViewUser.Rows[rind].Cells[3].Value.ToString();

            Form form = new FormUser(name, email, phone, country);

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

                // Створюємо папку images, якщо її ще немає
                if (!Directory.Exists(imagesDirectory))
                {
                    Directory.CreateDirectory(imagesDirectory);
                }

                string fileName = Path.GetFileName(openFileDialog.FileName);
                string destPath = Path.Combine(imagesDirectory, fileName);

                File.Copy(openFileDialog.FileName, destPath, true);  // true перезапише, якщо вже існує

                pictureBoxCoin.Image = Image.FromFile(destPath);
                pictureBoxCoin.Tag = destPath;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            //додавання монети
            String name = textBoxCoinName.Text;
            String path = pictureBoxCoin.Image.Tag as String;
            String country = textBoxCoinCountry.Text;
            String year = textBoxCoinYear.Text;
            String price = textBoxCoinPrice.Text;
            String metal = textBoxCoinMetal.Text;
            String mintage = textBoxCoinMintage.Text;



            dataGridViewCoins.Rows.Add(name, path, country, year, price, metal, mintage);
        }

        private void buttonCoinRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewCoins.SelectedRows.Count != 1)
            {
                MessageBox.Show("Ви повинні вибрати один рядок!");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewCoins.SelectedRows)
            {
                dataGridViewUser.Rows.Remove(row);
            }

        }

        private void buttonCoinView_Click(object sender, EventArgs e)
        {
            if (dataGridViewCoins.SelectedRows.Count != 1)
            {
                MessageBox.Show("Потрібно виділити всього один рядок!");
                return;
            }



            Form formCoins = new FormCoin();

            formCoins.ShowDialog();
        }

        private void buttonCoinsSave_Click(object sender, EventArgs e)
        {
            SaveDataToJson<Coins>(jsonFilePathCoins, dataGridViewCoins);
        }
    }
}
