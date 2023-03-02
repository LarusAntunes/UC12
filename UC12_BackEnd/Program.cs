using UC12_BackEnd.Classes;

string? opcao;
// Console.ForegroundColor = ConsoleColor.Green;
// Console.BackgroundColor = ConsoleColor.DarkGreen;
// Console.Write($"Aguarde um momento");
// for (var contador = 0; contador < 7; contador++)
// {   //var contador =0 é onde começa a contagem
//     //contador < 6 é a condição a ser seguida
//     //contador++ acréscimo de +1
//     Console.BackgroundColor = ConsoleColor.DarkGreen;
//     Console.Write($"*");            //Método de repetição
//     Thread.Sleep(500);
// }
// Console.ResetColor();


Utils.BarraCarregamento("Inicializando");
Console.Clear();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@$"

                        =================SISTEMA DE CADASTRO=====================
                        |                                                       |
                        |         Bem vindo ao Sistema de Cadastro de           |
                        |             Pessoa Física e Jurídica                  |
                        |                                                       |
                        =========================================================

");
Thread.Sleep(5000);

// Console.Write($"Aguarde um momento");
// Thread.Sleep(1000); //Thread.Sleep usado para colocar tempo na impressão
// Console.Write($"*");
// Thread.Sleep(500);
// Console.Write($"*");
// Thread.Sleep(500);
// Console.Write($"*");
// Thread.Sleep(500);                  //Repetição feito na mão
// Console.Write($"*");
// Thread.Sleep(500);
// Console.Write($"*");
// Thread.Sleep(500);
// Console.Write($"*");
// Thread.Sleep(2000);



do
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"

                        =========================================================
                        |                                                       |
                        |                Escolha uma opção abaixo               |
                        |              e tecle Enter para continuar             |   
                        |                         ***                           |   
                        |                   1.Pessoa Física                     |
                        |                   2.Pessoa Jurídica                   | 
                        |                                                       |
                        |                   0.Sair                              |
                        |                                                       |
                        =========================================================
");

    opcao = Console.ReadLine();
    // Console.WriteLine($"Você digitou : {opcao}");

    switch (opcao)
    {
        case "1":

            PessoaFisica novaPf = new PessoaFisica();
            Endereco novoEndPF = new Endereco();

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
            float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
            // Console.WriteLine(impostoPagar);
            // Console.WriteLine($"{impostoPagar: 0.00}");
            Console.WriteLine(impostoPagar.ToString("C"));

            DateTime temp = new DateTime(2010, 03, 03);
            Console.WriteLine(novaPf.ValidarDataNasc("01/01/2001"));


            Thread.Sleep(5000);

            Console.WriteLine($"Pressione qualque tecla para continuar");
            Thread.Sleep(5000);
            break;

        case "2":

            PessoaJuridica novoPJ = new PessoaJuridica();
            Endereco novoEndPJ = new Endereco();

            novoPJ.nome = "Empresa Banana";
            novoPJ.cnpj = "76773415000560";
            novoPJ.rendimento = 22600.5f;

            novoEndPJ.logradouro = "Rua Luiz Gama";
            novoEndPJ.numero = 288;
            novoEndPJ.complemento = "Banana Empresa";
            novoEndPJ.endComercial = true;

            novoPJ.endereco = novoEndPJ;

            //interpolação
            Console.WriteLine(@$"
        Nome: {novoPJ.nome}
        Endereço: {novoEndPJ.logradouro}, Numero: {novoEndPJ.numero}
        CNPJ: {novoPJ.cnpj} - Válido {novoPJ.ValidarCnpj(novoPJ.cnpj)}
        ");

            PessoaJuridica novaPj = new PessoaJuridica();
            Console.WriteLine(@$"
        Impostos a pagar {novaPj.CalcularImposto(6600.5f)}");



            Console.WriteLine($"Pressione enter para voltar ao menu");
            Console.ReadLine();
            Console.WriteLine($"Aguarde, por favor");
            Thread.Sleep(2000);
            break;

        case "0":


            // Console.WriteLine($"Finalizando");
            Console.WriteLine($"Tenha um ótimo dia!");
            Thread.Sleep(2000);
            Utils.BarraCarregamento("Finalizando");
            Console.Clear();
            break;

        default:
            Console.WriteLine($"Digite uma opção válida");
            Thread.Sleep(2000);


            break;
    }


} while (opcao != "0");

Console.ResetColor();









// PessoaFisica novaPf= new PessoaFisica();
// Endereco novoEndPF = new Endereco ();

// PessoaJuridica novoPJ = new PessoaJuridica ();
// Endereco novoEndPJ = new Endereco();


// Console.WriteLine(novoPJ.ValidarCnpj("76773415000160"));

//DADOS DA PESSOA JURIDICA ===========================================================
// novoPJ.nome = "Empresa Banana";
// novoPJ.cnpj = "76773415000560";
// novoPJ.rendimento = 22600.5f;

// novoEndPJ.logradouro = "Rua Luiz Gama";
// novoEndPJ.numero = 288;
// novoEndPJ.complemento = "Banana Empresa";
// novoEndPJ.endComercial = true;

// novoPJ.endereco = novoEndPJ;

// Console.WriteLine(@$"
// Nome: {novoPJ.nome}
// Endereço: {novoEndPJ.logradouro}, Numero: {novoEndPJ.numero}
// CNPJ: {novoPJ.cnpj} - Válido {novoPJ.ValidarCnpj(novoPJ.cnpj)}
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



