using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;

namespace Dibujar
{
    partial class fmDibujo
    {
        Bitmap mig; 
        Graphics imEditor; 
        Pen penGrosor; 
        SolidBrush brushRelleno; // Representa al relleno con el que algunas figuras
        int rojo, verde, azul= 0;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDibujo));
            this.pbDemo = new System.Windows.Forms.ProgressBar();
            this.btDemo = new System.Windows.Forms.Button();
            this.btProbar = new System.Windows.Forms.Button();
            this.laVerde = new System.Windows.Forms.Label();
            this.laNumAzul = new System.Windows.Forms.Label();
            this.tbAzul = new System.Windows.Forms.TrackBar();
            this.tbVerde = new System.Windows.Forms.TrackBar();
            this.ckRelleno = new System.Windows.Forms.CheckBox();
            this.laRojo = new System.Windows.Forms.Label();
            this.laAplicar = new System.Windows.Forms.Label();
            this.tsBarraBotones = new System.Windows.Forms.ToolStrip();
            this.tsbLinea = new System.Windows.Forms.ToolStripButton();
            this.tsbCuadrado = new System.Windows.Forms.ToolStripButton();
            this.tsbRectangulo = new System.Windows.Forms.ToolStripButton();
            this.tsbArco = new System.Windows.Forms.ToolStripButton();
            this.tsbCirculo = new System.Windows.Forms.ToolStripButton();
            this.tsbElipse = new System.Windows.Forms.ToolStripButton();
            this.tsbPoligono = new System.Windows.Forms.ToolStripButton();
            this.tsbCurvaAbierta = new System.Windows.Forms.ToolStripButton();
            this.tsbCurvaCerrada = new System.Windows.Forms.ToolStripButton();
            this.tsbTexto = new System.Windows.Forms.ToolStripButton();
            this.tsbTarta = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsitNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsiAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsitAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.laPrueba = new System.Windows.Forms.Label();
            this.laAzul = new System.Windows.Forms.Label();
            this.laNumVerde = new System.Windows.Forms.Label();
            this.laNumRojo = new System.Windows.Forms.Label();
            this.stGrafico = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbDemostracion = new System.Windows.Forms.ToolStripProgressBar();
            this.btAplicar = new System.Windows.Forms.Button();
            this.tbRojo = new System.Windows.Forms.TrackBar();
            this.pnPrueba = new System.Windows.Forms.Panel();
            this.pbEditor = new System.Windows.Forms.PictureBox();
            this.dlgAbrirDibujo = new System.Windows.Forms.OpenFileDialog();
            this.dlgGuardarDibujo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tbAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerde)).BeginInit();
            this.tsBarraBotones.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.stGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRojo)).BeginInit();
            this.pnPrueba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDemo
            // 
            this.pbDemo.Location = new System.Drawing.Point(268, 389);
            this.pbDemo.Name = "pbDemo";
            this.pbDemo.Size = new System.Drawing.Size(287, 23);
            this.pbDemo.Step = 5;
            this.pbDemo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDemo.TabIndex = 15;
            this.pbDemo.Visible = false;
            // 
            // btDemo
            // 
            this.btDemo.AutoSize = true;
            this.btDemo.Location = new System.Drawing.Point(133, 389);
            this.btDemo.Name = "btDemo";
            this.btDemo.Size = new System.Drawing.Size(82, 23);
            this.btDemo.TabIndex = 14;
            this.btDemo.Text = "Demostración";
            this.btDemo.UseVisualStyleBackColor = true;
            this.btDemo.Click += new System.EventHandler(this.btDemo_Click);
            // 
            // btProbar
            // 
            this.btProbar.AutoSize = true;
            this.btProbar.Location = new System.Drawing.Point(479, 24);
            this.btProbar.Name = "btProbar";
            this.btProbar.Size = new System.Drawing.Size(101, 23);
            this.btProbar.TabIndex = 6;
            this.btProbar.Text = "No probar colores";
            this.btProbar.UseVisualStyleBackColor = true;
            this.btProbar.Click += new System.EventHandler(this.btProbar_Click);
            // 
            // laVerde
            // 
            this.laVerde.AutoSize = true;
            this.laVerde.BackColor = System.Drawing.Color.Black;
            this.laVerde.ForeColor = System.Drawing.Color.White;
            this.laVerde.Location = new System.Drawing.Point(43, 160);
            this.laVerde.Name = "laVerde";
            this.laVerde.Size = new System.Drawing.Size(35, 13);
            this.laVerde.TabIndex = 7;
            this.laVerde.Text = "Verde";
            // 
            // laNumAzul
            // 
            this.laNumAzul.AutoSize = true;
            this.laNumAzul.Location = new System.Drawing.Point(105, 243);
            this.laNumAzul.Name = "laNumAzul";
            this.laNumAzul.Size = new System.Drawing.Size(13, 13);
            this.laNumAzul.TabIndex = 5;
            this.laNumAzul.Text = "0";
            // 
            // tbAzul
            // 
            this.tbAzul.Location = new System.Drawing.Point(46, 259);
            this.tbAzul.Maximum = 255;
            this.tbAzul.Name = "tbAzul";
            this.tbAzul.Size = new System.Drawing.Size(126, 45);
            this.tbAzul.TabIndex = 2;
            this.tbAzul.Scroll += new System.EventHandler(this.tbRojo_Scroll);
            // 
            // tbVerde
            // 
            this.tbVerde.Location = new System.Drawing.Point(46, 176);
            this.tbVerde.Maximum = 255;
            this.tbVerde.Name = "tbVerde";
            this.tbVerde.Size = new System.Drawing.Size(126, 45);
            this.tbVerde.TabIndex = 1;
            this.tbVerde.Scroll += new System.EventHandler(this.tbRojo_Scroll);
            // 
            // ckRelleno
            // 
            this.ckRelleno.AutoSize = true;
            this.ckRelleno.Location = new System.Drawing.Point(304, 33);
            this.ckRelleno.Name = "ckRelleno";
            this.ckRelleno.Size = new System.Drawing.Size(113, 17);
            this.ckRelleno.TabIndex = 13;
            this.ckRelleno.Text = "Con brush Relleno";
            this.ckRelleno.UseVisualStyleBackColor = true;
            this.ckRelleno.CheckedChanged += new System.EventHandler(this.ckRelleno_CheckedChanged);
            // 
            // laRojo
            // 
            this.laRojo.AutoSize = true;
            this.laRojo.BackColor = System.Drawing.Color.Black;
            this.laRojo.ForeColor = System.Drawing.Color.White;
            this.laRojo.Location = new System.Drawing.Point(43, 73);
            this.laRojo.Name = "laRojo";
            this.laRojo.Size = new System.Drawing.Size(29, 13);
            this.laRojo.TabIndex = 6;
            this.laRojo.Text = "Rojo";
            // 
            // laAplicar
            // 
            this.laAplicar.AutoSize = true;
            this.laAplicar.BackColor = System.Drawing.Color.Black;
            this.laAplicar.ForeColor = System.Drawing.Color.White;
            this.laAplicar.Location = new System.Drawing.Point(149, 34);
            this.laAplicar.Name = "laAplicar";
            this.laAplicar.Size = new System.Drawing.Size(66, 13);
            this.laAplicar.TabIndex = 12;
            this.laAplicar.Text = "Color Aplicar";
            // 
            // tsBarraBotones
            // 
            this.tsBarraBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsBarraBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLinea,
            this.tsbCuadrado,
            this.tsbRectangulo,
            this.tsbArco,
            this.tsbCirculo,
            this.tsbElipse,
            this.tsbPoligono,
            this.tsbCurvaAbierta,
            this.tsbCurvaCerrada,
            this.tsbTexto,
            this.tsbTarta});
            this.tsBarraBotones.Location = new System.Drawing.Point(0, 24);
            this.tsBarraBotones.Name = "tsBarraBotones";
            this.tsBarraBotones.Size = new System.Drawing.Size(104, 402);
            this.tsBarraBotones.TabIndex = 9;
            this.tsBarraBotones.Text = "toolStrip1";
            // 
            // tsbLinea
            // 
            this.tsbLinea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLinea.Image = ((System.Drawing.Image)(resources.GetObject("tsbLinea.Image")));
            this.tsbLinea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLinea.Name = "tsbLinea";
            this.tsbLinea.Size = new System.Drawing.Size(101, 19);
            this.tsbLinea.Text = "LINEA";
            this.tsbLinea.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbCuadrado
            // 
            this.tsbCuadrado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCuadrado.Image = ((System.Drawing.Image)(resources.GetObject("tsbCuadrado.Image")));
            this.tsbCuadrado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCuadrado.Name = "tsbCuadrado";
            this.tsbCuadrado.Size = new System.Drawing.Size(101, 19);
            this.tsbCuadrado.Text = "CUADRADO";
            this.tsbCuadrado.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbRectangulo
            // 
            this.tsbRectangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRectangulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRectangulo.Image")));
            this.tsbRectangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRectangulo.Name = "tsbRectangulo";
            this.tsbRectangulo.Size = new System.Drawing.Size(101, 19);
            this.tsbRectangulo.Text = "RECTANGULO";
            this.tsbRectangulo.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbArco
            // 
            this.tsbArco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbArco.Image = ((System.Drawing.Image)(resources.GetObject("tsbArco.Image")));
            this.tsbArco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbArco.Name = "tsbArco";
            this.tsbArco.Size = new System.Drawing.Size(101, 19);
            this.tsbArco.Text = "ARCO";
            this.tsbArco.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbCirculo
            // 
            this.tsbCirculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCirculo.Image = ((System.Drawing.Image)(resources.GetObject("tsbCirculo.Image")));
            this.tsbCirculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCirculo.Name = "tsbCirculo";
            this.tsbCirculo.Size = new System.Drawing.Size(101, 19);
            this.tsbCirculo.Text = "CIRCULO";
            this.tsbCirculo.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbElipse
            // 
            this.tsbElipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbElipse.Image = ((System.Drawing.Image)(resources.GetObject("tsbElipse.Image")));
            this.tsbElipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbElipse.Name = "tsbElipse";
            this.tsbElipse.Size = new System.Drawing.Size(101, 19);
            this.tsbElipse.Text = "ELIPSE";
            this.tsbElipse.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbPoligono
            // 
            this.tsbPoligono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPoligono.Image = ((System.Drawing.Image)(resources.GetObject("tsbPoligono.Image")));
            this.tsbPoligono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPoligono.Name = "tsbPoligono";
            this.tsbPoligono.Size = new System.Drawing.Size(101, 19);
            this.tsbPoligono.Text = "POLIGONO";
            this.tsbPoligono.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbCurvaAbierta
            // 
            this.tsbCurvaAbierta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCurvaAbierta.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurvaAbierta.Image")));
            this.tsbCurvaAbierta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurvaAbierta.Name = "tsbCurvaAbierta";
            this.tsbCurvaAbierta.Size = new System.Drawing.Size(101, 19);
            this.tsbCurvaAbierta.Text = "CURVA ABIERTA";
            this.tsbCurvaAbierta.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbCurvaCerrada
            // 
            this.tsbCurvaCerrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCurvaCerrada.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurvaCerrada.Image")));
            this.tsbCurvaCerrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurvaCerrada.Name = "tsbCurvaCerrada";
            this.tsbCurvaCerrada.Size = new System.Drawing.Size(101, 19);
            this.tsbCurvaCerrada.Text = "CURVA CERRADA";
            this.tsbCurvaCerrada.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbTexto
            // 
            this.tsbTexto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTexto.Image = ((System.Drawing.Image)(resources.GetObject("tsbTexto.Image")));
            this.tsbTexto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTexto.Name = "tsbTexto";
            this.tsbTexto.Size = new System.Drawing.Size(101, 19);
            this.tsbTexto.Text = "TEXTO";
            this.tsbTexto.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbTarta
            // 
            this.tsbTarta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTarta.Image = ((System.Drawing.Image)(resources.GetObject("tsbTarta.Image")));
            this.tsbTarta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTarta.Name = "tsbTarta";
            this.tsbTarta.Size = new System.Drawing.Size(101, 19);
            this.tsbTarta.Text = "TARTA";
            this.tsbTarta.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsitNuevo,
            this.toolStripSeparator,
            this.tsiAbrir,
            this.tsiGuardar,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "&Archivo";
            // 
            // tsitNuevo
            // 
            this.tsitNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsitNuevo.Image")));
            this.tsitNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsitNuevo.Name = "tsitNuevo";
            this.tsitNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsitNuevo.Size = new System.Drawing.Size(180, 22);
            this.tsitNuevo.Text = "&Nuevo";
            this.tsitNuevo.Click += new System.EventHandler(this.tsitNuevo_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // tsiAbrir
            // 
            this.tsiAbrir.Image = ((System.Drawing.Image)(resources.GetObject("tsiAbrir.Image")));
            this.tsiAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiAbrir.Name = "tsiAbrir";
            this.tsiAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsiAbrir.Size = new System.Drawing.Size(180, 22);
            this.tsiAbrir.Text = "&Abrir";
            this.tsiAbrir.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tsiGuardar
            // 
            this.tsiGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsiGuardar.Image")));
            this.tsiGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiGuardar.Name = "tsiGuardar";
            this.tsiGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsiGuardar.Size = new System.Drawing.Size(180, 22);
            this.tsiGuardar.Text = "&Guardar";
            this.tsiGuardar.Click += new System.EventHandler(this.tsiGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Salir";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsitAcercaDe});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.helpToolStripMenuItem.Text = "&Ayuda";
            // 
            // tsitAcercaDe
            // 
            this.tsitAcercaDe.Name = "tsitAcercaDe";
            this.tsitAcercaDe.Size = new System.Drawing.Size(126, 22);
            this.tsitAcercaDe.Text = "&Acerca de";
            this.tsitAcercaDe.Click += new System.EventHandler(this.tsitAcercaDe_Click);
            // 
            // laPrueba
            // 
            this.laPrueba.AutoSize = true;
            this.laPrueba.BackColor = System.Drawing.Color.Black;
            this.laPrueba.ForeColor = System.Drawing.Color.White;
            this.laPrueba.Location = new System.Drawing.Point(43, 43);
            this.laPrueba.Name = "laPrueba";
            this.laPrueba.Size = new System.Drawing.Size(94, 13);
            this.laPrueba.TabIndex = 10;
            this.laPrueba.Text = "Prueba de Colores";
            // 
            // laAzul
            // 
            this.laAzul.AutoSize = true;
            this.laAzul.BackColor = System.Drawing.Color.Black;
            this.laAzul.ForeColor = System.Drawing.Color.White;
            this.laAzul.Location = new System.Drawing.Point(43, 243);
            this.laAzul.Name = "laAzul";
            this.laAzul.Size = new System.Drawing.Size(27, 13);
            this.laAzul.TabIndex = 8;
            this.laAzul.Text = "Azul";
            // 
            // laNumVerde
            // 
            this.laNumVerde.AutoSize = true;
            this.laNumVerde.Location = new System.Drawing.Point(105, 160);
            this.laNumVerde.Name = "laNumVerde";
            this.laNumVerde.Size = new System.Drawing.Size(13, 13);
            this.laNumVerde.TabIndex = 4;
            this.laNumVerde.Text = "0";
            // 
            // laNumRojo
            // 
            this.laNumRojo.AutoSize = true;
            this.laNumRojo.Location = new System.Drawing.Point(105, 73);
            this.laNumRojo.Name = "laNumRojo";
            this.laNumRojo.Size = new System.Drawing.Size(13, 13);
            this.laNumRojo.TabIndex = 3;
            this.laNumRojo.Text = "0";
            // 
            // stGrafico
            // 
            this.stGrafico.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.stGrafico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsl2,
            this.tspbDemostracion});
            this.stGrafico.Location = new System.Drawing.Point(0, 426);
            this.stGrafico.Name = "stGrafico";
            this.stGrafico.Size = new System.Drawing.Size(600, 24);
            this.stGrafico.TabIndex = 11;
            this.stGrafico.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(122, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tsl2
            // 
            this.tsl2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tsl2.Name = "tsl2";
            this.tsl2.Size = new System.Drawing.Size(118, 19);
            this.tsl2.Text = "toolStripStatusLabel2";
            // 
            // tspbDemostracion
            // 
            this.tspbDemostracion.Name = "tspbDemostracion";
            this.tspbDemostracion.Size = new System.Drawing.Size(100, 18);
            // 
            // btAplicar
            // 
            this.btAplicar.Location = new System.Drawing.Point(46, 320);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(75, 23);
            this.btAplicar.TabIndex = 9;
            this.btAplicar.Text = "Aplicar Color";
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // tbRojo
            // 
            this.tbRojo.Location = new System.Drawing.Point(46, 89);
            this.tbRojo.Maximum = 255;
            this.tbRojo.Name = "tbRojo";
            this.tbRojo.Size = new System.Drawing.Size(129, 45);
            this.tbRojo.TabIndex = 0;
            this.tbRojo.Scroll += new System.EventHandler(this.tbRojo_Scroll);
            // 
            // pnPrueba
            // 
            this.pnPrueba.Controls.Add(this.laPrueba);
            this.pnPrueba.Controls.Add(this.btAplicar);
            this.pnPrueba.Controls.Add(this.laAzul);
            this.pnPrueba.Controls.Add(this.laVerde);
            this.pnPrueba.Controls.Add(this.laRojo);
            this.pnPrueba.Controls.Add(this.laNumAzul);
            this.pnPrueba.Controls.Add(this.laNumVerde);
            this.pnPrueba.Controls.Add(this.laNumRojo);
            this.pnPrueba.Controls.Add(this.tbAzul);
            this.pnPrueba.Controls.Add(this.tbVerde);
            this.pnPrueba.Controls.Add(this.tbRojo);
            this.pnPrueba.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPrueba.Enabled = false;
            this.pnPrueba.Location = new System.Drawing.Point(600, 0);
            this.pnPrueba.Name = "pnPrueba";
            this.pnPrueba.Size = new System.Drawing.Size(200, 450);
            this.pnPrueba.TabIndex = 10;
            // 
            // pbEditor
            // 
            this.pbEditor.BackColor = System.Drawing.Color.White;
            this.pbEditor.Location = new System.Drawing.Point(122, 56);
            this.pbEditor.Name = "pbEditor";
            this.pbEditor.Size = new System.Drawing.Size(458, 327);
            this.pbEditor.TabIndex = 16;
            this.pbEditor.TabStop = false;
            this.pbEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbEditor_MouseDown);
            // 
            // dlgAbrirDibujo
            // 
            this.dlgAbrirDibujo.FileName = "openFileDialog1";
            // 
            // fmDibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btProbar);
            this.Controls.Add(this.pbEditor);
            this.Controls.Add(this.pbDemo);
            this.Controls.Add(this.btDemo);
            this.Controls.Add(this.ckRelleno);
            this.Controls.Add(this.laAplicar);
            this.Controls.Add(this.tsBarraBotones);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.stGrafico);
            this.Controls.Add(this.pnPrueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDibujo";
            this.Text = "Dibujo1";
            this.Load += new System.EventHandler(this.fmDibujo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmDibujo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tbAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVerde)).EndInit();
            this.tsBarraBotones.ResumeLayout(false);
            this.tsBarraBotones.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stGrafico.ResumeLayout(false);
            this.stGrafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbRojo)).EndInit();
            this.pnPrueba.ResumeLayout(false);
            this.pnPrueba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbDemo;
        private System.Windows.Forms.Button btDemo;
        private System.Windows.Forms.Button btProbar;
        private System.Windows.Forms.Label laVerde;
        private System.Windows.Forms.Label laNumAzul;
        private System.Windows.Forms.TrackBar tbAzul;
        private System.Windows.Forms.TrackBar tbVerde;
        private System.Windows.Forms.CheckBox ckRelleno;
        private System.Windows.Forms.Label laRojo;
        private System.Windows.Forms.Label laAplicar;
        private System.Windows.Forms.ToolStrip tsBarraBotones;
        private System.Windows.Forms.ToolStripButton tsbLinea;
        private System.Windows.Forms.ToolStripButton tsbCuadrado;
        private System.Windows.Forms.ToolStripButton tsbRectangulo;
        private System.Windows.Forms.ToolStripButton tsbArco;
        private System.Windows.Forms.ToolStripButton tsbCirculo;
        private System.Windows.Forms.ToolStripButton tsbElipse;
        private System.Windows.Forms.ToolStripButton tsbPoligono;
        private System.Windows.Forms.ToolStripButton tsbCurvaAbierta;
        private System.Windows.Forms.ToolStripButton tsbCurvaCerrada;
        private System.Windows.Forms.ToolStripButton tsbTexto;
        private System.Windows.Forms.ToolStripButton tsbTarta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsitNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsiAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsiGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsitAcercaDe;
        private System.Windows.Forms.Label laPrueba;
        private System.Windows.Forms.Label laAzul;
        private System.Windows.Forms.Label laNumVerde;
        private System.Windows.Forms.Label laNumRojo;
        private System.Windows.Forms.StatusStrip stGrafico;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.TrackBar tbRojo;
        private System.Windows.Forms.Panel pnPrueba;
        private System.Windows.Forms.PictureBox pbEditor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsl2;
        private System.Windows.Forms.OpenFileDialog dlgAbrirDibujo;
        private System.Windows.Forms.ToolStripProgressBar tspbDemostracion;
        private System.Windows.Forms.SaveFileDialog dlgGuardarDibujo;
    }
}

