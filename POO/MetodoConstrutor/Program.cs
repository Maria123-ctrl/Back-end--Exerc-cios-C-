using MetodoConstrutor;

Pessoa maria = new Pessoa("Maria", 17);

//maria.Nome = "Maria Eduarda";
//maria.Idade = 19;


//System.Console.WriteLine($"O objeto pessoa que criei é o {maria.Nome} com a idade {maria.Idade}");

//maria.Nome = "Gustavo Oliveira";
//maria.ExibirDados();

//System.Console.WriteLine($"{maria.Nome}");
//primeiro metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas PrimeiraPessoa = new Pessoa3Sobrecargas();

System.Console.WriteLine($"Primeira pessoa cadastrada Nome: {PrimeiraPessoa.Nome}|| Idade: {PrimeiraPessoa.Idade}");
//Segundo metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas SegundaPessoa = new Pessoa3Sobrecargas("Matheus Felix");

System.Console.WriteLine($"Segunda pessoa cadastrada Nome: {SegundaPessoa.Nome}|| Idade: {SegundaPessoa.Idade}");
//Terceiro metodo construtor da class Pessoa3Sobrecargas
Pessoa3Sobrecargas TerceiraPessoa = new Pessoa3Sobrecargas();

//System.Console.WriteLine($"Terceira pessoa cadastrada Nome: {TerceiraPessoa.Nome} || Idade: {TerceiraPessoa.Idade}");

System.Console.WriteLine("Terceira pessoa, digite seu nome: ");
TerceiraPessoa.Nome = Console.ReadLine();
System.Console.WriteLine("Terceira pessoa, digite sua idade: ");
TerceiraPessoa.Idade = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Terceira pessoa cadastrada Nome: {TerceiraPessoa.Nome} || Idade: {TerceiraPessoa.Idade}");
