using System;

class Program
{
    static void Main()
    {
        while (true)  // meniul se repeta pana apesi 0
        {
            int varianta = CitesteVarianta(
                "Salut, bine ai venit la aplicatia de calculator!\n" +
                "Ce doresti sa faci?\n" +
                "1 - Adunare\n" +
                "2 - Scadere\n" +
                "3 - Inmultire\n" +
                "4 - Impartire\n" +
                "0 - Iesire\n" +
                "Alege o optiune: "
            );

            if (varianta == 0)
            {
                Console.WriteLine("La revedere!");
                break;
            }

            double n1 = CitesteNumar("Introdu primul numar: ");
            double n2 = CitesteNumar("Introdu al doilea numar: ");

            switch (varianta)
            {
                case 1:
                    Console.WriteLine($"Suma este: {CalculeazaSuma(n1, n2)}");
                    break;

                case 2:
                    Console.WriteLine($"Diferenta este: {CalculeazaDiferenta(n1, n2)}");
                    break;

                case 3:
                    Console.WriteLine($"Produsul este: {CalculeazaProdusul(n1, n2)}");
                    break;

                case 4:
                    Console.WriteLine($"Impartirea este: {CalculeazaImpartirea(n1, n2)}");
                    break;

                default:
                    Console.WriteLine("Optiune invalida.");
                    break;
            }

            Console.WriteLine(); // linie goala pentru aspect
        }
    }

    static int CitesteVarianta(string mesaj)
    {
        while (true)
        {
            Console.Write(mesaj);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int optiune) && optiune >= 0 && optiune <= 4)
                return optiune;

            Console.WriteLine("Nu ai introdus o optiune valida!");
        }
    }

    static double CitesteNumar(string mesaj)
    {
        while (true)
        {
            Console.Write(mesaj);
            string input = Console.ReadLine();

            if (double.TryParse(input, out double numar))
                return numar;

            Console.WriteLine("Nu este un numar valid! Mai incearca.");
        }
    }

    public static double CalculeazaSuma(double a, double b) => a + b;
    public static double CalculeazaDiferenta(double a, double b) => a - b;
    public static double CalculeazaProdusul(double a, double b) => a * b;
    public static double CalculeazaImpartirea(double a, double b) => a / b;
}
