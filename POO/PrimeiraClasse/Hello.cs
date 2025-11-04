

namespace PrimeiraClasse
{
    public class Hello
    {
        // Propriedadess/Características - variáveis internas dessa classe
    public string TextoHello = "";

        public void SaldarUsuario()
        {
            //this acessa os metodos dessa classe
            Console.WriteLine(this.TextoHello);
        }
        public void SaldarComNome(string n)
        {
            Console.WriteLine($"Olá {n}");
        }
    }
}