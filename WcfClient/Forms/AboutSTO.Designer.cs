namespace WcfClient.Forms
{
    partial class AboutSTO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServicesList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesList)).BeginInit();
            this.SuspendLayout();
            // 
            // ServicesList
            // 
            this.ServicesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ServicesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ServicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesList.Location = new System.Drawing.Point(12, 12);
            this.ServicesList.Name = "ServicesList";
            this.ServicesList.RowHeadersWidth = 51;
            this.ServicesList.RowTemplate.Height = 24;
            this.ServicesList.Size = new System.Drawing.Size(608, 286);
            this.ServicesList.TabIndex = 0;
            // 
            // AboutSTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 310);
            this.Controls.Add(this.ServicesList);
            this.Name = "AboutSTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutSTO";
            this.Load += new System.EventHandler(this.AboutSTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServicesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView ServicesList;
    }
}