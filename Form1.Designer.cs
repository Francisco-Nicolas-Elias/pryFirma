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
            pictureBox1 = new PictureBox();
            btnMostrarRectangulo = new Button();
            pbFirma = new PictureBox();
            btnGuardarFirma = new Button();
            lblFirma = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFirma).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(86, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 196);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnMostrarRectangulo
            // 
            btnMostrarRectangulo.Cursor = Cursors.Hand;
            btnMostrarRectangulo.Location = new Point(293, 287);
            btnMostrarRectangulo.Name = "btnMostrarRectangulo";
            btnMostrarRectangulo.Size = new Size(85, 37);
            btnMostrarRectangulo.TabIndex = 1;
            btnMostrarRectangulo.Text = "Mostrar";
            btnMostrarRectangulo.UseVisualStyleBackColor = true;
            btnMostrarRectangulo.Click += btnMostrarRectangulo_Click;
            // 
            // pbFirma
            // 
            pbFirma.BorderStyle = BorderStyle.FixedSingle;
            pbFirma.Location = new Point(624, 44);
            pbFirma.Name = "pbFirma";
            pbFirma.Size = new Size(332, 196);
            pbFirma.TabIndex = 2;
            pbFirma.TabStop = false;
            pbFirma.MouseDown += pbFirma_MouseDown;
            pbFirma.MouseMove += pbFirma_MouseMove;
            pbFirma.MouseUp += pbFirma_MouseUp;
            // 
            // btnGuardarFirma
            // 
            btnGuardarFirma.Cursor = Cursors.Hand;
            btnGuardarFirma.Location = new Point(862, 277);
            btnGuardarFirma.Name = "btnGuardarFirma";
            btnGuardarFirma.Size = new Size(85, 36);
            btnGuardarFirma.TabIndex = 3;
            btnGuardarFirma.Text = "Guardar";
            btnGuardarFirma.UseVisualStyleBackColor = true;
            btnGuardarFirma.Click += btnGuardarFirma_Click;
            // 
            // lblFirma
            // 
            lblFirma.AutoSize = true;
            lblFirma.Location = new Point(624, 9);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(66, 15);
            lblFirma.TabIndex = 4;
            lblFirma.Text = "Firme aquí:";
            // 
            // frmFirma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 409);
            Controls.Add(lblFirma);
            Controls.Add(btnGuardarFirma);
            Controls.Add(pbFirma);
            Controls.Add(btnMostrarRectangulo);
            Controls.Add(pictureBox1);
            Name = "frmFirma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmFirma_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFirma).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnMostrarRectangulo;
        private PictureBox pbFirma;
        private Button btnGuardarFirma;
        private Label lblFirma;
    }
}