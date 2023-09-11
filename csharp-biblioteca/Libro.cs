using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documento
    {
        //Proprietà
        public int Pagine { get; set; }

        //Costruttore
        public Libro(string titolo, string anno, string settore, string nomeAutore, string cognomeAutore, int pagine) : base(titolo, anno, settore, nomeAutore, cognomeAutore) 
        {
            this.Pagine = pagine;
        }

        //Metodi
        public override void StampaInfo()
        {
            base.StampaInfo();
            Console.WriteLine($"- Numero Pagine: {this.Pagine}");
        }
    }
}
