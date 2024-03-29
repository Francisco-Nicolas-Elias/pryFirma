using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace pryFirma
{
    public partial class frmFirma : Form
    {
        public frmFirma()
        {
            InitializeComponent();

            // Crear un nuevo bitmap del mismo tama�o que el PictureBox
            firmaBitmap = new Bitmap(pbFirma.Width, pbFirma.Height);
            // Asignar el bitmap al PictureBox
            pbFirma.Image = firmaBitmap;
        }

        private void frmFirma_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarRectangulo_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen l�piz = new Pen(Color.Black);
            papel.DrawRectangle(l�piz, 10, 10, 100, 50);
            papel.DrawRectangle(l�piz, 10, 75, 100, 100);
            papel.DrawEllipse(l�piz, 120, 10, 100, 50);
            papel.DrawLine(l�piz, 200, 75, 100, 100);
            papel.DrawLine(l�piz, -200, 0, 100, 100);
            papel.DrawRectangle(l�piz, 120, 75, 100, 100);
        }

        //Creo una variable booleana para darle valor true cuando el usuario este dibujando sobre el PictureBox 
        private bool dibujando = false;

        private Bitmap firmaBitmap;

        //La variable de tipo Point es una estructura que representa un par de coordenadas x e y 

        //Creo una variable de tipo point para almacenar la posici�n anterior del cursor del mouse mientras el usuario 
        //dibuja
        private Point posicionAnterior;

        //Trabajo sobre el evento en el que el usuario hace click sobre el PictureBox
        private void pbFirma_MouseDown(object sender, MouseEventArgs e)
        {
            //Al poner la variable en true indico que el usuario esta dibujando sobre el PictureBox
            dibujando = true;

            //Se actualiza con la posici�n del mouse en el momento que se hace click
            posicionAnterior = e.Location;

        }

        //Trabajo sobre el evento en el que el usuario mueve el mouse con el click presionado
        private void pbFirma_MouseMove(object sender, MouseEventArgs e)
        {
            //Si est� dibujando el usuario ingresa al if 
            if (dibujando == true)
            {
                //Con el objeto Graphics del PictureBox dibuja una l�nea entre la posici�n anterior y la actual del cursor
                using (Graphics lapiz = Graphics.FromImage(firmaBitmap))
                {
                    //Dibuja una l�nea desde la posici�n anterior a la posici�n actual
                    lapiz.DrawLine(Pens.Black, posicionAnterior, e.Location);
                    //Actualiza la posici�n anterior para el pr�ximo movimiento
                    posicionAnterior = e.Location;

                    // Invalidar el �rea del PictureBox para forzar el redibujado
                    pbFirma.Invalidate();
                }
            }
        }

        //En este evento pongo en false la variable booleana para indicar que el usuario dej� de dibujar
        private void pbFirma_MouseUp(object sender, MouseEventArgs e)
        {
            dibujando = false;
        }

        private void btnGuardarFirma_Click(object sender, EventArgs e)
        {
            if (firmaBitmap != null)
            {
                try
                {
                    // Obtener la ruta de la carpeta "Imagenes Firmas" en la soluci�n
                    string carpetaFirmas = Path.Combine(Application.StartupPath, "Imagenes Firmas");
                    // Crear la carpeta si no existe
                    if (!Directory.Exists(carpetaFirmas))
                    {
                        Directory.CreateDirectory(carpetaFirmas);
                    }
                    // Guardar la firma en la carpeta "Firmas" con un nombre �nico
                    string nombreArchivo = $"firma_{DateTime.Now.ToString("yyyyMMddHHmmss")}.png";
                    string rutaArchivo = Path.Combine(carpetaFirmas, nombreArchivo);
                    firmaBitmap.Save(rutaArchivo, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Firma guardada correctamente en la carpeta Imagenes Firmas.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la firma: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay firma para guardar.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pbFirma.Invalidate();

            txtNombreFirma.Clear();
        }

        private void txtNombreFirma_TextChanged(object sender, EventArgs e)
        {
            if(txtNombreFirma.Text != "")
            {
                btnGuardarFirma.Enabled = true;
            }
            else
            {
                btnGuardarFirma.Enabled = false;
            }
        }

        /*
        private void GuardarImagen(string rutaArchivo)
        {
            try
            {
                // Crear un Bitmap del mismo tama�o que el PictureBox
                Bitmap bmp = new Bitmap(pbFirma.Width, pbFirma.Height);

                // Crear un objeto Graphics a partir del Bitmap
                using (Graphics lapiz = Graphics.FromImage(bmp))
                {
                    // Copiar el contenido del PictureBox al Bitmap- pasa como parametros las coordenadas del pct y las coordenadas donde se van a pegar en el bitmap
                    //el ultimo paarms toma el tama�o del pct que se va a copiar
                    lapiz.CopyFromScreen(pbFirma.PointToScreen(Point.Empty), Point.Empty, pbFirma.Size);
                }

                // Guardar el Bitmap como una imagen en disco
                bmp.Save(rutaArchivo, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Imagen creada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */
    }
}