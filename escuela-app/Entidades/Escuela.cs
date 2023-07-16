using escuela_app.Util;

namespace escuela_app.Entidades
{
    public class Escuela : ObjetoEscuelaBase, Ilugar
    {
        public int AñoDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }

        public string Direccion { get; set; }
        public TiposEscuela TipoEscuela{get;set;}
        public List<Curso> Cursos { get; set; }
       
        // constructor
        public Escuela(string nombre, int año)
        {
            Nombre = nombre;
            AñoDeCreacion = año;
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

        public void LimpiarLugar()
        {
            Printer.DibujarLinea();
            Console.WriteLine("Limpiando Escuela....");
            foreach (var curso in Cursos)
            {
                curso.LimpiarLugar();
            }
            Console.WriteLine($"Escuela {Nombre} Limpio");
        }
    }
}
