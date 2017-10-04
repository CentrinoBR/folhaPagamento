using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using webApi.Entidades;

namespace webApi.DAO
{
    public class FuncionarioContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}