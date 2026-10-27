/*
 * Creado por SharpDevelop.
 * Usuario: CC2_PC40
 * Fecha: 27/10/2026
 * Hora: 07:29 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Practicasharpdevelop
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNumero1 = new System.Windows.Forms.Label();
			this.lblNumero2 = new System.Windows.Forms.Label();
			this.btnsumar = new System.Windows.Forms.Button();
			this.btnrestar = new System.Windows.Forms.Button();
			this.btnmultiplicar = new System.Windows.Forms.Button();
			this.btndividir = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtNumero1 = new System.Windows.Forms.TextBox();
			this.txtNumero2 = new System.Windows.Forms.TextBox();
			this.btnmodulo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNumero1
			// 
			this.lblNumero1.Location = new System.Drawing.Point(13, 32);
			this.lblNumero1.Name = "lblNumero1";
			this.lblNumero1.Size = new System.Drawing.Size(100, 23);
			this.lblNumero1.TabIndex = 0;
			this.lblNumero1.Text = "Numero 1";
			// 
			// lblNumero2
			// 
			this.lblNumero2.Location = new System.Drawing.Point(13, 74);
			this.lblNumero2.Name = "lblNumero2";
			this.lblNumero2.Size = new System.Drawing.Size(100, 23);
			this.lblNumero2.TabIndex = 1;
			this.lblNumero2.Text = "Numero 2";
			// 
			// btnsumar
			// 
			this.btnsumar.Location = new System.Drawing.Point(13, 114);
			this.btnsumar.Name = "btnsumar";
			this.btnsumar.Size = new System.Drawing.Size(75, 23);
			this.btnsumar.TabIndex = 2;
			this.btnsumar.Text = "Suma";
			this.btnsumar.UseVisualStyleBackColor = true;
			this.btnsumar.Click += new System.EventHandler(this.BtnsumarClick);
			// 
			// btnrestar
			// 
			this.btnrestar.Location = new System.Drawing.Point(103, 113);
			this.btnrestar.Name = "btnrestar";
			this.btnrestar.Size = new System.Drawing.Size(75, 23);
			this.btnrestar.TabIndex = 3;
			this.btnrestar.Text = "Resta";
			this.btnrestar.UseVisualStyleBackColor = true;
			this.btnrestar.Click += new System.EventHandler(this.BtnrestarClick);
			// 
			// btnmultiplicar
			// 
			this.btnmultiplicar.Location = new System.Drawing.Point(184, 113);
			this.btnmultiplicar.Name = "btnmultiplicar";
			this.btnmultiplicar.Size = new System.Drawing.Size(85, 23);
			this.btnmultiplicar.TabIndex = 4;
			this.btnmultiplicar.Text = "Multiplicacion";
			this.btnmultiplicar.UseVisualStyleBackColor = true;
			this.btnmultiplicar.Click += new System.EventHandler(this.BtnmultiplicarClick);
			// 
			// btndividir
			// 
			this.btndividir.Location = new System.Drawing.Point(275, 113);
			this.btndividir.Name = "btndividir";
			this.btndividir.Size = new System.Drawing.Size(75, 23);
			this.btndividir.TabIndex = 5;
			this.btndividir.Text = "Division";
			this.btndividir.UseVisualStyleBackColor = true;
			this.btndividir.Click += new System.EventHandler(this.BtndividirClick);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Location = new System.Drawing.Point(142, 6);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(100, 23);
			this.lblTitulo.TabIndex = 6;
			this.lblTitulo.Text = "Calculadora";
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(13, 171);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(100, 23);
			this.lblResultado.TabIndex = 7;
			// 
			// txtNumero1
			// 
			this.txtNumero1.Location = new System.Drawing.Point(78, 32);
			this.txtNumero1.Name = "txtNumero1";
			this.txtNumero1.Size = new System.Drawing.Size(100, 20);
			this.txtNumero1.TabIndex = 8;
			// 
			// txtNumero2
			// 
			this.txtNumero2.Location = new System.Drawing.Point(78, 74);
			this.txtNumero2.Name = "txtNumero2";
			this.txtNumero2.Size = new System.Drawing.Size(100, 20);
			this.txtNumero2.TabIndex = 9;
			// 
			// btnmodulo
			// 
			this.btnmodulo.Location = new System.Drawing.Point(242, 51);
			this.btnmodulo.Name = "btnmodulo";
			this.btnmodulo.Size = new System.Drawing.Size(75, 23);
			this.btnmodulo.TabIndex = 10;
			this.btnmodulo.Text = "Modulo";
			this.btnmodulo.UseVisualStyleBackColor = true;
			this.btnmodulo.Click += new System.EventHandler(this.BtnmoduloClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 305);
			this.Controls.Add(this.btnmodulo);
			this.Controls.Add(this.txtNumero2);
			this.Controls.Add(this.txtNumero1);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btndividir);
			this.Controls.Add(this.btnmultiplicar);
			this.Controls.Add(this.btnrestar);
			this.Controls.Add(this.btnsumar);
			this.Controls.Add(this.lblNumero2);
			this.Controls.Add(this.lblNumero1);
			this.Name = "MainForm";
			this.Text = "Practicasharpdevelop";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnmodulo;
		private System.Windows.Forms.TextBox txtNumero2;
		private System.Windows.Forms.TextBox txtNumero1;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Label lblTitulo;
		private System.Windows.Forms.Button btndividir;
		private System.Windows.Forms.Button btnmultiplicar;
		private System.Windows.Forms.Button btnrestar;
		private System.Windows.Forms.Button btnsumar;
		private System.Windows.Forms.Label lblNumero2;
		private System.Windows.Forms.Label lblNumero1;
	}
}
