using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_API_Agenda_de_Tarefas.Models;

namespace Projeto_API_Agenda_de_Tarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) :base(options)
        {

        }

        public DbSet<Tarefa> Tarefas {get; set;}
    }
}