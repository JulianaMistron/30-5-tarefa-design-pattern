using _30_5_tarefa_design_pattern;

class program
{
    static void Main(string[] args)
    {


        Console.WriteLine(">>>>DESIGN PATTERNS - PADRÃO VISITOR<<<<\n");

        Console.WriteLine(">>>>Concessionária Juliana's Auto<<<<\n");


        List<Carro> carros = new List<Carro>();
        carros.Add(new Carro() { Nome = "HB20", Preco = 82890, Modelo = "Hyundai" });
        carros.Add(new Carro() { Nome = "Polo", Preco = 89990, Modelo = "Volkswagen" });
        carros.Add(new Carro() { Nome = "Mobi", Preco = 69990, Modelo = "Fiat" });

        List<ILoja> lojas = new List<ILoja>();

        Console.WriteLine("Preços normais dos carros\n");
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Modelo} {carro.Nome}: R$ {carro.Preco}");
            lojas.Add(carro);
        }
        Console.WriteLine("\nPreços dos carros com desconto");
        Console.WriteLine("Aplicando o padrão visitor");

        Console.ReadLine();
        Console.WriteLine("Novos preços com desconto de 30%.....SÓ POR HOJE!!!\n");
        PrecoVisitor precoVisitor = new PrecoVisitor();
        foreach (var element in lojas)
        {
            element.Visit(precoVisitor);
        }
        Console.ReadKey();
    }



}