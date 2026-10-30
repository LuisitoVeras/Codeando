using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Codeando.Judge
{
    public class Compilacion
    {
        private string codigo;
        private SyntaxTree arbolSintaxis;
        private MetadataReference[] referencias;
        private CSharpCompilation configuracionCompilador;
        private CSharpCompilationOptions opcionesCompilador;

        public Compilacion (string codigo)
        {
            this.codigo = codigo;

            arbolSintaxis = SyntaxFactory.ParseSyntaxTree(codigo);

            referencias = new MetadataReference[]
            {

                // 1. Referencia base para objetos y tipos fundamentales
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),

                // 2. Referencia explícita para System.Console (Permite usar Console.WriteLine)
                MetadataReference.CreateFromFile(typeof(System.Console).Assembly.Location),

                // 3. Referencia para colecciones y LINQ (List<T>, Enumerable, etc.)
                MetadataReference.CreateFromFile(typeof(System.Collections.Generic.List<>).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(System.Linq.Enumerable).Assembly.Location),

                // 4. Referencia al runtime principal para evitar fallos de ejecución
                MetadataReference.CreateFromFile(Assembly.Load("System.Runtime").Location)
            };

            opcionesCompilador = new CSharpCompilationOptions(
                outputKind: OutputKind.DynamicallyLinkedLibrary,
                optimizationLevel: OptimizationLevel.Debug,
                concurrentBuild: true,
                warningLevel: 4
                );

            configuracionCompilador = CSharpCompilation.Create(
                "AsemblyDinamico.dll",
                syntaxTrees: new[] { arbolSintaxis },
                references: referencias,
                options: opcionesCompilador
                );
        }

        public string Compilar ()
        {
            using (var memoria = new MemoryStream()) {
                var result = configuracionCompilador.Emit(memoria);

                if (result.Success)
                {
                    //Rebobinando eta vaina
                    memoria.Seek(0, SeekOrigin.Begin);
                    //Convierte lo de memoria en un ejecutable de un arreglo de bytes
                    Assembly ensamblaje = Assembly.Load(memoria.ToArray());

                    //setear la clase principal
                    Type tipoClase = ensamblaje.GetType("Solution");

                    //setear el texto 
                    using(var escritorTexto = new StringWriter())
                    {
                        //Redirigimos todos los console writeline ejecutados a la memoria ram dentro del string writer
                        Console.SetOut(escritorTexto);

                        //cramos una instancia de la clase principal, que sera donde 
                        object Instancia = Activator.CreateInstance(tipoClase);
                        MethodInfo metodoPrueba = tipoClase.GetMethod("Prueba");

                        if (metodoPrueba != null)
                        {
                            object resultadoRetorno = metodoPrueba.Invoke(Instancia, null);
                            string textoRetorno = escritorTexto.ToString();
                            return textoRetorno;

                        }

                    }

                    
                }

                else
                {
                    // Filtrar solo las fallas fatales de compilación
                    var erroresCompilacion = result.Diagnostics
                        .Where(d => d.Severity == DiagnosticSeverity.Error)
                        .Select(d => $"[Línea {d.Location.GetLineSpan().StartLinePosition.Line + 1}]: {d.GetMessage()}");

                    string txtSalida = "--- ERROR DE COMPILACIÓN ---\r\n" + string.Join("\r\n", erroresCompilacion);
                    return txtSalida; 
                }

                return "";
                
            }

        }

    }
}
