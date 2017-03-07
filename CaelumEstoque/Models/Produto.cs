using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaelumEstoque.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [StringLength(20, MinimumLength = 5)]
        public String Nome { get; set; }
        [Range(1,999999999999)]
        public float Preco { get; set; }
        public CategoriaDoProduto Categoria { get; set; }
        public int? CategoriaId { get; set; }
        [StringLength(50, MinimumLength = 5)]
        public String Descricao { get; set; }
        [Range(1,99999999999)]
        public int Quantidade { get; set; }
    }
}