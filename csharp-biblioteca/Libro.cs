using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documento
    {
        public int Pagine { get; set; }
        public Libro(string titolo, string anno, string settore, string nomeAutore, string cognomeAutore, int pagine) : base(titolo, anno, settore, nomeAutore, cognomeAutore) 
        {
            this.Pagine = pagine;
        }
    }
}
