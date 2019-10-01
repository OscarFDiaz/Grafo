/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 30/11/2018
 * Hora: 04:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Etapa_1._
{
	/// <summary>
	/// Description of Dijkstra.
	/// </summary>
	public class Dijkstra
	{
		List<elementoDij> elementoDList;
		List<Vertice> listaVertices;
		List<Vertice> listaCamino;
		Grafo g;
		
		//elementoDij [] vectorDijkstra;
		
		public Dijkstra(Grafo g, Vertice vert, Vertice destino)
		{
			this.g = g;
			
			listaVertices = new List<Vertice>();
			listaVertices = g.getLV();
			
			listaCamino = new List<Vertice>();
			
			//vectorDijkstra = new elementoDij[listaVertices.Count]; //< Vector con el tamaño de la lista de vertices
			elementoDList = new List<elementoDij>(); //< Asigno memoria
			
			DijkstraA(vert, destino); // Llamo a la funcion con el vertice inicial
			encontrarCamino(vert, destino);
			
		}
		
		public List<elementoDij> getLED(){ //Lista elementos dijks
			return elementoDList;
		}
		
		public List<Vertice> getLCamino(){ //Lista elementos dijks
			return listaCamino;
		}
		
		void encontrarCamino(Vertice origen, Vertice destino){
			listaCamino.Add(destino); //< Añado el vertice destino, la lista empieza al reves
			
			Vertice temp = destino; //< Iterador en la lista
			while(temp.getId() != origen.getId()){ //< Mientras el Id del temporal no sea el del origen
				foreach(elementoDij e_d in elementoDList){
					if(e_d.getVEDJ() == temp){ // Busco el elementoDij que lo contiene y lo añado al camino y muevo el temporal
						listaCamino.Add(e_d.getProv());
						temp = e_d.getProv();
						break;
					}
				}
			}
			listaCamino.Reverse(); //< Le doy la vuelta a la lista para que esten en orden
		}
		
		/////////// ALGORITMO /////////// 
		
		void DijkstraA(Vertice v_inicial, Vertice destino){
			
			elementoDij e_d = new elementoDij(null, null, double.MaxValue, false, 0); //< Dummy
			inicializaVD(v_inicial);
			
			/*while(!solucion(destino)){
				e_d = seleccionaDefinitivo();
				actualiza(e_d);
			}*/
			
			while(!solucion()){
				e_d = seleccionaDefinitivo();
				actualiza(e_d);
			}
		}
		
		void inicializaVD(Vertice v_inicial){
			
			//Para cada vertice del grafo, creo de el un elemento de dijkstra
			foreach(Vertice v in listaVertices){
				elementoDij e_di = new elementoDij(v, null, double.MaxValue, false, v.getId()); //< Vertice, peso, definitivo, id
				elementoDList.Add(e_di);
			}
			
			// e_inicial{v_inicial, 0, noDefinitivo}
			// Busco el vertice que coincide con el inicial y hago lo de arriba
			elementoDij e_d;
			for(int i = 0; i < elementoDList.Count; i++){
				e_d = elementoDList[i];
				e_d.setVertice(elementoDList[i].getVEDJ());
				if(e_d.getVEDJ() == v_inicial){
					elementoDij nuevo = new elementoDij(v_inicial, v_inicial, 0, false, v_inicial.getId());
					//e_d = nuevo;
					elementoDList[i] = nuevo;
					break;
				}
			}
		}
		
		bool solucion(){
			//Si algun elemento no es definitivo regreso falso, si la funcion no se cumple se regresara true
			
			foreach(elementoDij e_i in elementoDList){
				if(e_i.esDefininito() == false){
					return false;
				}
			}
			return true;
		}
		
		elementoDij seleccionaDefinitivo(){
			//Devuelve el vertice del elemento Dijkstra que tenga el peso menor y que no sea definitivo, lo hace definitivo
			
			double min = double.MaxValue;
			elementoDij posible = new elementoDij(null, null, double.MaxValue, false, 100); //< Elemento dummy
			elementoDij e_d;
			
			for(int i = 0; i < elementoDList.Count; i++){
				e_d = elementoDList[i];
				
				if(!e_d.esDefininito()){
					if(e_d.getPeso() < min){
						min = e_d.getPeso(); //< Actualizo el peso minimo
						posible = e_d; //< Lo asigno a mi candidato
					}
				}
			}
			posible.setDefinitivo(true);
			return posible; //< Le asigno definitivo y lo regreso
		}
		
		void actualiza(elementoDij e_d){
			int posED = 0;
			foreach(Arista a_i in e_d.getVEDJ().getLA()){ //< Consigo los adyacentes del elementoDIJK mediante la lista de aristas
				// Si el el destino de la arista da con el elemento, asigno el elemento al nuevo elemento
				
				posED = buscaElemento(a_i.getDestino().getId()); //< Posicion de mi elemento a actualizar
				elementoDij e_i = elementoDList[posED]; //< lo asigno a un temporal
				
				//Si el peso de ti temporal es mayor al nuevo peso lo cambio y lo agrego de nuevo a la lista en la posicion
				if(e_i.getPeso() > (e_d.getPeso() + a_i.getDistancia())){
					e_i.setPeso((e_d.getPeso() + a_i.getDistancia()));
					e_i.setVerticeProv(e_d.getVEDJ());
					elementoDList[posED] = e_i;
				}
			}
			
		}
		
		// Me regresa una posicion del elemento que busco
		int buscaElemento(int id){
			elementoDij e_d;
			for(int i = 0; i < elementoDList.Count; i++){
				e_d = elementoDList[i];
				if(e_d.getVEDJ().getId() == id){
					return i;
				}
			}
			return -1;
		}
		
	}//fin de la clase
	
	public class elementoDij{
		Vertice vertice;
		Vertice proveniente;
		bool definitivo;
		double peso;
		int id;
		
		public elementoDij(){}
		
		public elementoDij(Vertice v, Vertice prov, double peso, bool definitivo, int id){
			this.vertice = v;
			this.proveniente = prov;
			this.peso = peso;
			this.definitivo = definitivo;
			this.id = id;
		}
		
		public Vertice getVEDJ(){ //< Vertice del elemento DIJKSTRA
			return vertice;
		}
		public Vertice getProv(){
			return proveniente;
		}
		
		public void setVerticeProv(Vertice v){
			this.proveniente = v;
		}
		
		public void setVertice(Vertice v){
			this.vertice = v;
		}
		
		public bool esDefininito(){
			return definitivo;
		}
		
		public void setDefinitivo(bool boleano){
			this.definitivo = boleano;
		}
		
		public double getPeso(){
			return peso;
		}
		
		public void setPeso(double peso){
			this.peso = peso;
		}
		
		public int getID(){
			return id;
		}
		
		public void setID(int id){
			this.id = id;
		}
		
		public override string ToString()
		{
			return string.Format("[Vertice={0}, Prov={1},Definitivo={2}, Peso={3}, Id={4}]", vertice.getId(), proveniente.getId(), definitivo, peso, id);
		}
		
	}
}
