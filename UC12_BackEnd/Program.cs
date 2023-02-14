using UC12_BackEnd.Classes;

PessoaFisica novaPf= new PessoaFisica();
Endereco novoEndPF = new Endereco ();

novaPf.nome = "Joao";
novaPf.cpf = "010.010.010-01";
novaPf.rendimento = 6600.5f;
novaPf.dataNasc = new DateTime(2001, 01, 01);

novoEndPF.logradouro = "Rua Luiz Gama";
novoEndPF.numero = 288;
novoEndPF.complemento = "Sobrado";
novoEndPF.endComercial = false;

novaPf.endereco = novoEndPF;

Console.WriteLine(@$"

Nome: {novaPf.nome}
Endereço: {novoEndPF.logradouro}, Numero: {novoEndPF.numero}
Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");


// Console.WriteLine($"Olá {novaPf.nome} de CPF: {novaPf.cpf}");

float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
// Console.WriteLine(impostoPagar);
// Console.WriteLine($"{impostoPagar: 0.00}");
Console.WriteLine(impostoPagar.ToString("C"));

DateTime temp = new DateTime(2010, 03, 03); 
Console.WriteLine (novaPf.ValidarDataNasc("01/01/2001"));




//============================================================

// PessoaJuridica novaPj= new PessoaJuridica();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));

// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);



