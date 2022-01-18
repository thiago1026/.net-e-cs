namespace ExemploPOO.Models
{
    public  class Professor : Pessoa
    {
        public double Salario { get; set; }
        public  override void Apresentar()
        {
            Console.WriteLine($"olá meu nome é {Nome} e sou um professor e ganho {Salario}");
        }

    }
}