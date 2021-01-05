using System.Collections.Generic;

namespace EscuelaApp.Entidades
{
    class Escuela
    {

        string nombre;
        public TiposEscuela TipoEscuela{get;set;}
        //  string pais;

        // LO ENCAPSULE EN UNA PROPIEDAD
        public string Nombre
        {
            get { return "copia: " + nombre; }

            //se setea siempre en mayuscula
            set { nombre = value.ToUpper(); }
        }
        // es lo mismo que nombre 
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public List<Curso> Cursos { get; set; }
        // constructor
        public Escuela(string nombre, int año)
        {
            this.nombre = nombre;
            this.AñoDeCreacion = año;
        }
        //constructor vacio
        public Escuela() { }

        //constructor lamda
        public Escuela(string nombre, string pais) => (Nombre, Pais) = (nombre, pais);
        //constructor con un valor por defecto
        public Escuela(string nombre, int año,TiposEscuela tipo, string pais="",
                        string ciudad="")
        {
            (Nombre,AñoDeCreacion)=(nombre,año);
            Pais=pais;
            Ciudad=ciudad;
        }

        // metodo toString 
        public override string ToString()
        {
            return $" Nombre: {Nombre}, Tipo: {TipoEscuela}\n Pais: {Pais}, Cuidad: {Ciudad}";
        }
    }
}
