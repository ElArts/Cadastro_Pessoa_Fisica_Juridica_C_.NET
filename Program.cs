using Fundamentos.Classes;

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

Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
Maior de idade: {metodosPf.ValidarDataNasc(novaPf.dataNasc)}
");


//Console.WriteLine($"Nome: {novaPf.Nome} Nome: {novaPf.Nome}");  <-- Interpolação
//Console.WriteLine("Nome: " + novaPf.Nome + "Nome: " + novaPf.Nome); <-- Concatenação

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

Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.RazaoSocial}
CNPJ: {novaPj.Cnpj}, Válido: {metodosPj.ValidarCnpj(novaPj.Cnpj)}
Endereço: {novaPj.Endereco.logradouro}, N°: {novaPj.Endereco.numero}
Complemento: {novaPj.Endereco.complemento}
");

