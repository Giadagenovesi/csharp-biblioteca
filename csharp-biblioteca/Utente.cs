using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente
    {
        //Proprietà
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public String RecapitoTelefonico { get; set; }


        //Costruttore
        public Utente(string nome, string cognome, string email, string recapitoTelefonico ) 
        {
            this.Nome = nome;
            this.Cognome = cognome; 
            this.Email = email;
            this.RecapitoTelefonico = recapitoTelefonico;
        }

        //Metodi
        public void StampaInfoUtente()
        {
            Console.WriteLine($"Benvenuto utente {this.Nome} {this.Cognome}");
        }
    }
}
