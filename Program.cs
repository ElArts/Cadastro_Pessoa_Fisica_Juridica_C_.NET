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
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodosPf = new PessoaFisica();
            Endereco novoEndPf = new Endereco();

            novaPf.Nome = "Fulano";
            novaPf.dataNasc = new DateTime(2000, 01, 01);
            novaPf.Cpf = "1234567890";
            novaPf.Rendimento = 3500.5f;

            novoEndPf.logradouro = "Andradas";
            novoEndPf.numero = 546;
            novoEndPf.complemento = "Esquina da Lanceiros";
            novoEndPf.endComercial = true;

            novaPf.Endereco = novoEndPf;

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
");

            Console.WriteLine($"Precione ENTER para continuar");
            Console.ReadLine();

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

            Console.Clear();
            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, N°: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");

            Console.WriteLine($"Precione ENTER para continuar");
            Console.ReadLine();
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


static void BarraCarregamento(string texto, int tempo, int quantidade){
    
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

