using System;
using System.Threading;

namespace Expendadora
{
    internal class Expendedora1
    {
        #region Atributos  
        string marca;
        byte temperatura;
        float precio;
        ushort cantProductos;
        #endregion

        public Expendedora1() 
        {
            marca = "ADM";
            temperatura = 18;
            Saludar();
            LimpiarPantalla();
            Console.WriteLine("Marca:{0}", marca);
            LimpiarPantalla();
            Console.WriteLine("Temperatura:{0}",temperatura);
            LimpiarPantalla();
            string codigo= MostrarCodigoProducto();
            LimpiarPantalla();
            MostrarPrecio(codigo);


        }

        #region Métodos

        void Saludar()

        {
            Console.WriteLine("**Bienvenido a tu expendedora**");
            
        }
        void LimpiarPantalla()
        {
            Thread.Sleep(2000);//el parametro está en milisegundos
            Console.Clear();
        }

        string MostrarCodigoProducto()
        {
            Console.WriteLine(" 1A) Crujitos \n 2B) Totis ");
            Console.WriteLine("Ingresa el codigo del producto a elegir: ");
            string codigo = Console.ReadLine();//Variable local
            return codigo;
        }

        void MostrarPrecio(string codigo)
        {
            switch(codigo)
            {
                case "1A":
                    precio = 13;// Todo atributo tiene un valor por default
                                //Para este caso en 0.0
                    break;
                case "2B":
                    precio = 10;
                    break;
            }
            Console.WriteLine("El precio es:{0}", precio);

        }

        #endregion

    }
}
