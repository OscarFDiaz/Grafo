/*
 * Created by SharpDevelop.
 * User: Usuario
 * Date: 21/08/2018
 * Time: 01:44 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Etapa_1._
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainForm ventana1 = new MainForm();
			ventana1.ShowDialog();
		}
		
	}
}
