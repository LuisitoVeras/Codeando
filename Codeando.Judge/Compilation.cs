using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Codeando.Judge
{
    public class Compilation
    {
        private string codigo;
        private SyntaxTree arbolSintaxis;
        private MetadataReference[] referencias;
        private CSharpCompilation configuracionCompilador;
        private CSharpCompilationOptions opcionesCompilador;

        public Compilation (string codigo)
        {
            this.codigo = codigo;

            arbolSintaxis = SyntaxFactory.ParseSyntaxTree(codigo);

            referencias = new MetadataReference[]
            {
               MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
               // Tipos e interfaces comunes en tiempo de ejecución (System.Runtime)
               MetadataReference.CreateFromFile(Assembly.Load("System.Runtime").Location),
               // Colecciones genéricas (List<T>, Dictionary<TKey, TValue>)
               MetadataReference.CreateFromFile(typeof(System.Collections.Generic.List<>).Assembly.Location),
               // LINQ para consultas (System.Linq)
               MetadataReference.CreateFromFile(typeof(System.Linq.Enumerable).Assembly.Location)
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

        public void Compilar ()
        {
            using (var memoria = new MemoryStream()) {
                var result = configuracionCompilador.Emit(memoria);

                if (result.Success)
                {
                    //Rebobinando eta vaina
                    memoria.Seek(0, SeekOrigin.Begin);
                    
                }

                else
                {

                }
                
            }


        }

    }
}
