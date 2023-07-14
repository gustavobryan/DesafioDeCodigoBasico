 public class DesafioUm
    {
        static void Main(string[] args)
        {
            // Criação das variáveis
            int numero;
            int digito;
            int soma = 0;
            int produto = 1;
            int saida = 0;


            //Mostrar mensagem para o usuário.
            Console.Write("Informe um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Estrutura de repetição
            while (numero > 0)
            {
                digito = numero % 10; //último digito
                soma = soma + digito;
                numero = numero / 10;
                produto *= digito;
                saida = produto - soma;
            }
            
            Console.WriteLine($"Produto = {produto}");
            Console.WriteLine($"Soma = {soma}");
            Console.WriteLine($"Saida = {saida}");
            Console.ReadKey();
        }
    }
