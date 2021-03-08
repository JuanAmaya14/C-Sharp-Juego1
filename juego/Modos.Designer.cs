
namespace juego
{
    partial class Modos
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
            this.Mouse = new System.Windows.Forms.Button();
            this.Teclado = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverAlMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que modo elijes?";
            // 
            // Mouse
            // 
            this.Mouse.Location = new System.Drawing.Point(18, 97);
            this.Mouse.Name = "Mouse";
            this.Mouse.Size = new System.Drawing.Size(108, 47);
            this.Mouse.TabIndex = 1;
            this.Mouse.Text = "Mouse";
            this.Mouse.UseVisualStyleBackColor = true;
            this.Mouse.Click += new System.EventHandler(this.Mouse_Click);
            // 
            // Teclado
            // 
            this.Teclado.Location = new System.Drawing.Point(162, 97);
            this.Teclado.Name = "Teclado";
            this.Teclado.Size = new System.Drawing.Size(108, 47);
            this.Teclado.TabIndex = 2;
            this.Teclado.Text = "Teclado";
            this.Teclado.UseVisualStyleBackColor = true;
            this.Teclado.Click += new System.EventHandler(this.Teclado_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAlMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverAlMenuToolStripMenuItem
            // 
            this.volverAlMenuToolStripMenuItem.Name = "volverAlMenuToolStripMenuItem";
            this.volverAlMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.volverAlMenuToolStripMenuItem.Text = "Volver al menu";
            this.volverAlMenuToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuToolStripMenuItem_Click);
            // 
            // Modos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(294, 174);
            this.Controls.Add(this.Teclado);
            this.Controls.Add(this.Mouse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "Modos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Mouse;
        private System.Windows.Forms.Button Teclado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuToolStripMenuItem;
    }
}