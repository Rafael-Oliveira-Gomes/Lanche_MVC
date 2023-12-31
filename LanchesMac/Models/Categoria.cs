﻿using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [StringLength(100, ErrorMessage ="O tamanho máximo é de 100 caracteres.")]
        [Required(ErrorMessage ="Informe o nome da categoria.")]
        [Display(Name= "Nome")]
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres.")]
        [Required(ErrorMessage = "Informe a descrição.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set;} //uma categoria tem muitos lanches
    }
}
