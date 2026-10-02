namespace TechRent.WinForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.btnBetoltes = new System.Windows.Forms.Button();
            this.dataGridViewEszkozok = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEszkozok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBetoltes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBetoltes.FlatAppearance.BorderSize = 0;
            this.btnBetoltes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBetoltes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBetoltes.ForeColor = System.Drawing.Color.White;
            this.btnBetoltes.Location = new System.Drawing.Point(12, 12);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(180, 45);
            this.btnBetoltes.TabIndex = 0;
            this.btnBetoltes.Text = "Eszközök betöltése";
            this.btnBetoltes.UseVisualStyleBackColor = false;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // dataGridViewEszkozok
            // 
            this.dataGridViewEszkozok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEszkozok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEszkozok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEszkozok.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEszkozok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEszkozok.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEszkozok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            // Fejléc stílus
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEszkozok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEszkozok.ColumnHeadersHeight = 40;
            this.dataGridViewEszkozok.EnableHeadersVisualStyles = false;

            this.dataGridViewEszkozok.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewEszkozok.Name = "dataGridViewEszkozok";
            this.dataGridViewEszkozok.RowHeadersVisible = false;

            // Cellák és kijelölés stílusa
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewEszkozok.DefaultCellStyle = dataGridViewCellStyle3;

            // Váltakozó sorszínek
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.dataGridViewEszkozok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;

            this.dataGridViewEszkozok.RowTemplate.Height = 35;
            this.dataGridViewEszkozok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEszkozok.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewEszkozok.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.dataGridViewEszkozok);
            this.Controls.Add(this.btnBetoltes);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechRent Adminisztráció";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEszkozok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.DataGridView dataGridViewEszkozok;
    }
}