using System;
using System.Collections.Generic;
using System.Text;

namespace Codeando.Entidad
{
    public class Problema
    {
        int idProblema {  get; set; }
        string inputs { get; set; }
        string outputs { get; set; }
        int tiempoLimite { get; set; }
        int memoriaLimite { get; set; }
        bool disponible { get; set; }
        string dificultad { get; set; }
        string titulo { get; set; }
        string descripcion { get; set; }
    }


}
