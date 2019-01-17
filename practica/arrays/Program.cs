using System;

namespace arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
                OperacionesCliente opCliente = new OperacionesCliente();
                //MENU
                bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("__________________________________________");
                Console.WriteLine("____________________MENU__________________");
                Console.WriteLine("1. INGRESE (1) PARA AGREGAR CLIENTES:");
                Console.WriteLine("2. INGRESE (2) PARA MOSTRAR CLIENTES:");
                Console.WriteLine("3. INGRESE (3) PARA BUSCAR UN CLIENTE:");
                Console.WriteLine("4. INGRESE (4) PARA MODIFICAR CLIENTES:");
                Console.WriteLine("5. INGRESE (5) PARA ELIMINAR CLIENTES:");
                Console.WriteLine("6. INGRESE (6) PARA REALIZAR UN DEPÓSITO:");
                Console.WriteLine("7. INGRESE (7) PARA REALIZAR UN RETIRO:");
                Console.WriteLine("0. INGRESE (0) PARA SALIR DEL PROGRAMA");
                Console.WriteLine("__________________________________________");
                int op = Int32.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0:
                        continuar = false;
                        break;
                    case 1:
                        opCliente.agregarClientes();
                        break;
                    case 2:
                        opCliente.mostrarClientes();
                        break;
                    case 3:
                        opCliente.buscarCliente();
                        break;
                    case 4:
                        opCliente.editarCliente();
                        break;
                    case 5:
                        opCliente.eliminarCliente();
                        break;
                    case 6:
                        opCliente.depositarDinero();
                        break;
                    case 7:
                        opCliente.retirarDinero();
                        break;
                    default:
                        Console.WriteLine("LA OPCION INGRESADA NO ES VÁLIDA");
                        break;
                }               
            } while (continuar);           
        }
    }
}
