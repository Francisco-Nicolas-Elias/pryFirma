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
            Pen l�piz = new Pen(Color.Black);
            papel.DrawRectangle(l�piz, 10, 10, 100, 50);
            papel.DrawRectangle(l�piz, 10, 75, 100, 100);
            papel.DrawEllipse(l�piz, 120, 10, 100, 50);
            papel.DrawLine(l�piz, 200, 75, 100, 100);
            papel.DrawLine(l�piz, -200, 0, 100, 100);
        }
    }
}