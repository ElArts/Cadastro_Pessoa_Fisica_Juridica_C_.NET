using Fundamentos.Classes;



Console.WriteLine(@$"
============================================
|   Bem-vindo ao sistema de cadastro de    |
|      Pessoas Físicas e Juridicas         |
============================================
");

// Console.BackgroundColor = ConsoleColor.Red;
// Console.ForegroundColor = ConsoleColor.White;


BarraCarregamento("Iniciando", 1000, 3);

// Console.ResetColor();

List<PessoaFisica> listaPf = new List<PessoaFisica>();

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
============================================
|        Escolha uma das opções:           |
|       1 - Pessoa Física                  |
|       2 - Pessoa Jurídica                |
|                                          |
|       0 - Sair                           |
============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
============================================
|        Escolha uma das opções:           |
|       1 -  Cadastrar Pessoa Física       |
|       2 - Listar Pessoas Física          |
|                                          |
|       0 - Retornar ao Menu Anterior      |
============================================
");

                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {

                    case "1":
                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física para cadastro");
                        novaPf.Nome = Console.ReadLine();

                        // bool dataValida;
                        // do
                        // {
                        //     Console.WriteLine($"Digite a data de nascimento (dd/mm/aaaa)");
                        //     string? dataNascimento = Console.ReadLine();

                        //     dataValida = metodosPf.ValidarDataNasc(dataNascimento);

                        //     if (dataValida)
                        //     {

                        //         DateTime DataConvertida;
                        //         DateTime.TryParse(dataNascimento, out DataConvertida);

                        //         novaPf.dataNasc = DataConvertida;

                        //     }
                        //     else
                        //     {
                        //         Console.WriteLine($"Você deve ter no mínimo 18 anos para ser cadastrado(a) como pessoa física");
                        //         Thread.Sleep(4000);

                        //     }


                        // } while (dataValida == false);

                        // Console.WriteLine($"Digite o número do seu CPF");
                        // novaPf.Cpf = Console.ReadLine();


                        // Console.WriteLine($"Digite seu rendimento mensal");
                        // novaPf.Rendimento = float.Parse(Console.ReadLine());

                        // Console.WriteLine($"Digite o endereço");
                        // novoEndPf.logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o número");
                        // novoEndPf.numero = int.Parse(Console.ReadLine());

                        // Console.WriteLine($"Ponto de referência (caso tenha algum)");
                        // novoEndPf.complemento = Console.ReadLine();


                        // Console.WriteLine($"O endereço inserido é comercial? S/N");
                        // string endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEndPf.endComercial = true;

                        // }
                        // else
                        // {
                        //     novoEndPf.endComercial = false;
                        // }

                        // novaPf.Endereco = novoEndPf;

                        // listaPf.Add(novaPf);


                        // StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt");
                        // sw.WriteLine(novaPf.Nome);
                        // sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            sw.WriteLine(novaPf.Nome);
                        }





                        Console.WriteLine($"Cadastro realizado com sucesso");
                        Thread.Sleep(4000);

                        break;

                    case "2":

                        Console.Clear();
                        //                         if (listaPf.Count > 0)
                        //                         {
                        //                             foreach (PessoaFisica cadaPessoa in listaPf)
                        //                             {
                        //                                 Console.Clear();
                        //                                 Console.WriteLine(@$"
                        // Nome: {cadaPessoa.Nome}
                        // Endereço: {cadaPessoa.Endereco.logradouro}, {cadaPessoa.Endereco.numero};
                        // Imposto a ser pago: {metodosPf.PagarImposto(cadaPessoa.Rendimento).ToString("C")}");

                        //                                 Console.WriteLine("Aperte ENTER para continuar");
                        //                                 Console.ReadLine();
                        //                             }
                        //                         }
                        //                         else
                        //                         {
                        //                             Console.WriteLine($"Lista vazia");
                        //                             Thread.Sleep(4000);

                        //                         }

                        using (StreamReader sr = new StreamReader("Arts.txt"))
                        {
                            string linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");
                            }
                        }

                        Console.WriteLine("Aperte ENTER para continuar");
                                                       Console.ReadLine();





                        break;

                    case "0":

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção Invalida!");
                        Thread.Sleep(3000);
                        break;

                }


            } while (opcaoPf != "0");


            // condicao ? "Sim" : "Não"


            break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Fulano Juridico";
            novaPj.RazaoSocial = "";
            novaPj.Cnpj = "00.000.000/0001-00";
            novaPj.Rendimento = 10000.5f;

            novoEndPj.logradouro = "Andradas";
            novoEndPj.numero = 789;
            novoEndPj.complemento = "do lado da Americanas";
            novoEndPj.endComercial = true;

            novaPj.Endereco = novoEndPj;


            metodosPj.Inserir(novaPj);






        List<PessoaJuridica> ListaPj = metodosPj.LerArquivo();

        foreach(PessoaJuridica cadaItem in ListaPj){
            Console.Clear();
            Console.WriteLine(@$"
Nome: {cadaItem.Nome}
Razão Social: {cadaItem.RazaoSocial}
CNPJ: {cadaItem.Cnpj}
");

            Console.WriteLine($"Precione ENTER para continuar");
            Console.ReadLine();
        }

//             Console.Clear();
//             Console.WriteLine(@$"
// Nome: {novaPj.Nome}
// Razão Social: {novaPj.RazaoSocial}
// CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
// Endereço: {novaPj.Endereco.logradouro}, N°: {novaPj.Endereco.numero}
// Complemento: {novaPj.Endereco.complemento}
// ");

//             Console.WriteLine($"Precione ENTER para continuar");
//             Console.ReadLine();
            break;

        case "0":
            Console.Clear();
            Console.WriteLine($"Informações salvas com sucesso!");
            Thread.Sleep(3000);
            BarraCarregamento("Finalizando", 1000, 3);
            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção Invalida!");
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");


static void BarraCarregamento(string texto, int tempo, int quantidade)
{

    Console.Write(texto);
    for (var contador = 0; contador < quantidade; contador++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);

    }

}













// PessoaFisica novaPf = new PessoaFisica();
// PessoaFisica metodosPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.Nome = "Fulano";
// novaPf.dataNasc = new DateTime(2000, 01, 01);
// novaPf.Cpf = "1234567890";
// novaPf.Rendimento = 3500.5f;

// novoEndPf.logradouro = "Andradas";
// novoEndPf.numero = 546;
// novoEndPf.complemento = "Esquina da Lanceiros";
// novoEndPf.endComercial = true;

// novaPf.Endereco = novoEndPf;

// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
// Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
// ");


// Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");  <-- Interpolação
// Console.WriteLine("Nome: " + novaPf.Nome + "Nome: " + novaPf.Nome); <-- Concatenação

// PessoaJuridica novaPj = new PessoaJuridica();
// PessoaJuridica metodosPj = new PessoaJuridica();
// Endereco novoEndPj = new Endereco();

// novaPj.Nome = "Fulano Juridico";
// novaPj.RazaoSocial = "";
// novaPj.Cnpj = "00.000.000/0001-00";
// novaPj.Rendimento = 10000.5f;

// novoEndPj.logradouro = "Andradas";
// novoEndPj.numero = 789;
// novoEndPj.complemento = "do lado da Americanas";
// novoEndPj.endComercial = true;

// novaPj.Endereco = novoEndPj;

// Console.WriteLine(@$"
// Nome: {novaPj.Nome}
// Razão Social: {novaPj.RazaoSocial}
// CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
// Endereço: {novaPj.Endereco.logradouro}, N°: {novaPj.Endereco.numero}
// Complemento: {novaPj.Endereco.complemento}
// ");

