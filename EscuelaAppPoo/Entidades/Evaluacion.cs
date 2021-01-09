using System;
/*
Se tendria que llama Evaluacion
*/
namespace EscuelaAppPoo.Entidades
{
    public class Evaluacion : ObjetoEscuelaBase
    {

        public Alumno Alumno{ get; set; }
        public Asignatura Asignatura{get; set;}
        public float Nota { get; set; }
        
  } 
  }