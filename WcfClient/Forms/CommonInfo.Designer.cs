namespace WcfClient.Forms
{
    partial class CommonInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.First = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Second = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesList)).BeginInit();
            this.SuspendLayout();
            // 
            // ServicesList
            // 
            this.ServicesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ServicesList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ServicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesList.Location = new System.Drawing.Point(12, 68);
            this.ServicesList.Name = "ServicesList";
            this.ServicesList.RowHeadersWidth = 51;
            this.ServicesList.RowTemplate.Height = 24;
            this.ServicesList.Size = new System.Drawing.Size(531, 286);
            this.ServicesList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(435, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Информация с";
            // 
            // First
            // 
            this.First.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.First.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.First.Location = new System.Drawing.Point(123, 19);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(135, 27);
            this.First.TabIndex = 4;
            this.First.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "по";
            // 
            // Second
            // 
            this.Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Second.Location = new System.Drawing.Point(294, 19);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(135, 27);
            this.Second.TabIndex = 6;
            // 
            // CommonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 362);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.First);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ServicesList);
            this.Name = "CommonInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CommonInfo";
            ((System.ComponentModel.ISupportInitialize)(this.ServicesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView ServicesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker First;
        public System.Windows.Forms.DateTimePicker Second;
    }
}