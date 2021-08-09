using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            Printer.WriteTitle("BIENVENIDOS A LA ESCUELA");
            //Printer.Beep(10000, cantidad: 10);
            ImpimirCursosEscuela(engine.Escuela);
            var listaObjetos = engine.GetObjetosEscuela();

            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.DrawLine(20);
            Printer.WriteTitle("Pruebas de Polimorfismo");
            var alumnoTest = new Alumno{ Nombre="Pedro underwood" };

            ObjetoEscuelaBase ob = alumnoTest;
            

            Printer.WriteTitle("Alumno");
            WriteLine($"Alumno: {alumnoTest.Nombre}");
            WriteLine($"Alumno: {alumnoTest.UniqueId}");
            WriteLine($"Alumno: {alumnoTest.GetType()}");

            Printer.WriteTitle("ObjetoEscuela");
            WriteLine($"Alumno: {ob.Nombre}");
            WriteLine($"Alumno: {ob.UniqueId}");
            WriteLine($"Alumno: {ob.GetType()}");

            var objDummy = new ObjetoEscuelaBase(){Nombre= "Frank UnderWood"};
            Printer.WriteTitle("ObjetoEscuelaBase");
            WriteLine($"Alumno: {objDummy.Nombre}");
            WriteLine($"Alumno: {objDummy.UniqueId}");
            WriteLine($"Alumno: {objDummy.GetType()}");

            var evaluación = new Evaluación(){Nombre="Math", Nota=4.5f};
            Printer.WriteTitle("Evaluación");
            WriteLine($"Evaluación: {evaluación.Nombre}");
            WriteLine($"Evaluación: {evaluación.UniqueId}");
            WriteLine($"Evaluación: {evaluación.Nota}");
            WriteLine($"Evaluación: {evaluación.GetType()}");

            //ob = evaluación;

            if (ob is Alumno)
            {
                Alumno alumnoRecuperado = (Alumno)ob;
            }


            Alumno alumnoRecuperado2 = ob as Alumno;

            if (alumnoRecuperado2 != null)
            {
                
            }
        }

        private static void ImpimirCursosEscuela(Escuela escuela)
        {

            Printer.WriteTitle("Cursos de la Escuela");


            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre {curso.Nombre  }, Id  {curso.UniqueId}");
                }
            }
        }
    }
}
