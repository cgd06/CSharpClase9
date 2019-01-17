using System;
using System.Collections.Generic;
using System.Text;

namespace Clase9
{
    class A {
        public A() {
        }
        public void teDigoTuDireccion(A a) {
            yoMismo = a;
        }
        public void mostrarDireccion()
        {
            Console.WriteLine(yoMismo.GetHashCode());
            Console.WriteLine(this.GetHashCode());
        }
        private A yoMismo;
    }

    public class ElProblemaDelThis
    {
        public void init() {
            A a1 = new A();
            a1.teDigoTuDireccion(a1);
            a1.mostrarDireccion();

            A a2 = new A();
            a2.teDigoTuDireccion(a2);
            a2.mostrarDireccion();
        }
    }
}
