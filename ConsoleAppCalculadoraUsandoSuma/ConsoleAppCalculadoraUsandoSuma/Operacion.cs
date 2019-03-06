using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculadoraUsandoSuma
{
    class Operacion
    {
        public double _Numero1;
        public double _Numero2;
        public double Resultado;
        public double multiplicar;
        public double dividir;

        public double Numero1
            {
            get { return _Numero1; }
            set { _Numero1 = value; }
            }

        public double Numero2
            {
            get { return _Numero2; }
            set { _Numero2 = value; }
            }

        public double Sumar()
        {
        Resultado = Numero1 + Numero2;
        return Resultado;
        }

        public string Restar()
        {
            var resta = 0;

            if (Numero1 >= Numero2)
            {
                for (int k = (int)Numero2; k < Numero1; k++)
                { 
                resta++;
                }
                return resta.ToString();
            }
            else
            {
                for (int k = (int)Numero1; k < Numero2; k++)
                { 
                resta++;                
                }
                return "-" + resta;
            }
            
        }

        public double Multiplicar()
            {
            for (int k = 0; k < Numero2; ++k)
            {  
                multiplicar += Numero1;
            }
            return multiplicar;
        }

        public double Dividir()
            {
            if (Numero1 >= Numero2)
            {
                for (int i = 0; i < (int)Numero1; i = i + (int)Numero2)
                { 
                    dividir++;
                }
            }
            return dividir;
            }
    }
}
