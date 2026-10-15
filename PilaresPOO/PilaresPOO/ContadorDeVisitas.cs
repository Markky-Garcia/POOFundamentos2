using System;
using System.Collections.Generic;
using System.Text;

namespace PilaresPOO
{
    internal class ContadorDeVisitas
    {
        private int Visitas;

        public int RegistrarVisitas;

        public ContadorDeVisitas(int visitas, int registrarVisitas)
        {
            Visitas = visitas;
            RegistrarVisitas = registrarVisitas;
        }

        public int ObterTotal;
        
        {



    }
}





//internal class ContaBancaria
//{
//    private string Titular;

//    private double Saldo;

//    public void Despositar(double valor)
//    {
//        if (valor < 0)
//        {
//            Console.WriteLine("Valor inválido!");
//        }
//        Saldo += valor;
//        Console.WriteLine($"Saldo atualizado para: {Saldo}");

//    }