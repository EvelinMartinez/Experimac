namespace Experimac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.clientes",
                c => new
                    {
                        pkcliente = c.Int(nullable: false, identity: true),
                        Nomb_Cliente = c.String(nullable: false, unicode: false),
                        Ap_Cliente = c.String(nullable: false, unicode: false),
                        sCorreo = c.String(nullable: false, unicode: false),
                        sTelefono = c.String(nullable: false, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        Ordenes_pkOrdenes = c.Int(),
                    })
                .PrimaryKey(t => t.pkcliente)
                .ForeignKey("dbo.Ordenes", t => t.Ordenes_pkOrdenes)
                .Index(t => t.Ordenes_pkOrdenes);
            
            CreateTable(
                "dbo.Ordenes",
                c => new
                    {
                        pkOrdenes = c.Int(nullable: false, identity: true),
                        Tipo_Modelo = c.String(unicode: false),
                        Procesador = c.String(unicode: false),
                        Almacenamiento = c.String(unicode: false),
                        Estado_Bateria = c.String(unicode: false),
                        Apple_Id = c.String(unicode: false),
                        Tamanio = c.String(unicode: false),
                        Core_Nucleos = c.String(unicode: false),
                        Almacenamiento_Dos = c.String(unicode: false),
                        Ciclos_Bateria = c.String(unicode: false),
                        Pass_Apple_Id = c.String(unicode: false),
                        ID = c.String(unicode: false),
                        Num = c.String(unicode: false),
                        Modelo = c.String(unicode: false),
                        Memoria = c.String(unicode: false),
                        Memoria_Video = c.String(unicode: false),
                        No_Serie = c.String(unicode: false),
                        Codigo_Pass = c.String(unicode: false),
                        IMEI = c.String(unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        servicios_pkServicio = c.Int(),
                    })
                .PrimaryKey(t => t.pkOrdenes)
                .ForeignKey("dbo.servicios", t => t.servicios_pkServicio)
                .Index(t => t.servicios_pkServicio);
            
            CreateTable(
                "dbo.servicios",
                c => new
                    {
                        pkServicio = c.Int(nullable: false, identity: true),
                        Nomb_Serv = c.String(nullable: false, unicode: false),
                        Costo_serv = c.String(nullable: false, unicode: false),
                        sDescripcion = c.String(nullable: false, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkServicio);
            
            CreateTable(
                "dbo.solicita",
                c => new
                    {
                        pkSolicita = c.Int(nullable: false, identity: true),
                        Fecha = c.String(nullable: false, unicode: false),
                        Hora = c.String(nullable: false, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        Ordenes_pkOrdenes = c.Int(),
                    })
                .PrimaryKey(t => t.pkSolicita)
                .ForeignKey("dbo.Ordenes", t => t.Ordenes_pkOrdenes)
                .Index(t => t.Ordenes_pkOrdenes);
            
            CreateTable(
                "dbo.usuarios",
                c => new
                    {
                        pkUsuarios = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, unicode: false),
                        sPassword = c.String(nullable: false, unicode: false),
                        sCorreo = c.String(nullable: false, unicode: false),
                        bStatus = c.Boolean(nullable: false),
                        ordenes_pkOrdenes = c.Int(),
                    })
                .PrimaryKey(t => t.pkUsuarios)
                .ForeignKey("dbo.Ordenes", t => t.ordenes_pkOrdenes)
                .Index(t => t.ordenes_pkOrdenes);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.usuarios", "ordenes_pkOrdenes", "dbo.Ordenes");
            DropForeignKey("dbo.solicita", "Ordenes_pkOrdenes", "dbo.Ordenes");
            DropForeignKey("dbo.Ordenes", "servicios_pkServicio", "dbo.servicios");
            DropForeignKey("dbo.clientes", "Ordenes_pkOrdenes", "dbo.Ordenes");
            DropIndex("dbo.usuarios", new[] { "ordenes_pkOrdenes" });
            DropIndex("dbo.solicita", new[] { "Ordenes_pkOrdenes" });
            DropIndex("dbo.Ordenes", new[] { "servicios_pkServicio" });
            DropIndex("dbo.clientes", new[] { "Ordenes_pkOrdenes" });
            DropTable("dbo.usuarios");
            DropTable("dbo.solicita");
            DropTable("dbo.servicios");
            DropTable("dbo.Ordenes");
            DropTable("dbo.clientes");
        }
    }
}
