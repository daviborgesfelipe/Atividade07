namespace Atividade07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] valoresInteiros = { -5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6};


            //maior valor
            int maiorValor = valoresInteiros.Max();
            Console.WriteLine("Maior valor do array: " + maiorValor);


            //menor valor
            int menorValor = valoresInteiros.Min();
            Console.WriteLine("Menor valor do array: " + menorValor);


            //valor medio
            int valorMedio = Convert.ToInt32(valoresInteiros.Average());
            Console.WriteLine("Valor medio do array: " + valorMedio);


            //arruma a sequencia
            int[] ArrumarSequencia(int[] valoresEmSequencia)
            {
                Array.Reverse(valoresEmSequencia);
                Array.Sort(valoresEmSequencia);
                return valoresEmSequencia;
            }
            int[] valoresEmSequencia = ArrumarSequencia(valoresInteiros);
            Console.Write($"Valores em sequencia: ");
            for (int i = 0; i < valoresEmSequencia.Length; i++)
            {
                Console.Write(valoresEmSequencia[i]);
                if (i < valoresEmSequencia.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();


            //gera tres maiores numeros
            int[] tresMaioresNumeros = new int[3];
            Array.Reverse(valoresEmSequencia);
            Array.Copy(valoresEmSequencia, tresMaioresNumeros, 3);
            Console.Write("Tres maiores valores: ");
            for (int i = 0; i < tresMaioresNumeros.Length; i++)
            {
                Console.Write(tresMaioresNumeros[i]);
                if (i < tresMaioresNumeros.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();


            //gera valores negativos
            int[] numerosNegativos = Array.FindAll(valoresEmSequencia, numero => numero < 0);
            Console.Write("Valores negativos do array: ");
            for (int i = 0; i < numerosNegativos.Length; i++)
            {
                Console.Write(numerosNegativos[i]);
                if (i < numerosNegativos.Length - 1)
                {
                    Console.Write(", ");
                }
            }
             Console.WriteLine();


            //Exclui
            int valorASerExcluido = 8;
            int indiceExcluido = Array.IndexOf(valoresEmSequencia, valorASerExcluido);
            int[] ExcluirValorDoArray(int[] valoresEmSequencia, int indiceExcluido)
            {
                int[] arrayAtualizado = new int[valoresInteiros.Length - 1];
                Array.Copy(valoresEmSequencia, 0, arrayAtualizado, 0, indiceExcluido);
                Array.Copy(valoresEmSequencia, indiceExcluido + 1, arrayAtualizado, indiceExcluido, valoresEmSequencia.Length - indiceExcluido - 1);
                return arrayAtualizado;
            }
            valoresEmSequencia = ExcluirValorDoArray(valoresEmSequencia, indiceExcluido);
            Console.Write("Aray sem o valor excluido: ");
            Array.Reverse(valoresEmSequencia);
            for (int i = 0; i < valoresEmSequencia.Length; i++)
            {
                Console.Write(valoresEmSequencia[i]);
                if (i < valoresEmSequencia.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.ReadLine();
        }
    }
}