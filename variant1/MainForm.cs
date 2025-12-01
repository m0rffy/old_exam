using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace variant1
{
    public partial class MainForm : Form
    {
        public string connectionString = "Server=DESKTOP-3EQEMUL\\SQLEXPRESS;Database=variant_pavlik;Trusted_Connection=True;"; //строка подключения к базе данных

        public MainForm()
        {
            InitializeComponent();
            LoadPartners();
        }

      
        public void LoadPartners()
        {
            string query = @"SELECT pt.[Тип продукции], p.[Наименование продукции], p.[Артикул], p.[Минимальная стоимость для партнера], p.[Ширина рулона, м], p.[id_products]
                             FROM Products p JOIN Product_type pt ON p.[Тип продукции] = pt.[id_product_type]";
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var card = new panel(this);

                    card.SetData(
                        reader["Тип продукции"].ToString(),
                        reader["Наименование продукции"].ToString(),
                        reader["Артикул"].ToString(),
                        reader["Минимальная стоимость для партнера"].ToString(),
                        reader["Ширина рулона, м"].ToString(),
                        reader["id_products"].ToString()
                    );
                    flowLayoutPanelCardsForm.Controls.Add(card);
                }
            }
        }

        public void FormUpdate(object sender, EventArgs e)
        {
            flowLayoutPanelCardsForm.Controls.Clear();
            LoadPartners();
        }

        public void AddButton_Click_1(object sender, EventArgs e)
        {
            var forma = new UpdateInputForm();
            forma.FormClosed += FormUpdate;
            forma.SetData();
            forma.ShowDialog();
        }
    }
}