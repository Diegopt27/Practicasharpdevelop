/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC40
 * Fecha: 27/10/2026
 * Hora: 07:29 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Practicasharpdevelop
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnsumarClick(object sender, EventArgs e)
		{
			double a=double.Parse(txtNumero1.Text);
			double b=double.Parse(txtNumero2.Text);
			
			lblResultado.Text="Resultado :"+(a+b);
		}
		
		void BtnrestarClick(object sender, EventArgs e)
		{
			double a=double.Parse(txtNumero1.Text);
			double b=double.Parse(txtNumero2.Text);
			
			lblResultado.Text="Resultado :"+(a-b);
		}
		
		void BtnmultiplicarClick(object sender, EventArgs e)
		{
			double a=double.Parse(txtNumero1.Text);
			double b=double.Parse(txtNumero2.Text);
			
			lblResultado.Text="Resultado :"+(a*b);			
		}
		
		void BtndividirClick(object sender, EventArgs e)
		{
			double a=double.Parse(txtNumero1.Text);
			double b=double.Parse(txtNumero2.Text);
			if (b!=0)
			{
				lblResultado.Text="Resultado :"+(a/b);
			}
			else
			{
				MessageBox.Show("No se puede dividir entre cero.");
			}
		}
		
		void BtnmoduloClick(object sender, EventArgs e)
		{
			double a=double.Parse(txtNumero1.Text);
			double b=double.Parse(txtNumero2.Text);
			if (b!=0)
			{
				lblResultado.Text="Resultado :"+(a%b);
			}
			else
			{
				MessageBox.Show("No se puede calcular el modulo entre cero.");
			}			
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double a=double.Parse(txtA.Text);
			double b=double.Parse(txtB.Text);
			double c=double.Parse(txtC.Text);
			
			if (a==0)
			{
				MessageBox.Show("el valor de A no puede ser cero.");
					return;
			}
			
			double discriminante =b*b-4*a*c;
			
			if (discriminante<0)
			{
				MessageBox.Show("la ecuacion no tiene soluciones reales.");
				return;
			}
			
			double x1=(-b+Math.Sqrt(discriminante))/(2*a);
			double x2=(-b+Math.Sqrt(discriminante))/(2*a);
			
			lblx1.Text="X1:"+x1;
			lblx2.Text="X2:"+x2;
		}
	}
}
