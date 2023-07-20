// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using Newtonsoft.Json;
using System.Net;
using System.Text.Json.Serialization;

namespace Generic
{
    class program
    { 
        static void Main(string[] args) 
        {
            //A<int> oA = new A<int>();
            //oA.Algo(4);

            //A<string> oA2 = new A<string>();
            //oA2.Algo("1");

            string url = "https://jsonplaceholder.typicode.com/posts";
            Persona oPersona = new Persona() { Nombre = "Juan", Edad = 12 };
            Solicitud<Persona> oSolicitud = new Solicitud<Persona>(oPersona);
            string resultado = oSolicitud.Solicitar(url);


            Carro oCarro = new Carro() { Marca = "Nissan", Modelo = "March" };
            Solicitud<Carro> oSolicitud2 = new Solicitud<Carro>(oCarro);
            string resultado2 = oSolicitud2.Solicitar(url);

        }

        //public class A<T> 
        //{
        //    public void Algo(T parametro) 
        //    {

        //    }
        //}

        public class Solicitud<T>
        {
            T data;

            public Solicitud(T data)
            {
                this.data = data;
            }
            public string Solicitar(string url)
            {
                string result = "";
                WebRequest oRequest = WebRequest.Create(url);
                oRequest.Method = "POST";
                oRequest.ContentType = "application/json;charset=UTF-8";

                using (var oSW = new StreamWriter(oRequest.GetRequestStream()))
                { 
                    string json = JsonConvert.SerializeObject(data);

                    oSW.Write(json);
                    oSW.Flush();
                    oSW.Close();
                }

                WebResponse oResponse = oRequest.GetResponse();

                using (var oSR = new StreamReader(oResponse.GetResponseStream()))
                { 
                    result = oSR.ReadToEnd().Trim();
                }

                return (result);
            }
        }

        public class Persona
        {
            public string? Nombre { get; set; }
            public int Edad { get; set; }
        }

        public class Carro
        {
            public string? Marca { get; set; }
            public string? Modelo { get; set; }
        }
    }
}
