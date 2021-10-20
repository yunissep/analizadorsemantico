using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semantico_analizador
{
    class tabla_Simbolos
    {
        public List<tab_s> Tabla_Simbolos = new List<tab_s>();
        tabla_errores Tabla_Errores = new tabla_errores();


        public tabla_Simbolos()
        {

        }
        public List<tab_s> TablaSimbolos
        {
            get { return Tabla_Simbolos; }
            set { Tabla_Simbolos = value; }
        }

        public void reinicialista()
        {
            Tabla_Simbolos.Clear();
        }

        //Se define la tabla de simbolos a utilizar
        public void inicialista()
        {
            tab_s ts = new tab_s("/*", "", -0, -0, -0, 0, "comentario", "inicio de un comentario de mas de una linea", "");
            Tabla_Simbolos.Add(ts);
            tab_s ts1 = new tab_s("*/", "", -0, -0, -0, 1, "comentario", "final de un comentario de mas de una linea", "");
            Tabla_Simbolos.Add(ts1);
            tab_s ts2 = new tab_s("//", "", -0, -0, -0, 2, "comentario", "inicio de un comentario de una linea", "");
            Tabla_Simbolos.Add(ts2);
            tab_s ts3 = new tab_s("float", "", -0, -0, -0, 3, "palabra reservada", "numero flotante", "");
            Tabla_Simbolos.Add(ts3);
            tab_s ts4 = new tab_s("{", "", -0, -0, -0, 4, "bloque", "inicio de un bloque", "");
            Tabla_Simbolos.Add(ts4);
            tab_s ts5 = new tab_s("}", "", -0, -0, -0, 5, "bloque", "final de un bloque", "");
            Tabla_Simbolos.Add(ts5);
            tab_s ts6 = new tab_s("int", "", -0, -0, -0, 6, "palabra reservada", "numero entero", "");
            Tabla_Simbolos.Add(ts6);
            tab_s ts7 = new tab_s("object", "", -0, -0, -0, 7, "palabra reservada", "clase base", "");
            Tabla_Simbolos.Add(ts7);
            tab_s ts8 = new tab_s("double", "", -0, -0, -0, 8, "palabra reservada", "numero con decimales", "");
            Tabla_Simbolos.Add(ts8);
            tab_s ts9 = new tab_s("string", "", -0, -0, -0, 9, "palabra reservada", "cadena de caracteres", "");
            Tabla_Simbolos.Add(ts9);
            tab_s ts10 = new tab_s("bool", "", -0, -0, -0, 10, "palabra reservada", "booleano true o false", "");
            Tabla_Simbolos.Add(ts10);
            tab_s ts11 = new tab_s("uint", "", -0, -0, -0, 11, "palabra reservada", "entero de 32 bits", "");
            Tabla_Simbolos.Add(ts11);
            tab_s ts12 = new tab_s("=", "", -0, -0, -0, 12, "asignacion", "simbolo de asignacion", "");
            Tabla_Simbolos.Add(ts12);
            tab_s ts13 = new tab_s(";", "", -0, -0, -0, 13, "posicionador", "final de linea", "");
            Tabla_Simbolos.Add(ts13);
            tab_s ts14 = new tab_s("'", "", -0, -0, -0, 14, "indicador de texto", "inicio y final de un texto", "");
            Tabla_Simbolos.Add(ts14);
            tab_s ts15 = new tab_s("/n", "", -0, -0, -0, 15, "posicionador", "salto de linea en un texto", "");
            Tabla_Simbolos.Add(ts15);
            tab_s ts16 = new tab_s("[", "", -0, -0, -0, 16, "arreglo", "inicio de asignacion de un arreglo", "");
            Tabla_Simbolos.Add(ts16);
            tab_s ts17 = new tab_s("]", "", -0, -0, -0, 17, "arreglo", "final de asignacion de un arreglo", "");
            Tabla_Simbolos.Add(ts17);
            tab_s ts18 = new tab_s("+", "", -0, -0, -0, 18, "operador", "suma", "");
            Tabla_Simbolos.Add(ts18);
            tab_s ts20 = new tab_s("-", "", -0, -0, -0, 20, "operador", "resta", "");
            Tabla_Simbolos.Add(ts20);
            tab_s ts21 = new tab_s("*", "", -0, -0, -0, 21, "operador", "multiplicacion", "");
            Tabla_Simbolos.Add(ts21);
            tab_s ts22 = new tab_s("/", "", -0, -0, -0, 22, "operador", "division", "");
            Tabla_Simbolos.Add(ts22);
            tab_s ts23 = new tab_s("!", "", -0, -0, -0, 23, "signo relacionador", "negacion", "");
            Tabla_Simbolos.Add(ts23);
            tab_s ts24 = new tab_s(">", "", -0, -0, -0, 24, "signo comparador", "mayor que", "");
            Tabla_Simbolos.Add(ts24);
            tab_s ts25 = new tab_s("<", "", -0, -0, -0, 25, "signo comparador", "menor que", "");
            Tabla_Simbolos.Add(ts25);
            tab_s ts26 = new tab_s(">=", "", -0, -0, -0, 26, "signo comparador", "mayor o igual que", "");
            Tabla_Simbolos.Add(ts26);
            tab_s ts27 = new tab_s("<=", "", -0, -0, -0, 27, "signo comparador", "menor o igual que", "");
            Tabla_Simbolos.Add(ts27);
            tab_s ts28 = new tab_s("&&", "", -0, -0, -0, 28, "signo relacionador", "expresion y (and)", "");
            Tabla_Simbolos.Add(ts28);
            tab_s ts29 = new tab_s("||", "", -0, -0, -0, 29, "signo relacionador", "expresion or", "");
            Tabla_Simbolos.Add(ts29);
            tab_s ts30 = new tab_s("==", "", -0, -0, -0, 30, "signo comparador", "expresion igual", "");
            Tabla_Simbolos.Add(ts30);
            tab_s ts31 = new tab_s("!=", "", -0, -0, -0, 31, "signo comparador", "expresion distinto", "");
            Tabla_Simbolos.Add(ts31);
            tab_s ts32 = new tab_s("if", "", -0, -0, -0, 32, "palabra reservada", "si tal condicion se cumple", "");
            Tabla_Simbolos.Add(ts32);

            tab_s ts34 = new tab_s("else", "", -0, -0, -0, 34, "palabra reservada", "si no se cumple la condicion", "");
            Tabla_Simbolos.Add(ts34);
            tab_s ts35 = new tab_s("switch", "", -0, -0, -0, 35, "palabra reservada", "opciones (casos)", "");
            Tabla_Simbolos.Add(ts35);
            tab_s ts36 = new tab_s("case", "", -0, -0, -0, 36, "palabra reservada", "caso", "");
            Tabla_Simbolos.Add(ts36);

            tab_s ts38 = new tab_s("while", "", -0, -0, -0, 38, "palabra reservada", "ciclo while", "");
            Tabla_Simbolos.Add(ts38);
            tab_s ts39 = new tab_s("for", "", -0, -0, -0, 39, "palabra reservada", "ciclo for", "");
            Tabla_Simbolos.Add(ts39);
            tab_s ts40 = new tab_s("foreach", "", -0, -0, -0, 40, "palabra reservada", "ciclo foreach", "");
            Tabla_Simbolos.Add(ts40);
            tab_s ts42 = new tab_s("try", "", -0, -0, -0, 42, "palabra reservada", "intenta realizar el codigo contenido", "");
            Tabla_Simbolos.Add(ts42);
            tab_s ts43 = new tab_s("catch", "", -0, -0, -0, 43, "palabra reservada", "muestra una accion a seguir en caso de error", "");
            Tabla_Simbolos.Add(ts43);
            tab_s ts44 = new tab_s("print", "", -0, -0, -0, 44, "palabra reservada", "muestra en consola", "");
            Tabla_Simbolos.Add(ts44);
            tab_s ts45 = new tab_s("Console.ReadLine", "", -0, -0, -0, 45, "palabra reservada", "pide en consola", "");
            Tabla_Simbolos.Add(ts45);
            tab_s ts47 = new tab_s("class", "", -0, -0, -0, 47, "palabra reservada", "clase", "");
            Tabla_Simbolos.Add(ts47);
            tab_s ts48 = new tab_s("(", "", -0, -0, -0, 48, "parametro", "inicia peticion de parametro", "");
            Tabla_Simbolos.Add(ts48);
            tab_s ts49 = new tab_s(")", "", -0, -0, -0, 49, "parametro", "termina peticion de parametro", "");
            Tabla_Simbolos.Add(ts49);
            tab_s ts50 = new tab_s("+", "", -0, -0, -0, 50, "concatenador", "concatena variables", "");
            Tabla_Simbolos.Add(ts50);
            tab_s ts51 = new tab_s("break", "", -0, -0, -0, 50, "palabra reservada", "rompe un ciclo", "");
            Tabla_Simbolos.Add(ts51);
            tab_s ts52 = new tab_s("long", "", -0, -0, -0, 50, "palabra reservada", "entero con signo", "");
            Tabla_Simbolos.Add(ts52);
            tab_s ts53 = new tab_s("byte", "", -0, -0, -0, 50, "palabra reservada", "entero sin signo", "");
            Tabla_Simbolos.Add(ts53);
            tab_s ts54 = new tab_s("short", "", -0, -0, -0, 50, "palabra reservada", "entero con signo", "");
            Tabla_Simbolos.Add(ts54);
        }


        public List<tab_s> llamatabla()
        {
            return Tabla_Simbolos;
        }

        public void añadir_obj(tab_s Ts)
        {
            Tabla_Simbolos.Add(Ts);
        }

        public bool compararAL(string argsplit)
        {
            bool comp = false;
            foreach (var palabra in Tabla_Simbolos)
            {

                if (palabra.simbolo == argsplit)
                {
                    comp = true;
                    break;
                }
                else
                {
                    comp = false;
                }

            }
            return comp;
        }

        public bool busca_dupl()
        {
            bool flag = false;

            foreach (var sent1 in Tabla_Simbolos)
            {
                foreach (var sent2 in Tabla_Simbolos)
                {
                    if (sent1.ID == sent2.ID)
                    {

                        flag = true;


                    }
                }
            }
            return flag;
        }

        public void comparacion_semantic()
        {

            foreach (var palabra in Tabla_Simbolos)
            {
                foreach (var palabra2 in Tabla_Simbolos)
                {
                    if (palabra.Simbolo == palabra2.Simbolo)
                    {
                        palabra2.Tipo_Dato = palabra.Tipo_Dato;
                    }
                }
            }

        }



        public int compararALRef(string argsplit)
        {
            int id = 0;
            foreach (var palabra in Tabla_Simbolos)
            {

                if (palabra.simbolo == argsplit)
                {
                    id = palabra.id;
                    break;
                }
                else
                {
                    id = 0;
                }

            }
            return id;
        }


        public int contlineas()
        {
            int numid = 0;
            foreach (var nlinea in Tabla_Simbolos)
            {
                numid = numid + 1;
            }
            return numid - 1;
        }
    }
}
