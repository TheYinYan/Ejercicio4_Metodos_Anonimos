void sectEjer(int num)
{
    switch (num)
    {
        case 1:
            Ejercicio1();
            break;
        case 2:
            Ejercicio2();
            break;
        case 3:
            Ejercicio3();
            break;
        case 4:
            Ejercicio4();
            break;
        case 5:
            Ejercicio5();
            break;
        case 6:
            Ejercicio6();
            break;
        case 7:
            Ejercicio7();
            break;
        case 8:
            Ejercicio8();
            break;
        case 9:
            Ejercicio9();
            break;
        case 10:
            Ejercicio10();
            break;
        case 11:
            Ejercicio11();
            break;
        case 12:
            Ejercicio12();
            break;
        case 0:
            Console.WriteLine($"Saliendo del Programa");
            break;
        default:
            Console.WriteLine($"No existe el ejercicio {num}");
            break;
    }
}

int ej = 0;

do
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicios de Delegados ---");
    Console.WriteLine();

    Console.WriteLine("Ejercicio 1");
    Console.WriteLine("Ejercicio 2");
    Console.WriteLine("Ejercicio 3");
    Console.WriteLine("Ejercicio 4");
    Console.WriteLine("Ejercicio 5");
    Console.WriteLine("Ejercicio 6");
    Console.WriteLine("Ejercicio 7");
    Console.WriteLine("Ejercicio 8");
    Console.WriteLine("Ejercicio 9");
    Console.WriteLine("Ejercicio 10");
    Console.WriteLine("Ejercicio 11");
    Console.WriteLine("Ejercicio 12");
    Console.WriteLine("0. Salir");
    Console.WriteLine();

    Console.Write("Introduce el Ejercicio a ver: ");
    ej = Convert.ToInt32(Console.ReadLine());
    sectEjer(ej);
}
while (ej != 0);

void Ejercicio1()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 1 ---");
    Console.WriteLine();

    Multiplicar mult = delegate (int x, int y)
    {
        return x * y;
    };

    Console.WriteLine($"4*3={mult(4, 3)}");
    Console.WriteLine($"7*5={mult(7, 5)}");
}

void Ejercicio2()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 2 ---");
    Console.WriteLine();

    VerificarPalindromo esPalindromo = delegate (string cadena)
    {
        char[] caracteres = cadena.ToLower().ToCharArray();
        Array.Reverse(caracteres);
        string invertida = new string(caracteres);
        return cadena.ToLower() == invertida;
    };

    Console.WriteLine($"'radar' es un palíndromo: {esPalindromo("radar")}");
    Console.WriteLine($"'puerta' es un palíndromo: {esPalindromo("puerta")}");
}

void Ejercicio3()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 3 ---");
    Console.WriteLine();

    ConvertirTemperatura aFahrenheit = delegate (double c)
    {
        return (c * 9 / 5) + 32;
    };

    Console.WriteLine($"0°C -> {aFahrenheit(0)}°F");
    Console.WriteLine($"30°C -> {aFahrenheit(30)}°F");
}

void Ejercicio4()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 4 ---");
    Console.WriteLine();

    EsMayorQueDiez mayorQue10 = delegate (int n)
    {
        return n > 10;
    };

    Console.WriteLine($"8 es mayor que 10: {mayorQue10(8)}");
    Console.WriteLine($"15 es mayor que 10: {mayorQue10(15)}");
}

void Ejercicio5()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 5 ---");
    Console.WriteLine();

    CompararLongitud mismaLongitud = delegate (string s1, string s2)
    {
        return s1.Length == s2.Length;
    };

    Console.WriteLine($"Las palabras 'gato' y 'perro' tienen la misma longitud: {mismaLongitud("gato", "perro")}");
}

void Ejercicio6()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 6 ---");
    Console.WriteLine();

    CalcularFactorial factorial = delegate (int n)
    {
        int resultado = 1;
        for (int i = 2; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    };

    Console.WriteLine($"Factorial de 4 es {factorial(4)}");
    Console.WriteLine($"Factorial de 6 es {factorial(6)}");
}

void Ejercicio7()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 7 ---");
    Console.WriteLine();

    ContarCaracteres contar = delegate (string s)
    {
        return s.Length;
    };

    Console.WriteLine($"La palabra 'mundo' tiene {contar("mundo")} caracteres");
    Console.WriteLine($"La palabra 'programa' tiene {contar("programa")} caracteres");
}

void Ejercicio8()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 8 ---");
    Console.WriteLine();

    void ProcesarNumero(int num, Operacion op)
    {
        Console.WriteLine($"El número {num} es par: {op(num)}");
    }

    Operacion esPar = delegate (int n)
    {
        return n % 2 == 0;
    };

    ProcesarNumero(4, esPar);
    ProcesarNumero(7, esPar);
}

