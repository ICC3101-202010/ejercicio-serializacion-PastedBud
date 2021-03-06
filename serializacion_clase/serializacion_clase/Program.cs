﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace serializacion_clase
{
    
    class MainClass
    {
        //crear persona
        //nombre edad
        //A la clase persona tienen que poner el atributo [Serializable]. Esta clase es muy simple, solo nombre, apellido y edad.
        //Luego en la clase program, tienen que tener los métodos para guardar y cargar(todo sale en la documentación).
        //Finalmente para probar pueden hacer una minì app de consola, donde puedan crear personas, que les muestre todas las personas registradas y salirse.
        //Eso si al volver a meterse y ver la lista que esten las personas registradas anteriormente


        public static void Main(string[] args)
        {



            int a = 0;

            List<Person> personas = new List<Person>();
            while (a != 4)
            {
                Console.WriteLine("Desea 1 -crear nueva persona");
                Console.WriteLine("      2 -cargar personas existentes");
                Console.WriteLine("      3 -para mostrar lista de personas");
                Console.WriteLine("      4 -Salir");
                a = Convert.ToInt32(Console.ReadLine());

                if (a == 1)
                {
                    Person person = new Person();
                    Console.WriteLine("Introduzca Nombre");
                    string Nombre = Console.ReadLine();
                    person.Nombre = Nombre;
                    Console.WriteLine("Introduzca Apellido");
                    string Apellido = Console.ReadLine();
                    person.Apellido = Apellido;
                    Console.WriteLine("Introduzca Edad");
                    int Edad = Convert.ToInt32(Console.ReadLine());
                    person.Edad = Edad;
                    personas.Add(person);
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, person);
                    stream.Close();


                }
                if (a == 2)
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                    Person person = (Person)formatter.Deserialize(stream);
                    stream.Close();

                    // Here's the proof.  
                    Console.WriteLine("Nombre: {0}", person.Nombre);
                    Console.WriteLine("Apellido: {0}", person.Apellido);
                    Console.WriteLine("Edas: {0}", person.Edad);
                }
                if (a == 3)
                {
                    foreach (var item in personas)
                    {
                        Console.WriteLine(item.Info_Personas());
                    }
                }


            }
            
        }
    }
}
