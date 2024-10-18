using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace mf_dev_backend.Models
{

    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        [Required(ErrorMessage = "O campo Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório")]

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Data é obrigatório")]

        public DateTime Data { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório")]

        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo Quilometragem é obrigatório")]

        public int Km { get; set; }

        [Required(ErrorMessage = "O campo Id é obrigatório")]
        public TipoCombustivel Tipo { get; set; }

        [Required(ErrorMessage = "O campo Veículo é obrigatório")]

        [Display(Name = "Veículo")]
        public  int IdVeiculo{ get; set; }

        [ForeignKey("IdVeiculo")]

        public Veiculo Veiculo { get; set; }

    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol
    }
}
