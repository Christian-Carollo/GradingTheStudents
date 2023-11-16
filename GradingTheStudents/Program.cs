using GradingTheStudents;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Studente> studenti = new List<Studente>()
        {
            new Studente("Marco", 10),
            new Studente("Alessio", 3),
            new Studente("Alessia", 7),
            new Studente("Marta", 6),
            new Studente("Stefano", 4),
            new Studente("Francesca", 5),
            new Studente("Mirco", 9),
            new Studente("Emanuela", 8),
            new Studente("Paolo", 6),
            new Studente("Pamela", 2)
    };


        //---------------------------------------------------------------------------------------------

        double media = studenti.Average(studente => studente.voto);

        Console.WriteLine($"Media Voti: {media}\n");

        //---------------------------------------------------------------------------------------------

        var studenteConVotoPiùAlto = studenti.OrderBy(studente => studente.voto).Last();

        Console.WriteLine($"Lo studente con il voto più alto è {studenteConVotoPiùAlto}\n");



    }
}