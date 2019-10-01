﻿﻿﻿/*
	 * Created by SharpDevelop.
	 * User: Usuario
	 * Date: 06/09/2018
	 * Time: 02:26 p. m.
	 * 
	 * To change this template use Tools | Options | Coding | Edit Standard Headers.
	 */
	using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Web.UI;

namespace Etapa_1._
{
	/// <summary>
	/// Description of Grafo.
	/// </summary>
	public class Grafo
	{
		List<Vertice> lv;
		List<Arista> la;
		List<Point> lp1;
		Bitmap bmpO;
		
		public Grafo(List<Circle> lc, string ruta, Bitmap bmpOC)
		{
			double distanciaObtenida;
			bmpO = new Bitmap(ruta);
			lv = new List<Vertice>();
			la = new List<Arista>();
			int id = 0;
			foreach(Circle c_i in lc){
				id++;
				Vertice v_i = new Vertice(c_i,id);
				lv.Add(v_i);
			}
			//AÑADIR LA LISTA DE PUNTOS
			foreach(Vertice oringen in lv){
				foreach(Vertice destino in lv){
					if(oringen != destino){
						if(drawLine2(oringen.getCircle(), destino.getCircle(), bmpO, bmpOC)){
							distanciaObtenida = getDistanciaArista(oringen.getCircle(), destino.getCircle());
							oringen.insertaArista(destino, oringen, distanciaObtenida, lp1);
						}
					}
				}
			}
			
			Pen myPen = new Pen(Color.Red,4);
			foreach(Vertice v in lv){
				foreach(Arista a in v.getLA()){
					Graphics g = Graphics.FromImage(bmpOC);
					g.DrawLine(myPen, v.getCircle().getP().X, v.getCircle().getP().Y, a.getDestino().getCircle().getP().X, a.getDestino().getCircle().getP().Y);
				}
			}
			
			//Lista de aristas
			foreach(Vertice v in lv){
				foreach(Arista a in v.getLA()){
					la.Add(a);
				}
			}
		}
		
		public List<Vertice> getLV(){
			return lv;
		}
		public List<Arista> getLA(){
			return la;
		}
		
