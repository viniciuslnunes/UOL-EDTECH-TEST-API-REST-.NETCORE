using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UolEdtech.Data.Dtos
{
    public class UpdateSmsDto
    {
        [Required(ErrorMessage = "O campo Tipo é obrigatório")]
        public string Tipo { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "O campo Mensagem é obrigatório e deve ter até 100 caracteres")]
        public string Mensagem { get; set; }

        [StringLength(100, ErrorMessage = "O campo NumDestinatario é obrigatório e deve ter até 100 caracteres")]
        public string NumDestinatario { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O campo Assunto é obrigatório e deve ter até 50 caracteres")]
        public string Assunto { get; set; }

        [Required(ErrorMessage = "O campo Cliente é obrigatório")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "O campo NomeUsuario é obrigatório")]
        public string NomeUsuario { get; set; }
    }
}
