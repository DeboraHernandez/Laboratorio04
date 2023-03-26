using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio04
    {
        public int[] CalcularBilletes(int cant, int[] billetes)
        {
            int[] result = new int[billetes.Length];

            for (int i = 0; i < billetes.Length; i++)
            {
                result[i] = cant / billetes[i];
                cant = cant % billetes[i];
            }
            return result;
        }
    }
}
