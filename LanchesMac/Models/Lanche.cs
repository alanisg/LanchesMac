﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanche")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        

        [Required(ErrorMessage ="O nome do Lanche deve ser informado")]
        [Display(Name ="Nome do Lanche")]
        [StringLength(80, MinimumLength = 10,ErrorMessage ="O {0} deve ter no minimo {1} e no maximo {2}")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "A descrição do Lanche deve ser informado")]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20, ErrorMessage ="A Descrição deve ter no minimo {1} caracteres")]
        [MaxLength(200,ErrorMessage ="A Descrição pode não pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }


        [Required(ErrorMessage = "A descrição detalhada do Lanche deve ser informado")]
        [Display(Name = "Descrição detalhada do Lanche")]
        [MinLength(20, ErrorMessage = "A Descrição detalhada deve ter no minimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A Descrição detalhada não pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }


        [Required(ErrorMessage ="Informe o Preço do Lanche")]
        [Display(Name ="Nome")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999.99")]
        public decimal Preco { get; set; }


        [Display(Name = "Caminho Imagem Normal")]        
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]
        public string ImagemUrl { get; set; }


        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }


        [Display(Name ="Preferido?")]
        public bool IsLanchePreferido { get; set; }


        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
        
    }
}
