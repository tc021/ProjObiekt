namespace BazaUniwersytecka
{
    partial class ModTabW
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddTabBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddTable = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.VievList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodanie kolmny :";
            // 
            // AddTabBox
            // 
            this.AddTabBox.Location = new System.Drawing.Point(15, 93);
            this.AddTabBox.Name = "AddTabBox";
            this.AddTabBox.Size = new System.Drawing.Size(188, 20);
            this.AddTabBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa Kolumny";
            // 
            // AddTable
            // 
            this.AddTable.Location = new System.Drawing.Point(15, 119);
            this.AddTable.Name = "AddTable";
            this.AddTable.Size = new System.Drawing.Size(108, 43);
            this.AddTable.TabIndex = 4;
            this.AddTable.Text = "Dodaj Tabele";
            this.AddTable.UseVisualStyleBackColor = true;
            this.AddTable.Click += new System.EventHandler(this.AddTable_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(15, 262);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(86, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "Cofnij";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(128, 262);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Wyjdź";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // VievList
            // 
            this.VievList.Location = new System.Drawing.Point(15, 177);
            this.VievList.Name = "VievList";
            this.VievList.Size = new System.Drawing.Size(188, 61);
            this.VievList.TabIndex = 7;
            this.VievList.Text = "Zobacz Tabele Pracownicy";
            this.VievList.UseVisualStyleBackColor = true;
            // 
            // ModTabW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 306);
            this.Controls.Add(this.VievList);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.AddTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTabBox);
            this.Controls.Add(this.label1);
            this.Name = "ModTabW";
            this.Text = "Modyfikacja Tabeli Pracownicy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddTabBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddTable;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button VievList;
    }
}