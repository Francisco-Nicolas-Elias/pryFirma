namespace pryFirma
{
    partial class frmFirma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMostrarRectangulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(86, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 196);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMostrarRectangulo
            // 
            this.btnMostrarRectangulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarRectangulo.Location = new System.Drawing.Point(293, 287);
            this.btnMostrarRectangulo.Name = "btnMostrarRectangulo";
            this.btnMostrarRectangulo.Size = new System.Drawing.Size(85, 37);
            this.btnMostrarRectangulo.TabIndex = 1;
            this.btnMostrarRectangulo.Text = "Mostrar";
            this.btnMostrarRectangulo.UseVisualStyleBackColor = true;
            this.btnMostrarRectangulo.Click += new System.EventHandler(this.btnMostrarRectangulo_Click);
            // 
            // frmFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 409);
            this.Controls.Add(this.btnMostrarRectangulo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmFirma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnMostrarRectangulo;
    }
}