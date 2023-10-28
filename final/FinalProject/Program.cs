using System;

class Program
{
    static void Main(string[] args)
    {
        //creating a fictitious list//
        List<Elder> Elders = new List<Elder>();
        Elder elder = new ElderActive("juan perez", "mucho lote");
        Elders.Add(elder);
        elder = new ElderActive("Jose Miguel", "romareda");
        Elders.Add(elder);
        elder= new ElderInactive("Pepe pacheco", "paraiso 1");
        Elders.Add(elder);
        elder = new ElderActive("Miler Bolanos", "urdesa");
        Elders.Add(elder);
        elder= new ElderInactive("francisco cevallos", "paraiso 2");
        Elders.Add(elder);
        elder = new ElderActive("pepito juan", "romareda 4");
        Elders.Add(elder);
        elder= new ElderInactive("juan piguave", "paraiso 5");
        Elders.Add(elder);
        elder = new ElderActive("Matias lokoman", "urdesa 2");
        Elders.Add(elder);
        elder= new ElderInactive("cesar farias", "paraiso 3");
        Elders.Add(elder);
        elder = new ElderActive("Jose chavez", "rommareda");
        Elders.Add(elder);
        elder= new ElderInactive("Johnny Salv", "paraiso 4");
        Elders.Add(elder);
        elder = new ElderActive("Wilmer perez", "urdesa");
        Elders.Add(elder);
        elder= new ElderInactive("ivan valencia", "paraiso 2");
        Elders.Add(elder);
        elder = new ElderActive("juan dalgo", "romareda 4");
        Elders.Add(elder);
        elder= new ElderInactive("jimmy boze", "paraiso 5");
        Elders.Add(elder);
        elder = new ElderActive("Antonio Solis", "urdesa 2");
        Elders.Add(elder);
        elder= new ElderInactive("Marco Tulio", "paraiso 3");
        Elders.Add(elder);


        MinisterManager ministerManager = new MinisterManager(Elders);
        ministerManager.Start();


    }
}