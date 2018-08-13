using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class Livro
    {
        [Key]
        public int IdLivro { get; set; }
        [Required]
        [StringLength(50)]
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [Required]
        public string Resumo { get; set; }
        public string Autor { get; set; }
        public int Quantidade { get; set; }
        public Double Valor { get; set; }
        public string Categoria { get; set; }
        
        public DateTime? DataPublicacao { get; set; }
        public bool Publicado { get; set; }

    }
}