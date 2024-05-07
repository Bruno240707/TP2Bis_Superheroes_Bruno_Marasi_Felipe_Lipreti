namespace TP2_Bis_Superheroes_Bruno_Marasi_Felipe_Lipreti;

class Program
{


    static void Main(string[] args)
    {
        double skills1 = 0, skills2 = 0;
        int numMenu = -1;
        Superheroes nSuperHeroe1 = new Superheroes();
        Superheroes nSuperHeroe2 = new Superheroes();
        do 
        {
        mostrarMenu();
        numMenu = ingreseNumMenu();
        
        switch(numMenu)
        {
            case 1:
            nSuperHeroe1 = ObtenerSuperHeroe(nSuperHeroe1);
            skills1 = nSuperHeroe1.obtenerSkill();
            break;

            case 2:
            nSuperHeroe2 = ObtenerSuperHeroe(nSuperHeroe2);
            skills2 = nSuperHeroe2.obtenerSkill();
            break;

            case 3:
            if (skills1 > 0 && skills2 > 0)
            {
                competir(nSuperHeroe1, nSuperHeroe2, skills1, skills2);
            }
            break;

            case 4:
            finaliza();
            break;
        }
        } while(numMenu != 4);

    }

    static Superheroes ObtenerSuperHeroe(Superheroes superHeroe)
    {
        Console.WriteLine("Ingrese el nombre del superHeroe");
        superHeroe.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la ciudad del superHeroe");
        superHeroe.Ciudad = Console.ReadLine();
        Console.WriteLine("Ingrese el peso del superHeroe");
        superHeroe.Peso = double.Parse(Console.ReadLine());
        do 
        {
            Console.WriteLine("Ingrese la fuerza del superHeroe");
            superHeroe.Fuerza = double.Parse(Console.ReadLine());
        } while (superHeroe.Fuerza < 1 || superHeroe.Fuerza > 100);

        do 
        {
            Console.WriteLine("Ingrese la velocidad del superHeroe");
            superHeroe.Velocidad = double.Parse(Console.ReadLine());
        } while(superHeroe.Velocidad < 1 || superHeroe.Velocidad > 100);

        Console.WriteLine("Se ha creado el superheroe: " + superHeroe.Nombre);
        return superHeroe;
    }

    static void mostrarMenu()
    {
        Console.WriteLine("1. Cargar Datos SuperHeroe 1");
        Console.WriteLine("2. Cargar Datos Superhéroe 2");
        Console.WriteLine("3. Competir!");
        Console.WriteLine("4. Salir");
    }

    static int ingreseNumMenu()
    {
        int numMenu = -1;
        do 
        {
        Console.WriteLine("Ingrese el numero del menu que quiere ver");
        numMenu = int.Parse(Console.ReadLine());
        } while (numMenu != 1 && numMenu != 2 && numMenu != 3 && numMenu != 4 && numMenu != 5);
        return numMenu;
    }

    static void finaliza()
    {
        Console.WriteLine("EL PROGRAMA FINALIZA");
    }

    static void competir(Superheroes nSuperheroe1, Superheroes nSuperheroe2, double skill1, double skill2)
    {
        if (skill1 > skill2)
        {
            if ((skill1 - skill2) >= 30)
            {
                Console.WriteLine("El superheroe " + nSuperheroe1.Nombre + " gano por amplia diferencia");
            }
            else if ((skill1 - skill2) >= 10 && (skill1 - skill2) < 30)
            {
                Console.WriteLine("El superheroe " + nSuperheroe1.Nombre + " gano, ¡Fue muy parejo!”");
            } 
            else 
            {
                Console.WriteLine("Gano " + nSuperheroe1.Nombre + ",¡No le sobró nada");
            }
        }
        else 
        {
            if ((skill2 - skill1) >= 30)
            {
                Console.WriteLine("El superheroe " + nSuperheroe2.Nombre + " gano por amplia diferencia");
            }
            else if ((skill1 - skill2) >= 10 && (skill2 - skill1) < 30)
            {
                Console.WriteLine("El superheroe " + nSuperheroe2.Nombre + " gano, ¡Fue muy parejo!”");
            } 
            else 
            {
                Console.WriteLine("Gano " + nSuperheroe2.Nombre + ",¡No le sobró nada");
            }
        }
    }



}
