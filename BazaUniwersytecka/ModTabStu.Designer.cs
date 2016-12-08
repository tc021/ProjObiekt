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
            this.AddTable = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.ViewList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj Tabele";
            // 
            // AddTabBox
            // 
            this.AddTabBox.Location = new System.Drawing.Point(31, 92);
            this.AddTabBox.Name = "AddTabBox";
            this.AddTabBox.Size = new System.Drawing.Size(100, 20);
            this.AddTabBox.TabIndex = 1;
            // 
            // AddTable
            // 
            this.AddTable.Location = new System.Drawing.Point(31, 118);
            this.AddTable.Name = "AddTable";
            this.AddTable.Size = new System.Drawing.Size(100, 23);
            this.AddTable.TabIndex = 2;
            this.AddTable.Text = "Dodaj Tabele";
            this.AddTable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwa tabeli";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(112, 255);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Wyjdź";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(31, 255);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "Cofnij";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // ViewList
            // 
            this.ViewList.Location = new System.Drawing.Point(31, 159);
            this.ViewList.Name = "ViewList";
            this.ViewList.Size = new System.Drawing.Size(100, 68);
            this.ViewList.TabIndex = 6;
            this.ViewList.Text = "Zobacz Tabelę Studenci";
            this.ViewList.UseVisualStyleBackColor = true;
            // 
            // ModTabStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 306);
            this.Controls.Add(this.ViewList);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddTable);
            this.Controls.Add(this.AddTabBox);
            this.Controls.Add(this.label1);
            this.Name = "ModTabStu";
            this.Text = "ModTabStu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddTabBox;
        private System.Windows.Forms.Button AddTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button ViewList;
    }
}