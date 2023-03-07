using UC12_BackEnd.Classes;

List<PessoaJuridica> listaPJ = new List<PessoaJuridica>();

string? opcao;
string? opcaoPF;
string? opcaoPJ;
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

            do
            {


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"

                        =========================================================
                        |                                                       |
                        |                Escolha uma opção abaixo               |
                        |           e pressione Enter para continuar            |
                        |                         ***                           |   
                        |               1.Cadastrar Pessoa Física               |
                        |                2.Listar Pessoa Física                 | 
                        |                                                       |
                        |                       0.Sair                          |
                        |                                                       |
                        =========================================================

");

                Thread.Sleep(3000);
                opcaoPF = Console.ReadLine();

                switch (opcaoPF)
                {
                    case "1":  //comandos para cadastrar Pessoa Física
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPF = new Endereco();
                        Console.Clear();
                        Console.WriteLine($"Digite nome completo:");
                        novaPf.nome = Console.ReadLine();


                        Console.WriteLine($"Cadastrar Pessoa Física");
                        Thread.Sleep(2000);
                        break;

                    case "2": //comandos para listar Pessoa Física
                        Console.WriteLine($"Listar Pessoa Física");

                        Thread.Sleep(2000);
                        break;
                    case "0": //Voltar
                        Console.WriteLine($"Voltar ao menu anterior");

                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine($"Digite uma opção válida");
                        Thread.Sleep(2000);

                        break;
                }
            } while (opcaoPF != "0");

            // novaPf.nome = "Joao";
            // novaPf.cpf = "010.010.010-01";
            // novaPf.rendimento = 6600.5f;
            // novaPf.dataNasc = new DateTime(2001, 01, 01);

            //novoEndPF.logradouro = "Rua Luiz Gama";
            //novoEndPF.numero = 288;
            //novoEndPF.complemento = "Sobrado";
            //novoEndPF.endComercial = false;

            //novaPf.endereco = novoEndPF;

            // Console.WriteLine(@$"

            // Nome: {novaPf.nome}
            // Endereço: {novoEndPF.logradouro}, Numero: {novoEndPF.numero}
            // Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
            // ");
            //         float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
            //         // Console.WriteLine(impostoPagar);
            //         // Console.WriteLine($"{impostoPagar: 0.00}");
            //         Console.WriteLine(impostoPagar.ToString("C"));

            //         DateTime temp = new DateTime(2010, 03, 03);
            //         Console.WriteLine(novaPf.ValidarDataNasc("01/01/2001"));

            // Thread.Sleep(3000);
            // Console.ForegroundColor = ConsoleColor.DarkBlue;
            // Console.WriteLine($"Pressione enter para voltar ao menu");
            // Console.ReadLine();
            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine($"Aguarde, por favor");
            // Thread.Sleep(2000);
            break;

        case "2":
            do
            {

                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"

                        =========================================================
                        |                                                       |
                        |                Escolha uma opção abaixo               |
                        |           e pressione Enter para continuar            |
                        |                         ***                           |   
                        |               1.Cadastrar Pessoa Jurídica             |
                        |               2.Listar Pessoa Jurídica                | 
                        |                                                       |
                        |                       0.Sair                          |
                        |                                                       |
                        =========================================================

");

                Thread.Sleep(3000);
                opcaoPJ = Console.ReadLine();

                switch (opcaoPJ)
                {
                    case "1":  //comandos para cadastrar Pessoa Física
                        PessoaJuridica novoPJ = new PessoaJuridica();
                        Endereco novoEndPJ = new Endereco();

                        Console.Clear();
                        Console.WriteLine($"Digite nome da Razão Social:");
                        novoPJ.nome = Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine($"Digite o CNPJ da empresa:");
                        novoPJ.cnpj = Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine($"Digite o rendimento da empresa:");
                        string? rendEntrada = Console.ReadLine();
                        float.TryParse(rendEntrada, out float rendConvertido);
                        novoPJ.rendimento = rendConvertido;
                        Console.Clear();

                        Console.WriteLine($"Digite o logradouro da empresa:");
                        novoEndPJ.logradouro = Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine($"Digite o número do imóvel:");
                        string? numeroEntrada = Console.ReadLine();
                        int.TryParse(numeroEntrada, out int numeroConvertido);
                        novoEndPJ.numero = numeroConvertido;

                        novoPJ.endereco = novoEndPJ;
                        listaPJ.Add(novoPJ);

                        Console.Clear();
                        Console.WriteLine($"Cadastro concluído com sucesso");
                        Thread.Sleep(500);
                        Console.WriteLine($"Pressione Enter para continuar");
                        Console.ReadLine();

                        break;

                    case "2": //comandos para listar Pessoa Física

                        Console.Clear();

                        if (listaPJ.Count > 0)
                        {
                            foreach (PessoaJuridica cadaPJ in listaPJ) //foreach usado para listas
                        {
                            Console.Clear();
                            Console.WriteLine(@$"
                        Nome: {cadaPJ.nome}
                        Endereço: {cadaPJ.endereco.logradouro}, Numero: {cadaPJ.endereco.numero}
                        CNPJ: {cadaPJ.cnpj} - Válido 
                        {cadaPJ.ValidarCnpj(cadaPJ.cnpj)}
                        ");

                            Console.WriteLine($"Pressione Enter para continuar");
                            Console.ReadLine();
                        }
                        } else
                        {
                            Console.WriteLine($"Lista vazia no momento");
                            Thread.Sleep(2000);
                        }

                        break;

                    case "0": //Voltar
                        Console.WriteLine($"Voltar ao menu anterior");

                        Thread.Sleep(500);
                        break;
                    default:
                        Console.WriteLine($"Digite uma opção válida");
                        Thread.Sleep(1000);

                        break;
                }
            } while (opcaoPJ != "0");

            //     

            //     
            //     novoPJ.cnpj = "76773415000560";
            //     novoPJ.rendimento = 22600.5f;
            //     novoEndPJ.logradouro = "Rua Luiz Gama";
            //     novoEndPJ.numero = 288;
            //     novoEndPJ.complemento = "Banana Empresa";
            //     novoEndPJ.endComercial = true;
            //     novoPJ.endereco = novoEndPJ;

            //     //interpolação
            // Console.WriteLine(@$"
            // Nome: {novoPJ.nome}
            // Endereço: {novoEndPJ.logradouro}, Numero: {novoEndPJ.numero}
            // CNPJ: {novoPJ.cnpj} - Válido {novoPJ.ValidarCnpj(novoPJ.cnpj)}
            // ");

            //     PessoaJuridica novaPj = new PessoaJuridica();
            //     Console.WriteLine(@$"
            // Impostos a pagar {novaPj.CalcularImposto(6600.5f)}");


            //     Thread.Sleep(3000);
            //     Console.ForegroundColor = ConsoleColor.DarkBlue;
            //     Console.WriteLine($"Pressione enter para voltar ao menu");
            //     Console.ReadLine();
            //     Console.ForegroundColor = ConsoleColor.Green;
            //     Console.WriteLine($"Aguarde, por favor");
            //     Thread.Sleep(2000);

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



