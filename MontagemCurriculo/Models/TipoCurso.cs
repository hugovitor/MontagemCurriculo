using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.Models
{
    public class TipoCurso
    {
        public int TipoCursoId { get; set; }
        public int Tipo { get; set; }
        public ICollection<FormacaoAcademica> FormacoesAcademicas { get; set; }
    }
}
