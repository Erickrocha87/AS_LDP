public abstract class ItemBiblioteca
{
    public int Id {get; set;}
    public string? Titulo {get; set;}
    protected string DescricaoInterna {get; set;}
    public ItemBiblioteca(int Id, string titulo)
    {
        this.Id = Id;
        this.Titulo = titulo;
        this.DescricaoInterna = "Romance Antigo";
    }
}