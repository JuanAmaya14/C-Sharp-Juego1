
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Como_Jugar));
            this.A_ins = new System.Windows.Forms.Button();
            this.modo1 = new System.Windows.Forms.Label();
            this.wasd = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wasd)).BeginInit();
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
            // modo1
            // 
            this.modo1.AutoSize = true;
            this.modo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modo1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.modo1.Location = new System.Drawing.Point(439, 63);
            this.modo1.Name = "modo1";
            this.modo1.Size = new System.Drawing.Size(90, 25);
            this.modo1.TabIndex = 1;
            this.modo1.Text = "Modo 1";
            // 
            // wasd
            // 
            this.wasd.Image = ((System.Drawing.Image)(resources.GetObject("wasd.Image")));
            this.wasd.Location = new System.Drawing.Point(47, 211);
            this.wasd.Name = "wasd";
            this.wasd.Size = new System.Drawing.Size(256, 189);
            this.wasd.TabIndex = 2;
            this.wasd.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(69, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controles";
            // 
            // Como_Jugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wasd);
            this.Controls.Add(this.modo1);
            this.Controls.Add(this.A_ins);
            this.MaximizeBox = false;
            this.Name = "Como_Jugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instrucciones";
            ((System.ComponentModel.ISupportInitialize)(this.wasd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A_ins;
        private System.Windows.Forms.Label modo1;
        private System.Windows.Forms.PictureBox wasd;
        private System.Windows.Forms.Label label1;
    }
}