using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;
using System.IO;
using System.Xml.Serialization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("federico", "ivagaza");

            XmlSerializer xml = new XmlSerializer(typeof(Persona));
            //todas las clases que quiera serializar en xml tiene q ser publica y tener un constructor por defecto

            TextWriter escritor = new StreamWriter("D:\\persona.xml", false);

            xml.Serialize(escritor, persona);

            escritor.Close();

            TextReader lector = new StreamReader("D:\\persona.xml");

            Persona p=(Persona)xml.Deserialize(lector);
            p.Nombre = "fede";

            Console.WriteLine(p.ToString());

            lector.Close();

            List<Alumno> gente = new List<Alumno>();
            Alumno p1 = new Alumno("seba", "perez",1);
            Alumno p2 = new Alumno("fede", "perez",2);
            Alumno p3 = new Alumno("flor", "perez",3);

            gente.Add(p1);
            gente.Add(p3);
            gente.Add(p2);



            XmlSerializer xmls = new XmlSerializer(typeof(List<Alumno>));

            TextWriter escritores = new StreamWriter("D:\\gente.xml", false);

            xmls.Serialize(escritores, gente);

            escritor.Close();




            //AppDomain.CurrentDomain.BaseDirectory; devuelve un string con la ubicacion de donde se encuentra nuestra aplicacion

            /*Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//devuelve un string con la direccion de directorio que le indices por parametro

            StreamWriter stream=new StreamWriter(@"D:\personas.txt",true);//solo archivo de escritura
            //,si el archivo es nuevo lo crea y si existe lo sobreescibe y pierdo los datos
            //a no ser que ponga en true como parametro para agregar datos al archivo
            StreamWriter write = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\persona.txt", true);
            write.WriteLine(persona.ToString());
            write.Close();

            stream.WriteLine(persona.ToString());

            stream.Close();

            StreamReader reader = new StreamReader(@"D:\personas.txt");//solo de lectura, y si el archivo
            //no existe lanza una excepcion
            while (reader.EndOfStream == false)
            {
                Console.WriteLine(reader.ReadLine());
            }
            

            reader.Close();*/

            

            Console.Read();
        }

    }
}
