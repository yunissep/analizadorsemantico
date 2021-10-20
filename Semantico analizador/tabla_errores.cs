using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semantico_analizador
{
    class tabla_errores
    {
        public List<tab_e> Tabla_Errores = new List<tab_e>();
        public List<tab_e> Tabla_Erroresed = new List<tab_e>();


        public tabla_errores()
        {

        }
        public List<tab_e> TablaErrores
        {
            get { return Tabla_Errores; }
            set { Tabla_Errores = value; }
        }
        public void reinicialista()
        {
            Tabla_Errores.Clear();
            Tabla_Erroresed.Clear();
        }
        public void inicialestaE()
        {

            tab_e te = new tab_e(0, "valor incorrecto", "escriba el valor aceptado por el tipo de variable", "valor diferente al aceptado por el tipo");
            Tabla_Errores.Add(te);

            tab_e te1 = new tab_e(1, "se espera un valor", "escriba un valor para la variable ", "se espera un valor despues de...");
            Tabla_Errores.Add(te1);


            tab_e te3 = new tab_e(3, "error aritmetico", "revise la operación que esta realizando", "excepciones producidas durante operaciones aritméticas");
            Tabla_Errores.Add(te3);

            tab_e te4 = new tab_e(4, "error dividir por cero ", "escoja otro numero que no sea el 0 para dividir", "posible incongruencia en divicion,o en cualquier operación");
            Tabla_Errores.Add(te4);

            tab_e te5 = new tab_e(5, "error de conversion de tipo", "verifique que los tipos de las variables sea el mismo ", "Se produce cuando tiene lugar un error en tiempo de ejecución en una conversión explícita de un tipo base a una interfaz o a un tipo derivado.");
            Tabla_Errores.Add(te5);

            tab_e te6 = new tab_e(6, "error referencia nula", "revise que esta dando un valor a la variable", "Se produce al intentar hacer referencia a un objeto cuyo valor es null.");
            Tabla_Errores.Add(te6);

            tab_e te7 = new tab_e(7, "error de desbordamiento", "asegurese del tamaño del resultado ", "Se produce cuando una operación aritmética en un contexto produce un desbordamiento.");
            Tabla_Errores.Add(te7);
            tab_e te8 = new tab_e(8, "error de Ambito", "asegurese de que las llaves '{' tengan su contraparte '}' ", "Se produce cuando hay alguna llave sin cerrar, ambito incompleto");
            Tabla_Errores.Add(te8);
            tab_e te9 = new tab_e(9, "sintaxis desconocida", "asegurese de que la sintaxis sea correcta ", "Se produce cuando se desconoce la sintaxis de la sentencia");
            Tabla_Errores.Add(te9);
            tab_e te10 = new tab_e(10, "sintaxis erronea", "asegurese de que la sintaxis sea correcta, verifique espacios ", "Se produce cuando la sintaxis de la sentencia contiene algun error");
            Tabla_Errores.Add(te10);
            tab_e te11 = new tab_e(11, "warning", "asegurese de que las variables no esten repetidas ", "Se produce cuando mas de una variable estan inicializadas con el mismo nombre");
            Tabla_Errores.Add(te11);


        }

        public List<tab_e> llamatablaE()
        {
            return Tabla_Erroresed;
        }



        public void agrega_error_l(int id, int nl)
        {
            foreach (var error in Tabla_Errores)
            {

                if (error.Id == id)
                {
                    tab_e er = new tab_e();
                    er.Descripcion = error.Descripcion;
                    er.Recomendacion = error.Recomendacion;
                    er.Error = error.Error;
                    er.num_linea = nl;
                    Tabla_Erroresed.Add(er);
                }

            }

        }
        public void agrega_error(int id)
        {
            foreach (var error in Tabla_Errores)
            {

                if (error.Id == id)
                {
                    tab_e er = new tab_e();
                    er.Descripcion = error.Descripcion;
                    er.Recomendacion = error.Recomendacion;
                    er.Id = error.Id;
                    Tabla_Erroresed.Add(er);
                }

            }

        }
    }
}
