using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Documento
    {
        public int Durata {  get; set; } 
        
        public Dvd(string titolo, string anno, string settore, string nomeAutore, string cognomeAutore, int durata) : base (titolo, anno, settore, nomeAutore, cognomeAutore)
        {
            this.Durata = durata;       
        }
    }
}
