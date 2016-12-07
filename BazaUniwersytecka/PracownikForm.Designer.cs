namespace BazaUniwersytecka
{
    partial class PracownikForm
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
            this.StudentList = new System.Windows.Forms.Button();
            this.StudentDelete = new System.Windows.Forms.Button();
            this.WorkersList = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.StudentSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentList
            // 
            this.StudentList.Location = new System.Drawing.Point(170, 3);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(583, 47);
            this.StudentList.TabIndex = 0;
            this.StudentList.Text = "Lista Studentow";
            this.StudentList.UseVisualStyleBackColor = true;
            // 
            // StudentDelete
            // 
            this.StudentDelete.Location = new System.Drawing.Point(170, 109);
            this.StudentDelete.Name = "StudentDelete";
            this.StudentDelete.Size = new System.Drawing.Size(583, 52);
            this.StudentDelete.TabIndex = 1;
            this.StudentDelete.Text = "Usuń Studenta";
            this.StudentDelete.UseVisualStyleBackColor = true;
            // 
            // WorkersList
            // 
            this.WorkersList.Location = new System.Drawing.Point(170, 167);
            this.WorkersList.Name = "WorkersList";
            this.WorkersList.Size = new System.Drawing.Size(583, 51);
            this.WorkersList.TabIndex = 2;
            this.WorkersList.Text = "Lista Pracownikow";
            this.WorkersList.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(414, 250);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Wyloguj";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // StudentSearch
            // 
            this.StudentSearch.Location = new System.Drawing.Point(170, 56);
            this.StudentSearch.Name = "StudentSearch";
            this.StudentSearch.Size = new System.Drawing.Size(583, 47);
            this.StudentSearch.TabIndex = 4;
            this.StudentSearch.Text = "Szukaj Studenta";
            this.StudentSearch.UseVisualStyleBackColor = true;
            // 
            // PracownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 285);
            this.Controls.Add(this.StudentSearch);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.WorkersList);
            this.Controls.Add(this.StudentDelete);
            this.Controls.Add(this.StudentList);
            this.Name = "PracownikForm";
            this.Text = "PracownikForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentList;
        private System.Windows.Forms.Button StudentDelete;
        private System.Windows.Forms.Button WorkersList;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button StudentSearch;
    }
}