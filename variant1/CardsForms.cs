using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace variant1
{

    public partial class panel : UserControl
    {
        public string connectionString = "Server=DESKTOP-3EQEMUL\\SQLEXPRESS;Database=variant_pavlik;Trusted_Connection=True;";
        private MainForm mainform;
        string type, name, article, min_price_for_partner, width, id;

        public panel(MainForm form)
        {
            InitializeComponent();
            this.mainform = form;
            mainform = form;
        }

        private void ArticleLabel_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void PriceLabel_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void TypeLabel_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void MinPriceForPartnerLabel_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void WidthLabel_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        public void CardsForms_Load(object sender, EventArgs e)
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

            TypeLabel.Text = $"Тип: {type}";
            NameLabel.Text = $"Наименование: {name}";
            ArticleLabel.Text = $"Артикул: {article}";
            MinPriceForPartnerLabel.Text = $"Минимальная цена для партнера: {min_price_for_partner}";
            WidthLabel.Text = $"Ширина, м: {width}";
        }

        public void UpdateData()
        {
            var forma = new UpdateInputForm();
            forma.SetData(type, name, article, min_price_for_partner, width, id);
            forma.FormClosed += mainform.FormUpdate;
            forma.Show();
        }
        
    }
}
