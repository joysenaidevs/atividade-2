using System;

namespace atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIO 2

            // Entrada
	        // Quantidade de Litros
	        // Tipo de combustivel

            // Processamento

 	        // Analisar o tipo de combustivel
	        // CASO FOR ALCOOL
	        // desconto = se a quantidade de litros for maior que 20 litros desconto de 5% caso contrario dar desconto de 3%
	        // pagamento = (quantidade de litro * R$ 4,99) - (quantidade de litros * R$ 4,9) * desconto);

	        // CASO FOR GASOLINA	
	        // desconto = se a quantidade litros for maior que 20 litros desconto de 6 % caso contrario dar desconto dde 4%
	        // pagamento = (quantidadde de litros * R$ 5,33) * desconto;
	

            // Saida
	        // Exibir valor a ser pago

            Console.WriteLine("Exercicio 2 ");
            Console.WriteLine("Selecione o tipo de combustivel");
            Console.WriteLine("A - Alcool");
            Console.WriteLine("G - Gasolina");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de combustivel");
            float quantidadeCombustivel = float.Parse(Console.ReadLine());

            float percDesconto, desconto, valorTotal;
            float precoAlcool = 4.9f;
            float precoGasolina = 5.3f;
            
            switch (combustivel.ToLower())
            {
                case "a":
                    if(quantidadeCombustivel>20){
                        percDesconto = 0.5f;
                    }else{
                        percDesconto = 0.3f;
                    }
                    valorTotal = (quantidadeCombustivel * precoAlcool);
                    desconto = (quantidadeCombustivel * precoAlcool)* percDesconto;
                    Console.WriteLine($"valor a ser pago {valorTotal-desconto}");
                    
                    break;
              

                case "g":
                    if(quantidadeCombustivel>20){
                        percDesconto = 0.6f;
                    }else{
                        percDesconto = 0.4f;
                    }
                    valorTotal = (quantidadeCombustivel * precoGasolina);
                    desconto = (quantidadeCombustivel * precoGasolina) * percDesconto;
                    Console.WriteLine($"valor a ser pago {valorTotal-desconto}");
                    
                    break;
                    default:
                    Console.WriteLine("Valor invalido");
                    break;
        }   }
    }
}
