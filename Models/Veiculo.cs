using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend.Models
{

    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Placa é obrigatório")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "O campo Ano do Veículo é obrigatório")]
        public int AnoVeiculo { get; set; }

        [Required(ErrorMessage = "O campo Ano do Modelo é obrigatório")]
        public int AnoModelo     { get; set; }
}
}
