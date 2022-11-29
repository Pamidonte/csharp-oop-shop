// See https://aka.ms/new-console-template for more information
using System;

namespace CSharpShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Prodotto primoProdotto = new Prodotto("pizza", "pizza con mozzarella", 1, 20);
            Prodotto secondoProdotto = new Prodotto("Fanta", "Fanta Orange", 1, 10);



            Console.WriteLine( "codice prodotto: " + primoProdotto.infoCodice);

            Console.WriteLine("Nome prodotto: " + primoProdotto.infoNome);

            primoProdotto.infoDescrizione = "pizza con ananas";
            Console.WriteLine("tipo della pizza: " + primoProdotto.infoDescrizione);

            primoProdotto.infoPrezzo = 8;
            Console.WriteLine("prezzo della pizza: " + primoProdotto.infoPrezzo + " euro");

            primoProdotto.infoIva = 18;
            Console.WriteLine("l'iva sulla pizza è al: " + primoProdotto.infoIva + "%");

            Console.WriteLine("prezzo con iva: " + primoProdotto.prezzoIva() + " euro");

            Console.WriteLine("codice prodotto con nome : " + primoProdotto.nomePiuCodice());

            Console.WriteLine();    

            

            Console.WriteLine("codice prodotto: " + secondoProdotto.infoCodice);

            Console.WriteLine("Nome prodotto: " + secondoProdotto.infoNome);

            Console.WriteLine("tipo di bevanda: " + secondoProdotto.infoDescrizione);

            Console.WriteLine("prezzo della bevanda: " + secondoProdotto.infoPrezzo + " euro");

            Console.WriteLine("l'iva sulla bevanda è al: " + secondoProdotto.infoIva + "%");

            Console.WriteLine("prezzo con iva: " + secondoProdotto.prezzoIva() + " euro");

            Console.WriteLine("codice prodotto con nome: " + secondoProdotto.nomePiuCodice());

            Console.WriteLine("codice con padLeft: " + secondoProdotto.metodoPadLeft());













        }

    }
}
   