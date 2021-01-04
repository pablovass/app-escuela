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
        // private int myVar;
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

        // metodo toString 
        public override string ToString()
        {
            return $"Nombre: {Nombre},Tipo: {TipoEscuela}\n Pais: {Pais},Cuidad: {Ciudad}";
        }
    }
}
