//La compañía McDonalds nos pide realizar un sistema para pedir comida, desde el alimento hasta la bebida
//y que al final nos muestre el monto total para que el usuario pueda pagar en caja con su ticket de compra.

using System.ComponentModel.Design;

int op = 0;
int menu = 0;

Console.WriteLine("Bienvenido a Mc Donalds");
do
{
    Console.WriteLine("1-Realizar un pedido \n2-Salir");
    Console.WriteLine("Seleccione una opción:");
    op = int.Parse(Console.ReadLine());

    while (op > 2 || op <1)
    {
        Console.WriteLine("Opción invalida, vuela a intentar");
        Console.WriteLine("1-Realizar un pedido: \n2-Salir");
        Console.WriteLine("Seleccione una opción:");
        op = int.Parse(Console.ReadLine());
    }
    
    switch (op)
    {
        case 1:
            Console.Clear();
            int comidaop = 0;
            int total = 0;
            int bebidaop = 0;
            string comida = "";
            string bebida = "";
            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("1: hamburguer \n2: Chesseburuger\n3: DobleHamburguer \n4: Mcdouble \n5: Quarter Pounder");
                Console.WriteLine("6: Big Mac \n7:McChicken \n8: Filet-O-Fish");
                comidaop = int.Parse(Console.ReadLine());
                switch (comidaop)
                {
                    case 1:
                        comida = "Hamburguer";
                        total = 200;
                        break;
                    case 2:
                        comida = "Chesseburguer";
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
                        total  = 450;
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
                while (comidaop < 1 || comidaop > 8)
                {
                    Console.WriteLine();
                    Console.WriteLine("Opcion invalida!");
                    Console.WriteLine("Menu: ");
                    Console.WriteLine("1: hamburguer \n2: Chesseburuger\n3: DobleHamburguer \n4: Mcdouble \n5: Quarter Pounder");
                    Console.WriteLine("6: Big Mac \n7:McChicken \n8: Filet-O-Fish");
                    comidaop = int.Parse(Console.ReadLine());
                }
                /*
                 * Coca cola = 100
                   Sprite = 80
                   Fanta = 80
                */
                Console.Clear();
                Console.WriteLine("Bebida:");
                Console.WriteLine("1-Coca Cola \n2-Sprite \n3-Fanta \n4-Agua ");
                bebidaop = int.Parse(Console.ReadLine());
                
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
                while (bebidaop < 1 || bebidaop > 4)
                {
                    Console.Clear();
                    Console.WriteLine("Opcion invalida!");
                    Console.WriteLine("Bebida:");
                    Console.WriteLine("1-Coca Cola \n2-Sprite \n3-Fanta \n4-Agua ");
                    bebidaop = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                Console.WriteLine("1-Retirar Ticket \n2-Volver a pedir menu ");
                menu = int.Parse(Console.ReadLine());
                while (menu < 1 || menu > 2)
                {
                    Console.Clear();
                    Console.WriteLine("Opcion invalida!");
                    Console.WriteLine("1-Retirar Ticket \n2-Volver a pedir menu ");
                    menu = int.Parse(Console.ReadLine());
                }
                if (menu == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Usted debera pagar: $" + total + "\nSu pedido es una " + comida + " , con " + bebida + ",Disfrute de su pedido!");
                }
                else if (menu == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Redirigiendose al menu..");
                    total = 0;
                }
            } while (menu != 1);
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Muchas Gracias, hasta luego!");
            break;
    }

} while (op != 2);
