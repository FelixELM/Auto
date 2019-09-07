using System;
using System.Collections.Generic;


namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Auto a = new Auto("Nissan","Z350",2006);

            Auto b = new Auto("Toyota", "Corolla", 2019);

            a.imprime();
            b.imprime();
        }
    }

    class Auto
    {
        private string marca;
        private string modelo;
        private Int16 año;
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        
        public string getMarca()
        {
            return marca;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public string getModelo()
        {
            return modelo;
        }
    
        public Auto (string ma, string mo, Int16 año)
        {
            //Construtores sirve para inicalizar un objeto
            this.marca = ma;
            this.modelo = mo;
            this.año = año;
        }

        public Int16 getAño()
        {
            return año;
        }

        public Auto()
        {
            //Cuando tenemos dos argumentos llamados de la misma manera se llama Sobrecarga
        }

        public void imprime()
        {
            //Metodo para imprimir
            Console.WriteLine("{0}, {1}, {2}", this.getMarca(), this.getModelo(), this.getAño());
        }
        
    }
}
