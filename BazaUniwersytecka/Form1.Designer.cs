namespace BazaUniwersytecka
{
    partial class LoginWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Logowanie = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Logowanie
            // 
            this.Logowanie.Location = new System.Drawing.Point(42, 167);
            this.Logowanie.Name = "Logowanie";
            this.Logowanie.Size = new System.Drawing.Size(660, 47);
            this.Logowanie.TabIndex = 0;
            this.Logowanie.Text = "Zaloguj się";
            this.Logowanie.UseVisualStyleBackColor = true;
            this.Logowanie.Click += new System.EventHandler(this.Logowanie_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(317, 247);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(99, 29);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Wyjście";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(365, 45);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(215, 20);
            this.LoginBox.TabIndex = 3;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(365, 87);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(215, 20);
            this.PassBox.TabIndex = 4;
            this.PassBox.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(168, 45);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(97, 13);
            this.Login.TabIndex = 5;
            this.Login.Text = "Login Uzytkownika";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(168, 87);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 13);
            this.Password.TabIndex = 6;
            this.Password.Text = "Hasło Użytkownika";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 306);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Logowanie);
            this.Name = "LoginWindow";
            this.Text = "Baza Uniwersytecka";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Logowanie;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Password;
    }
}

