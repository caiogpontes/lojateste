using LojaVirtual.Dominio.Dto;
using LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.Web.V2.Models
{
    public class ModalidadeSubGrupoViewModel
    {
        public Modalidade Modalidade { get; set; }
        public IEnumerable<SubGrupoDto> SubGrupos { get; set; }

    }
}