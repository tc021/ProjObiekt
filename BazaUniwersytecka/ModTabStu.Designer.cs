namespace BazaUniwersytecka
{
    partial class ModTabStu
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
            this.label3 = new System.Windows.Forms.Label();
            this.DelBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DelTable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodanie kolmny :";
            // 
            // AddTabBox
            // 
            this.AddTabBox.Location = new System.Drawing.Point(317, 69);
            this.AddTabBox.Name = "AddTabBox";
            this.AddTabBox.Size = new System.Drawing.Size(100, 20);
            this.AddTabBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwa Kolumny";
            // 
            // AddTable
            // 
            this.AddTable.Location = new System.Drawing.Point(316, 95);
            this.AddTable.Name = "AddTable";
            this.AddTable.Size = new System.Drawing.Size(101, 23);
            this.AddTable.TabIndex = 3;
            this.AddTable.Text = "Dodaj Tabele";
            this.AddTable.UseVisualStyleBackColor = true;
            this.AddTable.Click += new System.EventHandler(this.AddTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuwanie Kolumny:";
            // 
            // DelBox
            // 
            this.DelBox.Location = new System.Drawing.Point(317, 195);
            this.DelBox.Name = "DelBox";
            this.DelBox.Size = new System.Drawing.Size(100, 20);
            this.DelBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nazwa Kolumny";
            // 
            // DelTable
            // 
            this.DelTable.Location = new System.Drawing.Point(316, 221);
            this.DelTable.Name = "DelTable";
            this.DelTable.Size = new System.Drawing.Size(101, 23);
            this.DelTable.TabIndex = 8;
            this.DelTable.Text = "Usuń Tabele";
            this.DelTable.UseVisualStyleBackColor = true;
            this.DelTable.Click += new System.EventHandler(this.DelTable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 104);
            this.button1.TabIndex = 9;
            this.button1.Text = "Zobacz tabele studenci";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(244, 250);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 10;
            this.Back.Text = "Cofnij";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(409, 250);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Wyjdź";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ModTabStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 306);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DelTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DelBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTabBox);
            this.Controls.Add(this.label1);
            this.Name = "ModTabStu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Modyfikacja Tabeli Studenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddTabBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddTable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DelBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DelTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Exit;
    }
}