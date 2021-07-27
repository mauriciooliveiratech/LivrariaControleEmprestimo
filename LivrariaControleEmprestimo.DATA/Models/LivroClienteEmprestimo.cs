﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LivrariaControleEmprestimo.DATA.Models
{
    public partial class LivroClienteEmprestimo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("idCliente")]
        public int IdCliente { get; set; }
        [Column("idLivro")]
        public int IdLivro { get; set; }
        [Column("dataemprestimo", TypeName = "datetime")]
        public DateTime Dataemprestimo { get; set; }
        [Column("datadevolucao", TypeName = "datetime")]
        public DateTime Datadevolucao { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Cliente.LivroClienteEmprestimo))]
        public virtual Cliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdLivro))]
        [InverseProperty(nameof(Livro.LivroClienteEmprestimo))]
        public virtual Livro IdLivroNavigation { get; set; }
    }
}