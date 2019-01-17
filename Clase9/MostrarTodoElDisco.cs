using System;
using System.Collections.Generic;
using System.Text;

namespace Clase9
{
    class MostrarTodoElDisco
    {
        private void recurrir(String path) {
            var rootDir = System.IO.Directory.GetDirectories(path);
            foreach (var dir in rootDir)
            {   
                recurrir(dir);
                Console.WriteLine(dir);
            }
            var filesRoot = System.IO.Directory.GetFiles(path);
            foreach (var arc in filesRoot)
            {
                Console.WriteLine(arc);
            }
        }

        public void init() {

            recurrir(@"c:\clase9");
            Console.ReadLine();
        }
    }
}
