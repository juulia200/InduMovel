using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;

namespace InduMovel.Models
{
    public class Movel
    {
        public int MovelId{get;set;}
        [Required(ErrorMessage = "Informe o nome da Movel")]
        [Display(Name = "Nome Movel")]
        [MinLength(4, ErrorMessage = "Movel dever ter no minimo {1} caracteres")]
        [MaxLength(20, ErrorMessage = "Movel dever ter no maximo {1} caracteres")]
        public string Nome{get;set;}
        [Required(ErrorMessage = "Informe o nome da Descricao")]
        [Display(Name = "Descricao")]
        [MinLength(20, ErrorMessage = "Descricao dever ter no minimo {1} caracteres")]
        [MaxLength(150, ErrorMessage = "Descricao dever ter no maximo {1} caracteres")]
        public string Decricao{get;set;}
        [Display(Name = "Cor")]
        [MaxLength(20, ErrorMessage = "Cor dever ter no maximo {1} caracteres")]
        public string Cor{get;set;}
        [Display(Name = "Imagem grande")]
        public string ImagemUrl{get;set;}
        [Display(Name = "Imagem pequena")]
        public string ImagemPequena{get;set;}
        [Display(Name = "Em Producao")]
        public bool EmProducao{get;set;}
        [Display(Name = "Ativo")]
        public bool Ativo{get;set;}
        [Required(ErrorMessage = "Informe a categoria")]
        [Display(Name = "Categoria")]
        public int CategoriaId{get;set;}
        public virtual Categoria Categoria{get;set;}
    }
}