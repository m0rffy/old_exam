using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace variant1
{
    public partial class UpdateInputForm : Form
    {
        string type, name, article, min_price_for_partner, width, id;
        
        bool condition; // false - редактирование true - добавление

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        public UpdateInputForm()
        {
            InitializeComponent();
            SetTypes();
        }

        private void UpdateInputForm_Load(object sender, EventArgs e)
        {

        }

        public void SetData(string type, string name, string article, string min_price_for_partner, string width, string id)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.article = article;
            this.min_price_for_partner = min_price_for_partner;
            this.width = width;

            comboBoxType.SelectedItem = type;
            NameProductText.Text = name;
            ArticleText.Text = article;
            MinPriceText.Text = min_price_for_partner;
            WidthText.Text = width;

            condition = false;
            FormProperty();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void SetData()
        {
            condition = true;
            FormProperty();
        }

        public void SetTypes()
        {
            using (SqlConnection connection = new SqlConnection(new MainForm().connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Select * from Product_type", connection))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxType.Items.Add(reader["Тип продукции"].ToString());
                        }
                    }
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(new MainForm().connectionString))
            {
                conn.Open();
                // 1. Удалить зависимые записи из таблицы Product_materials
                using (SqlCommand cmd1 = new SqlCommand(
                    "DELETE FROM Product_materials WHERE Продукция = @id", conn))
                {
                    cmd1.Parameters.AddWithValue("@id", id);
                    cmd1.ExecuteNonQuery();
                }
                // 2. Удалить саму запись из Products
                using (SqlCommand cmd2 = new SqlCommand(
                    "DELETE FROM Products WHERE id_products = @id", conn))
                {
                    cmd2.Parameters.AddWithValue("@id", id);
                    cmd2.ExecuteNonQuery();
                }
            }
            // Закрываем форму после удаления
            this.Close();
        }
        

        public void FormProperty()
        {
            if (condition)
            {
                this.Text = "Добавление сущности";
                button1.Text = "добавить";
                button1.Click += InsertData;
            }
            else
            {
                this.Text = "Изменение сущности";
                button1.Text = "изменить";
                button1.Click += UpdateData;
            }
        }

        public void InsertData(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new MainForm().connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand($"INSERT INTO Products ([Тип продукции], [Наименование продукции], [Артикул], [Минимальная стоимость для партнера], [Ширина рулона, м]) " +
                    $"VALUES ('{ConvertTypeInID()}', '{NameProductText.Text}', '{ArticleText.Text}', '{MinPriceText.Text}', '{WidthText.Text}')", connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Запись добавлена");
        }

        public void UpdateData(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new MainForm().connectionString))
            {
                connection.Open();
                
                using (SqlCommand cmd = new SqlCommand($"UPDATE Products SET [Тип продукции] = '{ConvertTypeInID()}', [Наименование продукции] = '{NameProductText.Text}', " +
                    $"[Артикул] = '{ArticleText.Text}', [Минимальная стоимость для партнера] = '{MinPriceText.Text}', [Ширина рулона, м] = '{WidthText.Text}' WHERE [id_products] = '{id}'", connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Запись изменена");
        }

        private string ConvertTypeInID()
        {
            string value;
            using (SqlConnection connection = new SqlConnection(new MainForm().connectionString))
            using (SqlCommand command = new SqlCommand($"select id_product_type from Product_type where [Тип продукции] = '{comboBoxType.Text}'", connection))
            {
                connection.Open();
                value = command.ExecuteScalar().ToString();
            }
            return value;
        }

        public void DeleteProduct(int id)
        {
            string sql = "DELETE FROM Products WHERE id_products = @id";
            using (SqlConnection conn = new SqlConnection(new MainForm().connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Запись удалена");
        }

    }
}