		private bool drawLine2(Circle frm, Circle to, Bitmap img, Bitmap bmpTD){ //Punto 1 y 2 - Bitmap a analizar - Bitmap a dibujar
			int bandera = 0;
			bool obs = false;
			bool reverse = false, existe = false;
			double m, b;
			double x_a, x_i, x_f, x_aux;
			double y_a, y_i, y_f, y_aux;
			lp1 = new List<Point>();
			
			
			lp1.Clear();
			Point p;
			x_i = frm.getP().X;
			x_f = to.getP().X;
			y_i = frm.getP().Y;
			y_f = to.getP().Y;
			bandera = 0;
			obs = false;

			if (frm != to)
			{
				m = (y_f - y_i) / (x_f - x_i);
				b = y_i - (m * x_i);

				if ((m > 1 || m < -1) && double.IsInfinity(m) == false)
				{
					reverse = false;
					if (y_i > y_f)
					{
						y_aux = y_i;
						y_i = y_f;
						y_f = y_aux;
						reverse = true;
					}

					for (y_a = y_i; y_a <= y_f; y_a++)
					{
						x_a = (y_a - b) / m;
						p = new Point((int)x_a, (int)y_a);
						lp1.Add(p);

						if (bandera == 0)
						{
							if (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).R == 255)
								if (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).G == 255)
									if (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).B == 255)
							{
								bandera = 1;
							}
						}
						if (bandera == 1)
						{
							if ((img.GetPixel((int)(Math.Round(x_a)), (int)y_a).R <= 255) && (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).R >= 250) &&
							    (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).G <= 255) && (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).G >= 250) &&
							    (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).B <= 255) && (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).B >= 250))
							{
								
							}
							else
							{
								bandera = 2;
							}
							
						}
						if (bandera == 2)
						{
							if (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).R == 255)
								if (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).G == 255)
									if (img.GetPixel((int)(Math.Round(x_a)), (int)y_a).B == 255)
							{
								obs = true;
								break;
							}
						}
					}
					if (obs == false)
					{
						if (reverse == true)
						{
							lp1.Reverse();
						}
						existe = true;
					}
				}
				
				////////////////////////////
				
				if (m <= 1 && m >= -1)
				{
					reverse = false;
					if (x_i > x_f)
					{
						x_aux = x_i;
						x_i = x_f;
						x_f = x_aux;
						reverse = true;
					}
					for (x_a = x_i; x_a <= x_f; x_a++)
					{
						y_a = m * x_a + b;
						p = new Point((int)x_a, (int)y_a);
						lp1.Add(p);

						if (bandera == 0)
						{
							if (img.GetPixel((int)x_a, (int)Math.Round(y_a)).R == 255)
								if (img.GetPixel((int)x_a, (int)Math.Round(y_a)).G == 255)
									if (img.GetPixel((int)x_a, (int)Math.Round(y_a)).B == 255)
							{
								bandera = 1;
							}
						}
						if (bandera == 1)
						{
							if ((img.GetPixel((int)x_a, (int)Math.Round(y_a)).R <= 255) && (img.GetPixel((int)x_a, (int)Math.Round(y_a)).R >= 250) &&
							    (img.GetPixel((int)x_a, (int)Math.Round(y_a)).G <= 255) && (img.GetPixel((int)x_a, (int)Math.Round(y_a)).G >= 250) &&
							    (img.GetPixel((int)x_a, (int)Math.Round(y_a)).B <= 255) && (img.GetPixel((int)x_a, (int)Math.Round(y_a)).B >= 250))

							{
								
							}
							else
							{
								bandera = 2;
							}
							if (m > 0)
							{
								if ((img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).R <= 255) && (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).R >= 250) &&
								    (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).G <= 255) && (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).G >= 250) &&
								    (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).B <= 255) && (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).B >= 250))
								{

								}
								else
								{
									bandera = 2;
									x_a++;
								}
							}
							if (m < 0)
							{
								if ((img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).R <= 255) && (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).R >= 250) &&
								    (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).G <= 255) && (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).G >= 250) &&
								    (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).B <= 255) && (img.GetPixel((int)x_a + 1, (int)Math.Round(y_a)).B >= 250))
								{

								}
								else
								{
									bandera = 2;
									x_a++;
								}
							}
							
						}
						if (bandera == 2)
						{
							{
								if (img.GetPixel((int)x_a, (int)Math.Round(y_a)).R == 255)
									if (img.GetPixel((int)x_a, (int)Math.Round(y_a)).G == 255)
										if (img.GetPixel((int)x_a, (int)Math.Round(y_a)).B == 255)
								{
									obs = true;
									break;
								}
							}

						}
					}
					if (obs == false)
					{
						if(reverse == true)
						{
							lp1.Reverse();
						}
						existe = true;
					}

				}
				if( double.IsInfinity(m) == true)
				{
					reverse = false;
					if (y_i > y_f)
					{
						y_aux = y_i;
						y_i = y_f;
						y_f = y_aux;
						reverse = true;
					}

					for(y_a = y_i; y_a <= y_f; y_a++)
					{
						x_a = x_i;
						p = new Point((int)x_a, (int)y_a);
						lp1.Add(p);

						if (bandera == 0)
						{
							if (img.GetPixel((int)x_a, (int)(y_a)).R == 255)
								if (img.GetPixel((int)x_a, (int)(y_a)).G == 255)
									if (img.GetPixel((int)x_a, (int)(y_a)).B == 255)
							{
								bandera = 1;
							}
						}
						if (bandera == 1)
						{
							if ((img.GetPixel((int)x_a, (int)(y_a)).R <= 255) && (img.GetPixel((int)x_a, (int)(y_a)).R >= 250) &&
							    (img.GetPixel((int)x_a, (int)(y_a)).G <= 255) && (img.GetPixel((int)x_a, (int)(y_a)).G >= 250) &&
							    (img.GetPixel((int)x_a, (int)(y_a)).B <= 255) && (img.GetPixel((int)x_a, (int)(y_a)).B >= 250))
							{
								
							}else{
								bandera = 2;
							}
						}
						if (bandera == 2)
						{
							{
								if (img.GetPixel((int)x_a, (int)(y_a)).R == 255)
									if (img.GetPixel((int)x_a, (int)(y_a)).G == 255)
										if (img.GetPixel((int)x_a, (int)(y_a)).B == 255)
								{
									obs = true;
									break;
								}
							}
						}
					}
					if (obs == false){
						if (reverse == true){
							lp1.Reverse();
						}
						existe = true;
					}
				}
			}
			return existe;
		}
		
		private double getDistanciaArista(Circle frm, Circle to){
			return Math.Sqrt(Math.Pow((to.getP().X - frm.getP().X), 2) + Math.Pow((to.getP().Y - frm.getP().Y), 2));
		}
	}
	
	public class FuerzaBruta{
		Grafo g;
		List<Vertice> camino = new List<Vertice>();
		double min = double.MaxValue;
		double posible;
		
		public FuerzaBruta(Grafo g){
			this.g = g;
		}
		
		public List<Vertice> getCamino()
		{
			return camino;
		}

		public double getMin()
		{
			return min;
		}
		
		public void CaminoMasCorto()
		{
			camino.Clear();
			foreach (Vertice v1 in g.getLV())
			{
				foreach (Arista a1 in v1.getLA())
				{
					foreach (Arista a2 in a1.getDestino().getLA())
					{
						foreach (Arista a3 in a2.getDestino().getLA())
						{
							//Si el vertice origen no es igual a ninguno de los otros destinos
							if (v1.getId() != a1.getDestino().getId() && v1.getId() != a2.getDestino().getId() && v1.getId() != a3.getDestino().getId())
								if (a1.getDestino().getId() != a2.getDestino().getId() && a1.getDestino().getId() != a3.getDestino().getId())
									if (a2.getDestino().getId() != a3.getDestino().getId())
							{
								posible = a1.getDistancia() + a2.getDistancia() + a3.getDistancia();
								if (posible < min)
								{
									min = posible;
									camino.Clear();
									camino.Add(v1);
									camino.Add(a1.getDestino());
									camino.Add(a2.getDestino());
									camino.Add(a3.getDestino());
								}
							}
						}
					}
				}
			}
		}
		public void paresMinimo()
		{
			camino.Clear();
			foreach (Vertice v1 in g.getLV())
			{
				foreach (Arista a1 in v1.getLA())
				{
					if (v1.getId() != a1.getDestino().getId())
					{
						posible = a1.getDistancia();
						if (posible < min)
						{
							min = posible;
							camino.Clear();
							camino.Add(v1);
							camino.Add(a1.getDestino());
						}
					}
				}
			}
		}
	}
	
	public class Vertice{
		//privado
		List<Arista> la;
		Circle c;
		int id;
		public Vertice(){}
		
		public Vertice(Circle c, int id){
			this.c = c;
			this.id = id;
			la = new List<Arista>();
		}
		
		public void insertaArista(Vertice destino, Vertice origen, double distanciaA, List<Point> lpo)
		{
			Arista a = new Arista(destino, origen, distanciaA, lpo);
			la.Add(a);
		}
		public List<Arista>getLA(){
			return la;
		}
		public int getId(){
			return id;
		}
		public Circle getCircle(){
			return c;
		}
		
		public override string ToString()
		{
			return string.Format("Vertice: {0}",id);
		}
	}
	
	public class Arista{
		double dist;
		Vertice destino;
		Vertice origen;
		//TO-DO: Añadir la lista de puntos que define la arista
		//
		List<Point> lp;
		//
		public Arista(){}
		
		public Arista(Vertice dest, Vertice orig, double distancia, List<Point> lpo){
			destino = dest;
			origen = orig;
			dist = distancia;
			lp = new List<Point>();
			lp = lpo;
		}
		public Vertice getDestino(){
			return destino;
		}
		public Vertice getOrigen(){
			return origen;
		}
		public double getDistancia(){
			return dist;
		}
		public List<Point> getListaP(){
			return lp;
		}
		
		public override string ToString()
		{
			return string.Format("{0} ---| {1} |---> {2}", origen.getId(), Math.Round(dist, 5), destino.getId());
		}
		
	}
	
	public class RecorridosGrafo{
		
		Grafo graf;
		List<Vertice> recorrido;
		List<Vertice> camino;
		
		public RecorridosGrafo(){}
		
		public RecorridosGrafo(Grafo g){
			graf = g;
		}
		
		public List<Vertice> getRecorridoAmplitud(Vertice origen){
			rAmplitudCompleto(origen);
			rAmptermina();
			return camino;
		}
		
		public List<Vertice> getRecorridoProfundidad(Vertice origen){
			recorridoProfundidad(origen);
			
			return recorrido;
		}
		
		private void rAmplitudCompleto(Vertice origen){
			Queue<Vertice> cola = new Queue<Vertice>();
			camino = new List<Vertice>();
			Vertice [] provenientes = new Vertice[graf.getLV().Count+1];
			
			List<Vertice> visitados = new List<Vertice>(); //Para cada deprededadora
			
			cola.Enqueue(origen);
			visitados.Add(origen);
			//provenientes[x] = new Vertice();
			provenientes[origen.getId()-1] = null;
			
			
			Vertice v_o = new Vertice();
			Vertice v_d = new Vertice();
			Vertice auxv_o = new Vertice();
			Vertice auxv_d;// = new Vertice();
			
			List<Vertice> camino1 = new List<Vertice>();
			List<Vertice> camino2 = new List<Vertice>();
			Stack<Vertice> pilaAux = new Stack<Vertice>();
			while(visitados.Count != graf.getLV().Count){
				
				foreach(Arista a_i in origen.getLA()){
					Vertice dest = a_i.getDestino();
					
					if(!visitados.Contains(dest)){
						cola.Enqueue(dest);
						visitados.Add(dest);
						provenientes[dest.getId()] = origen;
						
						while(auxv_o != null){
							if(provenientes[auxv_o.getId()] != null)
								camino1.Add(provenientes[auxv_o.getId()]);
							auxv_o = provenientes[auxv_o.getId()];
						}
						auxv_d = dest;
						while(provenientes[auxv_d.getId()] != null){
							pilaAux.Push(provenientes[auxv_d.getId()]);
							auxv_d = provenientes[auxv_d.getId()];
						}
						while(pilaAux.Count != 0){ //Voltea el camino
							camino2.Add(pilaAux.Pop());
						}
						//solo si existen dos caminos
						if(camino1.Count != 0)
						{
							if(camino2.Count != 0)
							{
								camino.AddRange(combinaCaminos(camino1, camino2));
							}else{
								camino.AddRange(camino1);
							}
						}else{
							camino.AddRange(camino2);
						}
						camino.Add(dest);//Add
						camino1.Clear();
						camino2.Clear();
						auxv_o = auxv_d;
						
					}
				}
				cola.Dequeue();
				origen = cola.First();
			}
		}
		public List<Vertice> combinaCaminos(List<Vertice> camino1, List<Vertice> camino2){
			
			for(int i = 0; i < camino.Count; i++){
				for(int j =0; j < camino2.Count; j++){
					if(camino1[i] == camino2[j]){
						camino1.RemoveRange(i+1, camino1.Count-(i+1));
						camino2.RemoveRange(0, j+2);
						camino1.AddRange(camino2);
						return camino1;
					}
				}
			}
			return null;
		}
		
		private void rAmptermina(){
			Stack<Vertice> pila = new Stack<Vertice>();
			List<Vertice> nRecorrido = new List<Vertice>();
			
			/*
			 * Almacen el primer número
			 * compruebo que el segundo sea conocido por el primero
			 * si lo conoce desapila vertice y añade el vertice en el tope hasta que lo conozca
			 */
			nRecorrido.Add(camino[0]); //< Añado el primer vertice del recorrido
			
			pila.Push(nRecorrido[0]); //< Meto a la pila el primer vertice del nuevo recorrido
			
			int i = 0;
			int j;
			bool existe;
			for(j = 1; j < camino.Count; j++){
				existe = false;
				if(existeArista(nRecorrido[i], camino[j])){
					pila.Push(camino[j]);
					nRecorrido.Add(camino[j]);
					i++;
					existe = true;
				}else{
					while(!existe && pila.Count != 0){
						pila.Pop();
						if(pila.Count != 0){
							nRecorrido.Add(pila.Peek());
							i++;
						}
						if(existeArista(nRecorrido[i], camino[j])){
							existe = true;
							j--;
						}
					}
				}
			}
			camino = nRecorrido;
		}
		
		private void rProfundidadCompleto(){
			Stack<Vertice> pila = new Stack<Vertice>();
			List<Vertice> nRecorrido = new List<Vertice>();
			
			/*
			 * Almacen el primer número
			 * compruebo que el segundo sea conocido por el primero
			 * si lo conoce desapila vertice y añade el vertice en el tope hasta que lo conozca
			 */
			nRecorrido.Add(recorrido[0]); //< Añado el primer vertice del recorrido
			
			pila.Push(nRecorrido[0]); //< Meto a la pila el primer vertice del nuevo recorrido
			
			int i = 0;
			int j;
			bool existe;
			for(j = 1; j < recorrido.Count; j++){
				existe = false;
				if(existeArista(nRecorrido[i], recorrido[j])){
					pila.Push(recorrido[j]);
					nRecorrido.Add(recorrido[j]);
					i++;
					existe = true;
				}else{
					while(!existe && pila.Count != 0){
						pila.Pop();
						if(pila.Count != 0){
							nRecorrido.Add(pila.Peek());
							i++;
						}
						if(existeArista(nRecorrido[i], recorrido[j])){
							existe = true;
							j--;
						}
					}
				}
			}
			recorrido = nRecorrido;
		}
		
		private bool existeArista(Vertice origen, Vertice destino){
			bool existe = false;
			foreach(Arista a in origen.getLA()){
				if(a.getDestino().getId() == destino.getId()){
					existe = true;
					break;
				}
			}
			return existe;
		}
		
		private void recorridoProfundidad(Vertice origen) {
			Vertice actual;// = new Vertice();
			Vertice aux; //= new Vertice();
			
			Stack<Vertice> pila = new Stack<Vertice>();
			List<Vertice> visitados = new List<Vertice>();
			recorrido = new List<Vertice>();
			
			pila.Push(origen);
			
			while(pila.Count > 0){
				actual = pila.Pop();
				
				if(!visitados.Contains(actual)){
					
					visitados.Add(actual);
					recorrido.Add(actual);
					
					int contador = 0;
					foreach(Arista a in actual.getLA()){
						aux = actual.getLA()[contador].getDestino();
						contador++;
						if(!visitados.Contains(aux)){
							pila.Push(aux);
						}
					}
				}
			}
			rProfundidadCompleto();
		}
	}
}
