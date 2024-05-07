class Superheroes
{
    public string Nombre {get; set;}
    public string Ciudad {get; set;}
    public double Peso {get; set;}
    public double Fuerza {get; set;}
    public double Velocidad {get; set;}



    public Superheroes() {}

    public Superheroes(string nombre, string ciudad, double peso, double fuerza, double velocidad)
    {
        Nombre = nombre;
        Ciudad = ciudad;
        Peso = peso;
        Fuerza = fuerza;
        Velocidad = velocidad;
    }

    public double obtenerSkill()
    {
        double skill;
        Random num = new Random();
        skill = (Fuerza * 0.8) + (Velocidad * 0.6) + num.Next(0,11);
        return skill;
    }
}