/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 10/10/2018
 * Time: 10:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Etapa_1._
{
	partial class GrafoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafoForm));
			this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.pictureBoxRestore = new System.Windows.Forms.PictureBox();
			this.pictureBoxMaximize = new System.Windows.Forms.PictureBox();
			this.pictureImageGrafo = new System.Windows.Forms.PictureBox();
			this.treeViewGrafo = new System.Windows.Forms.TreeView();
			this.groupBoxParticulas = new System.Windows.Forms.GroupBox();
			this.buttonSeleccionar = new System.Windows.Forms.Button();
			this.comboBoxPresas = new System.Windows.Forms.ComboBox();
			this.buttonPresaNormal = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpPosDest = new System.Windows.Forms.NumericUpDown();
			this.PosP = new System.Windows.Forms.Label();
			this.NoParticulas = new System.Windows.Forms.Label();
			this.numericUpPosPresa = new System.Windows.Forms.NumericUpDown();
			this.buttonDepre = new System.Windows.Forms.Button();
			this.numericUpDepre = new System.Windows.Forms.NumericUpDown();
			this.buttonAnimar = new System.Windows.Forms.Button();
			this.buttonInserccion = new System.Windows.Forms.Button();
			this.numericUpNPresa = new System.Windows.Forms.NumericUpDown();
			this.buttonDistC = new System.Windows.Forms.Button();
			this.buttonCaminoC = new System.Windows.Forms.Button();
			this.numericUpAnchura = new System.Windows.Forms.NumericUpDown();
			this.numericUpProfundidad = new System.Windows.Forms.NumericUpDown();
			this.listBoxCamino = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.recorridosINFO = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureImageGrafo)).BeginInit();
			this.groupBoxParticulas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpPosDest)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpPosPresa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDepre)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpNPresa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpAnchura)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpProfundidad)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxMinimize
			// 
			this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.Image")));
			this.pictureBoxMinimize.Location = new System.Drawing.Point(808, 12);
			this.pictureBoxMinimize.Name = "pictureBoxMinimize";
			this.pictureBoxMinimize.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxMinimize.TabIndex = 12;
			this.pictureBoxMinimize.TabStop = false;
			this.pictureBoxMinimize.Click += new System.EventHandler(this.PictureBoxMinimizeClick);
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(870, 12);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxClose.TabIndex = 10;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxCloseClick);
			// 
			// pictureBoxRestore
			// 
			this.pictureBoxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxRestore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxRestore.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRestore.Image")));
			this.pictureBoxRestore.Location = new System.Drawing.Point(839, 12);
			this.pictureBoxRestore.Name = "pictureBoxRestore";
			this.pictureBoxRestore.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxRestore.TabIndex = 13;
			this.pictureBoxRestore.TabStop = false;
			this.pictureBoxRestore.Visible = false;
			this.pictureBoxRestore.Click += new System.EventHandler(this.PictureBoxRestoreClick);
			// 
			// pictureBoxMaximize
			// 
			this.pictureBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaximize.Image")));
			this.pictureBoxMaximize.Location = new System.Drawing.Point(839, 12);
			this.pictureBoxMaximize.Name = "pictureBoxMaximize";
			this.pictureBoxMaximize.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxMaximize.TabIndex = 11;
			this.pictureBoxMaximize.TabStop = false;
			this.pictureBoxMaximize.Click += new System.EventHandler(this.PictureBoxMaximizeClick);
			// 
			// pictureImageGrafo
			// 
			this.pictureImageGrafo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureImageGrafo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
			this.pictureImageGrafo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureImageGrafo.BackgroundImage")));
			this.pictureImageGrafo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureImageGrafo.Location = new System.Drawing.Point(40, 56);
			this.pictureImageGrafo.Name = "pictureImageGrafo";
			this.pictureImageGrafo.Size = new System.Drawing.Size(506, 386);
			this.pictureImageGrafo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureImageGrafo.TabIndex = 14;
			this.pictureImageGrafo.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureImageGrafo, "Imagen cargada, creada un grafo de la misma");
			// 
			// treeViewGrafo
			// 
			this.treeViewGrafo.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.treeViewGrafo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
			this.treeViewGrafo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeViewGrafo.ForeColor = System.Drawing.SystemColors.Info;
			this.treeViewGrafo.Location = new System.Drawing.Point(552, 84);
			this.treeViewGrafo.Name = "treeViewGrafo";
			this.treeViewGrafo.Size = new System.Drawing.Size(175, 297);
			this.treeViewGrafo.TabIndex = 15;
			// 
			// groupBoxParticulas
			// 
			this.groupBoxParticulas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxParticulas.Controls.Add(this.buttonSeleccionar);
			this.groupBoxParticulas.Controls.Add(this.comboBoxPresas);
			this.groupBoxParticulas.Controls.Add(this.buttonPresaNormal);
			this.groupBoxParticulas.Controls.Add(this.label3);
			this.groupBoxParticulas.Controls.Add(this.numericUpPosDest);
			this.groupBoxParticulas.Controls.Add(this.PosP);
			this.groupBoxParticulas.Controls.Add(this.NoParticulas);
			this.groupBoxParticulas.Controls.Add(this.numericUpPosPresa);
			this.groupBoxParticulas.Controls.Add(this.buttonDepre);
			this.groupBoxParticulas.Controls.Add(this.numericUpDepre);
			this.groupBoxParticulas.Controls.Add(this.buttonAnimar);
			this.groupBoxParticulas.Controls.Add(this.buttonInserccion);
			this.groupBoxParticulas.Controls.Add(this.numericUpNPresa);
			this.groupBoxParticulas.Location = new System.Drawing.Point(552, 388);
			this.groupBoxParticulas.Name = "groupBoxParticulas";
			this.groupBoxParticulas.Size = new System.Drawing.Size(344, 122);
			this.groupBoxParticulas.TabIndex = 20;
			this.groupBoxParticulas.TabStop = false;
			this.groupBoxParticulas.Text = "Insertar Particulas";
			this.toolTip1.SetToolTip(this.groupBoxParticulas, "Aquí se insertan las particulas y se hacen las animaciones.");
			// 
			// buttonSeleccionar
			// 
			this.buttonSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSeleccionar.FlatAppearance.BorderSize = 0;
			this.buttonSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.buttonSeleccionar.Location = new System.Drawing.Point(149, 14);
			this.buttonSeleccionar.Name = "buttonSeleccionar";
			this.buttonSeleccionar.Size = new System.Drawing.Size(137, 20);
			this.buttonSeleccionar.TabIndex = 34;
			this.buttonSeleccionar.Text = "Seleccionar";
			this.toolTip1.SetToolTip(this.buttonSeleccionar, "Inserta cuantas presas se hayan seleccionado en el contador.");
			this.buttonSeleccionar.UseVisualStyleBackColor = false;
			this.buttonSeleccionar.Click += new System.EventHandler(this.ButtonSeleccionarClick);
			// 
			// comboBoxPresas
			// 
			this.comboBoxPresas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.comboBoxPresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxPresas.Items.AddRange(new object[] {
									"Inserta Presas",
									"Inserta Presa Dijkstra"});
			this.comboBoxPresas.Location = new System.Drawing.Point(6, 14);
			this.comboBoxPresas.Name = "comboBoxPresas";
			this.comboBoxPresas.Size = new System.Drawing.Size(137, 21);
			this.comboBoxPresas.TabIndex = 33;
			this.toolTip1.SetToolTip(this.comboBoxPresas, "Selecciona si deseas insertar una partícula normal o de Dijkstra");
			// 
			// buttonPresaNormal
			// 
			this.buttonPresaNormal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonPresaNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonPresaNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonPresaNormal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPresaNormal.FlatAppearance.BorderSize = 0;
			this.buttonPresaNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.buttonPresaNormal.Location = new System.Drawing.Point(6, 51);
			this.buttonPresaNormal.Name = "buttonPresaNormal";
			this.buttonPresaNormal.Size = new System.Drawing.Size(137, 25);
			this.buttonPresaNormal.TabIndex = 31;
			this.buttonPresaNormal.Text = "Insertar Presas";
			this.toolTip1.SetToolTip(this.buttonPresaNormal, "Inserta cuantas presas se hayan seleccionado en el contador.");
			this.buttonPresaNormal.UseVisualStyleBackColor = false;
			this.buttonPresaNormal.Click += new System.EventHandler(this.ButtonPresaNormalClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(256, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 14);
			this.label3.TabIndex = 30;
			this.label3.Text = "Pos D";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpPosDest
			// 
			this.numericUpPosDest.Location = new System.Drawing.Point(256, 53);
			this.numericUpPosDest.Name = "numericUpPosDest";
			this.numericUpPosDest.Size = new System.Drawing.Size(45, 20);
			this.numericUpPosDest.TabIndex = 29;
			this.toolTip1.SetToolTip(this.numericUpPosDest, "Si desea que la particula haga DIJKSTRA seleccione un vértice origen y un vértice" +
						" destino. De lo contrario mantenga un 0.");
			// 
			// PosP
			// 
			this.PosP.Location = new System.Drawing.Point(200, 36);
			this.PosP.Name = "PosP";
			this.PosP.Size = new System.Drawing.Size(45, 14);
			this.PosP.TabIndex = 28;
			this.PosP.Text = "Pos O";
			this.PosP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NoParticulas
			// 
			this.NoParticulas.Location = new System.Drawing.Point(149, 36);
			this.NoParticulas.Name = "NoParticulas";
			this.NoParticulas.Size = new System.Drawing.Size(45, 14);
			this.NoParticulas.TabIndex = 27;
			this.NoParticulas.Text = "#";
			this.NoParticulas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpPosPresa
			// 
			this.numericUpPosPresa.Location = new System.Drawing.Point(200, 53);
			this.numericUpPosPresa.Name = "numericUpPosPresa";
			this.numericUpPosPresa.Size = new System.Drawing.Size(45, 20);
			this.numericUpPosPresa.TabIndex = 25;
			this.toolTip1.SetToolTip(this.numericUpPosPresa, "Si desea que la particula haga DIJKSTRA seleccione un vértice origen y un vértice" +
						" destino. De lo contrario mantenga un 0.");
			// 
			// buttonDepre
			// 
			this.buttonDepre.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonDepre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonDepre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonDepre.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonDepre.FlatAppearance.BorderSize = 0;
			this.buttonDepre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.buttonDepre.Location = new System.Drawing.Point(6, 86);
			this.buttonDepre.Name = "buttonDepre";
			this.buttonDepre.Size = new System.Drawing.Size(137, 25);
			this.buttonDepre.TabIndex = 24;
			this.buttonDepre.Text = "Insertar Depredadoras";
			this.toolTip1.SetToolTip(this.buttonDepre, "Inserta cuantas depredadoras se hayan seleccionado en el contador.");
			this.buttonDepre.UseVisualStyleBackColor = false;
			this.buttonDepre.Click += new System.EventHandler(this.ButtonDepreClick);
			// 
			// numericUpDepre
			// 
			this.numericUpDepre.Location = new System.Drawing.Point(149, 87);
			this.numericUpDepre.Name = "numericUpDepre";
			this.numericUpDepre.Size = new System.Drawing.Size(45, 20);
			this.numericUpDepre.TabIndex = 23;
			this.toolTip1.SetToolTip(this.numericUpDepre, "Número de depredadoras que se van a insertar. Se insertan aleatoriamente");
			// 
			// buttonAnimar
			// 
			this.buttonAnimar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonAnimar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonAnimar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAnimar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAnimar.FlatAppearance.BorderSize = 0;
			this.buttonAnimar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonAnimar.Location = new System.Drawing.Point(220, 83);
			this.buttonAnimar.Name = "buttonAnimar";
			this.buttonAnimar.Size = new System.Drawing.Size(81, 25);
			this.buttonAnimar.TabIndex = 22;
			this.buttonAnimar.Text = "Animar";
			this.toolTip1.SetToolTip(this.buttonAnimar, "Anima las particulas insertadas en la imagen.");
			this.buttonAnimar.UseVisualStyleBackColor = false;
			this.buttonAnimar.Visible = false;
			this.buttonAnimar.Click += new System.EventHandler(this.ButtonAnimarClick);
			// 
			// buttonInserccion
			// 
			this.buttonInserccion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonInserccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonInserccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonInserccion.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonInserccion.FlatAppearance.BorderSize = 0;
			this.buttonInserccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
			this.buttonInserccion.Location = new System.Drawing.Point(6, 52);
			this.buttonInserccion.Name = "buttonInserccion";
			this.buttonInserccion.Size = new System.Drawing.Size(137, 25);
			this.buttonInserccion.TabIndex = 21;
			this.buttonInserccion.Text = "Insertar Presas";
			this.toolTip1.SetToolTip(this.buttonInserccion, "Inserta cuantas presas se hayan seleccionado en el contador.");
			this.buttonInserccion.UseVisualStyleBackColor = false;
			// 
			// numericUpNPresa
			// 
			this.numericUpNPresa.Location = new System.Drawing.Point(149, 53);
			this.numericUpNPresa.Name = "numericUpNPresa";
			this.numericUpNPresa.Size = new System.Drawing.Size(45, 20);
			this.numericUpNPresa.TabIndex = 0;
			this.toolTip1.SetToolTip(this.numericUpNPresa, "Número de presas que se van a insertar.");
			// 
			// buttonDistC
			// 
			this.buttonDistC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonDistC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonDistC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonDistC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonDistC.FlatAppearance.BorderSize = 0;
			this.buttonDistC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.buttonDistC.Location = new System.Drawing.Point(248, 460);
			this.buttonDistC.Name = "buttonDistC";
			this.buttonDistC.Size = new System.Drawing.Size(146, 39);
			this.buttonDistC.TabIndex = 18;
			this.buttonDistC.Text = "Recorrido Profundidad";
			this.toolTip1.SetToolTip(this.buttonDistC, "Muestra un recorrido en profundidad en el vertice correspondiente seleccionado en" +
						" el contador");
			this.buttonDistC.UseVisualStyleBackColor = false;
			this.buttonDistC.Click += new System.EventHandler(this.ButtonDistCClick);
			this.buttonDistC.MouseLeave += new System.EventHandler(this.ButtonDistCMouseLeave);
			this.buttonDistC.MouseHover += new System.EventHandler(this.ButtonDistCMouseHover);
			// 
			// buttonCaminoC
			// 
			this.buttonCaminoC.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonCaminoC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonCaminoC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonCaminoC.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCaminoC.FlatAppearance.BorderSize = 0;
			this.buttonCaminoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCaminoC.Location = new System.Drawing.Point(40, 460);
			this.buttonCaminoC.Name = "buttonCaminoC";
			this.buttonCaminoC.Size = new System.Drawing.Size(131, 39);
			this.buttonCaminoC.TabIndex = 16;
			this.buttonCaminoC.Text = "Recorrido Amplitud";
			this.toolTip1.SetToolTip(this.buttonCaminoC, "Muestra un recorrido en amplitud en el vertice correspondiente seleccionado en el" +
						" contador");
			this.buttonCaminoC.UseVisualStyleBackColor = false;
			this.buttonCaminoC.Click += new System.EventHandler(this.ButtonCaminoCClick);
			this.buttonCaminoC.MouseLeave += new System.EventHandler(this.ButtonCaminoCMouseLeave);
			this.buttonCaminoC.MouseHover += new System.EventHandler(this.ButtonCaminoCMouseHover);
			// 
			// numericUpAnchura
			// 
			this.numericUpAnchura.Location = new System.Drawing.Point(177, 470);
			this.numericUpAnchura.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpAnchura.Name = "numericUpAnchura";
			this.numericUpAnchura.Size = new System.Drawing.Size(45, 20);
			this.numericUpAnchura.TabIndex = 23;
			this.toolTip1.SetToolTip(this.numericUpAnchura, "Número de vertice donde se hará el recorrido");
			this.numericUpAnchura.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// numericUpProfundidad
			// 
			this.numericUpProfundidad.Location = new System.Drawing.Point(400, 470);
			this.numericUpProfundidad.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpProfundidad.Name = "numericUpProfundidad";
			this.numericUpProfundidad.Size = new System.Drawing.Size(45, 20);
			this.numericUpProfundidad.TabIndex = 24;
			this.toolTip1.SetToolTip(this.numericUpProfundidad, "Número de vertice donde se hará el recorrido");
			this.numericUpProfundidad.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// listBoxCamino
			// 
			this.listBoxCamino.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.listBoxCamino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
			this.listBoxCamino.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxCamino.ForeColor = System.Drawing.SystemColors.Info;
			this.listBoxCamino.FormattingEnabled = true;
			this.listBoxCamino.Location = new System.Drawing.Point(733, 83);
			this.listBoxCamino.Name = "listBoxCamino";
			this.listBoxCamino.Size = new System.Drawing.Size(163, 299);
			this.listBoxCamino.TabIndex = 25;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(561, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 33);
			this.label1.TabIndex = 26;
			this.label1.Text = "Lista de adyacencia en forma de árbol";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(736, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 33);
			this.label2.TabIndex = 27;
			this.label2.Text = "Lista de vertices";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// recorridosINFO
			// 
			this.recorridosINFO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.recorridosINFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.recorridosINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.recorridosINFO.Cursor = System.Windows.Forms.Cursors.Hand;
			this.recorridosINFO.FlatAppearance.BorderSize = 0;
			this.recorridosINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.recorridosINFO.Location = new System.Drawing.Point(467, 463);
			this.recorridosINFO.Name = "recorridosINFO";
			this.recorridosINFO.Size = new System.Drawing.Size(44, 35);
			this.recorridosINFO.TabIndex = 28;
			this.recorridosINFO.Text = "?";
			this.toolTip1.SetToolTip(this.recorridosINFO, "Si deseas ver un camino en profundidad o amplitud especifico en un vertice selecc" +
						"ionalo y arriba a la derecha se mostrara la lista con los vertices que una parti" +
						"cula debe de seguir.");
			this.recorridosINFO.UseVisualStyleBackColor = false;
			this.recorridosINFO.Click += new System.EventHandler(this.RecorridosINFOClick);
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			// 
			// GrafoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Sienna;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(908, 522);
			this.Controls.Add(this.recorridosINFO);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBoxCamino);
			this.Controls.Add(this.numericUpProfundidad);
			this.Controls.Add(this.numericUpAnchura);
			this.Controls.Add(this.groupBoxParticulas);
			this.Controls.Add(this.buttonDistC);
			this.Controls.Add(this.buttonCaminoC);
			this.Controls.Add(this.treeViewGrafo);
			this.Controls.Add(this.pictureImageGrafo);
			this.Controls.Add(this.pictureBoxMinimize);
			this.Controls.Add(this.pictureBoxClose);
			this.Controls.Add(this.pictureBoxRestore);
			this.Controls.Add(this.pictureBoxMaximize);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GrafoForm";
			this.Text = "GrafoForm";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GrafoFormMouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureImageGrafo)).EndInit();
			this.groupBoxParticulas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpPosDest)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpPosPresa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDepre)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpNPresa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpAnchura)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpProfundidad)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button buttonSeleccionar;
		private System.Windows.Forms.ComboBox comboBoxPresas;
		private System.Windows.Forms.Button buttonPresaNormal;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button recorridosINFO;
		private System.Windows.Forms.NumericUpDown numericUpPosDest;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label NoParticulas;
		private System.Windows.Forms.Label PosP;
		private System.Windows.Forms.NumericUpDown numericUpPosPresa;
		private System.Windows.Forms.NumericUpDown numericUpDepre;
		private System.Windows.Forms.Button buttonDepre;
		private System.Windows.Forms.ListBox listBoxCamino;
		private System.Windows.Forms.NumericUpDown numericUpProfundidad;
		private System.Windows.Forms.NumericUpDown numericUpAnchura;
		private System.Windows.Forms.Button buttonAnimar;
		private System.Windows.Forms.NumericUpDown numericUpNPresa;
		private System.Windows.Forms.Button buttonInserccion;
		private System.Windows.Forms.GroupBox groupBoxParticulas;
		private System.Windows.Forms.Button buttonDistC;
		private System.Windows.Forms.Button buttonCaminoC;
		private System.Windows.Forms.TreeView treeViewGrafo;
		private System.Windows.Forms.PictureBox pictureImageGrafo;
		private System.Windows.Forms.PictureBox pictureBoxMaximize;
		private System.Windows.Forms.PictureBox pictureBoxRestore;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.PictureBox pictureBoxMinimize;
		
		
	}
}
