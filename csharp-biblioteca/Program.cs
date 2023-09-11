namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro IlSignoreDegliAnelli = new Libro("Il Signore defli Anelli", "1955", "Romanzo", "J.R.R", "Tolkien", 1364);
            Dvd Matrix = new Dvd("Matrix", "1999", "Fantascienza", "Joel", "Silver", 136);
            
            List<Documento> listaDiDocumenti = new List<Documento>();
            listaDiDocumenti.Add(Matrix);
            listaDiDocumenti.Add(IlSignoreDegliAnelli);

            foreach (Documento documento in listaDiDocumenti)
            {
                documento.StampaInfo();
            }
        }
    }
}