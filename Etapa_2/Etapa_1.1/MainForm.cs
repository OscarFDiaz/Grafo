﻿/*
	 * Created by SharpDevelop.
	 * User: Usuario
	 * Date: 21/08/2018
	 * Time: 01:44 p. m.
	 * 
	 * To change this template use Tools | Options | Coding | Edit Standard Headers.
	 */
	using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Etapa_1._
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		//Bitmap bmpOriginal;
		string imagenR;
		Grafo g;
		ImageProcessing ip;
		List<Circle> lc;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			buttonGrafo.Enabled = false;
			buttonAnalizar.Enabled = false;
			recorridosINFO.Enabled = false;
		}
		
		void ButtonAbrirClick(object sender, EventArgs e)
		{
			buttonGrafo.Enabled = false;
			buttonAnalizar.Enabled = false;
			recorridosINFO.Enabled = false;
			listBox1.DataSource = null;
			try
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					imagenR = openFileDialog1.FileName;
					pictureImage.Image = Image.FromFile(imagenR);
					buttonAnalizar.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
			}
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			if(imagenR == null){
				MessageBox.Show("ERROR: Debe de haber un archivo seleccionado");
				return;
			}
			
			//codigo que remplaza todo
			ip = new ImageProcessing(imagenR);
			lc = ip.findCenters();
			
			pictureImage.Image = ip.imagenAct();
			
			listBox1.DataSource = lc;//< Añado a la listbox lo que tiene la lista (las coordenadas)
			
			MessageBox.Show("PROCESO TERMINADO");
			buttonGrafo.Enabled = true;
			recorridosINFO.Enabled = true;
			
		}
		
		void ButtonGrafoClick(object sender, EventArgs e)
		{
			g = new Grafo(lc, imagenR, ip.imagenAct());
			
			GrafoForm ventanaGrafo = new GrafoForm(g, ip.imagenAct());
			ventanaGrafo.ShowDialog();
		}
		
		void ButtonKPRIMClick(object sender, EventArgs e)
		{
			g = new Grafo(lc, imagenR, ip.imagenAct());
			KruskalPrimForm  ventanPrimKru = new KruskalPrimForm(g, ip.imagenAct());
			ventanPrimKru.ShowDialog();
		}
		
		void ButtonAbrirMouseHover(object sender, EventArgs e)
		{
			buttonAbrir.BackColor = Color.FromArgb(255,87,51);
		}
		
		void ButtonAbrirMouseLeave(object sender, EventArgs e)
		{
			buttonAbrir.BackColor = Color.FromArgb(255,195,0);
		}
		
		void ButtonAnalizarMouseHover(object sender, EventArgs e)
		{
			buttonAnalizar.BackColor = Color.FromArgb(255,87,51);
		}
		
		void ButtonAnalizarMouseLeave(object sender, EventArgs e)
		{
			buttonAnalizar.BackColor = Color.FromArgb(255,195,0);
		}
		
		void ButtonGrafoMouseHover(object sender, EventArgs e)
		{
			buttonGrafo.BackColor = Color.FromArgb(255, 87, 51);
		}
		
		void ButtonGrafoMouseLeave(object sender, EventArgs e)
		{
			buttonGrafo.BackColor = Color.FromArgb(255,195,0);
		}
		
		void PictureBoxCloseClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void PictureBoxMaximizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			pictureBoxMaximize.Visible = false;
			pictureBoxRestore.Visible = true;
		}
		
		void PictureBoxRestoreClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			pictureBoxMaximize.Visible = true;
			pictureBoxRestore.Visible = false;
		}
		
		//Minimizar la ventana
		void PictureBoxMinimizeClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		
		
		////> Me permite mover la ventana, usando un estilo sin bordes
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		
		void MainFormMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		////<
		/// 
		void ButtonKPRIMMouseHover(object sender, EventArgs e)
		{
			recorridosINFO.BackColor = Color.FromArgb(255, 87, 51);
		}
		
		void ButtonKPRIMMouseLeave(object sender, EventArgs e)
		{
			recorridosINFO.BackColor = Color.FromArgb(255,195,0);
		}
		
		//INFO BOTON ABRIR IMAGEN
		void AImagenINFOClick(object sender, EventArgs e)
		{
			MessageBox.Show("Da click en 'ABRIR IMAGEN' para abrir una imagen, y posteriormente en 'ANALIZAR CENTRO', \n después podrás usar todas las demás opciones, \n recuerda hacer siempre lo mismo al cargar una imagen diferente.");
		}
		
		//ANALIZAR CENTRO INFO
		void AnalizarCINFOClick(object sender, EventArgs e)
		{
			MessageBox.Show("Al dar click en 'ANALIZAR CENTRO', \nel programa buscara los centros en tu imagen cargada, una vez encontrados podrás disfrutar de todo el programa.");
		}
		
		//INFO PARTICULAS
		void ParticulasINFOClick(object sender, EventArgs e)
		{
			MessageBox.Show("Al dar click en 'PARTÍCULAS', \npodrás crear partículas presas y depredadoras, las cuales \nse moverán en amplitud y profundidad a través de la imagen, \nademás podrás ver como una partícula recorre el grafo de un origen a un destino seleccionado de la manera más corta posible, \ntambién podrás ver como las presas son consumidas por las depredadoras si estas colisionan.");
		}
		
		//RECORRIDOS INFO
		void Button3Click(object sender, EventArgs e)
		{
			MessageBox.Show("Al dar click en 'RECORRIDOS', \npodrás visualizar recorridos mediante Kruskal, Prim para árboles de recubrimiento mínimo, \ntambién podrás ver la distancia minima entre 4 vértices y ver la arista más pequeña existente.");
		}
	}
}