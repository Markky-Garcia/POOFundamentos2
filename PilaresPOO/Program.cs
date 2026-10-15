
using PilaresPOO;
using System.Collections.Concurrent;
/*
Carro carro1 = new Carro("Fiat","Argo");
Carro carro2 = new Carro("Fiat","147");
Carro carro3 = new Carro("Fiat","Punto");
Carro carro4 = new Carro("Fiat","Palio");
Carro carro5 = new Carro("Fiat","MOB");

Console.WriteLine(carro1.Marca);
Console.WriteLine();
Console.WriteLine(carro1.Modelo);
//Console.WriteLine(carro2.Marca);
Console.WriteLine(carro2.Modelo);
//Console.WriteLine(carro3.Marca);
Console.WriteLine(carro3.Modelo);
//Console.WriteLine(carro4.Marca);
Console.WriteLine(carro4.Modelo);
//Console.WriteLine(carro5.Marca);
Console.WriteLine(carro5.Modelo);
*/


// Metodo Construtor - Obriga o objeto a ser criado de uma forma
// Pilares da POO

// Evitar estados inválidos

//ContaBancaria conta1 = new ContaBancaria();

//conta1.Saldo = -500;

//Console.WriteLine(conta1.Saldo);


// Livro livro1 = new Livro("Sem Nome", "Jane Doe", 385);
//Console.WriteLine(livro1.Titulo);
//Console.WriteLine(livro1.Autor);
//Console.WriteLine(livro1.Paginas);


Viagem viagem1 = new Viagem("França", 7, 2525.54);
Console.WriteLine($"Seu Destino: {viagem1.Destino}");
Console.WriteLine($"Dias de Férias: {viagem1.DIas}");
Console.WriteLine($"Valor da diaria:R$ {viagem1.ValorDiaria}");
Console.WriteLine($"Valor da Viagem R$ {viagem1.ValorDiaria * viagem1.DIas} ");
Console.WriteLine($"Pagamento a vista, desconto de 13%: R$ {(viagem1.ValorDiaria * viagem1.DIas) * 0.87:F2} ");