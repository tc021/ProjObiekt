namespace BazaUniwersytecka
{
    partial class StSearchA
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
            this.Insert = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.Location = new System.Drawing.Point(67, 17);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(386, 13);
            this.Insert.TabIndex = 2;
            this.Insert.Text = "Podaj jedno z wybranych danych(nrAlbumu, Imie,  Nazwisko, Wydział, Kierunek)";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(70, 33);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(606, 20);
            this.SearchBox.TabIndex = 3;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(70, 59);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "Szukaj";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(70, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 182);
            this.dataGridView1.TabIndex = 5;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(118, 276);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Cofnij";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(552, 276);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Wyjście";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StSearchA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 306);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Insert);
            this.Location = new System.Drawing.Point(67, 17);
            this.Name = "StSearchA";
            this.Text = "Wyszukiwarka studentów";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Insert;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}