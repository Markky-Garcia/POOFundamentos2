using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    public class Viagem
    {
        public string Destino;
        public int DIas;
        public Double ValorDiaria;
        public Viagem(string Destino, int Dias, Double ValorDiaria)
        {
            this.Destino = Destino;
            this.DIas = Dias;
            this.ValorDiaria = ValorDiaria ;

        }
    }
}