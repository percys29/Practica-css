using System;
using System.Collections.Generic;
using System.Text;

namespace arrays
{
    public class OperacionesCliente
    {
        const int TAMANIO_ARRAY_CLIENTES = 10;//DEFINIMOS UN TAMAÑO PERTINENTE PARA EL ARRAY DE CLIENTES
        Cliente[] clientes = new Cliente[TAMANIO_ARRAY_CLIENTES];//CREAMOS UN ARRAY DE CLIENTES
        bool existenClientes = false;
        bool clienteLogeado = false;
        int clienteSeleccionado = -1;
        int contadorClientes = 0;
        public void agregarClientes()
        {
            bool continuar = true;
            do
            {
                try
                {
                    Console.Clear();
                    clientes[contadorClientes] = new Cliente();
                    Console.WriteLine("INGRESE EL DNI DEL CLIENTE");
                    clientes[contadorClientes].Dni = Console.ReadLine();
                    Console.WriteLine("INGRESE EL NOMBRE DEL CLIENTE");
                    clientes[contadorClientes].Nombre = Console.ReadLine();
                    Console.WriteLine("INGRESE EL APELLIDO DEL CLIENTE");
                    clientes[contadorClientes].Apellido = Console.ReadLine();
                    Console.WriteLine("INGRESE EL PASSWORD DEL CLIENTE");
                    clientes[contadorClientes].Password = Console.ReadLine();
                    Console.WriteLine("INGRESE LA EDAD DEL CLIENTE");
                    clientes[contadorClientes].Edad = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("CLIENTE INGRESADO CORRECTAMENTE");
                    existenClientes = true;
                    contadorClientes++;
                    Console.WriteLine("DESEA AGREGAR UN NUEVO CLIENTE?: (s/n)");
                    continuar = (Console.ReadLine() == "s") ? true : false;
                }
                catch (Exception exception) when (exception is System.ArgumentOutOfRangeException || exception is System.IndexOutOfRangeException)
                {
                    Console.WriteLine("HAY " + TAMANIO_ARRAY_CLIENTES + " CLIENTES, YA NO QUEDA ESPACIO PARA NUEVOS CLIENTES");
                    Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR.......................");
                    Console.ReadLine();
                    break;//PARA SALIR DEL BUCLE DO....WHILE
                }

            } while (continuar);
        }
        public void mostrarCliente(int i)//PARA MOSTRAR UN SOLO CLIENTE
        {

            Console.WriteLine("DNI:" + clientes[i].Dni);
            Console.WriteLine("NOMBRE:" + clientes[i].Nombre);
            Console.WriteLine("APELLIDO:" + clientes[i].Apellido);
            Console.WriteLine("EDAD:" + clientes[i].Edad);
            Console.WriteLine("SALDO:" + clientes[i].Saldo);
        }
        public void mostrarClientes()
        {
            Console.Clear();
            if (existenClientes)
            {
                for (var i = 0; i < contadorClientes; i++)
                {
                    Console.WriteLine("__________________________________________");
                    Console.WriteLine("CLIENTE Nº: " + (i + 1));
                    Console.WriteLine("DNI:" + clientes[i].Dni);
                    Console.WriteLine("NOMBRE:" + clientes[i].Nombre);
                    Console.WriteLine("APELLIDO:" + clientes[i].Apellido);
                    Console.WriteLine("EDAD:" + clientes[i].Edad);
                    Console.WriteLine("SALDO:" + clientes[i].Saldo);
                }
            }
            else
            {
                Console.WriteLine("AUN NO HA SIDO INGRESADO NINGUN CLIENTE PARA MOSTRAR");
            }
            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR......");
            Console.ReadLine();
        }
        public void buscarCliente()
        {
            Console.Clear();
            if (existenClientes)
            {
                Console.WriteLine("INGRESE EL DNI DEL CLIENTE QUE DESEA BUSCAR");
                string dniBuscado = Console.ReadLine();
                bool dniEncontrado = false;
                for (var i = 0; i < contadorClientes; i++)
                {
                    if (clientes[i].Dni == dniBuscado && dniEncontrado == false)
                    {
                        Console.WriteLine("CLIENTE ENCONTRADO:");
                        Console.WriteLine("DNI:" + clientes[i].Dni);
                        Console.WriteLine("NOMBRE:" + clientes[i].Nombre);
                        Console.WriteLine("APELLIDO:" + clientes[i].Apellido);
                        Console.WriteLine("EDAD:" + clientes[i].Edad);
                        Console.WriteLine("SALDO:" + clientes[i].Saldo);
                        dniEncontrado = true;
                        break;
                    }
                }
                if (!dniEncontrado)
                    Console.WriteLine("CLIENTE NO ENCONTRADO:");
            }
            else
            {
                Console.WriteLine("AUN NO HA SIDO INGRESADO NINGUN CLIENTE PARA BUSCAR");
            }
            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR......");
            Console.ReadLine();
        }
        public void editarCliente()
        {
            Console.Clear();
            if (existenClientes)
            {
                Console.WriteLine("INGRESE EL DNI DEL CLIENTE QUE DESEA MODIFICAR");
                string dniBuscado = Console.ReadLine();
                bool dniEncontrado = false;
                for (var i = 0; i < contadorClientes; i++)
                {
                    if (clientes[i].Dni == dniBuscado && dniEncontrado == false)
                    {
                        Console.WriteLine("INGRESE EL NUEVO DNI DEL CLIENTE");
                        clientes[i].Dni = Console.ReadLine();
                        Console.WriteLine("INGRESE EL NUEVO NOMBRE DEL CLIENTE");
                        clientes[i].Nombre = Console.ReadLine();
                        Console.WriteLine("INGRESE EL NUEVO APELLIDO DEL CLIENTE");
                        clientes[i].Apellido = Console.ReadLine();
                        Console.WriteLine("INGRESE NUEVA EDAD DEL CLIENTE");
                        clientes[i].Edad = Int32.Parse(Console.ReadLine());
                        dniEncontrado = true;
                        Console.WriteLine("CLIENTE MODIFICADO CORRECTAMENTE:");
                        break;
                    }
                }
                if (!dniEncontrado)
                    Console.WriteLine("CLIENTE NO ENCONTRADO:");
            }
            else
            {
                Console.WriteLine("AUN NO HA SIDO INGRESADO NINGUN CLIENTE PARA MODIFICAR");
            }
            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR......");
            Console.ReadLine();
        }
        public void eliminarCliente()
        {
            Console.Clear();
            if (existenClientes)
            {
                Console.WriteLine("INGRESE EL DNI DEL CLIENTE QUE DESEA ELIMINAR");
                string dniBuscado = Console.ReadLine();
                bool dniEncontrado = false;
                for (var i = 0; i < contadorClientes; i++)//CON ESTE BUCLE BUSCAREMOS EL DNI EN EL ARRAY
                {
                    if (clientes[i].Dni == dniBuscado && dniEncontrado == false)
                    {
                        int posicionBorrar = i;
                        //ESTE BUCLE QUE EMPIEZA DESDE LA POSICION EN DONDE SE ENCUENTRA EL DNI BUSCADO
                        //RECORRE TODO EL ARRAY A PARTIR DE ESTE PUNTO, PASANDO LOS DATOS DE LA POSICION SIGUIENTE
                        //HACIA LA POSICION ANTERIOR, EN DONDE SE ENCONTRABA EL CLIENTE ELIMINADO Y ASI SUCESIVAMENTE HASTA LLEGAR
                        //A LA ULTIMA POSICION - 1 YA QUE SE HA ELIMINADO UN ELEMENTO DE TODO EL ARRAY,
                        //DE ESTA FORMA NOS ASEGURAMOS QUE NO QUEDEN ESPACIOS VACIOS EN NUESTRO ARRAY DE CLIENTES
                        for (var j = posicionBorrar; j < contadorClientes - 1; j++)
                        {
                            clientes[j] = clientes[j + 1];
                        }
                        contadorClientes--;
                        dniEncontrado = true;
                        Console.WriteLine("CLIENTE ELIMINADO CORRECTAMENTE:");
                        break;
                    }
                }
                if (!dniEncontrado)
                    Console.WriteLine("CLIENTE NO ENCONTRADO:");
            }
            else
            {
                Console.WriteLine("AUN NO HA SIDO INGRESADO NINGUN CLIENTE PARA ELIMINAR");
            }
            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR......");
            Console.ReadLine();
        }
        public void login()
        {
            Console.Clear();
            if (existenClientes)
            {
                Console.WriteLine("INGRESE SU NOMBRE: ");
                string nombreBuscado = Console.ReadLine();
                Console.WriteLine("INGRESE SU APELLIDO: ");
                string apellidoBuscado = Console.ReadLine();
                for (var i = 0; i < contadorClientes; i++)//CON ESTE BUCLE BUSCAREMOS EL DNI EN EL ARRAY
                {
                    if (clientes[i].Nombre == nombreBuscado && apellidoBuscado == clientes[i].Apellido && clienteLogeado == false)
                    {
                        Console.WriteLine("INGRESE LA CONTRASEÑA PARA: " + nombreBuscado + " " + apellidoBuscado);
                        string password = Console.ReadLine();
                        if (clientes[i].Password == password)
                        {
                            Console.WriteLine("BIENVENIDO: " + nombreBuscado + " " + apellidoBuscado);
                            clienteLogeado = true;
                            clienteSeleccionado = i;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("CONTRASEÑA INCORRECTA");
                            i--;
                        }
                    }
                }
                if (!clienteLogeado)
                    Console.WriteLine("CLIENTE NO ENCONTRADO:");
            }
            else
            {
                Console.WriteLine("AUN NO HA SIDO INGRESADO NINGUN CLIENTE PARA DEPOSITAR/RETIRAR DINERO");
            }
            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR......");
            Console.ReadLine();
        }
        public void depositarDinero()
        {            
            double cantidad = 0;
            login();
            Console.Clear();
            if (clienteLogeado)
            {
                Console.WriteLine("INGRESE LA CANTIDAD A DEPOSITAR:");
                cantidad = Double.Parse(Console.ReadLine());
                clientes[clienteSeleccionado].Saldo = cantidad;
                clienteSeleccionado = -1;
                clienteLogeado = false;
                Console.WriteLine("CANTIDAD DEPOSITADA CON ÉXITO:");
            }            
            else
            {
                Console.WriteLine("NO FUE POSIBLE AUTENTICAR AL CLIENTE");
            }
            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR......");
            Console.ReadLine();
        }
        public void retirarDinero()
        {            
            double cantidad = 0;
            login();
            Console.Clear();
            if (clienteLogeado)
            {
                Console.WriteLine("INGRESE LA CANTIDAD A RETIRAR:");
                cantidad = Double.Parse(Console.ReadLine());
                if(cantidad<= clientes[clienteSeleccionado].Saldo) { 
                    clientes[clienteSeleccionado].Saldo -= cantidad;
                    clienteSeleccionado = -1;
                    clienteLogeado = false;
                    Console.WriteLine("CANTIDAD RETIRADA CON ÉXITO:");
                }
                else
                {
                    Console.WriteLine("NO CUENTA CON SUFICIENTE DINERO PARA HACER EL RETIRO");
                }                
            }            
            else
            {
                Console.WriteLine("NO FUE POSIBLE AUTENTICAR AL CLIENTE");                
            }
            Console.WriteLine("PRESIONE UNA TECLA PARA CONTINUAR......");
            Console.ReadLine();
        }
    }
}