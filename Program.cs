
      /*
      q1  int numeroInteiro = 10;
        float numeroFlutuante = 20.5f;
        string texto = "Olá, mundo!";
        bool valorBooleano = true;

        Console.WriteLine("Valor do inteiro: " + numeroInteiro);
        Console.WriteLine("Valor do float: " + numeroFlutuante);
        Console.WriteLine("Valor da string: " + texto);
        Console.WriteLine("Valor do bool: " + valorBooleano);  
q2
        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = int.Parse(Console.ReadLine());

        
        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = int.Parse(Console.ReadLine());

      
        int soma = numero1 + numero2;
        int subtracao = numero1 - numero2;
        int multiplicacao = numero1 * numero2;
        float divisao = (float)numero1 / numero2; 

        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Subtração: " + subtracao);
        Console.WriteLine("Multiplicação: " + multiplicacao);

        Console.WriteLine("Divisão: " + divisao); */

        Console.Write("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Olá, {nome}, você tem {idade} anos.");
