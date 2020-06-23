namespace WcfClient
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.автосервисыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StoList = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСТОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУслугуКСТОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаПоСТОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eckeubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокУслугToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьУслугуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автомобилиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАвтомобилейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАвтомобильToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsList = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автосервисыToolStripMenuItem,
            this.eckeubToolStripMenuItem,
            this.автомобилиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // автосервисыToolStripMenuItem
            // 
            this.автосервисыToolStripMenuItem.Checked = true;
            this.автосервисыToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.автосервисыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StoList,
            this.добавитьСТОToolStripMenuItem,
            this.добавитьУслугуКСТОToolStripMenuItem,
            this.статистикаПоСТОToolStripMenuItem});
            this.автосервисыToolStripMenuItem.Name = "автосервисыToolStripMenuItem";
            this.автосервисыToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.автосервисыToolStripMenuItem.Text = "СТО";
            // 
            // StoList
            // 
            this.StoList.Name = "StoList";
            this.StoList.Size = new System.Drawing.Size(248, 26);
            this.StoList.Text = "Список СТО";
            this.StoList.Click += new System.EventHandler(this.списокСТОToolStripMenuItem_Click);
            // 
            // добавитьСТОToolStripMenuItem
            // 
            this.добавитьСТОToolStripMenuItem.Name = "добавитьСТОToolStripMenuItem";
            this.добавитьСТОToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.добавитьСТОToolStripMenuItem.Text = "Добавить СТО";
            this.добавитьСТОToolStripMenuItem.Click += new System.EventHandler(this.добавитьСТОToolStripMenuItem_Click);
            // 
            // добавитьУслугуКСТОToolStripMenuItem
            // 
            this.добавитьУслугуКСТОToolStripMenuItem.Name = "добавитьУслугуКСТОToolStripMenuItem";
            this.добавитьУслугуКСТОToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.добавитьУслугуКСТОToolStripMenuItem.Text = "Добавить услугу к СТО";
            this.добавитьУслугуКСТОToolStripMenuItem.Click += new System.EventHandler(this.добавитьУслугуКСТОToolStripMenuItem_Click);
            // 
            // статистикаПоСТОToolStripMenuItem
            // 
            this.статистикаПоСТОToolStripMenuItem.Name = "статистикаПоСТОToolStripMenuItem";
            this.статистикаПоСТОToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.статистикаПоСТОToolStripMenuItem.Text = "Статистика всех СТО";
            // 
            // eckeubToolStripMenuItem
            // 
            this.eckeubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокУслугToolStripMenuItem,
            this.добавитьУслугуToolStripMenuItem});
            this.eckeubToolStripMenuItem.Name = "eckeubToolStripMenuItem";
            this.eckeubToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.eckeubToolStripMenuItem.Text = "Услуги";
            // 
            // списокУслугToolStripMenuItem
            // 
            this.списокУслугToolStripMenuItem.Name = "списокУслугToolStripMenuItem";
            this.списокУслугToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.списокУслугToolStripMenuItem.Text = "Список услуг";
            this.списокУслугToolStripMenuItem.Click += new System.EventHandler(this.списокУслугToolStripMenuItem_Click);
            // 
            // добавитьУслугуToolStripMenuItem
            // 
            this.добавитьУслугуToolStripMenuItem.Name = "добавитьУслугуToolStripMenuItem";
            this.добавитьУслугуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьУслугуToolStripMenuItem.Text = "Добавить услугу";
            this.добавитьУслугуToolStripMenuItem.Click += new System.EventHandler(this.добавитьУслугуToolStripMenuItem_Click);
            // 
            // автомобилиToolStripMenuItem
            // 
            this.автомобилиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокАвтомобилейToolStripMenuItem,
            this.добавитьАвтомобильToolStripMenuItem});
            this.автомобилиToolStripMenuItem.Name = "автомобилиToolStripMenuItem";
            this.автомобилиToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.автомобилиToolStripMenuItem.Text = "Автомобили";
            // 
            // списокАвтомобилейToolStripMenuItem
            // 
            this.списокАвтомобилейToolStripMenuItem.Name = "списокАвтомобилейToolStripMenuItem";
            this.списокАвтомобилейToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.списокАвтомобилейToolStripMenuItem.Text = "Список автомобилей";
            this.списокАвтомобилейToolStripMenuItem.Click += new System.EventHandler(this.списокАвтомобилейToolStripMenuItem_Click);
            // 
            // добавитьАвтомобильToolStripMenuItem
            // 
            this.добавитьАвтомобильToolStripMenuItem.Name = "добавитьАвтомобильToolStripMenuItem";
            this.добавитьАвтомобильToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.добавитьАвтомобильToolStripMenuItem.Text = "Добавить автомобиль";
            this.добавитьАвтомобильToolStripMenuItem.Click += new System.EventHandler(this.добавитьАвтомобильToolStripMenuItem_Click);
            // 
            // ItemsList
            // 
            this.ItemsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ItemsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ItemsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsList.Location = new System.Drawing.Point(12, 31);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.RowHeadersWidth = 51;
            this.ItemsList.RowTemplate.Height = 24;
            this.ItemsList.Size = new System.Drawing.Size(674, 262);
            this.ItemsList.TabIndex = 4;
            this.ItemsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ItemsList_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 307);
            this.Controls.Add(this.ItemsList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WcfClient";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem автосервисыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eckeubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem автомобилиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСТОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьУслугуКСТОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаПоСТОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьУслугуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАвтомобильToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StoList;
        private System.Windows.Forms.ToolStripMenuItem списокУслугToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокАвтомобилейToolStripMenuItem;
        public System.Windows.Forms.DataGridView ItemsList;
    }
}

