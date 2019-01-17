using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Clase9
{
    public class LeerImagen
    {
        public void leer() {
            String inputPath = @"c:\clase9\Hamburguesa.bmp";
            FileStream fs = new FileStream(inputPath, FileMode.Open);
            int largoArchivoInput = (int)fs.Length;

            Console.WriteLine();

            byte[] arrayDeBytes = new byte[largoArchivoInput];
            fs.Read(arrayDeBytes, 0, (int)largoArchivoInput);

            for (int idx = 0; idx < largoArchivoInput; idx++) {
                if (idx < 53)
                    continue;

                if ((idx > 6000) && (idx < 350000)) {
                    arrayDeBytes[idx] = (byte)(arrayDeBytes[idx] + 200);
                }
            }

            String outPutFile = @"c:\clase9\HamburguesaOut.bmp";
            FileStream fsOut = new FileStream(outPutFile, FileMode.Create);

            fsOut.Write(arrayDeBytes, 0, largoArchivoInput);

            fs.Close();
            fsOut.Close();
        }
    }
}
