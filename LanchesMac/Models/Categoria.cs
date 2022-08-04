using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(100,ErrorMessage ="O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da Categoria")]
        [Display(Name ="Nome")]      
        public string CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "O tamanho maximo é 200 caracteres")]
        [Required(ErrorMessage = "Informe a Descrição")]
        [Display(Name = "Descriacao")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
