using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semantico_analizador
{
    class tab_e
    {
        public int ID;
        public int num_linea;
        public string error;
        public string descr;
        public string soluc_error;


        public tab_e(int id, int nl, string e, string se, string d)
        {
            ID = id;
            num_linea = nl;
            error = e;
            soluc_error = se;
            descr = d;

        }
        public tab_e(int id, string e, string se, string d)
        {

            ID = id;
            error = e;
            soluc_error = se;
            descr = d;

        }

        public tab_e()
        {

        }

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        public int Num_Linea
        {
            get { return num_linea; }
            set { num_linea = value; }
        }

        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        public string Recomendacion
        {
            get { return soluc_error; }
            set { soluc_error = value; }
        }
        public string Descripcion
        {
            get { return descr; }
            set { descr = value; }
        }
    }
}
