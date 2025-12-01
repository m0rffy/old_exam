namespace variant1
{
    partial class panel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TypeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.MinPriceForPartnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeLabel.Location = new System.Drawing.Point(38, 9);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(44, 42);
            this.TypeLabel.TabIndex = 7;
            this.TypeLabel.Text = "Тип";
            this.TypeLabel.Click += new System.EventHandler(this.TypeLabel_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(421, 9);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(212, 42);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Наименование продукции";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticleLabel.Location = new System.Drawing.Point(38, 47);
            this.ArticleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(86, 42);
            this.ArticleLabel.TabIndex = 9;
            this.ArticleLabel.Text = "Артикул";
            this.ArticleLabel.Click += new System.EventHandler(this.ArticleLabel_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(39, 129);
            this.WidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(101, 42);
            this.WidthLabel.TabIndex = 11;
            this.WidthLabel.Text = "Ширина, м";
            this.WidthLabel.Click += new System.EventHandler(this.WidthLabel_Click);
            // 
            // MinPriceForPartnerLabel
            // 
            this.MinPriceForPartnerLabel.AutoSize = true;
            this.MinPriceForPartnerLabel.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinPriceForPartnerLabel.Location = new System.Drawing.Point(39, 87);
            this.MinPriceForPartnerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MinPriceForPartnerLabel.Name = "MinPriceForPartnerLabel";
            this.MinPriceForPartnerLabel.Size = new System.Drawing.Size(320, 42);
            this.MinPriceForPartnerLabel.TabIndex = 10;
            this.MinPriceForPartnerLabel.Text = "Минимальная стоимость для партнера";
            this.MinPriceForPartnerLabel.Click += new System.EventHandler(this.MinPriceForPartnerLabel_Click);
            // 
            // panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ArticleLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.MinPriceForPartnerLabel);
            this.Font = new System.Drawing.Font("Gabriola", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.Name = "panel";
            this.Size = new System.Drawing.Size(891, 186);
            this.Load += new System.EventHandler(this.CardsForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ArticleLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label MinPriceForPartnerLabel;
    }
}
