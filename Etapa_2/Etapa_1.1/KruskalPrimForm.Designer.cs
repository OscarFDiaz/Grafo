/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 29/11/2018
 * Time: 12:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Etapa_1._
{
	partial class KruskalPrimForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KruskalPrimForm));
			this.pictureImagePRIM = new System.Windows.Forms.PictureBox();
			this.pictureImageKRUSKAL = new System.Windows.Forms.PictureBox();
			this.buttonPRIM = new System.Windows.Forms.Button();
			this.buttonKruskal = new System.Windows.Forms.Button();
			this.numericUpPRIM = new System.Windows.Forms.NumericUpDown();
			this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.pictureBoxRestore = new System.Windows.Forms.PictureBox();
			this.pictureBoxMaximize = new System.Windows.Forms.PictureBox();
			this.listBoxPRIM = new System.Windows.Forms.ListBox();
			this.listBoxKRUSKAL = new System.Windows.Forms.ListBox();
			this.labelPesoPRIM = new System.Windows.Forms.Label();
			this.labelPesoKRUSKAL = new System.Windows.Forms.Label();
			this.buttonArista = new System.Windows.Forms.Button();
			this.buttonCamino = new System.Windows.Forms.Button();
			this.labelArista = new System.Windows.Forms.Label();
			this.labelCamino = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureImagePRIM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureImageKRUSKAL)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpPRIM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureImagePRIM
			// 
			this.pictureImagePRIM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureImagePRIM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
			this.pictureImagePRIM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureImagePRIM.BackgroundImage")));
			this.pictureImagePRIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureImagePRIM.Location = new System.Drawing.Point(12, 43);
			this.pictureImagePRIM.Name = "pictureImagePRIM";
			this.pictureImagePRIM.Size = new System.Drawing.Size(437, 273);
			this.pictureImagePRIM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureImagePRIM.TabIndex = 15;
			this.pictureImagePRIM.TabStop = false;
			// 
			// pictureImageKRUSKAL
			// 
			this.pictureImageKRUSKAL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureImageKRUSKAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
			this.pictureImageKRUSKAL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureImageKRUSKAL.BackgroundImage")));
			this.pictureImageKRUSKAL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.pictureImageKRUSKAL.Location = new System.Drawing.Point(459, 43);
			this.pictureImageKRUSKAL.Name = "pictureImageKRUSKAL";
			this.pictureImageKRUSKAL.Size = new System.Drawing.Size(437, 273);
			this.pictureImageKRUSKAL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureImageKRUSKAL.TabIndex = 16;
			this.pictureImageKRUSKAL.TabStop = false;
			// 
			// buttonPRIM
			// 
			this.buttonPRIM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonPRIM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonPRIM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonPRIM.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPRIM.FlatAppearance.BorderSize = 0;
			this.buttonPRIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPRIM.Location = new System.Drawing.Point(12, 322);
			this.buttonPRIM.Name = "buttonPRIM";
			this.buttonPRIM.Size = new System.Drawing.Size(131, 39);
			this.buttonPRIM.TabIndex = 17;
			this.buttonPRIM.Text = "Prim";
			this.toolTip1.SetToolTip(this.buttonPRIM, "Da click para visualizar el árbol de recumbrimiento mínimo con el algoritmo de Pr" +
						"im.");
			this.buttonPRIM.UseVisualStyleBackColor = false;
			this.buttonPRIM.Click += new System.EventHandler(this.ButtonPRIMClick);
			this.buttonPRIM.MouseLeave += new System.EventHandler(this.ButtonPRIMMouseLeave);
			this.buttonPRIM.MouseHover += new System.EventHandler(this.ButtonPRIMMouseHover);
			// 
			// buttonKruskal
			// 
			this.buttonKruskal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonKruskal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonKruskal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonKruskal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonKruskal.FlatAppearance.BorderSize = 0;
			this.buttonKruskal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonKruskal.Location = new System.Drawing.Point(459, 322);
			this.buttonKruskal.Name = "buttonKruskal";
			this.buttonKruskal.Size = new System.Drawing.Size(131, 39);
			this.buttonKruskal.TabIndex = 18;
			this.buttonKruskal.Text = "Kruskal";
			this.toolTip1.SetToolTip(this.buttonKruskal, "Da click para visualizar el árbol de recumbrimiento mínimo con el algoritmo de Kr" +
						"uskal");
			this.buttonKruskal.UseVisualStyleBackColor = false;
			this.buttonKruskal.Click += new System.EventHandler(this.ButtonKruskalClick);
			this.buttonKruskal.MouseLeave += new System.EventHandler(this.ButtonKruskalMouseLeave);
			this.buttonKruskal.MouseHover += new System.EventHandler(this.ButtonKruskalMouseHover);
			// 
			// numericUpPRIM
			// 
			this.numericUpPRIM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.numericUpPRIM.Location = new System.Drawing.Point(149, 334);
			this.numericUpPRIM.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.numericUpPRIM.Name = "numericUpPRIM";
			this.numericUpPRIM.Size = new System.Drawing.Size(45, 20);
			this.numericUpPRIM.TabIndex = 24;
			this.toolTip1.SetToolTip(this.numericUpPRIM, "Selecciona el vértice de donde deseas que inicie el algorirmo de Prim.");
			this.numericUpPRIM.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// pictureBoxMinimize
			// 
			this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.Image")));
			this.pictureBoxMinimize.Location = new System.Drawing.Point(807, 11);
			this.pictureBoxMinimize.Name = "pictureBoxMinimize";
			this.pictureBoxMinimize.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxMinimize.TabIndex = 27;
			this.pictureBoxMinimize.TabStop = false;
			this.pictureBoxMinimize.Click += new System.EventHandler(this.PictureBoxMinimizeClick);
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(869, 11);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxClose.TabIndex = 25;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxCloseClick);
			// 
			// pictureBoxRestore
			// 
			this.pictureBoxRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBoxRestore.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxRestore.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRestore.Image")));
			this.pictureBoxRestore.Location = new System.Drawing.Point(838, 12);
			this.pictureBoxRestore.Name = "pictureBoxRestore";
			this.pictureBoxRestore.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxRestore.TabIndex = 28;
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
			this.pictureBoxMaximize.Location = new System.Drawing.Point(838, 11);
			this.pictureBoxMaximize.Name = "pictureBoxMaximize";
			this.pictureBoxMaximize.Size = new System.Drawing.Size(26, 26);
			this.pictureBoxMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxMaximize.TabIndex = 26;
			this.pictureBoxMaximize.TabStop = false;
			this.pictureBoxMaximize.Click += new System.EventHandler(this.PictureBoxMaximizeClick);
			// 
			// listBoxPRIM
			// 
			this.listBoxPRIM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.listBoxPRIM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
			this.listBoxPRIM.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxPRIM.ForeColor = System.Drawing.SystemColors.Info;
			this.listBoxPRIM.FormattingEnabled = true;
			this.listBoxPRIM.Location = new System.Drawing.Point(12, 420);
			this.listBoxPRIM.Name = "listBoxPRIM";
			this.listBoxPRIM.Size = new System.Drawing.Size(437, 104);
			this.listBoxPRIM.TabIndex = 29;
			// 
			// listBoxKRUSKAL
			// 
			this.listBoxKRUSKAL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.listBoxKRUSKAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
			this.listBoxKRUSKAL.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBoxKRUSKAL.ForeColor = System.Drawing.SystemColors.Info;
			this.listBoxKRUSKAL.FormattingEnabled = true;
			this.listBoxKRUSKAL.Location = new System.Drawing.Point(458, 420);
			this.listBoxKRUSKAL.Name = "listBoxKRUSKAL";
			this.listBoxKRUSKAL.Size = new System.Drawing.Size(437, 104);
			this.listBoxKRUSKAL.TabIndex = 30;
			// 
			// labelPesoPRIM
			// 
			this.labelPesoPRIM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelPesoPRIM.Location = new System.Drawing.Point(200, 332);
			this.labelPesoPRIM.Name = "labelPesoPRIM";
			this.labelPesoPRIM.Size = new System.Drawing.Size(228, 22);
			this.labelPesoPRIM.TabIndex = 31;
			this.labelPesoPRIM.Text = "Peso total";
			this.labelPesoPRIM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.labelPesoPRIM, "Muestra el peso mínimo de todas las aristas al dar click en \'Prim\'.");
			// 
			// labelPesoKRUSKAL
			// 
			this.labelPesoKRUSKAL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelPesoKRUSKAL.Location = new System.Drawing.Point(596, 332);
			this.labelPesoKRUSKAL.Name = "labelPesoKRUSKAL";
			this.labelPesoKRUSKAL.Size = new System.Drawing.Size(228, 22);
			this.labelPesoKRUSKAL.TabIndex = 32;
			this.labelPesoKRUSKAL.Text = "Peso total";
			this.labelPesoKRUSKAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.labelPesoKRUSKAL, "Muestra el peso mínimo de todas las aristas al dar click en \'Kruskal\'.");
			// 
			// buttonArista
			// 
			this.buttonArista.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonArista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonArista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonArista.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonArista.FlatAppearance.BorderSize = 0;
			this.buttonArista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonArista.Location = new System.Drawing.Point(12, 367);
			this.buttonArista.Name = "buttonArista";
			this.buttonArista.Size = new System.Drawing.Size(131, 39);
			this.buttonArista.TabIndex = 33;
			this.buttonArista.Text = "Arista más corta";
			this.toolTip1.SetToolTip(this.buttonArista, "Da click para ver la arista más corta en el grafo generado.");
			this.buttonArista.UseVisualStyleBackColor = false;
			this.buttonArista.Click += new System.EventHandler(this.ButtonAristaClick);
			// 
			// buttonCamino
			// 
			this.buttonCamino.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.buttonCamino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
			this.buttonCamino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.buttonCamino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonCamino.FlatAppearance.BorderSize = 0;
			this.buttonCamino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCamino.Location = new System.Drawing.Point(459, 367);
			this.buttonCamino.Name = "buttonCamino";
			this.buttonCamino.Size = new System.Drawing.Size(131, 39);
			this.buttonCamino.TabIndex = 34;
			this.buttonCamino.Text = "Camino más corto";
			this.toolTip1.SetToolTip(this.buttonCamino, "Da click para ver el camino entre 4 vértices más corto en el grafo generado.");
			this.buttonCamino.UseVisualStyleBackColor = false;
			this.buttonCamino.Click += new System.EventHandler(this.ButtonCaminoClick);
			// 
			// labelArista
			// 
			this.labelArista.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelArista.Location = new System.Drawing.Point(200, 376);
			this.labelArista.Name = "labelArista";
			this.labelArista.Size = new System.Drawing.Size(228, 22);
			this.labelArista.TabIndex = 37;
			this.labelArista.Text = "Peso total";
			this.labelArista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.labelArista, "Muestra el peso mínimo de todas las aristas al dar click en \'Arista más corto\'.");
			// 
			// labelCamino
			// 
			this.labelCamino.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.labelCamino.Location = new System.Drawing.Point(596, 376);
			this.labelCamino.Name = "labelCamino";
			this.labelCamino.Size = new System.Drawing.Size(228, 22);
			this.labelCamino.TabIndex = 38;
			this.labelCamino.Text = "Peso total";
			this.labelCamino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip1.SetToolTip(this.labelCamino, "Muestra el peso mínimo de todas las aristas al dar click en \'Camino más corto\'.");
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label1.Location = new System.Drawing.Point(221, 407);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 35);
			this.label1.TabIndex = 39;
			this.label1.Text = "Lista de aristas dibujadas                                  Origen | Peso | Desti" +
			"no";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Location = new System.Drawing.Point(667, 407);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(228, 35);
			this.label2.TabIndex = 40;
			this.label2.Text = "Lista de aristas dibujadas                                  Origen | Peso | Desti" +
			"no";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// toolTip1
			// 
			this.toolTip1.IsBalloon = true;
			// 
			// KruskalPrimForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Sienna;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(908, 540);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelCamino);
			this.Controls.Add(this.labelArista);
			this.Controls.Add(this.buttonCamino);
			this.Controls.Add(this.buttonArista);
			this.Controls.Add(this.labelPesoKRUSKAL);
			this.Controls.Add(this.labelPesoPRIM);
			this.Controls.Add(this.listBoxKRUSKAL);
			this.Controls.Add(this.listBoxPRIM);
			this.Controls.Add(this.pictureBoxMinimize);
			this.Controls.Add(this.pictureBoxClose);
			this.Controls.Add(this.pictureBoxRestore);
			this.Controls.Add(this.pictureBoxMaximize);
			this.Controls.Add(this.numericUpPRIM);
			this.Controls.Add(this.buttonKruskal);
			this.Controls.Add(this.buttonPRIM);
			this.Controls.Add(this.pictureImageKRUSKAL);
			this.Controls.Add(this.pictureImagePRIM);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "KruskalPrimForm";
			this.Text = "KruskalPrimForm";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.KruskalPrimFormMouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pictureImagePRIM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureImageKRUSKAL)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpPRIM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRestore)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaximize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelCamino;
		private System.Windows.Forms.Label labelArista;
		private System.Windows.Forms.Button buttonCamino;
		private System.Windows.Forms.Button buttonArista;
		private System.Windows.Forms.Label labelPesoKRUSKAL;
		private System.Windows.Forms.Label labelPesoPRIM;
		private System.Windows.Forms.ListBox listBoxKRUSKAL;
		private System.Windows.Forms.ListBox listBoxPRIM;
		private System.Windows.Forms.PictureBox pictureBoxMaximize;
		private System.Windows.Forms.PictureBox pictureBoxRestore;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.PictureBox pictureBoxMinimize;
		private System.Windows.Forms.NumericUpDown numericUpPRIM;
		private System.Windows.Forms.Button buttonKruskal;
		private System.Windows.Forms.Button buttonPRIM;
		private System.Windows.Forms.PictureBox pictureImageKRUSKAL;
		private System.Windows.Forms.PictureBox pictureImagePRIM;
	}
}
