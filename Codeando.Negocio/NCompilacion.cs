using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using Codeando.Judge;

namespace Codeando.Negocio
{
    public class NCompilacion
    {
        public string Compilar (string codigo)
        {
            Compilacion compilador = new Compilacion(codigo);
            return compilador.Compilar();
        }
    }
}
