﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Experimac.Models
{
    public class DataModel :DbContext
    {
        /// <summary>
        /// Contructor de la clase DataModel ese envia la conexion a la clase heredada
        /// </summary>
        public DataModel() : base("DataModel") { }

        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<servicios> servicios { get; set; }
        public DbSet<Solicita> solicita { get; set; }
        public DbSet<Ordenes> ordenes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
