﻿
namespace juego
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_Jugar = new System.Windows.Forms.Button();
            this.B_Acerca_De = new System.Windows.Forms.Button();
            this.B_como_jugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Jugar
            // 
            this.B_Jugar.Location = new System.Drawing.Point(36, 296);
            this.B_Jugar.Name = "B_Jugar";
            this.B_Jugar.Size = new System.Drawing.Size(213, 83);
            this.B_Jugar.TabIndex = 0;
            this.B_Jugar.Text = "Jugar";
            this.B_Jugar.UseVisualStyleBackColor = true;
            // 
            // B_Acerca_De
            // 
            this.B_Acerca_De.Location = new System.Drawing.Point(549, 296);
            this.B_Acerca_De.Name = "B_Acerca_De";
            this.B_Acerca_De.Size = new System.Drawing.Size(213, 83);
            this.B_Acerca_De.TabIndex = 1;
            this.B_Acerca_De.Text = "Acerca De";
            this.B_Acerca_De.UseVisualStyleBackColor = true;
            this.B_Acerca_De.Click += new System.EventHandler(this.B_Acerca_De_Click);
            // 
            // B_como_jugar
            // 
            this.B_como_jugar.Location = new System.Drawing.Point(298, 296);
            this.B_como_jugar.Name = "B_como_jugar";
            this.B_como_jugar.Size = new System.Drawing.Size(213, 83);
            this.B_como_jugar.TabIndex = 2;
            this.B_como_jugar.Text = "Instrucciones";
            this.B_como_jugar.UseVisualStyleBackColor = true;
            this.B_como_jugar.Click += new System.EventHandler(this.B_como_jugar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_como_jugar);
            this.Controls.Add(this.B_Acerca_De);
            this.Controls.Add(this.B_Jugar);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Jugar;
        private System.Windows.Forms.Button B_Acerca_De;
        private System.Windows.Forms.Button B_como_jugar;
    }
}

