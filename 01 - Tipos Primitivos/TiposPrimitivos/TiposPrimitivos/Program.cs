using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int numero = 3;
            float numero2 = 2f;
            bool certidaoDeVivo = false;
            int resultado = numero + (int) numero2;
            string texto = "Ola mundo";

            enum Dias  = {
            domingo,segunda,terça,quarta,quinta,sexta,sabado
             };

            


            Console.WriteLine(numero);
            Console.WriteLine(texto);

            Console.WriteLine(texto+"Voce esta vivo {0}", certidaoDeVivo);

            Console.ReadLine();

            // Comentário em Chsarp é escrito com // {tambem}


        }
    }
}
