using System.ComponentModel;
using System.Globalization;
using TheBasics;


// // string[] nomes = new string[5];
// // int[] idades = new int[5];
// // string[] logradouros = new string[5];
// // List<Pessoa> peoples = new List<Pessoa>();


// // Endereco enderecoEdu = new Endereco();
// // enderecoEdu.Logradouro = "Rua Niterói";
// // Pessoa edu = new Pessoa(enderecoEdu);
// // edu.Nome = "Eduardo Costa";
// // edu.Idade = 43;

// // // Endereço
// // Endereco endGilsa = new Endereco();
// // endGilsa.Logradouro = "Rua Niterói";
// // // Pessoa com Endereço
// // Pessoa gilsa = new Pessoa(endGilsa);
// // gilsa.Nome = "Eduardo Costa";
// // gilsa.Idade = 44;

// // Endereco endMurilo = new Endereco();
// // endMurilo.Logradouro = "Rua Niterói";
// // Pessoa murilo = new Pessoa(enderecoEdu);
// // murilo.Nome = "Murilo Silva";
// // murilo.Idade = 43;

// // Endereco endStephani = new Endereco();
// // endStephani.Logradouro = "Rua Niterói";
// // Pessoa stephani = new Pessoa(enderecoEdu);
// // stephani.Nome = "stephani Silva";
// // stephani.Idade = 43;


// // peoples.Add(edu);//0
// // peoples.Add(gilsa);//1
// // peoples.Add(murilo);//2
// // peoples.Add(stephani);//3



// // // Pessoa edu = new Pessoa();
// // // Pessoa gilsa = new Pessoa();
// // // Pessoa stephani = new Pessoa();
// // // Pessoa stephani = new Pessoa();

// // edu.Nome = "Eduarda Costa";
// // edu.Idade = 43;
// // enderecoEdu.Logradouro = "Rua Niterói";
// // enderecoEdu.Numero = 180;

// // // enderecoEdu.Falar();
// // gilsa.Nome = "Gilsa Freitas";
// // gilsa.Idade = 44;
// // endGilsa.Logradouro = "Rio dos Meninos";
// // endGilsa.Numero = 2372;
// // endGilsa.Complemento = "Apt 95 - Bloco 2";

// // murilo.Nome = "Murilo Silva";
// // murilo.Idade = 16;
// // endMurilo.Logradouro = "Rua riga";
// // endMurilo.Numero = 399;
// // endMurilo.Complemento = "Casa 1";

// // stephani.Nome = "Stephani";
// // stephani.Idade = 16;
// // endStephani.Logradouro = "Rua camargo";
// // endStephani.Numero = 790;
// // endStephani.Complemento = "Apt 76 - Bloco B";

// // // guardando os dados na lista

// // foreach ( Pessoa p in peoples)
// // {
// //     System.Console.WriteLine($"Nome: {p.Nome}");
// // }

// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spínola Teixeira";
// endEnzo.Numero = 3960;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Enzinho";
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lá de casa";
// endProfAlex.Numero = 987;

// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Aléxia Vitória";

// System.Console.WriteLine($"Aluno {pedroEnzo} estuda na turma {pedroEnzo.Curso} da profa. {profAlexia.Nome}");


Carro fusca = new Carro();
fusca.Marca = "Bajaj";
fusca.Modelo = "Fusca";
fusca.AbrirPortaMala();

Moto mitsubishi = new Moto();
mitsubishi.Marca = "Wolksvagem";
mitsubishi.Modelo = "Fusca";
mitsubishi.Empinar();

fusca.Ligar();
fusca.AbrirPortaMala();

mitsubishi.Ligar();
mitsubishi.Empinar();

