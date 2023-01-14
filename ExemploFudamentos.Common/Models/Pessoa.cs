namespace dotnet_DIO.Common.Models
{
  public class Pessoa
  {
    public string? Nome { get; set; } //propriedades
    public int Idade { get; set; }

    public void Apresentar()
    {
      Console.WriteLine($"Ola, meu nome é {Nome}, e tenho {Idade} anos!"); //metodo /funcao da pessoa
      // quebra de linha /n ou usando dias strings concatenadas com +
    }
  }
}