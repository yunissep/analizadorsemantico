using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Semantico_analizador
{
	public partial class First : Form
	{
		int cantLineas = 0;

		tabla_Simbolos tabla_simbolos = new tabla_Simbolos();
		tabla_errores tabla_errorres = new tabla_errores();

		public First()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			rTexto.Text = "";
			dataGridView1.DataSource = null;
			dataGridView2.DataSource = null;
			dataGridView1.Columns.Clear();
			dataGridView2.Columns.Clear();
			dataGridView1.Rows.Clear();
			dataGridView2.Rows.Clear();

			cantLineas = 0;

			tabla_simbolos = new tabla_Simbolos();
			tabla_errorres = new tabla_errores();
		}

		private void First_Load(object sender, EventArgs e)
		{

		}
		public void leer_texto(string texto)
		{

			int contador_Ambitoi = 0;
			int contador_Ambitf = 0;
			int ambito = 0;

			try
			{
				string[] oracion;
				string[] palabra_sep;
				int num_linea = 0;
				oracion = texto.Split('\n');

				if (oracion.Length > 0)
				{
					for (int i = 0; i < oracion.Length; i++)
					{

						num_linea++;
						//separamos las palabras divididas por espacios
						palabra_sep = oracion[i].Split(' ');

						foreach (var palabra in palabra_sep)
						{

							if (palabra == "{")
							{
								contador_Ambitoi = contador_Ambitoi + 1;
							}
							if (palabra == "}")
							{
								contador_Ambitf = contador_Ambitf + 1;
							}
							ambito = contador_Ambitoi;


							//en esta parte se compara si la palabra esta dentro de la tabla de simbolos que tenemos predefinida
							if (tabla_simbolos.compararAL(palabra.ToString()) && palabra != null)
							{

								tab_s obj = new tab_s(palabra, "", num_linea, -0, ambito, tabla_simbolos.compararALRef(palabra.ToString()), "palabra nueva", "palabra contenida en la tabla de simbolos", "");
								tabla_simbolos.añadir_obj(obj);

							}
							//si dicha palabra no esta contenida dentro de la tabla de simbolos, pues procedemos a insertarla
							else
							{
								if (Regex.IsMatch(palabra, @"[a-zA-Z]") && palabra != null)
								{
									tab_s obj = new tab_s(palabra, "", num_linea, -0, ambito, tabla_simbolos.contlineas() + 1, "palabra nueva", "palabra que no coincide con la Tabla de simbolos,pero no se considera error", "");
									tabla_simbolos.añadir_obj(obj);
								}
								else if (Regex.IsMatch(palabra, @"\d{1}|\d{2}|\d{3}|\d{4}|\d{5}") && palabra != null)
								{
									tab_s obj = new tab_s(palabra, palabra, num_linea, -0, ambito, tabla_simbolos.contlineas() + 1, "numero nuevo", "numero", "");
									tabla_simbolos.añadir_obj(obj);
								}
							}
						}
						//hasta aqui se realiza el analisis lexico


						//palabra_sep = null;
						//Rtexto = "";
						cantLineas = num_linea;
					}

					//verificamos si existe algun error
					if (contador_Ambitf != contador_Ambitoi)
					{
						tabla_errorres.agrega_error(8);

					}

				}
				else {

					MessageBox.Show("Vacío");
				}

			}
			catch (ArgumentNullException)
			{

				MessageBox.Show("Error");

				tabla_errorres.agrega_error(2);
			}
			catch (Exception)
			{

				MessageBox.Show("error");
			}



		}

		public string[] une_tokens()
		{
			
			string sentencia = null;
			string[] sentencias = new string[cantLineas];
			int comp = 0;
			string tipov = "";

			for (int i = 1; i < cantLineas; i++)
			{
				
				foreach (var token in tabla_simbolos.llamatabla())
				{
					if (token.num_linea == i && token != null)
					{
						

						if (comp == 0 && Regex.IsMatch(token.Simbolo, @"(int|float|double|bool|string|uint|byte|object)$"))
						{
							token.Tipo_Dato = token.Simbolo;
							tipov = token.Simbolo;
						}


						if (comp != 0)
						{
							sentencia = sentencia + " " + token.simbolo.ToString();
							token.Tipo_Dato = tipov;
						}
						else
						{
							sentencia = sentencia + token.simbolo.ToString();
							comp = 1;
						}

					}
					else
					{

						sentencia = sentencia + " " + token.simbolo.ToString();
					}
				}
				sentencias[i] = sentencia;
				sentencia = null;
				comp = 0;
				tipov = "";
			}

			return sentencias;
		}

		public void Analisis_Sint_Sem(string[] sentencias)
		{


			for (int i = 1; i < sentencias.Length; i++)
			{
				if (sentencias[i] != null)
				{
					if (sentencias[i].Contains("int"))
					{
						string[] separanum;
						separanum = sentencias[i].Split(' ');

						try
						{
							int num;
							num = int.Parse(separanum[2].Replace(";", ""));


						}
						catch (FormatException e)
						{
							tabla_errorres.agrega_error_l(0, i);

						}
						catch (IndexOutOfRangeException e)
						{

							tabla_errorres.agrega_error_l(10, i);
							MessageBox.Show("Error en sintaxis");

						}



					}
					else if (sentencias[i].Contains("double"))
					{
					
						string[] separanum;
						separanum = sentencias[i].Split(' ');
						try
						{
							double num;
							num = double.Parse(separanum[3]);

						}
						catch (FormatException e)
						{
							tabla_errorres.agrega_error_l(0, i);

						}
						catch (IndexOutOfRangeException e)
						{

							tabla_errorres.agrega_error_l(10, i);
							MessageBox.Show("Error en sintaxis");

						}


					}
					else if (sentencias[i].Contains("string"))
					{

					}
					else if (sentencias[i].Contains("bool"))
					{
					   
						string[] separavar;
						separavar = sentencias[i].Split(' ');
						try
						{
							bool var;
							var = bool.Parse(separavar[3]);


						}
						catch (FormatException e)
						{

							tabla_errorres.agrega_error_l(0, i);
						}

					}
					else if (sentencias[i].Contains("//"))
					{

					}
					else if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s[a-z]|(\w)*\s\+\s(\w)*|\d(0,32000)*\s;$"))
					{
					  
						string tpv1 = "";
						string tpv2 = "";
						string tpv3 = "";

						string[] separavar;
						separavar = sentencias[i].Split(' ');

						if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\+\s(\w)*\s;$"))
						{

							foreach (var token in tabla_simbolos.llamatabla())
							{
								if (token.Simbolo == separavar[0])
								{
									tpv1 = token.Tipo_Dato;
								}
								if (token.Simbolo == separavar[2])
								{
									tpv2 = token.Tipo_Dato;
								}
								if (token.Simbolo == separavar[4])
								{
									tpv3 = token.Tipo_Dato;
								}

							}
							if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
							{
								MessageBox.Show("el tipo de las variables son el mismo");
							}
						}
						if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\-\s(\w)*\s;$"))
						{

							foreach (var token in tabla_simbolos.llamatabla())
							{
								if (token.Simbolo == separavar[0])
								{
									tpv1 = token.Tipo_Dato;
								}
								if (token.Simbolo == separavar[2])
								{
									tpv2 = token.Tipo_Dato;
								}
								if (token.Simbolo == separavar[4])
								{
									tpv3 = token.Tipo_Dato;
								}

							}
							if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
							{
								MessageBox.Show("El tipo de las variables son iguales");
							}
						}
						if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\/\s(\w)*\s;$"))
						{

							foreach (var token in tabla_simbolos.llamatabla())
							{
								if (token.Simbolo == separavar[0])
								{
									tpv1 = token.Tipo_Dato;
								}
								if (token.Simbolo == separavar[2])
								{
									tpv2 = token.Tipo_Dato;
								}
								if (token.Simbolo == separavar[4])
								{
									tpv3 = token.Tipo_Dato;
								}

							}
							if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
							{
								MessageBox.Show("El tipo de las variables son iguales");
							}
						}
						if (Regex.IsMatch(sentencias[i], @"[a-z]\s+:\s(\w)*\s\*\s(\w)*\s;$"))
						{

							foreach (var token in tabla_simbolos.llamatabla())
							{
								if (token.Simbolo == separavar[0])
								{
									tpv1 = token.Tipo_Dato;
								}
								if (token.Simbolo == separavar[2])
								{
									tpv2 = token.Tipo_Dato;
								}
								if (token.Simbolo == separavar[4])
								{
									tpv3 = token.Tipo_Dato;
								}

							}
							if (tpv1 == tpv2 && tpv2 == tpv3 && tpv1 != "")
							{
								MessageBox.Show("El tipo de las variables son iguales");
							}
						}

					}
					else if (Regex.IsMatch(sentencias[i], @"^{$"))
					{
						MessageBox.Show("inicio de ambito");
					}
					else if (Regex.IsMatch(sentencias[i], @"^}$"))
					{
						MessageBox.Show("fin de ambito");
					}
					else if (sentencias[i].Contains("if"))
					{
						MessageBox.Show("comienzo de if");
					}
					else if (sentencias[i].Contains("else if"))
					{
						MessageBox.Show("comienzo de else if");
					}
					else if (sentencias[i].Contains("else"))
					{
						MessageBox.Show("comienzo de else");
					}
					else if (sentencias[i].Contains("switch"))
					{
						MessageBox.Show("comienzo del switch");
					}
					else if (sentencias[i].Contains("case"))
					{
						MessageBox.Show("comienzo de case");
					}
					else if (sentencias[i].Contains("break"))
					{
						MessageBox.Show("break del case");
					}
					else if (sentencias[i].Contains("while"))
					{
						MessageBox.Show("inicio de un while");
					}

					else if (sentencias[i].Contains("print"))
					{
						MessageBox.Show("mostrar por pantalla \n" + sentencias[i]);

					}
					else
					{
						if (sentencias[i] != null)
						{
							tabla_errorres.agrega_error_l(9, i);
						}
					}
				}


			}

		}

	   //BOTON COMPILAR
		private void button2_Click(object sender, EventArgs e)
		{
			
			tabla_errorres.inicialestaE(); //INICIA LA TABLA DE ERROES
			leer_texto(rTexto.Text); // ANALIZA EL TEXTO INGRESADO EN FORMA DE ANALISIS LÉXICO 
			string[] sent = une_tokens(); // UNE LO TOKENS QUE DEBE ESTAR UNIDOS.
			tabla_simbolos.comparacion_semantic(); //Hace la comparación semántica.
			Analisis_Sint_Sem(sent); // HACE EL PROCESO DE ANALISIS SEMANTICO Y SINTÁCTICO

			//CREACIÓN DE TABLAS.
			dataGridView1.DataSource = null;
			dataGridView2.DataSource = null;
			dataGridView1.DataSource = tabla_simbolos.llamatabla();
			dataGridView2.DataSource = tabla_errorres.llamatablaE();
		}
	}
}
