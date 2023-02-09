using UC12_BackEnd.Classes;

PessoaFisica novaPf= new PessoaFisica();
novaPf.nome = "Joao";
novaPf.cpf = "010.010.010-01";
novaPf.rendimento = 6600.5f;

Console.WriteLine($"Olá {novaPf.nome} de CPF: {novaPf.cpf}");

float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine(impostoPagar);
Console.WriteLine($"{impostoPagar: 0.00}");
Console.WriteLine(impostoPagar.ToString("C"));




//============================================================

PessoaJuridica novaPj= new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(6600.5f));








// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);



