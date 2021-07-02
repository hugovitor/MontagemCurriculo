﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MontagemCurriculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.ViewComponents
{
    public class FormacoesAcademicasViewComponent : ViewComponent
    {
        private readonly Contexto _contexto;

        public FormacoesAcademicasViewComponent(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _contexto.FormacoesAcademicas.Include(f => f.TipoCurso).Where(f => f.CurriculoId == id).ToListAsync());
        }
    }
}
