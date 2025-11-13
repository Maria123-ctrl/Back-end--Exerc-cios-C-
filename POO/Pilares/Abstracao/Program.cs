using Abstracao;

// Cachorro auau = new Cachorro();
// Gato miau = new Gato();

ContaCorrente c1 = new ContaCorrente();
c1.Depositar(3000);
c1.Sacar(2000);
c1.CalcularSaldo();
ContaPoupanca p1 = new ContaPoupanca();
p1.Depositar(3000);
p1.Sacar(2000);
p1.CalcularSaldo();
