/*
 * Created by SharpDevelop.
 * User: Oscar
 * Date: 11/10/2018
 * Time: 02:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Etapa_1._
{
	/// <summary>
	/// Description of Particula.
	/// </summary>
	public class Particula
	{
		int indOrigen;
		int indArista;
		int indPos;//si indPo = -1 => pos = origen
		int radio;
		int contador;
		int cOri;
		int cDes;
		
		bool depr;
		int comidas;
		
		Point posActual;
		
		List<Vertice> recorrido;
		public Particula(){}
		
		public Particula(int indOrigen, List<Vertice> recorrido, bool depre)
		{
			indArista = -1;
			indPos = -1;
			this.indOrigen = indOrigen;
			radio = 20;
			this.recorrido = new List<Vertice>();
			this.recorrido = recorrido;
			contador = 0;
			cOri = 0;
			cDes = 1;
			depr = depre;
			comidas = 0;
			posActual = new Point();
		}
		
		public bool esDepre(){
			return depr;
		}
		public void setDepre(bool depre){
			depr = depre;
		}
		public int getComidas(){
			return comidas;
		}
		public void setComidas(int numero){
			comidas = numero;
		}
		public Point getPosActual(){
			return posActual;
		}
		public void setPosActual(Point p){
			posActual = p;
		}
		/// /////////////////////////
		public int getR(){
			return radio;
		}
		public void setR(int nRadio){
			radio = nRadio;
		}
		public int getIndPos(){
			return indPos;
		}
		public void setIndPos(int indP){
			indPos = indP;
		}
		public int getIndOrigen(){
			return indOrigen;
		}
		public void setIndOrigen(int indO){
			indOrigen = indO;
		}
		public List<Vertice> getLVertices(){
			return recorrido;
		}
		public void setContador(int cont){
			contador = cont;
		}
		public int getContador(){
			return contador;
		}
		public void setCOri(int ori){
			cOri = ori;
		}
		public int getCOri(){
			return cOri;
		}
		public void setCDes(int des){
			cDes = des;
		}
		public int getCDes(){
			return cDes;
		}
	}
	/*
	public class Depre:Particula{
		Queue<Vertice> cola;
		List<Vertice> camino;
		Vertice [] provenientes;
		
		List<Vertice> visitados = new List<Vertice>(); //Para cada deprededadora
		
		public Depre(int x, Vertice v, int maxV){
			cola = new Queue<Vertice>();
			camino = new List<Vertice>();
			provenientes = new Vertice[maxV+1];
			visitados = new List<Vertice>();
			
			cola.Enqueue(v);
			visitados.Add(v);
			//provenientes[x] = new Vertice();
			provenientes[x] = null;
			
		}
		
		private void recorridoAmplitud(Vertice v, int nume){
			Vertice v_o = new Vertice();
			Vertice v_d = new Vertice();
			Vertice auxv_o;// = new Vertice();
			Vertice auxv_d;// = new Vertice();
			
			List<Vertice> camino1 = new List<Vertice>();
			List<Vertice> camino2 = new List<Vertice>();
			Stack<Vertice> pilaAux = new Stack<Vertice>();
			while(visitados.Count != nume){
				
				foreach(Arista a_i in v.getLA()){
					Vertice dest = a_i.getDestino();
					
					if(!visitados.Contains(dest)){
						cola.Enqueue(dest);
						visitados.Add(dest);
						provenientes[dest.getId()] = v;
						
						while(auxv_o != null){
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
						camino.AddRange(combinaCaminos(camino1, camino2));
						camino.Add(dest);//Add
						camino1.Clear();
						camino2.Clear();
						auxv_o = auxv_d;
						
					}
				}
				cola.Dequeue();
				v = cola.First();
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
	}//end class*/
}//end namespace
