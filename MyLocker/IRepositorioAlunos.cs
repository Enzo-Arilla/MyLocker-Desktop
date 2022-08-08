﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLocker
{
    public interface IRepositorioAlunos
    {
        [Get("/students")]
        Task<Alunos[]> ListAlunos();
    }
}
