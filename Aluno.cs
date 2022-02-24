namespace revisao
{
    public class Aluno
    {
        public String Nome {get; set;}
        public decimal Notas {get; set;}

        public decimal CalcularMedia (List<Aluno> alunos) {
          decimal soma = 0;

          foreach(var elementos in alunos)
          {
           soma += elementos.Notas; 
          } 
          return soma / alunos.Count();
        }

    }
}