/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 29/11/2018
 * Time: 12:10 p. m.
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
	/// Description of KruskalPrimForm.
	/// </summary>
	public partial class KruskalPrimForm : Form
	{
		Grafo graf;
		Bitmap imgGrafo;
		
		Bitmap bmpGrafo;
		
		public KruskalPrimForm(Grafo g, Bitmap bmp)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			graf = g;
			imgGrafo = bmp;
			InitializeComponent();
			pictureImageKRUSKAL.Image = imgGrafo;
			pictureImagePRIM.Image = imgGrafo;
			
		}
		
		void ButtonPRIMClick(object sender, EventArgs e)
		{
			numericUpPRIM.Maximum = graf.getLV().Count;
			Vertice origen = new Vertice();
			
			int vertice = 0;
			vertice = (int)numericUpPRIM.Value;
			
			foreach(Vertice v in graf.getLV()){
				if(v.getId() == vertice){
					origen = v;
					break;
				}
			}
			//KruskalPrim prim = new KruskalPrim(graf, imgGrafo);
			hazPrim(origen); //Falta vertice origen
		}
		
		
		void hazPrim(Vertice origen)
		{
			double pesoTotal = 0;
			bmpGrafo = new Bitmap(imgGrafo);
			List<Arista> C = new List<Arista>(graf.getLA()); //< Candidatos, con la lista de aristas
			List<Arista> PSolucion = new List<Arista>(); //< Solucion con las posibles aristas
			List<Vertice> visitados = new List<Vertice>(); //< Vertices que ya fueron visitados
			
			visitados.Add(origen);
			
			if(C.Count == 0){
				return;
			}
			
			C.Sort(
				delegate(Arista p1, Arista p2)
				{
					return p1.getDistancia().CompareTo(p2.getDistancia());
				}
			);
			
			while(visitados.Count < graf.getLV().Count){
				
				Arista a = new Arista();
				
				a = aristaSaliente(visitados, C); //Me regresa la arista menor
				//Si me regresa una arista dummy es porque termino una isla y no hay más vertices
				if(a.getDistancia() == double.MaxValue){
					visitados.Add(buscarIsla(visitados, C)); //Busco una "isla", que me regresa un vertice y lo añado a visitadis
					continue;
				}
				PSolucion.Add(a);// Añado a mi solucion la arista
				//Añado el vertice de la arista dependiendo de cual haga falta
				if(visitados.Contains(a.getOrigen())){
					visitados.Add(a.getDestino());
				}else{
					visitados.Add(a.getOrigen());
				}
			}
			
			//Dibujo las aristas de un color diferente y sumo las distancias de todas mis aristas para marcar el peso total del arbol
			Graphics gra = Graphics.FromImage(bmpGrafo);
			Pen lapiz = new Pen(Color.Blue, 10);
			for(int i = 0; i < PSolucion.Count; i++){
				try{
					gra.DrawLine(lapiz, PSolucion[i].getOrigen().getCircle().getP().X, PSolucion[i].getOrigen().getCircle().getP().Y, PSolucion[i].getDestino().getCircle().getP().X, PSolucion[i].getDestino().getCircle().getP().Y);
				}catch(Exception ex){}
			}
			
			foreach (Arista a in PSolucion)
			{
				pesoTotal += a.getDistancia();
			}
			
			listBoxPRIM.DataSource = null;
			listBoxPRIM.DataSource = PSolucion;
			
			labelPesoPRIM.Text = "Peso Total: " + Math.Round(pesoTotal, 4);
			pictureImagePRIM.Image = bmpGrafo;
		}
		
		public void hazKruskal()
		{
			bmpGrafo = new Bitmap(imgGrafo);
			int conta = 0;
			double pesoTotal = 0;
			
			List<Arista> C = new List<Arista>(graf.getLA()); //Lista de aristas
			List<Arista> solucion = new List<Arista>();
			List<List<Vertice>> CC = new List<List<Vertice>>(); //Lista de lista de vertices, conjunto conexo
			
			C.Sort(
				delegate(Arista p1, Arista p2)
				{
					return p1.getDistancia().CompareTo(p2.getDistancia());
				}
			);
			
			//Leno mi lista de compoentes conexos con una lista individual de vertices
			for(int i = 0; i < graf.getLV().Count; i++){
				List<Vertice> comp = new List<Vertice>();
				comp.Add(graf.getLV()[i]);
				
				CC.Add(comp);
			}
			
			while(conta < graf.getLA().Count){
				Arista a = new Arista();
				
				if(C.Count == 0 ){
					return;
				}
				
				a = C[conta]; //Selecciono la arista que va en mi contador, siempre será la menor
				
				conta++;
				
				//Factible
				a.getOrigen();
				a.getDestino();
				int e1 = 0, e2=0;
				
				for(int i = 0; i < CC.Count; i++){
					List<Vertice> laux = new List<Vertice>();
					laux = CC[i];
					
					//Obtengo los rangos para crear los componenetes conexos y hacerlos una lista
					for(int j = 0; j < CC[i].Count; j++){
						
						if(a.getOrigen() == laux[j]){
							e1 = i;
						}
						if(a.getDestino() == laux[j]){
							e2 = i;
						}
					}
				}
				
				//Concateno los componentes conexos
				if(e1 != e2 ){
					solucion.Add(a);
					CC[e1].AddRange(CC[e2]);
					CC.RemoveAt(e2);
				}
			}
			
			listBoxKRUSKAL.DataSource = null;
			listBoxKRUSKAL.DataSource =  solucion;
			
			//Dibujo las aristas restantes en mi slución
			Graphics gra = Graphics.FromImage(bmpGrafo);
			Pen lapiz = new Pen(Color.Blue, 10);
			for(int i = 0; i < solucion.Count; i++){
				gra.DrawLine(lapiz, solucion[i].getOrigen().getCircle().getP().X, solucion[i].getOrigen().getCircle().getP().Y, solucion[i].getDestino().getCircle().getP().X, solucion[i].getDestino().getCircle().getP().Y);
			}
			
			foreach (Arista a in solucion)
			{
				pesoTotal += a.getDistancia();
			}
			
			labelPesoKRUSKAL.Text = "Peso Total: " + Math.Round(pesoTotal, 4);
			
			pictureImageKRUSKAL.Image = bmpGrafo;
		}
		
		private Arista aristaSaliente(List<Vertice> S, List<Arista> C) //< Lista de visitados, lista de aristas
		{
			Arista a_min = new Arista(null,null,double.MaxValue, null); //Arista dummy
			bool cumple;
			foreach(Arista a_1 in C){
				
				cumple = false;
				//me aseguro de que la arista cumpla que no es un ciclo
				if((S.Contains(a_1.getOrigen()) && !S.Contains(a_1.getDestino())) || (!S.Contains(a_1.getOrigen())  && S.Contains(a_1.getDestino()))){
					cumple = true;
				}
				//Si cumple y es menor es la arista candidato
				if(cumple && a_1.getDistancia() < a_min.getDistancia()){
					a_min = a_1;
				}
			}
			//Elimino la arista de mis candidatos y la regreso
			if(a_min.getDistancia() != double.MaxValue){
				C.Remove(a_min);
			}
			return a_min;
		}
		
		Vertice buscarIsla(List<Vertice> visitados, List<Arista> g){
			if(visitados.Count < g.Count){
				for(int i = 0; i < g.Count; i++){
					if(!visitados.Contains(g[i].getOrigen())){
						return g[i].getOrigen();
					}
				}
			}
			return null;
		}
		
		void ButtonAristaClick(object sender, EventArgs e)
		{
			bmpGrafo = new Bitmap(imgGrafo);
			FuerzaBruta fbr = new FuerzaBruta(graf);
			fbr.paresMinimo();
			
			Graphics graphics = Graphics.FromImage(bmpGrafo);
			Pen pen = new Pen(Color.Black, 10);
			if (fbr.getCamino().Count > 1)
			{
				graphics.DrawLine(pen, fbr.getCamino()[0].getCircle().getP(), fbr.getCamino()[1].getCircle().getP());
				labelArista.Text = "Peso total:" + Math.Round(fbr.getMin(), 4);
				
				pictureImagePRIM.Image = bmpGrafo;
				listBoxPRIM.DataSource = null;
				listBoxPRIM.DataSource =  fbr.getCamino();
			}else{
				MessageBox.Show("-Error: El grafo debe contener almenos 2 vertices adyacentes.");
			}
		}
		
		void ButtonCaminoClick(object sender, EventArgs e)
		{
			bmpGrafo = new Bitmap(imgGrafo);
			FuerzaBruta fbr = new FuerzaBruta(graf);
			fbr.CaminoMasCorto();
			
			
			Graphics graphics = Graphics.FromImage(bmpGrafo);
			
			Pen pen = new Pen(Color.Black, 10);
			if (fbr.getCamino().Count > 3)
			{
				graphics.DrawLine(pen, fbr.getCamino()[0].getCircle().getP(), fbr.getCamino()[1].getCircle().getP());
				graphics.DrawLine(pen, fbr.getCamino()[1].getCircle().getP(), fbr.getCamino()[2].getCircle().getP());
				graphics.DrawLine(pen, fbr.getCamino()[2].getCircle().getP(), fbr.getCamino()[3].getCircle().getP());
				labelCamino.Text = "Peso total:" + Math.Round(fbr.getMin(), 4);
				pictureImageKRUSKAL.Image = bmpGrafo;
				listBoxKRUSKAL.DataSource = null;
				listBoxKRUSKAL.DataSource =  fbr.getCamino();
			}
			else
			{
				MessageBox.Show("-Error: El grafo debe contener almenos 4 vertices adyacentes.");
			}
		}
		
		/// PANTALLA
		void ButtonKruskalClick(object sender, EventArgs e)
		{
			//KruskalPrim prim = new KruskalPrim(graf, imgGrafo);
			hazKruskal(); //Falata vertice origen
		}
		
		void ButtonPRIMMouseHover(object sender, EventArgs e)
		{
			//Mouse encima
			buttonPRIM.BackColor = Color.FromArgb(255, 87, 51);
		}
		
		void ButtonPRIMMouseLeave(object sender, EventArgs e)
		{
			//Retirar el mouse de encima
			buttonPRIM.BackColor = Color.FromArgb(255,195,0);
		}
		
		void ButtonKruskalMouseHover(object sender, EventArgs e)
		{
			//Mouse encima
			buttonKruskal .BackColor = Color.FromArgb(255, 87, 51);
		}
		
		void ButtonKruskalMouseLeave(object sender, EventArgs e)
		{
			//Retirar el mouse de encima
			buttonKruskal.BackColor = Color.FromArgb(255,195,0);
		}
		
		void PictureBoxMinimizeClick(object sender, EventArgs e)
		{
			//Minimizar
			this.WindowState = FormWindowState.Minimized;
		}
		
		void PictureBoxRestoreClick(object sender, EventArgs e)
		{
			//Restaurar
			this.WindowState = FormWindowState.Normal;
			pictureBoxMaximize.Visible = true;
			pictureBoxRestore.Visible = false;
		}
		
		void PictureBoxMaximizeClick(object sender, EventArgs e)
		{
			//Maximizar
			this.WindowState = FormWindowState.Maximized;
			pictureBoxMaximize.Visible = false;
			pictureBoxRestore.Visible = true;
			
		}
		
		void PictureBoxCloseClick(object sender, EventArgs e)
		{
			//Cerrar
			this.Close();
		}
		
		////> Me permite mover la ventana, usando un estilo sin bordes
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		
		void KruskalPrimFormMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		////<
		
		
	}
}
