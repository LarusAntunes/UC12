using UC12_BackEnd.Classes;

PessoaFisica novaPf= new PessoaFisica();
Endereco novoEndPF = new Endereco ();

PessoaJuridica novoPJ = new PessoaJuridica ();
Endereco novoEndPJ = new Endereco();


// Console.WriteLine(novoPJ.ValidarCnpj("76773415000160"));

//DADOS DA PESSOA JURIDICA ===========================================================
novoPJ.nome = "Empresa Banana";
novoPJ.cnpj = "76773415000560";
novoPJ.rendimento = 22600.5f;

novoEndPJ.logradouro = "Rua Luiz Gama";
novoEndPJ.numero = 288;
novoEndPJ.complemento = "Banana Empresa";
novoEndPJ.endComercial = true;

novoPJ.endereco = novoEndPJ;

Console.WriteLine(@$"
Nome: {novoPJ.nome}
Endereço: {novoEndPJ.logradouro}, Numero: {novoEndPJ.numero}
CNPJ: {novoPJ.cnpj} - Válido {novoPJ.ValidarCnpj(novoPJ.cnpj)}
");
//=================================================================================

// Console.WriteLine($"Olá {novaPf.nome} de CPF: {novaPf.cpf}");

//================================================================================
// float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
// // Console.WriteLine(impostoPagar);
// // Console.WriteLine($"{impostoPagar: 0.00}");
// Console.WriteLine(impostoPagar.ToString("C"));

// DateTime temp = new DateTime(2010, 03, 03); 
// Console.WriteLine (novaPf.ValidarDataNasc("01/01/2001"));




//DADOS DA PESSOA FISICA ===========================================================
// novaPf.nome = "Joao";
// novaPf.cpf = "010.010.010-01";
// novaPf.rendimento = 6600.5f;
// novaPf.dataNasc = new DateTime(2001, 01, 01);

// novoEndPF.logradouro = "Rua Luiz Gama";
// novoEndPF.numero = 288;
// novoEndPF.complemento = "Sobrado";
// novoEndPF.endComercial = false;

// novaPf.endereco = novoEndPF;

// Console.WriteLine(@$"

// Nome: {novaPf.nome}
// Endereço: {novoEndPF.logradouro}, Numero: {novoEndPF.numero}
// Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
// ");
//=================================================================================

// Console.WriteLine($"Olá {novaPf.nome} de CPF: {novaPf.cpf}");

//================================================================================
// float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
// // Console.WriteLine(impostoPagar);
// // Console.WriteLine($"{impostoPagar: 0.00}");
// Console.WriteLine(impostoPagar.ToString("C"));

// DateTime temp = new DateTime(2010, 03, 03); 
// Console.WriteLine (novaPf.ValidarDataNasc("01/01/2001"));
//=================================================================================



//============================================================

// PessoaJuridica novaPj= new PessoaJuridica();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));

// Console.WriteLine(novaPf.nome);
// Console.WriteLine(novaPf.cpf);



