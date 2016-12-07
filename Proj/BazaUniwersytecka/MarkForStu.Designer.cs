namespace BazaUniwersytecka
{
    partial class MarkForStu
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
            this.nrAlbumBox = new System.Windows.Forms.TextBox();
            this.FinishMark = new System.Windows.Forms.Label();
            this.markBox = new System.Windows.Forms.TextBox();
            this.SetMarkB = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer Albumu Studenta :";
            // 
            // nrAlbumBox
            // 
            this.nrAlbumBox.Location = new System.Drawing.Point(304, 53);
            this.nrAlbumBox.Name = "nrAlbumBox";
            this.nrAlbumBox.Size = new System.Drawing.Size(119, 20);
            this.nrAlbumBox.TabIndex = 1;
            // 
            // FinishMark
            // 
            this.FinishMark.AutoSize = true;
            this.FinishMark.Location = new System.Drawing.Point(301, 100);
            this.FinishMark.Name = "FinishMark";
            this.FinishMark.Size = new System.Drawing.Size(93, 13);
            this.FinishMark.TabIndex = 2;
            this.FinishMark.Text = "Ocena Końcowa :";
            // 
            // markBox
            // 
            this.markBox.Location = new System.Drawing.Point(304, 127);
            this.markBox.Name = "markBox";
            this.markBox.Size = new System.Drawing.Size(119, 20);
            this.markBox.TabIndex = 3;
            // 
            // SetMarkB
            // 
            this.SetMarkB.Location = new System.Drawing.Point(304, 169);
            this.SetMarkB.Name = "SetMarkB";
            this.SetMarkB.Size = new System.Drawing.Size(119, 23);
            this.SetMarkB.TabIndex = 4;
            this.SetMarkB.Text = "Wystaw Ocene";
            this.SetMarkB.UseVisualStyleBackColor = true;
            this.SetMarkB.Click += new System.EventHandler(this.SetMarkB_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(583, 271);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 5;
            this.Back.Text = "Wróc";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // MarkForStu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 306);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SetMarkB);
            this.Controls.Add(this.markBox);
            this.Controls.Add(this.FinishMark);
            this.Controls.Add(this.nrAlbumBox);
            this.Controls.Add(this.label1);
            this.Name = "MarkForStu";
            this.Text = "MarkForStu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nrAlbumBox;
        private System.Windows.Forms.Label FinishMark;
        private System.Windows.Forms.TextBox markBox;
        private System.Windows.Forms.Button SetMarkB;
        private System.Windows.Forms.Button Back;
    }
}