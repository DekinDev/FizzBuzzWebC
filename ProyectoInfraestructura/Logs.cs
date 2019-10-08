using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoInfraestructura
{
    class Logs
    {
        private string Path = "";
        private string Salto = "\n";

        public Logs(string Path)
        {
            this.Path = Path;
        }

        public void Add(string sLog)
        {
            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";
            cadena += DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + "- " + sLog + Environment.NewLine;

            using (StreamWriter sr = new StreamWriter(Path + "/" + nombre, true))
            {
                sr.Write(cadena);
                sr.Close();
            }
        }


        private string GetNameFile()
        {
            string nombre = "";

            nombre = "Log_" + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + ".txt";

            return nombre;
        }

        private void CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
