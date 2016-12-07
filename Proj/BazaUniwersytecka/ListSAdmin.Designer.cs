namespace BazaUniwersytecka
{
    partial class ListSAdmin
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
            this.MenuBack = new System.Windows.Forms.Button();
            this.StudentList = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 266);
            this.dataGridView1.TabIndex = 3;
            // 
            // MenuBack
            // 
            this.MenuBack.Location = new System.Drawing.Point(298, 285);
            this.MenuBack.Name = "MenuBack";
            this.MenuBack.Size = new System.Drawing.Size(75, 23);
            this.MenuBack.TabIndex = 4;
            this.MenuBack.Text = "Cofnij";
            this.MenuBack.UseVisualStyleBackColor = true;
            this.MenuBack.Click += new System.EventHandler(this.MenuBack_Click);
            // 
            // StudentList
            // 
            this.StudentList.Location = new System.Drawing.Point(12, 12);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(100, 43);
            this.StudentList.TabIndex = 5;
            this.StudentList.Text = "Dodaj/Usuń Studenta";
            this.StudentList.UseVisualStyleBackColor = true;
            this.StudentList.Click += new System.EventHandler(this.StudentList_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(394, 285);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 6;
            this.exit.Text = "Wyjście";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ListSAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 356);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.MenuBack);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListSAdmin";
            this.Text = "ListSAdmin";
            this.Load += new System.EventHandler(this.ListSAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button MenuBack;
        private System.Windows.Forms.Button StudentList;
        private System.Windows.Forms.Button exit;
    }
}