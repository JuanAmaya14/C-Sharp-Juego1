
namespace juego
{
    partial class Como_Jugar
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
            this.A_ins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A_ins
            // 
            this.A_ins.Location = new System.Drawing.Point(12, 12);
            this.A_ins.Name = "A_ins";
            this.A_ins.Size = new System.Drawing.Size(198, 76);
            this.A_ins.TabIndex = 0;
            this.A_ins.Text = "Atras";
            this.A_ins.UseVisualStyleBackColor = true;
            this.A_ins.Click += new System.EventHandler(this.A_ins_Click);
            // 
            // Como_Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.A_ins);
            this.MaximizeBox = false;
            this.Name = "Como_Jugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrucciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A_ins;
    }
}