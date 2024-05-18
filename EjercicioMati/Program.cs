//La compañía McDonalds nos pide realizar un sistema para pedir comida, desde el alimento hasta la bebida
//y que al final nos muestre el monto total para que el usuario pueda pagar en caja con su ticket de compra.

using System.ComponentModel.Design;
int op = 0;
Console.WriteLine("Bienvenido a Mc Donalds");
do
{
    Console.WriteLine("----------------------------------");
    Console.WriteLine("1-Realizar un pedido \n2-Salir");
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("----------------------------------");

    if (!int.TryParse(Console.ReadLine(), out op) || op < 1 || op > 2)
    {
        Console.Clear();
        Console.WriteLine("Opción inválida, vuelva a intentar.");
        continue;
    }
    Console.Clear();
    switch (op)
    {
        case 1:
            RealizarPedido();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Muchas Gracias, hasta luego!");
            break;
    }

} while (op != 2);

static void RealizarPedido()
{
    int menu = 0;
    int comidaop = 0;
    int total = 0;
    int bebidaop = 0;
    string comida = "";
    string bebida = "";
    do
    {
        Console.WriteLine("Menu: ");
        Console.WriteLine("1: hamburguer \n2: Cheeseburuger\n3: DobleHamburguer \n4: Mcdouble \n5: Quarter Pounder");
        Console.WriteLine("6: Big Mac \n7: McChicken \n8: Filet-O-Fish");

        if (!int.TryParse(Console.ReadLine(), out comidaop) || comidaop < 1 || comidaop > 8)
        {
            Console.Clear();
            Console.WriteLine("Opción inválida, vuelva a intentar.");
            continue;
        }

        switch (comidaop)
        {
            case 1:
                comida = "Hamburguer";
                total = 200;
                break;
            case 2:
                comida = "Cheeseburguer";
                total = 250;
                break;
            case 3:
                comida = "DobleHamburguer";
                total = 300;
                break;
            case 4:
                comida = "Mcdouble";
                total = 350;
                break;
            case 5:
                comida = "Quarter Pounder";
                total = 450;
                break;
            case 6:
                comida = "Bic Mac";
                total = 550;
                break;
            case 7:
                comida = "McCicken";
                total = 300;
                break;
            case 8:
                comida = "Filet-o-Fish";
                total = 320;
                break;
        }
    } while (comidaop < 1 || comidaop > 8);

    Console.Clear();

    do
    {
        Console.WriteLine("Bebida:");
        Console.WriteLine("1-Coca Cola \n2-Sprite \n3-Fanta \n4-Agua ");

        if (!int.TryParse(Console.ReadLine(), out bebidaop) || bebidaop < 1 || bebidaop > 4)
        {
            Console.Clear();
            Console.WriteLine("Opción inválida, vuelva a intentar.");
            continue;
        }

        switch (bebidaop)
        {
            case 1:
                bebida = "Coca cola";
                total += 100;
                break;
            case 2:
                bebida = "Sprite";
                total += 80;
                break;
            case 3:
                bebida = "Fanta";
                total += 80;
                break;
            case 4:
                bebida = "Agua";
                total += 60;
                break;
        }
    } while (bebidaop < 1 || bebidaop > 4);

    do
    {
        Console.Clear();
        Console.WriteLine("1-Retirar Ticket \n2-Volver a pedir menu ");

        if (!int.TryParse(Console.ReadLine(), out menu) || menu < 1 || menu > 2)
        {
            Console.Clear();
            Console.WriteLine("Opción invalida");
            continue;
        }
        else if (menu == 1)
        {
            Console.Clear();
            Console.WriteLine("Usted debera pagar: $" + total + "\nSu pedido es una " + comida + " , con " + bebida + ", Disfrute de su pedido!");
        }
        else if (menu == 2)
        {
            Console.Clear();
            Console.WriteLine("Redirigiendose al menu..");
            total = 0;
        }
    } while (menu < 1 || menu > 2);
}