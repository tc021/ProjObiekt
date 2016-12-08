namespace BazaUniwersytecka
{
    partial class Admin
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
            this.StudSearch = new System.Windows.Forms.Button();
            this.AddDelStud = new System.Windows.Forms.Button();
            this.StudentOption = new System.Windows.Forms.Label();
            this.WorkersOption = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.WorkersList = new System.Windows.Forms.Button();
            this.SearchWorker = new System.Windows.Forms.Button();
            this.AddDelWorkier = new System.Windows.Forms.Button();
            this.ModTabWorkers = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentList
            // 
            this.StudentList.Location = new System.Drawing.Point(146, 56);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(233, 28);
            this.StudentList.TabIndex = 0;
            this.StudentList.Text = "Lista Studentów";
            this.StudentList.UseVisualStyleBackColor = true;
            this.StudentList.Click += new System.EventHandler(this.StudentList_Click);
            // 
            // StudSearch
            // 
            this.StudSearch.Location = new System.Drawing.Point(379, 56);
            this.StudSearch.Name = "StudSearch";
            this.StudSearch.Size = new System.Drawing.Size(233, 28);
            this.StudSearch.TabIndex = 1;
            this.StudSearch.Text = "Wyszukaj Studenta";
            this.StudSearch.UseVisualStyleBackColor = true;
            this.StudSearch.Click += new System.EventHandler(this.StudSearch_Click);
            // 
            // AddDelStud
            // 
            this.AddDelStud.Location = new System.Drawing.Point(146, 90);
            this.AddDelStud.Name = "AddDelStud";
            this.AddDelStud.Size = new System.Drawing.Size(233, 28);
            this.AddDelStud.TabIndex = 2;
            this.AddDelStud.Text = "Dodaj/Usuń Studenta";
            this.AddDelStud.UseVisualStyleBackColor = true;
            this.AddDelStud.Click += new System.EventHandler(this.AddDelStud_Click);
            // 
            // StudentOption
            // 
            this.StudentOption.AutoSize = true;
            this.StudentOption.Location = new System.Drawing.Point(358, 40);
            this.StudentOption.Name = "StudentOption";
            this.StudentOption.Size = new System.Drawing.Size(49, 13);
            this.StudentOption.TabIndex = 4;
            this.StudentOption.Text = "Studenci";
            // 
            // WorkersOption
            // 
            this.WorkersOption.AutoSize = true;
            this.WorkersOption.Location = new System.Drawing.Point(358, 138);
            this.WorkersOption.Name = "WorkersOption";
            this.WorkersOption.Size = new System.Drawing.Size(62, 13);
            this.WorkersOption.TabIndex = 5;
            this.WorkersOption.Text = "Pracownicy";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(379, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 28);
            this.button5.TabIndex = 6;
            this.button5.Text = "Modyfikacja Tabeli Student";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // WorkersList
            // 
            this.WorkersList.Location = new System.Drawing.Point(146, 154);
            this.WorkersList.Name = "WorkersList";
            this.WorkersList.Size = new System.Drawing.Size(233, 28);
            this.WorkersList.TabIndex = 8;
            this.WorkersList.Text = "Lista Pracowników";
            this.WorkersList.UseVisualStyleBackColor = true;
            this.WorkersList.Click += new System.EventHandler(this.WorkersList_Click);
            // 
            // SearchWorker
            // 
            this.SearchWorker.Location = new System.Drawing.Point(379, 154);
            this.SearchWorker.Name = "SearchWorker";
            this.SearchWorker.Size = new System.Drawing.Size(233, 28);
            this.SearchWorker.TabIndex = 9;
            this.SearchWorker.Text = "Wyszukaj Pracownika";
            this.SearchWorker.UseVisualStyleBackColor = true;
            this.SearchWorker.Click += new System.EventHandler(this.SearchWorker_Click);
            // 
            // AddDelWorkier
            // 
            this.AddDelWorkier.Location = new System.Drawing.Point(146, 188);
            this.AddDelWorkier.Name = "AddDelWorkier";
            this.AddDelWorkier.Size = new System.Drawing.Size(233, 28);
            this.AddDelWorkier.TabIndex = 10;
            this.AddDelWorkier.Text = "Dodaj/Usuń Pracownika";
            this.AddDelWorkier.UseVisualStyleBackColor = true;
            this.AddDelWorkier.Click += new System.EventHandler(this.AddDelWorkier_Click);
            // 
            // ModTabWorkers
            // 
            this.ModTabWorkers.Location = new System.Drawing.Point(379, 188);
            this.ModTabWorkers.Name = "ModTabWorkers";
            this.ModTabWorkers.Size = new System.Drawing.Size(233, 28);
            this.ModTabWorkers.TabIndex = 12;
            this.ModTabWorkers.Text = "Modyfikuj tabele Pracownicy";
            this.ModTabWorkers.UseVisualStyleBackColor = true;
            this.ModTabWorkers.Click += new System.EventHandler(this.ModTabWorkers_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(146, 266);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(233, 28);
            this.button12.TabIndex = 13;
            this.button12.Text = "Wyjście";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(379, 266);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(233, 28);
            this.logout.TabIndex = 14;
            this.logout.Text = "Wylogowanie";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 306);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.ModTabWorkers);
            this.Controls.Add(this.AddDelWorkier);
            this.Controls.Add(this.SearchWorker);
            this.Controls.Add(this.WorkersList);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.WorkersOption);
            this.Controls.Add(this.StudentOption);
            this.Controls.Add(this.AddDelStud);
            this.Controls.Add(this.StudSearch);
            this.Controls.Add(this.StudentList);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentList;
        private System.Windows.Forms.Button StudSearch;
        private System.Windows.Forms.Button AddDelStud;
        private System.Windows.Forms.Label StudentOption;
        private System.Windows.Forms.Label WorkersOption;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button WorkersList;
        private System.Windows.Forms.Button SearchWorker;
        private System.Windows.Forms.Button AddDelWorkier;
        private System.Windows.Forms.Button ModTabWorkers;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button logout;
    }
}