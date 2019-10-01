/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 04/09/2018
 * Time: 01:54 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Etapa_1._
{
	/// <summary>
	/// Description of Circle.
	/// </summary>
	public class Circle
	{
		Point p;
		int r;
		int r_y;
		public Circle()
		{
		}
		public Circle(int x, int y, int r, int r_y)
		{
			p = new Point(x,y);
			this.r = r;
			this.r_y = r_y;
		}
		
		public Point getP(){
			return p;
		}
		public int getR(){
			return r;
		}
		public int getRY(){
			return r_y;
		}
		public override string ToString()
		{
			return string.Format("Circulo: {0}, radio: {1}",p,r);
		}
	}
}
