﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfelse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if(nota >= 7.0)
            {
                Console.WriteLine("Foi Aprovado! ");
                Console.WriteLine("Não fez mais que sua obrigação ");
            }
            else
            {
                Console.WriteLine("Recuperação! ");
            }
        }
    }
}
