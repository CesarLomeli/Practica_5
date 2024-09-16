using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    public class Sjf
    {
        public List<Proceso> ejecutarSjf(List<Proceso> lista)
        {
            int actual = 0;
            var listaOrdenada = lista.OrderBy(p => p.tiempo).ToList();
            foreach (var item in listaOrdenada)
            {
                item.inicio = actual;
                item.final = actual + item.tiempo;
                actual = item.final;
            }
            return listaOrdenada;
        }
    }
}
