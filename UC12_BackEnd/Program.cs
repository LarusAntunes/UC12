using UC12_BackEnd.Classes;

PessoaFisica novaPf= new PessoaFisica();
novaPf.nome = "Joao";
novaPf.cpf = "010.010.010-01";

// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);

Console.WriteLine($"Olá {novaPf.nome} de CPF: {novaPf.cpf}");
