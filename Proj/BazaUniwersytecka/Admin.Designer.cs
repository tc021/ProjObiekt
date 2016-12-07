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
            this.ModifyStudent = new System.Windows.Forms.Button();
            this.StudentOption = new System.Windows.Forms.Label();
            this.WorkersOption = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.WorkersList = new System.Windows.Forms.Button();
            this.SearchWorker = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentList
            // 
            this.StudentList.Location = new System.Drawing.Point(146, 22);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(233, 28);
            this.StudentList.TabIndex = 0;
            this.StudentList.Text = "Lista Studentów";
            this.StudentList.UseVisualStyleBackColor = true;
            this.StudentList.Click += new System.EventHandler(this.StudentList_Click);
            // 
            // StudSearch
            // 
            this.StudSearch.Location = new System.Drawing.Point(379, 22);
            this.StudSearch.Name = "StudSearch";
            this.StudSearch.Size = new System.Drawing.Size(233, 28);
            this.StudSearch.TabIndex = 1;
            this.StudSearch.Text = "Wyszukaj Studenta";
            this.StudSearch.UseVisualStyleBackColor = true;
            this.StudSearch.Click += new System.EventHandler(this.StudSearch_Click);
            // 
            // AddDelStud
            // 
            this.AddDelStud.Location = new System.Drawing.Point(146, 56);
            this.AddDelStud.Name = "AddDelStud";
            this.AddDelStud.Size = new System.Drawing.Size(233, 28);
            this.AddDelStud.TabIndex = 2;
            this.AddDelStud.Text = "Dodaj/Usuń Studenta";
            this.AddDelStud.UseVisualStyleBackColor = true;
            this.AddDelStud.Click += new System.EventHandler(this.AddDelStud_Click);
            // 
            // ModifyStudent
            // 
            this.ModifyStudent.Location = new System.Drawing.Point(379, 56);
            this.ModifyStudent.Name = "ModifyStudent";
            this.ModifyStudent.Size = new System.Drawing.Size(233, 28);
            this.ModifyStudent.TabIndex = 3;
            this.ModifyStudent.Text = "Modyfikuj Studenta";
            this.ModifyStudent.UseVisualStyleBackColor = true;
            this.ModifyStudent.Click += new System.EventHandler(this.ModifyStudent_Click);
            // 
            // StudentOption
            // 
            this.StudentOption.AutoSize = true;
            this.StudentOption.Location = new System.Drawing.Point(143, 6);
            this.StudentOption.Name = "StudentOption";
            this.StudentOption.Size = new System.Drawing.Size(49, 13);
            this.StudentOption.TabIndex = 4;
            this.StudentOption.Text = "Studenci";
            // 
            // WorkersOption
            // 
            this.WorkersOption.AutoSize = true;
            this.WorkersOption.Location = new System.Drawing.Point(143, 138);
            this.WorkersOption.Name = "WorkersOption";
            this.WorkersOption.Size = new System.Drawing.Size(62, 13);
            this.WorkersOption.TabIndex = 5;
            this.WorkersOption.Text = "Pracownicy";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(268, 90);
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
            // 
            // SearchWorker
            // 
            this.SearchWorker.Location = new System.Drawing.Point(379, 154);
            this.SearchWorker.Name = "SearchWorker";
            this.SearchWorker.Size = new System.Drawing.Size(233, 28);
            this.SearchWorker.TabIndex = 9;
            this.SearchWorker.Text = "Wyszukaj Pracownika";
            this.SearchWorker.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(146, 188);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(233, 28);
            this.button9.TabIndex = 10;
            this.button9.Text = "Dodaj/Usuń Pracownika";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(379, 188);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(233, 28);
            this.button10.TabIndex = 11;
            this.button10.Text = "Modyfikuj Pracownika";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(268, 222);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(233, 28);
            this.button11.TabIndex = 12;
            this.button11.Text = "Modyfikuj tabele Pracownicy";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(146, 266);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(233, 28);
            this.button12.TabIndex = 13;
            this.button12.Text = "Wyjście";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(379, 266);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(233, 28);
            this.Logout.TabIndex = 14;
            this.Logout.Text = "Wylogowanie";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 306);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.SearchWorker);
            this.Controls.Add(this.WorkersList);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.WorkersOption);
            this.Controls.Add(this.StudentOption);
            this.Controls.Add(this.ModifyStudent);
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
        private System.Windows.Forms.Button ModifyStudent;
        private System.Windows.Forms.Label StudentOption;
        private System.Windows.Forms.Label WorkersOption;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button WorkersList;
        private System.Windows.Forms.Button SearchWorker;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Logout;
    }
}