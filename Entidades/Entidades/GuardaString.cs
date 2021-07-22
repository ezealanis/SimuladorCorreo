using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    //Metodo de extension para el objeto String, crea un archivo y lo guarda en formato texto.
    public static class GuardaString
    {
        public static bool Guardar(this string texto, string archivo)
        {
            try
            {
                //Obtiene la ruta del escritorio y le agrega "\nombrearchivo", con el true agrega el texto al final si ya existe el archivo.
                using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + archivo, true))
                {
                    sw.WriteLine(texto);
                    return true;
                }
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
