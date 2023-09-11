using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documento
    {
        //Proprietà

        public string Codice { get; set; }
        public string Titolo { get; set; }
        public string Anno { get; set; }
        public string Settore { get; set; }
        public string PosizioneScaffale { get; set; }
        public string NomeAutore { get; set; }
        public string CognomeAutore { get; set; }
        
        
        //Costruttore
        public Documento(string titolo, string anno, string settore, string nomeAutore, string cognomeAutore) 
        { 
            this.Titolo = titolo;
            this.Anno = anno;   
            this.Settore = settore;
            this.NomeAutore = nomeAutore;
            this.CognomeAutore = cognomeAutore; 
        }

        //Metodi
        public virtual void StampaInfo()
        {
            Console.WriteLine($@"Documento {this.Titolo}:
                                - Anno di pubblicazione: {this.Anno}
                                - Autore: {this.NomeAutore} {this.CognomeAutore}");
        }

    }
}
