public class Livro : ItemBiblioteca
{   
    public string Autor;

    
      public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
      this.Titulo = titulo;
      this.Autor = autor;
    }
    
      public void ExibirDescricaoInterna()
    {
      Console.WriteLine($"Livros de {DescricaoInterna}");
    }

}