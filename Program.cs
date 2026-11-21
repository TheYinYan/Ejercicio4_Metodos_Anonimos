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


}
void Ejercicio2()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 2 ---");
    Console.WriteLine();


}
void Ejercicio3()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 3 ---");
    Console.WriteLine();


}
void Ejercicio4()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 4 ---");
    Console.WriteLine();


}
void Ejercicio5()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 5 ---");
    Console.WriteLine();


}
void Ejercicio6()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 6 ---");
    Console.WriteLine();


}
void Ejercicio7()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 7 ---");
    Console.WriteLine();


}
void Ejercicio8()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 8 ---");
    Console.WriteLine();


}
void Ejercicio9()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 9 ---");
    Console.WriteLine();


}
void Ejercicio10(){
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 10 ---");
    Console.WriteLine();



}
void Ejercicio11()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 11 ---");
    Console.WriteLine();



}
void Ejercicio12()
{
    Console.WriteLine();
    Console.WriteLine("--- Ejercicio 12 ---");
    Console.WriteLine();



}