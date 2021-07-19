using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using WEB.API.Data;

namespace WEB.API.Model
{
    [Table("Usuarios")]
    public class Usuario
    {
        

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(14)]
        public string CPF { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Sobrenome")]
        public string Sobrenome { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Nacionalidade")]
        public string Nacionalidade { get; set; }

        [Required]
        [StringLength(9)]
        [DisplayName("CEP")]
        public string CEP { get; set; }

        [Required]
        [StringLength(2)]
        [DisplayName("Estado")]
        public string Estado { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Cidade")]
        public string Cidade { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Logradouro")]
        public string Logradouro { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(14)]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        
       



    }
}
