using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    public class Prioridades
    {
        public List<Proceso> ejecutarPrioridad(List<Proceso> lista)
        {
            var ordenarList = lista.OrderBy(p => p.prioridad).ToList();
            int actual = 0;
            foreach (var item in ordenarList) { 
                item.inicio = actual;
                item.final = actual + item.tiempo;
                actual = item.final;
            }
            return ordenarList;
        }
    }
}
