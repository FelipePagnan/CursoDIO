﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Pessoa
    {
        public string Nome{ get; set; }
        public int Idade { get; set; }

        public string NomeRepresentandoLegalDaPessoaFisica { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome e {Nome}, e tenho {Idade} anos");
        }
    }
}
