using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    public class Proceso
    {
        public string nombre { get; set; }
        public int tiempo { get; set; }
        public int prioridad { get; set; }
        public int inicio { get; set; }
        public int final { get; set; }
        public int restante { get; set; }
        //Cargamos los procesos del archivo txt
        public List<Proceso> cargarProcesos(string path)
        {
            List<Proceso> procesosLst = new List<Proceso>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] lineSplit = line.Split(',');
                    Proceso pr = new Proceso();
                    pr.nombre = lineSplit[0];
                    pr.tiempo = int.Parse(lineSplit[1]);
                    pr.prioridad = int.Parse(lineSplit[2]);
                    procesosLst.Add(pr);
                }
            }
            return procesosLst;
        }
    }
}


