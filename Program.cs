Biblioteca bibli = new();
Livro livro = new(01,"The end", "Dicaprio");
bibli.AdicionarItem(livro);
Livro livro2 = new(02, "Quem é", "Erick");
bibli.AdicionarItem(livro2);
bibli.BuscarItem(01);
bibli.RemoverItem(livro);
bibli.BuscarItem("Quem é");