
namespace juego
{
    partial class Acerca_De
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
            this.A_Acerca_de = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A_Acerca_de
            // 
            this.A_Acerca_de.Location = new System.Drawing.Point(12, 12);
            this.A_Acerca_de.Name = "A_Acerca_de";
            this.A_Acerca_de.Size = new System.Drawing.Size(189, 77);
            this.A_Acerca_de.TabIndex = 0;
            this.A_Acerca_de.Text = "Atras";
            this.A_Acerca_de.UseVisualStyleBackColor = true;
            this.A_Acerca_de.Click += new System.EventHandler(this.A_Acerca_de_Click);
            // 
            // Acerca_De
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.A_Acerca_de);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Acerca_De";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca De";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A_Acerca_de;
    }
}