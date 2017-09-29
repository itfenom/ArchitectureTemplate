using System;
using System.Collections.Generic;

namespace ArchitectureTemplate.Business.DataEntities
{
    public class Tela
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ControllerName { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public bool Create { get; set; }
        public bool Read { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public virtual ICollection<PerfilPorTela> PerfilPorTela { get; set; }
    }
}
