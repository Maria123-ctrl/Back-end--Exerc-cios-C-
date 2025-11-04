using ExerciciosMetodoConstrutor;

// //carro
// Carro c1 = new Carro("Urus","Lamborghini",2010);
// c1.ExibirDados("Urus","Lamborghini",2010);


// //aluno
// Aluno a1 = new Aluno();
// Aluno a2 = new Aluno("Maria Freitas", 8);

// System.Console.WriteLine($"Aluno 1: Nome: {a1.Nome} Nota: {a1.Nota}");

// System.Console.WriteLine();

// System.Console.WriteLine($"Aluno 2: Nome: {a2.Nome} Nota: {a2.Nota}");


// //prouto
// Produto p1 = new Produto("Leite", 4, 5);
// p1.ExibirDados("Leite", 4, 5);

MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.Nome = "Maria Eduarda";
a1.Media();

MediaAluno a2 = new MediaAluno();
a2.Nome = "Duda";
a2.Media();


