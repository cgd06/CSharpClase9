using System;
using System.Collections.Generic;
using System.Text;

namespace Clase9
{
    class Contenedor<TIPADO_A_FONDO> {
        public Contenedor() {
        }
        public void guardarObjeto(TIPADO_A_FONDO t) {
            this.o = t;
        }
        public TIPADO_A_FONDO obtenerObjeto() {
            return this.o;
        }
        private TIPADO_A_FONDO o;
    }

    class Transaccion {
        public String nroTransac { get; set; }
    }

    public class Genericos
    {
        public void init() {
            var tran = new Transaccion();
            tran.nroTransac = "10222";

            var cont = new Contenedor<Transaccion>();
            cont.guardarObjeto(tran);
            var tran2 = cont.obtenerObjeto();

            var contieneString = new Contenedor<String>();
            contieneString.guardarObjeto("HOLA");
            Console.WriteLine(contieneString.obtenerObjeto());

            Func<String, int> funcioncita = z => z.Length;
        }
    }
}
