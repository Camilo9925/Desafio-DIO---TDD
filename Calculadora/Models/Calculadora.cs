using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class CalculadoraSimples
    {
        private List<string> ListaHistorico;
        
        public CalculadoraSimples()
        {
            ListaHistorico = new List<string>();
        }
        
        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }

          public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            
            ListaHistorico.Insert(0, "Res:" + res);
            
            return res;
        }

          public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }

          public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            
            ListaHistorico.Insert(0, "Res:" + res);
            return res;
        }
        
        public List<string> historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);
            return ListaHistorico;
        }
    }
}