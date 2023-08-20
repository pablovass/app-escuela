namespace escuela_app.Entidades
{
    public interface Ilugar
    {
        //todos deben ser publicos 
        string Direccion { get; set; }

        void LimpiarLugar();
    }
}