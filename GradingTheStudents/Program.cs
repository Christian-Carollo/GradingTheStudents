using GradingTheStudents;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Studente> studenti = new List<Studente>();

        studenti.Add(new Studente("Marco", 10));
        studenti.Add(new Studente("Alessio", 3));
        studenti.Add(new Studente("Alessia", 7));
        studenti.Add(new Studente("Marta", 6));
        studenti.Add(new Studente("Stefano", 4));
        studenti.Add(new Studente("Francesca", 5));
        studenti.Add(new Studente("Mirco", 9));
        studenti.Add(new Studente("Emanuela", 8));
        studenti.Add(new Studente("Paolo", 6));
        studenti.Add(new Studente("Pamela", 2));


        //---------------------------------------------------------------------------------------------

        double media = studenti.Average(studente => studente.voto);

        Console.WriteLine($"Media Voti: {media}");

        //---------------------------------------------------------------------------------------------

        var studenteConVotoPiùAlto = studenti.OrderBy(studente => studente.voto).Last();

        Console.WriteLine($"Lo studente con il voto più alto è {studenteConVotoPiùAlto} ");



    }
}