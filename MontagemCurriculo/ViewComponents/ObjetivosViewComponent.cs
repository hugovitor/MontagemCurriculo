﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MontagemCurriculo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MontagemCurriculo.ViewComponents
{
    public class ObjetivosViewComponent : ViewComponent
    {
        private readonly Contexto _contexto;

        public ObjetivosViewComponent(Contexto contexo)
        {
            _contexto = contexo;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return View(await _contexto.Objetivos.Where(o => o.CurriculoId == id).ToListAsync());
        }
    }
}
