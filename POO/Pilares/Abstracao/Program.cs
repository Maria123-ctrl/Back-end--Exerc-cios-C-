using Abstracao;

// Cachorro auau = new Cachorro();
// Gato miau = new Gato();

ContaCorrente cc = new ContaCorrente();
cc.Depositar(3000);

// cc.CalcularSaldo();
ContaPoupanca cp = new ContaPoupanca();
cp.Depositar(3000);

// cp.CalcularSaldo();

cc.Sacar(2000);
cp.Sacar(2000);


Console.WriteLine($"Saldo Conta Corrente antes do Saque: {cc.Saldo}");
Console.WriteLine($"Saldo Conta Poupança antes do saque: R${cp.Saldo}");
cc.Sacar(1150);
cp.Sacar(550);

Console.WriteLine($"Saldo Conta Corrente após do Saque: {cc.Saldo}");
Console.WriteLine($"Saldo Poupança pós do saque: R${cp.Saldo}");


// Console.WriteLine($"Saldo Conta Corrente: {cc.Saldo}");
// Console.WriteLine($"Saldo Poupança: {cp.Saldo}");




