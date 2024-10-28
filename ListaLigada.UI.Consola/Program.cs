using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! LISTA LIGADA SIMPLE");

        var singleList = new SingleList <string> ();
        singleList.Add ("Priscila");
        singleList.Add ("Uriel");
        singleList.Add ("Alechis");
        singleList.Add ("César");
        singleList.Add ("Aneth");

        Console.WriteLine(singleList);
        Console.ReadKey();
    }
}