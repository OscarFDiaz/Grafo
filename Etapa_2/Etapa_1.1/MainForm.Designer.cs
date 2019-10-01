/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 21/08/2018
 * Time: 01:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Etapa_1._
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureImage = new System.Windows.Forms.PictureBox();
			this.buttonAbrir = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonAnalizar = new System.Windows.Forms.Button();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.pictureBoxMaximize = new System.Windows.Forms.PictureBox();
			this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
			this.pictureBoxRestore = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.buttonGrafo = new System.Windows.Forms.Button();
			this.recorridosINFO = new System.Windows.Forms.Button();
			this.aImagenINFO = new System.Windows.Forms.Button();
			this.analizarCINFO = new System.Windows.Forms.Button();
			this.particulasINFO = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureImage
			// 
			this.pictureImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
			this.pictureImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureImage.BackgroundImage")));
			this.pictureImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureImage.Location = new System.Drawing.Point(39, 30);
			this.pictureImage.Name = "pictureImage";
			this.pictureImage.Size = new System.Drawing.Size(585, 345);
			this.pictureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureImage.TabIndex = 0;
			this.pictureImage.TabStop = false;
			// 
			// buttonAbrir
			// 
			this.buttonAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonAbrir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonAbrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAbrir.FlatAppearance.BorderSize = 0;
			this.buttonAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonAbrir.Location = new System.Drawing.Point(39, 397);
			this.buttonAbrir.Name = "buttonAbrir";
			this.buttonAbrir.Size = new System.Drawing.Size(111, 60);
			this.buttonAbrir.TabIndex = 1;
			this.buttonAbrir.Text = "Abrir Imagen";
			this.buttonAbrir.UseVisualStyleBackColor = false;
			this.buttonAbrir.Click += new System.EventHandler(this.ButtonAbrirClick);
			this.buttonAbrir.MouseLeave += new System.EventHandler(this.ButtonAbrirMouseLeave);
			this.buttonAbrir.MouseHover += new System.EventHandler(this.ButtonAbrirMouseHover);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// buttonAnalizar
			// 
			this.buttonAnalizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonAnalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonAnalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonAnalizar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAnalizar.FlatAppearance.BorderSize = 0;
			this.buttonAnalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonAnalizar.Location = new System.Drawing.Point(265, 397);
			this.buttonAnalizar.Name = "buttonAnalizar";
			this.buttonAnalizar.Size = new System.Drawing.Size(111, 60);
			this.buttonAnalizar.TabIndex = 2;
			this.buttonAnalizar.Text = "Analizar Centro";
			this.buttonAnalizar.UseVisualStyleBackColor = false;
			this.buttonAnalizar.Click += new System.EventHandler(this.Button1Click);
			this.buttonAnalizar.MouseLeave += new System.EventHandler(this.ButtonAnalizarMouseLeave);
			this.buttonAnalizar.MouseHover += new System.EventHandler(this.ButtonAnalizarMouseHover);
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(860, 11);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxClose.TabIndex = 6;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxCloseClick);
			// 
			// pictureBoxMaximize
			// 
			this.pictureBoxMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxMaximize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMaximize.Image")));
			this.pictureBoxMaximize.Location = new System.Drawing.Point(829, 11);
			this.pictureBoxMaximize.Name = "pictureBoxMaximize";
			this.pictureBoxMaximize.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxMaximize.TabIndex = 7;
			this.pictureBoxMaximize.TabStop = false;
			this.pictureBoxMaximize.Click += new System.EventHandler(this.PictureBoxMaximizeClick);
			// 
			// pictureBoxMinimize
			// 
			this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.Image")));
			this.pictureBoxMinimize.Location = new System.Drawing.Point(798, 11);
			this.pictureBoxMinimize.Name = "pictureBoxMinimize";
			this.pictureBoxMinimize.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxMinimize.TabIndex = 8;
			this.pictureBoxMinimize.TabStop = false;
			this.pictureBoxMinimize.Click += new System.EventHandler(this.PictureBoxMinimizeClick);
			// 
			// pictureBoxRestore
			// 
			this.pictureBoxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxRestore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxRestore.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRestore.Image")));
			this.pictureBoxRestore.Location = new System.Drawing.Point(829, 11);
			this.pictureBoxRestore.Name = "pictureBoxRestore";
			this.pictureBoxRestore.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxRestore.TabIndex = 9;
			this.pictureBoxRestore.TabStop = false;
			this.pictureBoxRestore.Visible = false;
			this.pictureBoxRestore.Click += new System.EventHandler(this.PictureBoxRestoreClick);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(671, 89);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(200, 286);
			this.listBox1.TabIndex = 5;
			// 
			// buttonGrafo
			// 
			this.buttonGrafo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonGrafo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonGrafo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonGrafo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGrafo.FlatAppearance.BorderSize = 0;
			this.buttonGrafo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.buttonGrafo.Location = new System.Drawing.Point(491, 397);
			this.buttonGrafo.Name = "buttonGrafo";
			this.buttonGrafo.Size = new System.Drawing.Size(111, 60);
			this.buttonGrafo.TabIndex = 11;
			this.buttonGrafo.Text = "Particulas";
			this.buttonGrafo.UseVisualStyleBackColor = false;
			this.buttonGrafo.Click += new System.EventHandler(this.ButtonGrafoClick);
			this.buttonGrafo.MouseLeave += new System.EventHandler(this.ButtonGrafoMouseLeave);
			this.buttonGrafo.MouseHover += new System.EventHandler(this.ButtonGrafoMouseHover);
			// 
			// recorridosINFO
			// 
			this.recorridosINFO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.recorridosINFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.recorridosINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.recorridosINFO.Cursor = System.Windows.Forms.Cursors.Hand;
			this.recorridosINFO.FlatAppearance.BorderSize = 0;
			this.recorridosINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.recorridosINFO.Location = new System.Drawing.Point(713, 397);
			this.recorridosINFO.Name = "recorridosINFO";
			this.recorridosINFO.Size = new System.Drawing.Size(111, 60);
			this.recorridosINFO.TabIndex = 12;
			this.recorridosINFO.Text = "Ver recorridos";
			this.recorridosINFO.UseVisualStyleBackColor = false;
			this.recorridosINFO.Click += new System.EventHandler(this.ButtonKPRIMClick);
			this.recorridosINFO.MouseLeave += new System.EventHandler(this.ButtonKPRIMMouseLeave);
			this.recorridosINFO.MouseHover += new System.EventHandler(this.ButtonKPRIMMouseHover);
			// 
			// aImagenINFO
			// 
			this.aImagenINFO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.aImagenINFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.aImagenINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.aImagenINFO.Cursor = System.Windows.Forms.Cursors.Hand;
			this.aImagenINFO.FlatAppearance.BorderSize = 0;
			this.aImagenINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.aImagenINFO.Location = new System.Drawing.Point(156, 410);
			this.aImagenINFO.Name = "aImagenINFO";
			this.aImagenINFO.Size = new System.Drawing.Size(44, 35);
			this.aImagenINFO.TabIndex = 14;
			this.aImagenINFO.Text = "?";
			this.toolTip1.SetToolTip(this.aImagenINFO, "Da click en \'ABRIR IMAGEN\' para abrir una imagen, y posteriormente en \'ANALIZAR C" +
						"ENTRO\',  después podrás usar todas las demás opciones,  recuerda hacer siempre l" +
						"o mismo al cargar una imagen diferente.");
			this.aImagenINFO.UseVisualStyleBackColor = false;
			this.aImagenINFO.Click += new System.EventHandler(this.AImagenINFOClick);
			// 
			// analizarCINFO
			// 
			this.analizarCINFO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.analizarCINFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.analizarCINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.analizarCINFO.Cursor = System.Windows.Forms.Cursors.Hand;
			this.analizarCINFO.FlatAppearance.BorderSize = 0;
			this.analizarCINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.analizarCINFO.Location = new System.Drawing.Point(382, 410);
			this.analizarCINFO.Name = "analizarCINFO";
			this.analizarCINFO.Size = new System.Drawing.Size(44, 35);
			this.analizarCINFO.TabIndex = 15;
			this.analizarCINFO.Text = "?";
			this.toolTip1.SetToolTip(this.analizarCINFO, "Al dar click en \'ANALIZAR CENTRO\', el programa buscara los centros en tu imagen c" +
						"argada, una vez encontrados podrás disfrutar de todo el programa.");
			this.analizarCINFO.UseVisualStyleBackColor = false;
			this.analizarCINFO.Click += new System.EventHandler(this.AnalizarCINFOClick);
			// 
			// particulasINFO
			// 
			this.particulasINFO.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.particulasINFO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.particulasINFO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.particulasINFO.Cursor = System.Windows.Forms.Cursors.Hand;
			this.particulasINFO.FlatAppearance.BorderSize = 0;
			this.particulasINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.particulasINFO.Location = new System.Drawing.Point(608, 410);
			this.particulasINFO.Name = "particulasINFO";
			this.particulasINFO.Size = new System.Drawing.Size(44, 35);
			this.particulasINFO.TabIndex = 16;
			this.particulasINFO.Text = "?";
			this.toolTip1.SetToolTip(this.particulasINFO, resources.GetString("particulasINFO.ToolTip"));
			this.particulasINFO.UseVisualStyleBackColor = false;
			this.particulasINFO.Click += new System.EventHandler(this.ParticulasINFOClick);
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.button3.Location = new System.Drawing.Point(830, 410);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(44, 35);
			this.button3.TabIndex = 17;
			this.button3.Text = "?";
			this.toolTip1.SetToolTip(this.button3, resources.GetString("button3.ToolTip"));
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(691, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 23);
			this.label1.TabIndex = 18;
			this.label1.Text = "Lista de circulos encontrados";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Sienna;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(908, 493);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.particulasINFO);
			this.Controls.Add(this.analizarCINFO);
			this.Controls.Add(this.aImagenINFO);
			this.Controls.Add(this.recorridosINFO);
			this.Controls.Add(this.buttonGrafo);
			this.Controls.Add(this.pictureBoxMinimize);
			this.Controls.Add(this.pictureBoxClose);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.buttonAnalizar);
			this.Controls.Add(this.buttonAbrir);
			this.Controls.Add(this.pictureImage);
			this.Controls.Add(this.pictureBoxRestore);
			this.Controls.Add(this.pictureBoxMaximize);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Etapa_1.1";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button particulasINFO;
		private System.Windows.Forms.Button analizarCINFO;
		private System.Windows.Forms.Button aImagenINFO;
		private System.Windows.Forms.Button recorridosINFO;
		private System.Windows.Forms.Button buttonGrafo;
		private System.Windows.Forms.PictureBox pictureBoxRestore;
		private System.Windows.Forms.PictureBox pictureBoxMinimize;
		private System.Windows.Forms.PictureBox pictureBoxMaximize;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button buttonAnalizar;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button buttonAbrir;
		private System.Windows.Forms.PictureBox pictureImage;
	}
}
