namespace ExemploFudamentos.Common.Models
{
  public class Calculadora
  {
    public void Somar(int x, int y)
    {
      Console.WriteLine($"{x}+{y} = {x + y}");
    }

    public void Subtrair(int x, int y)
    {
      Console.WriteLine($"{x}-{y} = {x - y}");
    }

    public void Multiplicar(int x, int y)
    {
      Console.WriteLine($"{x} x {y} = {x * y}");
    }

    public void Dividir(int x, int y)
    {
      Console.WriteLine($"{x}/{y} = {x / y}");
    }

    public void Potencia(int x, int y)
    {
      double pot = Math.Pow(x, y);
      Console.WriteLine($"{x}^{y} = {pot}");
    }
    public void Seno(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double sen = Math.Sin(radiano);
      Console.WriteLine($"Seno {angulo}° = {Math.Round(sen, 4)}");
    }

    public void Cos(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double Cos = Math.Cos(radiano);
      Console.WriteLine($"Cos {angulo}° = {Math.Round(Cos, 4)}");

    }
    public void Tg(double angulo)
    {
      double radiano = angulo * Math.PI / 180;
      double tg = Math.Tan(radiano);
      Console.WriteLine($"Tan {angulo}° = {Math.Round(tg, 4)}");
    }
    public void Raiz(double x)
    {
      double raiz = Math.Sqrt(x);
      Console.WriteLine($"raiz {x} = {Math.Round(raiz, 4)}");
    }
  }

}