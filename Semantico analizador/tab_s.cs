using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semantico_analizador
{
    class tab_s
    {

        public string simbolo;
        public string valor;
        public int num_linea;
        public int tamaño;
        public int ambito;
        public int id;
        public string tipovar;
        public string tipo;
        public string descripcion;

        public tab_s(string simb, string val, int nunlin, int tam, int ambit, int id_, string tip, string descrip, string tipvar)
        {

            simbolo = simb;
            valor = val;
            num_linea = nunlin;
            tamaño = tam;
            ambito = ambit;
            id = id_;
            tipo = tip;
            descripcion = descrip;
            tipovar = tipvar;

        }


        public tab_s()
        {

        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Simbolo
        {
            get { return simbolo; }
            set { simbolo = value; }
        }
        public string Tipo_Dato
        {
            get { return tipovar; }
            set { tipovar = value; }
        }


        public int Num_Linea
        {
            get { return num_linea; }
            set { num_linea = value; }
        }
        public int Ambito
        {
            get { return ambito; }
            set { ambito = value; }
        }
        public int Tamaño
        {
            get { return tamaño; }
            set { tamaño = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
