using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace pryAguirreIE
{
    internal class clsGrabarArchivo

    {


        public static string RutaFull;

        public void Grabar(string numero, string entidad, string apertura, string expediente,string juzgado, string jurisdiccion, string direccion, string liquidador)
        {
            

           



            DirectoryInfo info = new DirectoryInfo(@"../../" + "Resources");
            string ruta = info.FullName;
            
            StreamWriter Listado = new StreamWriter((ruta + "/" + RutaFull), true);
            Listado.Write(numero);
            Listado.Write(";");
            Listado.Write(entidad);
            Listado.Write(";");
            Listado.Write(apertura);
            Listado.Write(";");
            Listado.Write(expediente);
            Listado.Write(";");
            Listado.Write(juzgado);
            Listado.Write(";");
            Listado.Write(jurisdiccion);
            Listado.Write(";");
            Listado.Write(direccion);
            Listado.Write(";");
            Listado.WriteLine(liquidador);
            Listado.Close();
            Listado.Dispose();
        }
    }
}
