using System.Collections;

public class Biblioteca
{
    public ArrayList colecao;

    public Biblioteca()
    {
        colecao = new ArrayList();
    }

    public void AdicionarItem(ItemBiblioteca item)
    {

        colecao.Add(item);
        Console.WriteLine("Livro adicionado com sucesso.");
    }

    public void RemoverItem(ItemBiblioteca item)
    {
        colecao.Remove(item);
        Console.WriteLine("Livro removido com sucesso.");
    }

    
    public ItemBiblioteca BuscarItem(string titulo)
    {
        foreach (ItemBiblioteca item in colecao)
        {
            if (item.Titulo == titulo)
            {
                Console.WriteLine("Aqui está o livro que estava procurando!");
                return item;
            }else
            {
                Console.WriteLine("O título foi digitado incorretamente ou não possuimos esse livro");
            }
            
        }
        return null;
        
    }

    public ItemBiblioteca BuscarItem(int id)
    {
        foreach (ItemBiblioteca item in colecao)
        {
            if (item.Id == id)
            {
                Console.WriteLine("Aqui está o livro que estava procurando!");
                return item;
            } else
            {
                Console.WriteLine("O Id foi digitado incorretamente ou não possuimos esse livro");
                
            }
            
        }
        return null;

    }
}
