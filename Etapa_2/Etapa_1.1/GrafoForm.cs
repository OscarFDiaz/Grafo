/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 10/10/2018
 * Time: 10:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Etapa_1._
{
	/// <summary>
	/// Description of GrafoForm.
	/// </summary>
	/// 
	
	public partial class GrafoForm : Form
	{
		Grafo g;
		Bitmap imgGrafo, iTransp;
		List<Particula> lParticulas = new List<Particula>();
		List<int> vOcupados = new List<int>();
		int totalVertices;
		int disponibles;
		bool esDijk = false;
		public GrafoForm(Grafo g, Bitmap bmp)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.g = g;
			imgGrafo = bmp;
			InitializeComponent();
			disponibles = totalVertices = g.getLV().Count;
			pictureImageGrafo.BackgroundImage = imgGrafo;
			
			iTransp = new Bitmap(imgGrafo.Width, imgGrafo.Height);//
			
			//tree view del grafo
			treeViewGrafo.Nodes.Clear();
			
			int contVertices = 0;
			foreach(Vertice v in g.getLV()){
				contVertices++;
				List<Arista> la = v.getLA();
				TreeNode[] array = new TreeNode[la.Count()];
				
				int i = 0;
				foreach(Arista a in la){
					
					TreeNode subNode = new TreeNode(a.getDestino().getId().ToString());
					array[i] = subNode;
					i++;
				}
				TreeNode node = new TreeNode(v.getId().ToString(), array);
				treeViewGrafo.Nodes.Add(node);
			}
			pictureImageGrafo.Image = iTransp;
			pictureImageGrafo.BackgroundImageLayout = ImageLayout.Zoom;
			
			numericUpPosPresa.Enabled = false;
			numericUpNPresa.Enabled = false;
			numericUpPosDest.Enabled = false;
		}
		
		// Recorrido amplitud
		void ButtonCaminoCClick(object sender, EventArgs e)
		{
			numericUpAnchura.Maximum = g.getLV().Count;
			RecorridosGrafo rg = new RecorridosGrafo(g);
			listBoxCamino.DataSource = null;
			listBoxCamino.DataSource = rg.getRecorridoAmplitud(g.getLV()[((int)numericUpAnchura.Value)-1]);
			
		}
		// Recorrido profundidad
		void ButtonDistCClick(object sender, EventArgs e)
		{
			numericUpProfundidad.Maximum = g.getLV().Count;
			RecorridosGrafo rg = new RecorridosGrafo(g);
			listBoxCamino.DataSource = null;
			listBoxCamino.DataSource = rg.getRecorridoProfundidad(g.getLV()[((int)numericUpProfundidad.Value)-1]);
		}
		
		//Selecciona dijkstra o normal
		void ButtonSeleccionarClick(object sender, EventArgs e)
		{
			string var;
			var = comboBoxPresas.Text;
			
			if(var == "Inserta Presas"){
				numericUpPosPresa.Enabled = true;
				numericUpPosPresa.Minimum = 0;
				numericUpPosPresa.Value = 0;
				
				numericUpPosDest.Enabled = false;
				numericUpPosDest.Minimum = 0;
				numericUpPosDest.Value = 0;
				
				numericUpNPresa.Enabled = true;
				numericUpNPresa.Value = 1;
				
				buttonDepre.Enabled = true;
				
				esDijk = false;
				lParticulas.Clear();
				vOcupados.Clear();
			}else if(var == "Inserta Presa Dijkstra"){
				MessageBox.Show("Recuerda que Dijkstra sólo funciona con grafos conexos");
				numericUpPosPresa.Enabled = true;
				numericUpPosPresa.Minimum = 1;
				numericUpPosPresa.Maximum = g.getLV().Count;
				
				numericUpPosDest.Enabled = true;
				numericUpPosDest.Minimum = 1;
				numericUpPosDest.Maximum = g.getLV().Count;
				
				numericUpNPresa.Enabled = false;
				numericUpNPresa.Value = 1;
				esDijk = true;
				
				lParticulas.Clear();
				vOcupados.Clear();
			}else if(var == ""){
				MessageBox.Show("Selecciona una opción valida");
			}
		}
		
		///Particulas presa
		void ButtonPresaNormalClick(object sender, EventArgs e)
		{
			
			if(!esDijk){
				buttonDepre.Enabled = true;
				int selecciono = (int)numericUpNPresa.Value;
				numericUpPosPresa.Maximum = g.getLV().Count; //< Para poner una particula en una pos especifica
				numericUpPosDest.Maximum = g.getLV().Count;
				if(selecciono <= totalVertices && selecciono <= disponibles){
					disponibles = disponibles - selecciono;
					if(disponibles >= 0){
						if((int)numericUpPosDest.Value == 0 && (int)numericUpPosPresa.Value == 0 && (int)numericUpNPresa.Value > 0){
							//TODO: INSERTO ALEATORIAMENTE
							Random r = new Random();
							int posParticula;
							for(int i = 0; i < selecciono; i++){
								posParticula = r.Next(0, g.getLV().Count);
								while(vOcupados.Contains(posParticula)){
									posParticula = r.Next(0, g.getLV().Count);
								}
								vOcupados.Add(posParticula);
								
								//Inserto recorrido en profundidad
								RecorridosGrafo rg = new RecorridosGrafo(g);
								List<Vertice> rec = new List<Vertice>();
								
								rec = rg.getRecorridoProfundidad(g.getLV()[posParticula]);
								
								Particula p = new Particula(posParticula, rec, false);
								lParticulas.Add(p);
							}
						}else if((int)numericUpPosPresa.Value != 0 && (int)numericUpPosDest.Value == 0 && (int)numericUpNPresa.Value == 1){
							//TODO: INSERTO EN EL ORIGEN SELECCIONADO
							int posP = (int)numericUpPosPresa.Value - 1;
							if(vOcupados.Contains(posP)){
								MessageBox.Show("Ese vértice origen ya esta ocupado");
								return;
							}
							vOcupados.Add(posP);
							RecorridosGrafo rg = new RecorridosGrafo(g);
							List<Vertice> rec = new List<Vertice>();
							
							rec = rg.getRecorridoProfundidad(g.getLV()[posP]);
							Particula p = new Particula(posP, rec, false);
							
							lParticulas.Add(p);
						}else if((int)numericUpPosPresa.Value != 0 && (int)numericUpNPresa.Value > 0){
							disponibles = disponibles + selecciono;
							MessageBox.Show("No puedes insertar multiples particulas en el mismo vértice");
						}
					}else{
						MessageBox.Show("No hay más lugares disponibles.");
					}
					dibujaParticulas();
					buttonAnimar.Visible = true;
				}else{
					MessageBox.Show("No puedes insertar más particulas que los vértices disponibles.");
				}
			}else{
				
				buttonAnimar.Visible = true;
				
				int posO, posD, posParticula;
				posO = (int)numericUpPosPresa.Value-1;
				posD = (int)numericUpPosDest.Value-1;
				
				if(posD == posO){
					MessageBox.Show("El origen no puede ser igual al actual destino");
					return;
				}
				
				Dijkstra dij = new Dijkstra(g, g.getLV()[posO], g.getLV()[posD]);
				
				disponibles--;
				posParticula = posO;
				if(vOcupados.Contains(posParticula)){
					MessageBox.Show("Ese vertice ya pertenece a un depredador");
				}else{
					vOcupados.Add(posParticula);
					Particula p = new Particula(posParticula, dij.getLCamino(), false);
					lParticulas.Add(p);
					buttonDepre.Enabled = true;
				}
				dibujaParticulas();
				
				listBoxCamino.DataSource = dij.getLCamino();
			}
		}
		
		//depredadoras
		void ButtonDepreClick(object sender, EventArgs e)
		{
			int selecciono = (int)numericUpDepre.Value; //Numero de depredadoras a insertar
			numericUpDepre.Maximum = g.getLV().Count;
			Random r = new Random();
			int posParticula;
			if(selecciono <= totalVertices && selecciono <= disponibles){
				disponibles = disponibles - selecciono;
				if(disponibles >= 0){
					for(int i = 0; i < selecciono; i++){
						
						// Creo una posicion random para insertar la particula siempre y cuando no este ocupada ya
						posParticula = r.Next(0, g.getLV().Count);
						while(vOcupados.Contains(posParticula)){
							posParticula = r.Next(0, g.getLV().Count);
						}
						vOcupados.Add(posParticula);
						
						//Inserto el recorrido
						RecorridosGrafo rg = new RecorridosGrafo(g);
						List<Vertice> rec = new List<Vertice>();
						rec = rg.getRecorridoAmplitud(g.getLV()[posParticula]);
						//
						Particula p = new Particula(posParticula, rec, true);
						lParticulas.Add(p);
					}
					
					dibujaParticulas();
					buttonAnimar.Visible = true;
				}else{
					MessageBox.Show("No hay más lugares disponibles.");
				}
			}else{
				MessageBox.Show("No puedes insertar más particulas que los vertives disponibles.");
			}
		}
		
		void dibujaParticulas(){
			Graphics graphics = Graphics.FromImage(iTransp);
			Brush brochaP = new SolidBrush(Color.BlueViolet);
			Brush brochaD = new SolidBrush(Color.Gold);
			
			foreach(Particula p in lParticulas){
				if(p.getIndPos()==-1){
					if(p.esDepre() == true){
						graphics.FillEllipse(brochaD, g.getLV()[p.getIndOrigen()].getCircle().getP().X-p.getR(), g.getLV()[p.getIndOrigen()].getCircle().getP().Y-p.getR(), 2*p.getR(), 2*p.getR());
					}else{
						graphics.FillEllipse(brochaP, g.getLV()[p.getIndOrigen()].getCircle().getP().X-p.getR(), g.getLV()[p.getIndOrigen()].getCircle().getP().Y-p.getR(), 2*p.getR(), 2*p.getR());
					}
				}
			}
			pictureImageGrafo.Refresh();
		}
		
		void animarParticulas(){
			if(!esDijk){
				bool vuelta = false;
				int vueltas = 0;
				Graphics graphics = Graphics.FromImage(iTransp);
				Brush brochaP = new SolidBrush(Color.BlueViolet);
				Brush brochaD = new SolidBrush(Color.Gold);
				Point point = new Point();
				
				Particula p = new Particula();
				while(lParticulas.Count > 0){
					if(vueltas == 2){
						vuelta = true;
					}
					for(int i = 0; i<lParticulas.Count; i++){
						
						p = lParticulas[i];
						p.setIndPos(p.getContador());
						
						Arista a = new Arista();
						Vertice ori = p.getLVertices()[p.getCOri()];
						Vertice des = p.getLVertices()[p.getCDes()];
						for(int j = 0; j < ori.getLA().Count; j++){
							if(ori.getLA()[j].getDestino().getId() == des.getId()){
								a = ori.getLA()[j];
								break;
							}
						}
						
						if(p.getIndPos() < a.getListaP().Count){ //Si la particula no ha terminado los puntos en la arista donde esta
							Point po = a.getListaP()[p.getIndPos()];
							if(p.esDepre() == true){
								point.X = po.X;
								point.Y = po.Y;
								p.setPosActual(point);
								graphics.FillEllipse(brochaD, po.X-p.getR(), po.Y-p.getR(), 2*p.getR(), 2*p.getR());
							}else{
								point.X = po.X;
								point.Y = po.Y;
								p.setPosActual(point);
								graphics.FillEllipse(brochaP, po.X-p.getR(), po.Y-p.getR(), 2*p.getR(), 2*p.getR());
							}
							//COMPROBAR COLISIONES
							if(vuelta){
								Particula p1 = new Particula();
								Particula p2 = new Particula();
								
								for(int z = 0; z < lParticulas.Count; z++){
									for(int x = 0; x < lParticulas.Count; x++){
										if(z < lParticulas.Count && x < lParticulas.Count){
											p1 = lParticulas[z]; // Es depredadora
											p2 = lParticulas[x]; // Es presa
										}
										
										if(p1.esDepre() && !p2.esDepre()){
											if(p1.getPosActual() == p2.getPosActual() ||
											   (p1.getPosActual().X-3 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X+3 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X+2 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X-2 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) || //Aqui ya captura en x lineal
											   (p1.getPosActual().X-4 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X+4 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X+1 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X-1 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y+1 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y+2 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y+3 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y+4 == p2.getPosActual().Y) || //Aqui ya captura en Y lineal
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y-1 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y-2 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y-3 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y-4 == p2.getPosActual().Y) ||

											   (p1.getPosActual().Y+1 == p2.getPosActual().Y && p1.getPosActual().X-1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+2 == p2.getPosActual().Y && p1.getPosActual().X-2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+3 == p2.getPosActual().Y && p1.getPosActual().X-3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+4 == p2.getPosActual().Y && p1.getPosActual().X-4 == p2.getPosActual().X) ||
											   
											   (p1.getPosActual().Y-1 == p2.getPosActual().Y && p1.getPosActual().X+1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-2 == p2.getPosActual().Y && p1.getPosActual().X+2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-3 == p2.getPosActual().Y && p1.getPosActual().X+3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-4 == p2.getPosActual().Y && p1.getPosActual().X+4 == p2.getPosActual().X) ||
											   
											   (p1.getPosActual().Y+1 == p2.getPosActual().Y && p1.getPosActual().X+1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+2 == p2.getPosActual().Y && p1.getPosActual().X+2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+3 == p2.getPosActual().Y && p1.getPosActual().X+3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+4 == p2.getPosActual().Y && p1.getPosActual().X+4 == p2.getPosActual().X) ||
											   
											   (p1.getPosActual().Y-1 == p2.getPosActual().Y && p1.getPosActual().X-1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-2 == p2.getPosActual().Y && p1.getPosActual().X-2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-3 == p2.getPosActual().Y && p1.getPosActual().X-3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-4 == p2.getPosActual().Y && p1.getPosActual().X-4 == p2.getPosActual().X) ||
											   
											   (p1.getPosActual().Y-1 == p2.getPosActual().Y && p1.getPosActual().X-1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-2 == p2.getPosActual().Y && p1.getPosActual().X-2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-3 == p2.getPosActual().Y && p1.getPosActual().X-3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-4 == p2.getPosActual().Y && p1.getPosActual().X-4 == p2.getPosActual().X)
											  ){
												p1.setR(p1.getR()+5);
												lParticulas.Remove(p2);
												//i--;
											}
										}
									}
								}
							}
						}else{ //si ya termino cambio el origen
							p.setCOri(p.getCOri()+1);
							p.setCDes(p.getCDes()+1);
							p.setContador(0);
							if(p.getCDes() == p.getLVertices().Count){ //Si el destino es el ultimo en la lista elimino la particula
								point.X = 0;
								point.Y = 0;
								p.setPosActual(point);
								lParticulas.Remove(p);
								i--;
							}
						}
						p.setContador(p.getContador()+5);
					}
					pictureImageGrafo.Refresh();
					graphics.Clear(Color.Transparent);
					vueltas++;
				}
				totalVertices = disponibles = g.getLV().Count; //< Reinicio el contador para insertar más
				vOcupados.Clear();
			}else{
				bool vuelta = false;
				bool viva = true;
				bool refresh = true;
				int vueltas = 0;
				//labelLlego.Text = "--";
				Graphics graphics = Graphics.FromImage(iTransp);
				Brush brochaP = new SolidBrush(Color.BlueViolet);
				Brush brochaD = new SolidBrush(Color.Gold);
				Point point = new Point();
				
				Particula p = new Particula();
				while(lParticulas.Count > 0){
					if(vueltas == 2){
						vuelta = true;
					}
					if(!viva){
						MessageBox.Show("-=LA PARTICULA FUE DEVORADA=-");
						totalVertices = disponibles = g.getLV().Count; //< Reinicio el contador para insertar más
						vOcupados.Clear();
						break;
					}
					for(int i = 0; i<lParticulas.Count; i++){
						
						p = lParticulas[i];
						p.setIndPos(p.getContador());
						
						Arista a = new Arista(null, null, double.MaxValue, null);
						Vertice ori = p.getLVertices()[p.getCOri()];
						Vertice des = p.getLVertices()[p.getCDes()];
						
						for(int j = 0; j < ori.getLA().Count; j++){
							if(ori.getLA()[j].getDestino() == des){
								a = ori.getLA()[j];
								break;
							}
						}
						
						if(p.getIndPos() < a.getListaP().Count){ //Si la particula no ha terminado los puntos en la arista donde esta
							Point po = a.getListaP()[p.getIndPos()];
							if(p.esDepre() == true){
								point.X = po.X;
								point.Y = po.Y;
								p.setPosActual(point);
								graphics.FillEllipse(brochaD, po.X-p.getR(), po.Y-p.getR(), 2*p.getR(), 2*p.getR());
							}else{
								point.X = po.X;
								point.Y = po.Y;
								p.setPosActual(point);
								graphics.FillEllipse(brochaP, po.X-p.getR(), po.Y-p.getR(), 2*p.getR(), 2*p.getR());
							}
							//COMPROBAR COLISIONES
							if(vuelta){
								Particula p1 = new Particula();
								Particula p2 = new Particula();
								
								for(int z = 0; z < lParticulas.Count; z++){
									for(int x = 0; x < lParticulas.Count; x++){
										if(z < lParticulas.Count && x < lParticulas.Count){
											p1 = lParticulas[z]; // Es depredadora
											p2 = lParticulas[x]; // Es presa
										}
										
										if(p1.esDepre() && !p2.esDepre()){
											if(p1.getPosActual() == p2.getPosActual() ||
											   (p1.getPosActual().X-3 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X+3 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X+2 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X-2 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) || //Aqui ya captura en x lineal
											   (p1.getPosActual().X-4 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X+4 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X+1 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   (p1.getPosActual().X-1 == p2.getPosActual().X && p1.getPosActual().Y == p2.getPosActual().Y) ||
											   
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y+1 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y+2 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y+3 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y+4 == p2.getPosActual().Y) || //Aqui ya captura en Y lineal
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y-1 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y-2 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y-3 == p2.getPosActual().Y) ||
											   (p1.getPosActual().X == p2.getPosActual().X && p1.getPosActual().Y-4 == p2.getPosActual().Y) ||

											   (p1.getPosActual().Y+1 == p2.getPosActual().Y && p1.getPosActual().X-1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+2 == p2.getPosActual().Y && p1.getPosActual().X-2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+3 == p2.getPosActual().Y && p1.getPosActual().X-3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+4 == p2.getPosActual().Y && p1.getPosActual().X-4 == p2.getPosActual().X) ||
											   
											   (p1.getPosActual().Y-1 == p2.getPosActual().Y && p1.getPosActual().X+1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-2 == p2.getPosActual().Y && p1.getPosActual().X+2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-3 == p2.getPosActual().Y && p1.getPosActual().X+3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-4 == p2.getPosActual().Y && p1.getPosActual().X+4 == p2.getPosActual().X) ||
											   
											   (p1.getPosActual().Y+1 == p2.getPosActual().Y && p1.getPosActual().X+1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+2 == p2.getPosActual().Y && p1.getPosActual().X+2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+3 == p2.getPosActual().Y && p1.getPosActual().X+3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y+4 == p2.getPosActual().Y && p1.getPosActual().X+4 == p2.getPosActual().X) ||
											   
											   (p1.getPosActual().Y-1 == p2.getPosActual().Y && p1.getPosActual().X-1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-2 == p2.getPosActual().Y && p1.getPosActual().X-2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-3 == p2.getPosActual().Y && p1.getPosActual().X-3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-4 == p2.getPosActual().Y && p1.getPosActual().X-4 == p2.getPosActual().X) ||
											   
											   (p1.getPosActual().Y-1 == p2.getPosActual().Y && p1.getPosActual().X-1 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-2 == p2.getPosActual().Y && p1.getPosActual().X-2 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-3 == p2.getPosActual().Y && p1.getPosActual().X-3 == p2.getPosActual().X) ||
											   (p1.getPosActual().Y-4 == p2.getPosActual().Y && p1.getPosActual().X-4 == p2.getPosActual().X))
											{
												p1.setR(p1.getR()+5);
												lParticulas.Clear();
												//TODO: Si se comieron la presa detengo todo el proceso
												numericUpPosPresa.Enabled = true;
												viva = false;
												MessageBox.Show("-=LA PARTICULA FUE DEVORADA=-");
												totalVertices = disponibles = g.getLV().Count; //< Reinicio el contador para insertar más
												vOcupados.Clear();
												pictureImageGrafo.Refresh();
												graphics.Clear(Color.Transparent);
											}
										}
									}
								}
							}
						}else{ //si ya termino cambio el origen
							p.setCOri(p.getCOri()+1);
							p.setCDes(p.getCDes()+1);
							p.setContador(0);
							int auxPos = p.getLVertices()[p.getCDes()-1].getId();
							if(p.getCDes() == p.getLVertices().Count){ //Si el destino es el ultimo en la lista elimino la particula
								point.X = 0;
								point.Y = 0;
								p.setPosActual(point);
								lParticulas.Clear();
								
								//TODO: Si llego al final el vertice final será el nuevo origen, deberia cambiar los numericUp
								viva = false;
								//MessageBox.Show("La presa llego a su destino, seleccione uno nuevo");
								numericUpPosPresa.Value = auxPos;
								numericUpPosPresa.Enabled = false;
								refresh = false;
								MessageBox.Show("-=LA PARTICULA LLEGO A SU DESTINO=-");
								totalVertices = disponibles = g.getLV().Count; //< Reinicio el contador para insertar más
								vOcupados.Clear();
								
								buttonDepre.Enabled = false;
							}
						}
						p.setContador(p.getContador()+5);
					}
					if(refresh){
						pictureImageGrafo.Refresh();
						graphics.Clear(Color.Transparent);
					}
					vueltas++;
				}
			}
		}
		
		void ButtonAnimarClick(object sender, EventArgs e)
		{
			//Cuando le doy en animar
			animarParticulas();
		}
		
		void PictureBoxCloseClick(object sender, EventArgs e)
		{
			this.Dispose(true);
			this.Close();
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
		
		void GrafoFormMouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		////<
		
		void TextBox1TextChanged(object sender, EventArgs e){}//no sirve we :v
		
		void ButtonCaminoCMouseHover(object sender, EventArgs e)
		{
			buttonCaminoC.BackColor = Color.FromArgb(255,87,51);
		}
		
		void ButtonCaminoCMouseLeave(object sender, EventArgs e)
		{
			buttonCaminoC.BackColor = Color.FromArgb(255,195,0);
		}
		
		void ButtonDistCMouseHover(object sender, EventArgs e)
		{
			buttonDistC.BackColor = Color.FromArgb(255,87,51);
		}
		
		void ButtonDistCMouseLeave(object sender, EventArgs e)
		{
			buttonDistC.BackColor = Color.FromArgb(255,195,0);
		}
		
		void RecorridosINFOClick(object sender, EventArgs e)
		{
			MessageBox.Show("Si deseas ver un camino en profundidad o amplitud especifico en un vertice seleccionalo y arriba a la derecha se mostrara la lista con los vertices que una particula debe de seguir.");
		}
	}
}