void Ejercicio9()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 9 ---");
    Console.WriteLine();

    void MostrarProductosFiltrados(List<Producto> productos, Filtro filtro)
    {
        foreach (Producto p in productos)
        {
            if (filtro(p))
            {
                Console.WriteLine($"{p.Nombre} (Cantidad: {p.Cantidad})");
            }
        }
    }

    List<Producto> inventario = new List<Producto>
    {
        new Producto { Nombre = "Televisor", Cantidad = 10 },
        new Producto { Nombre = "Teclado", Cantidad = 3 },
        new Producto { Nombre = "Refrigerador", Cantidad = 7 }
    };

    Filtro mayorA5 = delegate (Producto p)
    {
        return p.Cantidad > 5;
    };

    Console.WriteLine("Productos con cantidad mayor a 5:");
    MostrarProductosFiltrados(inventario, mayorA5);
}

void Ejercicio10()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 10 ---");
    Console.WriteLine();

    void FiltrarEmpleados(List<Empleado> empleados, FiltroEmpleado filtro)
    {
        foreach (Empleado e in empleados)
        {
            if (filtro(e))
            {
                Console.WriteLine($"{e.Nombre} (Edad: {e.Edad})");
            }
        }
    }

    List<Empleado> plantilla = new List<Empleado>
    {
        new Empleado { Nombre = "Ana", Edad = 35 },
        new Empleado { Nombre = "Carlos", Edad = 28 },
        new Empleado { Nombre = "Luis", Edad = 42 }
    };

    FiltroEmpleado mayorDe30 = delegate (Empleado e)
    {
        return e.Edad > 30;
    };

    Console.WriteLine("Empleados mayores de 30 años:");
    FiltrarEmpleados(plantilla, mayorDe30);
}

void Ejercicio11()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 11 ---");
    Console.WriteLine();

    void MostrarLibrosPorCategoria(List<Libro> libros, FiltroLibros filtro)
    {
        foreach (Libro l in libros)
        {
            if (filtro(l))
            {
                Console.WriteLine(l.Titulo);
            }
        }
    }

    List<Libro> biblioteca = new List<Libro>
    {
        new Libro { Titulo = "El Hobbit", Categoria = "Ficción" },
        new Libro { Titulo = "Breve historia del tiempo", Categoria = "Ciencia" },
        new Libro { Titulo = "Harry Potter", Categoria = "Ficción" }
    };

    FiltroLibros esFiccion = delegate (Libro l)
    {
        return l.Categoria == "Ficción";
    };

    Console.WriteLine("Libros de la categoría Ficción:");
    MostrarLibrosPorCategoria(biblioteca, esFiccion);
}

void Ejercicio12()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 12 ---");
    Console.WriteLine();

    void MostrarVehiculosAntiguos(List<Vehiculo> vehiculos, FiltroVehiculo filtro)
    {
        foreach (Vehiculo v in vehiculos)
        {
            if (filtro(v))
            {
                Console.WriteLine($"{v.Marca} {v.Modelo} ({v.AnioFabricacion})");
            }
        }
    }

    List<Vehiculo> taller = new List<Vehiculo>
    {
        new Vehiculo { Marca = "Toyota", Modelo = "Corolla", AnioFabricacion = 2005 },
        new Vehiculo { Marca = "Seat", Modelo = "Ibiza", AnioFabricacion = 2018 },
        new Vehiculo { Marca = "Honda", Modelo = "Civic", AnioFabricacion = 2008 }
    };

    FiltroVehiculo antesDe2010 = delegate (Vehiculo v)
    {
        return v.AnioFabricacion < 2010;
    };

    Console.WriteLine("Vehículos fabricados antes de 2010:");
    MostrarVehiculosAntiguos(taller, antesDe2010);
}

delegate int Multiplicar(int a, int b);
delegate bool VerificarPalindromo(string texto);
delegate double ConvertirTemperatura(double celsius);
delegate bool EsMayorQueDiez(int numero);
delegate bool CompararLongitud(string cadena1, string cadena2);
delegate int CalcularFactorial(int numero);
delegate int ContarCaracteres(string texto);
delegate bool Operacion(int numero);
delegate bool Filtro(Producto p);
delegate bool FiltroEmpleado(Empleado e);
delegate bool FiltroLibros(Libro l);
delegate bool FiltroVehiculo(Vehiculo v);

class Producto
{
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
}

class Empleado
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

class Libro
{
    public string Titulo { get; set; }
    public string Categoria { get; set; }
}

class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnioFabricacion { get; set; }
}
