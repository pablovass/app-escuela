namespace escuela_app.Entidades
{
        /// <summary>
        /// ObjetoEscuelaBase es abstract porque no quiero que se instancie objetos de esta clase, pero tambien cumple con los coseptos de abstract.
        /// </summary>

    public abstract class ObjetoEscuelaBase
    {
        // la clase abstrapta no se pueden implementar e instanciar una clase de esta clase.
        public string Nombre { get;  set; }  
        public string UniqueId{ get;private set; }

        public ObjetoEscuelaBase()
        {
            UniqueId=Guid.NewGuid().ToString();
        }
        // me permite ver los datos a la hora de hacer el debuguer
        public override string ToString()
        {
            return $"{Nombre},{UniqueId}";
        }
    }
}