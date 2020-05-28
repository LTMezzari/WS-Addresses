using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace ws_addresses.Models {
    public class Address {
        public int Id { get; set; }

        [Required(ErrorMessage = "CEP é obrigatório.", AllowEmptyStrings = false)]
        [MaxLength(8, ErrorMessage = "O CEP deve conter 6 caracteres sem nenhuma pontuação")]
        [MinLength(8, ErrorMessage = "O CEP deve conter 6 caracteres sem nenhuma pontuação")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "A rua é obrigatória.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "A rua deve conter no máximo 100 caracteres")]
        public string Street { get; set; }

        [Required(ErrorMessage = "O número é obrigatório.", AllowEmptyStrings = false)]
        [Range(1, 9999, ErrorMessage = "O número deve estar entre 1 e 9999")]
        public int Number { get; set; }

        public string Complement { get; set; }

        public string Reference { get; set; }

        [Required(ErrorMessage = "O UF é obrigatório.", AllowEmptyStrings = false)]
        [JsonConverter(typeof(StringEnumConverter))]
        public State UF { get; set; }

        [Required(ErrorMessage = "O Bairro é obrigatório.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "O bairro deve conter no máximo 100 caracteres")]
        public string Neighborhood { get; set; }

        [Required(ErrorMessage = "A cidade é obrigatória.", AllowEmptyStrings = false)]
        [MaxLength(100, ErrorMessage = "A cidade deve conter no máximo 100 caracteres")]
        public string City { get; set; }
    }
}