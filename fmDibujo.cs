using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Dibujar
{
    public partial class fmDibujo : Form
    {
        public fmDibujo()
        {
            InitializeComponent();
        }

        private void fmDibujo_Load(object sender, EventArgs e)
        {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height); // Creamos objeto bitmap
            imEditor = Graphics.FromImage(mig); //Asociamos el bitmap con el graphics
            penGrosor = new Pen(Color.Black, 2); // Valores iniciales del pen
            brushRelleno = new SolidBrush(Color.FromArgb(255, 255, 255));
            Text = "Dibujo1"; // Nombre propuesto para el gráfico
            tsl2.Text = "Grosor Linea: " + penGrosor.Width.ToString();
        }

        private void pbEditor_MouseDown(object sender, MouseEventArgs e)
        {
            stGrafico.Items[0].Text = Convert.ToString(e.X) + " " + Convert.ToString(e.Y);
            pbEditor.Image = (Image)mig;

            if ((e.Button == MouseButtons.Left) && (e.X < pbEditor.Width && e.Y < pbEditor.Height && e.Y >= 0 && e.X >= 0))
            {
                ((Bitmap)pbEditor.Image).SetPixel(e.X, e.Y, Color.FromArgb(rojo, verde, azul));
            }
        }

        private void btProbar_Click(object sender, EventArgs e)
        {
            if (pnPrueba.Enabled = !pnPrueba.Enabled)
            {
                btProbar.Text = "Probar Colores";
            }
            else
            {
                btProbar.Text = "No Probar Colores";
            }
        }


        void poncolor(Label milabel, int derojo, int deverde, int deazul)
        { //prueba de color en el fondo del label
            milabel.BackColor = Color.FromArgb(derojo, deverde, deazul);
            // color complementario para la fuente del label

            milabel.ForeColor = Color.FromArgb(255 - derojo, 255 - deverde, 255 - deazul);
        }

        private void tbRojo_Scroll(object sender, EventArgs e)
        {

            // Intensidad de cada color en label y valor numérico de cada uno
            if (sender == tbRojo)
            {
                poncolor(laRojo, tbRojo.Value, 0, 0);
                laNumRojo.Text = tbRojo.Value.ToString();
            }
            if (sender == tbVerde)
            {
                poncolor(laVerde, 0, tbVerde.Value, 0);
                laNumVerde.Text = tbVerde.Value.ToString();
            }
            if (sender == tbAzul)
            {
                poncolor(laAzul, 0, 0, tbAzul.Value);
                laNumAzul.Text = tbAzul.Value.ToString();
            }
            // Mezcla de colores
            poncolor(laPrueba, tbRojo.Value, tbVerde.Value, tbAzul.Value);

        }

        private void btAplicar_Click(object sender, EventArgs e)
        {
            //variables globales int para colores básicos
            rojo = tbRojo.Value;
            verde = tbVerde.Value;
            azul = tbAzul.Value;
            poncolor(laAplicar, rojo, verde, azul); // Muestra color aplicar 
                                                    // en label superior y lo asignamos a objeto Pen
            penGrosor.Color = Color.FromArgb(rojo, verde, azul);
            // El checkBox asigna color a objeto brush si está marcado
            ckRelleno_CheckedChanged(sender, e);

        }

        private void ckRelleno_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRelleno.Checked)
            { // mismo color de la mezcla para el relleno
                brushRelleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
            }
            else
            { // Color del fondo para relleno cuando hay repintados
                brushRelleno = new SolidBrush(Color.FromArgb(255, 255, 255));
            }
        }

        private void tsbLinea_Click(object sender, EventArgs e)

        {
            pbEditor.Image = mig; // Asignamos bitmap a PictureBox
            ToolStripButton btn = sender as ToolStripButton;
            switch (btn.Name)
            {
                case "tsbRectangulo":
                    // Dibuja Rectángulo Horizontal con relleno, parámetros (brush, 
                    // inicialX, inicialY, lado Horizontal mayor, lado vertical menor) 
                    imEditor.FillRectangle(brushRelleno, new Rectangle(80, 10, 85, 60));
                    // Dibuja Rectángulo igual pero sin relleno, solo línea contorno
                    imEditor.DrawRectangle(penGrosor, 80, 10, 85, 60);
                    break;
                case "tsbLinea":
                    // Dibuja línea, parámetros (pen, inicialX, inicialY, finalX, finalY).
                    imEditor.DrawLine(penGrosor, 0, 80, pbEditor.Width, 80);
                    break;
                case "tsbCuadrado":
                    // Iguales métodos que rectángulo, pero con lados iguales, es cuadrado
                    imEditor.FillRectangle(brushRelleno, new Rectangle(180, 10, 50, 50));
                    imEditor.DrawRectangle(penGrosor, 180, 10, 50, 50);
                    break;
                case "tsbElipse":
                    // Se pasa como parámetro las dimensiones de un rectángulo y dentro se 
                    // dibuja una elipse 
                    imEditor.FillEllipse(brushRelleno, new Rectangle(240, 10, 65, 40));
                    imEditor.DrawEllipse(penGrosor, new Rectangle(240, 10, 65, 40));
                    break;
                case "tsbCirculo":
                    // Igual que la elipse pero con lados iguales
                    imEditor.FillEllipse(brushRelleno, new Rectangle(10, 10, 50, 50));
                    imEditor.DrawEllipse(penGrosor, new Rectangle(10, 10, 50, 50));
                    break;
                case "tsbArco":
                    //Un arco es una parte de una elipse. Los parámetros indican dimensiones 
                    //de un rectángulo más un ángulo inicial de 90º y un ángulo de barrido 
                    //de 180º. Si ponemos 360º dibuja una elipse
                    // imEditor.DrawArc(penGrosor, 0, 85, 150, 50, 90, 180); // Lo mismo 
                    imEditor.DrawArc(penGrosor, new Rectangle(0, 85, 150, 50), 90, 180);
                    break;
                case "tsbPoligono":
                    /* Un polígono es una forma cerrada definida por 3 o más puntos (triángulo, 
                    cuadrado, etc). Al método se pasa parámetros Pen y una matriz de objetos 
                    point. Almacena los puntos que se van a conectar mediante líneas rectas.*/
                    Point[] vertices = { new Point(100, 126), new Point(150, 100), new Point(200, 126), new Point(200, 174), new Point(150, 200), new Point(100, 174) };
                    // new Point(100, 250), //Se pueden poner más 
                    // new Point(150, 200)}; // El cierre es automático
                    imEditor.DrawPolygon(penGrosor, vertices);
                    imEditor.FillPolygon(brushRelleno, vertices);
                    break;
                case "tsbCurvaAbierta":
                    /* La curva se dibuja indicando un inicio y fin de una recta y un/os 
                     punto/s intermedios de desplazamiento hacia arriba o abajo */
                    Point[] vertices2 = { new Point(250, 125), new Point(300, 100), new Point(350, 125), new Point(400, 100) };
                    imEditor.DrawCurve(penGrosor, vertices2);
                    // imEditor.DrawLine(penGrosor, 250, 125, 400, 100);// Recta entre 
                    // puntos de inicio y fin anteriores
                    break;
                case "tsbCurvaCerrada":
                    // El procedimiento es el mismo que el anterior solo que al final se 
                    // unen los puntos iniciales y finales automáticamente
                    Point[] vertices3 = { new Point(250, 185), new Point(300, 150), new Point(350, 185), new Point(400, 150) };
                    imEditor.DrawClosedCurve(penGrosor, vertices3);
                    imEditor.FillClosedCurve(brushRelleno, vertices3);
                    break;
                case "tsbTarta":
                    /* Es un arco junto con dos líneas que unen sus vértices con el centro de la 
                    elipse a la que pertenece el arco. Tiene los mismos parámetros que DrawArc, 
                    con la diferencia de las líneas indicadas y dibujadas automáticamente */
                    imEditor.DrawPie(penGrosor, new Rectangle(320, 10, 80, 60), 150, 50);
                    imEditor.FillPie(brushRelleno, new Rectangle(320, 10, 80, 60), 150, 50);
                    break;
                case "tsbTexto":
                    // Dibuja un texto con fuente , relleno y en coordenadas indicadas
                    Font fuente = new Font("Arial", 15);
                    imEditor.DrawString("Texto Incrustado En Gráfico", fuente,
                    brushRelleno, 50, 220);
                    break;
            }
        }

        private void tsitNuevo_Click(object sender, EventArgs e)
        {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);//Creamos objeto
            pbEditor.Image = mig;// Asignamos bitmap al picturebox
            imEditor = Graphics.FromImage(mig);//crea nuevo graphics con nuevo bitmap
                                               // Valor inicial posición stick 
            tbRojo.Value = tbVerde.Value = tbAzul.Value = 0;
            rojo = verde = azul = 0; // variables para colores


            poncolor(laPrueba, 0, 0, 0); // labels de prueba de colores
            poncolor(laRojo, 0, 0, 0);
            poncolor(laVerde, 0, 0, 0);
            poncolor(laAzul, 0, 0, 0);
            poncolor(laAplicar, 0, 0, 0);
            laNumAzul.Text = laNumRojo.Text = laVerde.Text = "0";
            penGrosor.Width = 2; // Valores iniciales del Pen
            penGrosor.Color = Color.Black;
            pbEditor.BackColor = Color.White; // Color de fondo del PictureBox 
            pbDemo.Value = 0; // Valores iniciales de los ProgressBar
            tspbDemostracion.Value = 0;
            ckRelleno.Checked = false; //Genera evento CheckedChanged que cambia brush

            tsl2.Text = "penGrosor Linea: 2"; //Valor Grosor en Barra de estado
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgAbrirDibujo.FileName = Text;
            if (dlgAbrirDibujo.ShowDialog() == DialogResult.OK &&
            dlgAbrirDibujo.FileName.Length > 0)
            {
                pbEditor.Image = Image.FromFile(dlgAbrirDibujo.FileName); //Posible 
                                                                          // Segundo parametro System.Drawing.Imaging.ImageFormat.Bmp);
                imEditor.DrawImage(pbEditor.Image, new Point(0, 0)); // Asignamos la 
                                                                     // imagen al Graphics, es necesario ubicarla al inicio del Graphics
                Text = dlgAbrirDibujo.FileName; //Ponemos nombre en la barra de título
            }
        }

        private void btDemo_Click(object sender, EventArgs e)
        {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);
            pbEditor.Image = mig;
            imEditor = Graphics.FromImage(mig);

            pbDemo.Visible = true; // Mostramos ProgresBar
            pbDemo.Value = 5; // Valor primer desplazamiento
            tspbDemostracion.Value = 5;

            foreach (ToolStripButton miboton in tsBarraBotones.Items)
            { // Recorremos matriz ítems de la barra de botones
                miboton.PerformClick(); // Ejecutamos evento click de cada botón
                pbEditor.Update();// Redibujamos las figuras para ver todas
                Thread.Sleep(1000);//parada de 1 segundo entre dibujos
                pbDemo.PerformStep(); //salto según valor de step
                //tspbDemostracion.PerformStep(); //Lo mismo 
            }
            // Ponemos color complementario elegido para Pen y Brush al fondo 
            pbEditor.BackColor = Color.FromArgb(255 - tbRojo.Value, 255 -
            tbVerde.Value, 255 - tbAzul.Value);

            pbDemo.Value = 100; // Final de las barras de progreso
            tspbDemostracion.Value = 100;
        }

        private void fmDibujo_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus) && penGrosor.Width < 100)
            {
                penGrosor.Width++; // Aumentamos grosor del Pen
            }
            if ((e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus) &&
            penGrosor.Width > 1)
            {
                penGrosor.Width--; // Disminuimos grosor
            }

            tsl2.Text = "penGrosor Linea: " + penGrosor.Width.ToString();

        }

        private void tsitAcercaDe_Click(object sender, EventArgs e)
        {
            fmAcercaDe VentanaAcercaDe = new fmAcercaDe();
            VentanaAcercaDe.ShowDialog();
        }

        private void tsiGuardar_Click(object sender, EventArgs e)
        {
            dlgGuardarDibujo.FileName = Text;
            if (dlgGuardarDibujo.ShowDialog() == DialogResult.OK && dlgGuardarDibujo.FileName.Length > 0)
            {
                pbEditor.Image.Save(dlgGuardarDibujo.FileName);//Posible Segundo 
                                                               //parámetro Imaging.ImageFormat.Bmp);
                Text = dlgGuardarDibujo.FileName;

            }
        }
    }
}
