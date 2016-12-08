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
            this.SetStudentMark = new System.Windows.Forms.Button();
            this.WorkersList = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.StudentSearch = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentList
            // 
            this.StudentList.Location = new System.Drawing.Point(71, 3);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(583, 47);
            this.StudentList.TabIndex = 0;
            this.StudentList.Text = "Lista Studentow";
            this.StudentList.UseVisualStyleBackColor = true;
            this.StudentList.Click += new System.EventHandler(this.StudentList_Click);
            // 
            // SetStudentMark
            // 
            this.SetStudentMark.Location = new System.Drawing.Point(71, 109);
            this.SetStudentMark.Name = "SetStudentMark";
            this.SetStudentMark.Size = new System.Drawing.Size(583, 52);
            this.SetStudentMark.TabIndex = 1;
            this.SetStudentMark.Text = "Wystaw Studentowi Średnia";
            this.SetStudentMark.UseVisualStyleBackColor = true;
            this.SetStudentMark.Click += new System.EventHandler(this.SetStudentMark_Click);
            // 
            // WorkersList
            // 
            this.WorkersList.Location = new System.Drawing.Point(71, 167);
            this.WorkersList.Name = "WorkersList";
            this.WorkersList.Size = new System.Drawing.Size(583, 51);
            this.WorkersList.TabIndex = 2;
            this.WorkersList.Text = "Lista Pracownikow";
            this.WorkersList.UseVisualStyleBackColor = true;
            this.WorkersList.Click += new System.EventHandler(this.WorkersList_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(579, 250);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Wyloguj";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // StudentSearch
            // 
            this.StudentSearch.Location = new System.Drawing.Point(71, 56);
            this.StudentSearch.Name = "StudentSearch";
            this.StudentSearch.Size = new System.Drawing.Size(583, 47);
            this.StudentSearch.TabIndex = 4;
            this.StudentSearch.Text = "Szukaj Studenta";
            this.StudentSearch.UseVisualStyleBackColor = true;
            this.StudentSearch.Click += new System.EventHandler(this.StudentSearch_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(71, 250);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Wyjdź";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PracownikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 306);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.StudentSearch);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.WorkersList);
            this.Controls.Add(this.SetStudentMark);
            this.Controls.Add(this.StudentList);
            this.Name = "PracownikForm";
            this.Text = "PracownikForm";
            this.Load += new System.EventHandler(this.PracownikForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StudentList;
        private System.Windows.Forms.Button SetStudentMark;
        private System.Windows.Forms.Button WorkersList;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button StudentSearch;
        private System.Windows.Forms.Button Exit;
    }
}