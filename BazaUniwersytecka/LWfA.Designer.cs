namespace BazaUniwersytecka
{
    partial class LWfA
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.DodUs = new System.Windows.Forms.Button();
            this.ModT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(339, 274);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Cofnij";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DodUs
            // 
            this.DodUs.Location = new System.Drawing.Point(22, 12);
            this.DodUs.Name = "DodUs";
            this.DodUs.Size = new System.Drawing.Size(75, 41);
            this.DodUs.TabIndex = 3;
            this.DodUs.Text = "Dodaj Usuń Pracownika";
            this.DodUs.UseVisualStyleBackColor = true;
            this.DodUs.Click += new System.EventHandler(this.DodUs_Click);
            // 
            // ModT
            // 
            this.ModT.Location = new System.Drawing.Point(22, 69);
            this.ModT.Name = "ModT";
            this.ModT.Size = new System.Drawing.Size(75, 41);
            this.ModT.TabIndex = 4;
            this.ModT.Text = "Modyfikuj Tabele";
            this.ModT.UseVisualStyleBackColor = true;
            // 
            // LWfA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 306);
            this.Controls.Add(this.ModT);
            this.Controls.Add(this.DodUs);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LWfA";
            this.Text = "LWfA";
            this.Load += new System.EventHandler(this.LWfA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button DodUs;
        private System.Windows.Forms.Button ModT;
    }
}