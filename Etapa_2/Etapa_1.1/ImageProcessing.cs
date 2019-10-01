﻿/*
	 * Created by SharpDevelop.
	 * User: Usuario
	 * Date: 04/09/2018
	 * Time: 01:59 p. m.
	 * 
	 * To change this template use Tools | Options | Coding | Edit Standard Headers.
	 */
	using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Etapa_1._
{
	/// <summary>
	/// Description of ImageProcessing.
	/// </summary>
	public class ImageProcessing
	{
		int conteo = 0;
		
		Bitmap bmpOriginal;
		Bitmap bmpImagen;
		Bitmap bmpOriginalCopia;
		
		List<Circle> lc = new List<Circle>();
		public ImageProcessing(){}
		
		public ImageProcessing(string ruta)
		{
			bmpOriginal = new Bitmap(ruta);
		}
		
		public List<Circle> findCenters(){
			
			bmpImagen = new Bitmap(bmpOriginal);
			bmpOriginalCopia = new Bitmap(bmpOriginal);
			
			for (int j = 0; j<bmpImagen.Height; j++){
				for(int i = 0; i<bmpImagen.Width; i++){
					Color  c = bmpImagen.GetPixel(i,j);
					if(c.R== 0)
						if(c.G == 0)
							if(c.B==0){
						Circle c_i = findCircleCenter(i, j); //me regresa el centro del circulo
						lc.Add(c_i);
						drawCircle(c_i, bmpImagen);
					}
				}
			}
			//elGrafo(bmpOriginalCopia, bmpImagen);
			drawCruz(bmpImagen);
			return lc;
		}
		
		Circle findCircleCenter(int i, int j){
			Circle c_i;
			Color c;
			int y_i = j;
			int y_f = j;
			int x_izq = i;
			int x_der = i;
			int y_m, x_m;
			int ry=0;
			
			
			for(;y_f<bmpOriginal.Height;y_f++)
			{
				ry++;
				c = bmpOriginal.GetPixel(i, y_f);
				if(c.R != 0)
					break;
				if(c.G != 0)
					break;
				if(c.B != 0)
					break;
			}
			y_f--;
			
			
			for(;y_i>=0;y_i--)
			{
				ry++;
				c = bmpOriginal.GetPixel(i, y_i);
				if(c.R != 0)
					break;
				if(c.G != 0)
					break;
				if(c.B != 0)
					break;
			}
			y_i++;
			
			y_m = (y_f+y_i)/2; //Centro de Y
			
			for(;x_izq>=0;x_izq--)
			{
				c = bmpOriginal.GetPixel(x_izq,y_m);
				if(c.R != 0)
					break;
				if(c.G != 0)
					break;
				if(c.B != 0)
					break;
			}
			
			for(;x_der<bmpOriginal.Width;x_der++)
			{
				c = bmpOriginal.GetPixel(x_der,y_m);
				if(c.R != 0)
					break;
				if(c.G != 0)
					break;
				if(c.B != 0)
					break;
			}
			x_m = (x_der+x_izq)/2; //Cetro en X
			int r = (x_der-x_izq)/2;
			c_i = new Circle(x_m, y_m, r, ry);
			return c_i;
		}
		
		private void drawCircle(Circle c, Bitmap bmp){
			conteo++;
			Graphics g = Graphics.FromImage(bmp);
			SolidBrush brocha = new SolidBrush(Color.DarkGreen);
			
			g.FillEllipse(brocha, c.getP().X-c.getR()-6, c.getP().Y-c.getR()-6, 2*c.getR()+10, c.getRY()+10);
			//bmp.Save(@"C:\Users\Oscar\Desktop\Proceso\"+conteo+".png"); //Guardo la imagen en una carpeta
		}
		
		private void drawCruz(Bitmap bmp){
			
			Graphics s = Graphics.FromImage(bmp);
			
			for(int i= 0; i<lc.Count(); i++){
				// Creo una + en el centro del circulo principal de color blanco
				for(int h = 0; h<(lc[i].getR()/2); h++){  //Derecha
					bmp.SetPixel(lc[i].getP().X+h,lc[i].getP().Y,Color.White);
				}
				for(int wide = 0; wide<(lc[i].getR()/2); wide++){ //Abajo
					bmp.SetPixel(lc[i].getP().X,lc[i].getP().Y+wide,Color.White);
				}
				
				for(int h = 0; h<(lc[i].getR()/2); h++){ //Izquierda
					bmp.SetPixel(lc[i].getP().X-h,lc[i].getP().Y,Color.White);
				}
				for(int wide = 0; wide<(lc[i].getR()/2); wide++){ //Arriba
					bmp.SetPixel(lc[i].getP().X,lc[i].getP().Y-wide,Color.White);
				}
			}
			conteo++;
			//bmp.Save(@"C:\Users\Oscar Diaz\Desktop\PROCESO\"+conteo+".png"); //Guardo la imagen en una carpeta
			int cont = 0;
			int tam = 0;
			for(int i = 0; i<lc.Count(); i++){
				cont++;
				tam = lc[i].getR();
				if(tam < 40){
					tam = 20;
				}else{
					tam = tam /2;
				}
				s.DrawString(cont.ToString(), new Font("Verdana", tam, GraphicsUnit.Pixel), new SolidBrush(Color.DarkRed), lc[i].getP().X+lc[i].getR(), lc[i].getP().Y);
			}
			conteo++;
			//bmp.Save(@"C:\Users\Oscar Diaz\Desktop\PROCESO\"+conteo+".png"); //Guardo la imagen en una carpeta
		}
		
		public Bitmap imagenAct(){ //Regreso el bitmap al main para actualziar el picturebox
			return bmpImagen;
		}
		
		
	}
}