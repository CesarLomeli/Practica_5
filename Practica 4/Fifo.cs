using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Practica_5
{
    public class Fifo
    {
        public List<Proceso> ejecutarFifo(List<Proceso> lista)
        {
            int actual = 0;
            foreach (var obj in lista)
            {
                obj.inicio = actual;
                obj.final = actual + obj.tiempo;
                actual = obj.final;
            }
            return lista;
        }
    }
}