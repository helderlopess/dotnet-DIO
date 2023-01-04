






//+++++++++++++++++++++++++++++++++++++
//MENU
// string opcao;

// while (true)
// {
//   Console.WriteLine("Digite a sua opção: ");
//   Console.WriteLine("1- Cadastrar cliente");
//   Console.WriteLine("2- Busca cliente");
//   Console.WriteLine("3- Apagar cliente");
//   Console.WriteLine("4- Encerrar");

//   opcao = Console.ReadLine();

//   switch (opcao)
//   {
//     case "1":
//       Console.WriteLine("Cadastro de cliente");
//       break;
//     case "2":
//       Console.WriteLine("Busca de cliente");
//       break;
//     case "3":
//       Console.WriteLine("Apagar cliente");
//       break;
//     case "4":
//       Console.WriteLine("Encerrar");
//       Environment.Exit(0);
//       break;

//     default:
//       Console.WriteLine("Opcao invalida");
//       break;
//   }
// }

// Console.WriteLine("O progama se encerrou");




//+++++++++++++++++++++++++++++++++++++
// int soma = 0, numero = 0;

// do
// {
//   Console.WriteLine("Digite um numero, 0 (zero) para PARAR");
//   numero = Convert.ToInt32(Console.ReadLine());

//   soma += numero;
// } while (numero != 0);
// Console.WriteLine($"O total da soma dos numeros é: {soma}");


//+++++++++++++++++++++++++++++++++++++
// while para condicionar uma execucao

// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//   Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
//   contador++;
//    if (contador == 6)  //interrompendo o while com condicionante ou for
//   {
//     break;
//   }
// }

//+++++++++++++++++++++++++++++++++++++
// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//   Console.WriteLine ($"{numero} x {contador} = {numero * contador}");
// }


//+++++++++++++++++++++++++++++++++++++
//iterando decrementos e incrementos
// int numero = 10;
// Console.WriteLine(numero);
// Console.WriteLine("Incrementando o 10");
// numero = numero +1;

// Console.WriteLine(numero);

// Console.WriteLine("Segunda forma de iterar");
// numero--;
// numero++;
// Console.WriteLine($"Agora usando o ++ {numero}");



//+++++++++++++++++++++++++++++++++++++
//  Calculadora calc = new Calculadora();
//  calc.Somar(2, 2);
//  calc.Subtrair(10, 50);
//  calc.Multiplicar(14, 45);
//  calc.Dividir(2, 2);
//  calc.Potencia(3, 3);
//  calc.Seno(30);
//  calc.Cos(25);
//  calc.Tg(89);
//  calc.Raiz(81);


//operadores
// = atrubuicao
// += soma com a variavel
// -= subtrai da variavel
//+++++++++++++++++++++++++++++++++++++
//calculadora







//+++++++++++++++++++++++++++++++++++++
//CASE switch

// Console.WriteLine("Digite uma letra")
// string letra = Console.ReadLine();

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine("Vogal");
//     break;

//     default:
//     Console.WriteLine("Não é uma vogal");
//     break;
// }

//+++++++++++++++++++++++++++++++++++++
//operadores condicionais

// int quantidadeEmEstoque =30;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra:{quantidadeCompra}");
// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");


// if (quantidadeCompra == 0)
// {
//   Console.WriteLine("Venda invalida");
// }
// else if (possivelVenda)
// {
//   Console.WriteLine("Venda realizada");
// } 
// else
// {
//   Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque");
// }

//+++++++++++++++++++++++++++++++++++++
//CONVERTENDO COM SEGURANÇA
// string a ="15";
// int b=0;

// //caso a conversao de errado sera exibido o valor de b;
// int.TryParse(a, out b);


// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso");

//+++++++++++++++++++++++++++++++++++++
//cast implicito
//
// int a = 5;
// double b = a;

//nao é necessario conversao de int para double porque ele cabo no double e mais, evitando redundancia.

// Console.WriteLine(b);


//+++++++++++++++++++++++++++++++++++++
// //conversdao para strimg 
// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);

//+++++++++++++++++++++++++++++++++++++
//CAST - CASTING
//MAIS RECOMENDADO O CONVERT SEGUNDO O BUTA PARA EVITAR DE PARAR O PROGRAMA
// int a = Convert.ToInt32(null); //mostra um 0 caso seja o valor seja nulo
// int a = int.Parse(null);

// Console.WriteLine(a);
// //+++++++++++++++++++++++++++++++++++++

//é necessario adicionar o name space para que o mesmo seja reconhecido o caminho

//tipo  nome  atributo da cariavel
// string apresentacao = "Olá, Seja Bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.88M;
// bool condicao = true;


// Console.WriteLine("Valor da variavel " + apresentacao);
// Console.WriteLine("Valor da variavel quantidade " + quantidade);
// Console.WriteLine("Valor da variavel altura " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel preco " + preco);
// Console.WriteLine("Valor da variavel condicao " + condicao);

// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

// //para apresentar a data no formato especifico use o metodo ToString()

// Console.WriteLine(dataAtual.ToString("dd/MM/yyy HH:mm"));
// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Helder";
// pessoa1.Idade = 36;
// pessoa1.Apresentar();
//+++++++++++++++++++++++++++++++++++++