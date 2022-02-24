namespace revisao
{
    public class Program
    {

        public static void Main(String[] args)
        {
            List<Aluno> Alunos = new List<Aluno>();
            Aluno Aluno = new Aluno();

            string opcaoUsuario = ObterOpcaoUsuario();

            while (!(opcaoUsuario.ToUpper().Equals("X")))
            {
                switch (opcaoUsuario)
                {
                    case "1":
                    Aluno AlunoNovo = new Aluno();

                    Console.WriteLine("Digite o nome do aluno:");
                    AlunoNovo.Nome = Console.ReadLine();

                    Console.WriteLine("Digite a nota do aluno:");
                    if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                       AlunoNovo.Notas = nota;
                    }
                    else
                    {
                        throw new ArgumentException("Valor deve ser decimal.\n");
                    }

                    Console.WriteLine();

                    Alunos.Add(AlunoNovo);

                    break;

                    case "2":
                    foreach(var elementos in Alunos)
                        Console.WriteLine("{0} | {1}", elementos.Nome, elementos.Notas);
                        Console.WriteLine();
                    break;

                    case "3":
                    Console.WriteLine("Média Geral: {0}", Aluno.CalcularMedia(Alunos).ToString("F"));
                    Console.WriteLine();
                    break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
 
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            String opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
  }