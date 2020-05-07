using System;
using System.Runtime.Serialization;
namespace serializacion_clase
{
    [Serializable]
    public class Person
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public Person()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            
        }
    }
}
