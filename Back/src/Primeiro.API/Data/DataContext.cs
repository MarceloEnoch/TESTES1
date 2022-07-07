using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Primeiro.API.Models;

namespace Primeiro.API.Data
{
    public class DataContext : DbContext
    {
        // o UseSqlite precisa de um DbContextBuilder, ou seja, tem que ter esse construtor abaixo
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        /* Eu recebi ele e passei pro construtor do pai DbContext.
        <Passando quem é meu contexto>  base é pra passar pro pai, ou seja, passar a conection string, o banco de dados que estou usando, para o banco de dados.
        GetConnectionString("Default"), agora devo lembrar de configurar o default do getconnection!
        */

        public DbSet<Evento> Eventos { get; set; }
        /*
        Eu fiz o construtor acima por precisar que essa referencia aqui se torne um banco de dados, afinal esse é o mapeamento da classe.
        essa base tem o nome no plural
        afinal, a propriedade do meu DataContext, Eventos, está no plural.
        e vai ser do tipo Evento, que tem 7 propriedades, que serão os campos do banco de dados,
        */
    }
}