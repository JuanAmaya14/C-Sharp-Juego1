
namespace juego
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.Per = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverAlMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Galleta = new System.Windows.Forms.Button();
            this.Pared_Izquierda = new System.Windows.Forms.PictureBox();
            this.Pared_Abajo = new System.Windows.Forms.PictureBox();
            this.Pared_Derecha = new System.Windows.Forms.PictureBox();
            this.Pared_Arriba = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pared_Izquierda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pared_Abajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pared_Derecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pared_Arriba)).BeginInit();
            this.SuspendLayout();
            // 
            // Per
            // 
            this.Per.BackColor = System.Drawing.Color.LimeGreen;
            this.Per.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Per.Location = new System.Drawing.Point(50, 50);
            this.Per.Name = "Per";
            this.Per.Size = new System.Drawing.Size(40, 40);
            this.Per.TabIndex = 1;
            this.Per.UseVisualStyleBackColor = false;
            this.Per.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Botones);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlMenuToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverAlMenuToolStripMenuItem
            // 
            this.volverAlMenuToolStripMenuItem.Name = "volverAlMenuToolStripMenuItem";
            this.volverAlMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.volverAlMenuToolStripMenuItem.Text = "Volver al menu";
            this.volverAlMenuToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Puntaje: 0";
            // 
            // Galleta
            // 
            this.Galleta.Image = ((System.Drawing.Image)(resources.GetObject("Galleta.Image")));
            this.Galleta.Location = new System.Drawing.Point(650, 350);
            this.Galleta.Name = "Galleta";
            this.Galleta.Size = new System.Drawing.Size(40, 40);
            this.Galleta.TabIndex = 4;
            this.Galleta.UseVisualStyleBackColor = true;
            // 
            // Pared_Izquierda
            // 
            this.Pared_Izquierda.BackColor = System.Drawing.Color.Black;
            this.Pared_Izquierda.Location = new System.Drawing.Point(0, 27);
            this.Pared_Izquierda.Name = "Pared_Izquierda";
            this.Pared_Izquierda.Size = new System.Drawing.Size(10, 426);
            this.Pared_Izquierda.TabIndex = 5;
            this.Pared_Izquierda.TabStop = false;
            // 
            // Pared_Abajo
            // 
            this.Pared_Abajo.BackColor = System.Drawing.Color.Black;
            this.Pared_Abajo.Location = new System.Drawing.Point(0, 443);
            this.Pared_Abajo.Name = "Pared_Abajo";
            this.Pared_Abajo.Size = new System.Drawing.Size(800, 10);
            this.Pared_Abajo.TabIndex = 6;
            this.Pared_Abajo.TabStop = false;
            // 
            // Pared_Derecha
            // 
            this.Pared_Derecha.BackColor = System.Drawing.Color.Black;
            this.Pared_Derecha.Location = new System.Drawing.Point(790, 27);
            this.Pared_Derecha.Name = "Pared_Derecha";
            this.Pared_Derecha.Size = new System.Drawing.Size(10, 426);
            this.Pared_Derecha.TabIndex = 7;
            this.Pared_Derecha.TabStop = false;
            // 
            // Pared_Arriba
            // 
            this.Pared_Arriba.BackColor = System.Drawing.Color.Black;
            this.Pared_Arriba.Location = new System.Drawing.Point(0, 27);
            this.Pared_Arriba.Name = "Pared_Arriba";
            this.Pared_Arriba.Size = new System.Drawing.Size(800, 10);
            this.Pared_Arriba.TabIndex = 8;
            this.Pared_Arriba.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(142, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "X: - Y:";
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pared_Arriba);
            this.Controls.Add(this.Pared_Derecha);
            this.Controls.Add(this.Pared_Abajo);
            this.Controls.Add(this.Pared_Izquierda);
            this.Controls.Add(this.Galleta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Per);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Play_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pared_Izquierda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pared_Abajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pared_Derecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pared_Arriba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Per;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Galleta;
        private System.Windows.Forms.PictureBox Pared_Izquierda;
        private System.Windows.Forms.PictureBox Pared_Abajo;
        private System.Windows.Forms.PictureBox Pared_Derecha;
        private System.Windows.Forms.PictureBox Pared_Arriba;
        private System.Windows.Forms.Label label2;
    }
}