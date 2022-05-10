namespace PizzeriaWebApp.Models
{
    public class Pizza
    {

        
        public string nome { get; set; }
        public double prezzo { get; set; }
        public string descrizione { get; set; }
        public string foto { get; set; }

        public Pizza()
        {



        }

        public Pizza(string nome , double prezzo , string descrizione , string foto)
        {

            this.nome = nome;
            this.prezzo = prezzo;
            this.descrizione = descrizione;
            this.foto = foto;

        }

    }
}
