using System;
using System.Collections.Generic;
using System.Text;

namespace arrays
{
    public class Cliente
    {
        private string dni;
        private string nombre;
        private string apellido;       
        private string password;
        private int edad;
        private double saldo;
        public string Dni{get {return dni;}set{dni = value;}}
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int Edad { get { return edad; } set { edad = value; } }
        public double Saldo { get { return saldo; } set { saldo = value; } }
        public Cliente()//CONSTRUCTOR
        {
            dni = null;
            nombre = null;
            apellido = null;
            password = null;
            edad = 0;
            saldo = 0;
        }
        public override string ToString()
        {
            string texto = null;
            texto += "DNI: " + Dni;
            texto += "Nombre: " + Nombre;
            texto += "Apellido: " + Apellido;
            texto += "Password: " + Password;
            texto += "Edad: " + Edad.ToString();
            texto += "Saldo: " + Saldo.ToString();
            return texto;
        }
    }
    
}
