using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exemplo_poo.Interfaces
{
    public interface ICalculadora
    {
        int Somar (int num1, int num2);
        int Subtrair (int num1, int num2);
        int Multiplicar (int num1, int num2);
        int Dividir (int num1, int num2); 
        //{
        //    return num1 / num2; MÉTODOS COM CORPO SÃO OPCIONAIS PARA SUA IMPLEMENTAÇÃO.
        //}
    }
}