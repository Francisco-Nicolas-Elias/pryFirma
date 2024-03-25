namespace pryFirma
{
    public partial class frmFirma : Form
    {
        public frmFirma()
        {
            InitializeComponent();
        }

        private void frmFirma_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarRectangulo_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lápiz = new Pen(Color.Black);
            papel.DrawRectangle(lápiz, 10, 10, 100, 50);
            papel.DrawRectangle(lápiz, 10, 75, 100, 100);
            papel.DrawEllipse(lápiz, 120, 10, 100, 50);
            papel.DrawLine(lápiz, 200, 75, 100, 100);
            papel.DrawLine(lápiz, -200, 0, 100, 100);
            papel.DrawRectangle(lápiz, 120, 75, 100, 100);
        }

        //Creo una variable booleana para que cuando el usuario este dibujando sobre el PictureBox darle valor true
        private bool dibujando = false;

        //Creo una variable de tipo point para almacenar la posición anterior del cursor del mouse mientras el usuario 
        //dibuja
        private Point posicionAnterior;

        //Trabajo sobre el evento en el que el usuario hace click sobre el PictureBox
        private void pbFirma_MouseDown(object sender, MouseEventArgs e)
        {
            //Al poner la variable en true indíco que el usuario esta dibujando sobre el PictureBox
            dibujando = true;

            //Se actualiza con la posición del mouse en el momento que se hace click
            posicionAnterior = e.Location;

        }

        //Trabajo sobre el evento en el que el usuario mueve el mouse con el click presionado
        private void pbFirma_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                using (Graphics g = pbFirma.CreateGraphics())
                {
                    //Dibuja una línea desde la posición anterior a la posición actual
                    g.DrawLine(Pens.Black, posicionAnterior, e.Location);
                    //Actualiza la posición anterior para el próximo movimiento
                    posicionAnterior = e.Location;
                }
            }
        }

        private void pbFirma_MouseUp(object sender, MouseEventArgs e)
        {
            dibujando = false;
        }

        private void btnGuardarFirma_Click(object sender, EventArgs e)
        {
            if (pbFirma.Image != null)
            {
                //Guarda la firma en una imagen PNG
                pbFirma.Image.Save("firma.png", System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("Firma guardada correctamente.");
            }
            else
            {
                MessageBox.Show("No hay firma para guardar.");
            }
        }
    }
}