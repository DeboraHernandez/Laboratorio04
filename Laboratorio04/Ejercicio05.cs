using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio05
    {
        public int[] CalcularBilletes(int cant, int[,] billetes)
        {
            int[] resultado = new int[billetes.GetLength(0)];

            for (int i = 0; i < resultado.Length; i++)
            {
                int denominacion = billetes[i, 0];
                int limiteDenominacion = billetes[i, 1];

                int posiblesBilletes = cant / denominacion;

                if (limiteDenominacion < 0 || posiblesBilletes <= limiteDenominacion)
                {
                    resultado[i] = posiblesBilletes;
                }
                else
                {
                    resultado[i] = limiteDenominacion;
                }

                cant = cant - (resultado[i] * denominacion);
            }

            return resultado;
        }
    }
}