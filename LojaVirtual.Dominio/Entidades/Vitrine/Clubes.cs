﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Dominio.Entidades.Vitrine
{
    public abstract class Clubes
    {
        [Key]
        public string LinhaCodigo { get; set; }

        public string LinhaDescricao { get; set; }
    }
}
