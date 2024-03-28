using Library.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SistemaVentas.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
	public DbSet<Productos> Productos { get; set; }
	public DbSet<Categorias> Categorias { get; set; }
	public DbSet<TiposContribuyente> TiposContribuyente { get; set; }
	public DbSet<Contactos> Contactos { get; set; }
	public DbSet<Proveedores> Proveedores { get; set; }
	public DbSet<Ventas> Ventas { get; set; }
	public DbSet<Compras> Compras { get; set; }
	public DbSet<MetodosPago> MetodosPago { get; set; }
	public DbSet<UnidadesMedida> UnidadesMedida { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Contactos>().HasData(new List<Contactos>
		{
			new Contactos { ContactoId = 1, Descripcion = "Tel�fono"},
			new Contactos { ContactoId = 2, Descripcion = "Fax"}
		});

		modelBuilder.Entity<TiposContribuyente>().HasData(new List<TiposContribuyente>
		{
			new TiposContribuyente { TipoContribuyenteId = 1, Descripcion = "Persona F�sica"},
			new TiposContribuyente { TipoContribuyenteId = 2, Descripcion = "Persona Jur�dica"}
		});

		modelBuilder.Entity<MetodosPago>().HasData(new List<MetodosPago>
		{
			new MetodosPago { MetodoPagoId = 1, MetodoPago = "Efectivo"},
			new MetodosPago { MetodoPagoId = 2, MetodoPago = "Cr�dito"},
			new MetodosPago { MetodoPagoId = 3, MetodoPago = "Transferencia"}
		});

		modelBuilder.Entity<UnidadesMedida>().HasData(new List<UnidadesMedida>
		{
			new UnidadesMedida { UnidadMedidaId = 1, UnidadMedida = "Caja"},
			new UnidadesMedida { UnidadMedidaId = 2, UnidadMedida = "Pieza"},
			new UnidadesMedida { UnidadMedidaId = 3, UnidadMedida = "Gramo"},
			new UnidadesMedida { UnidadMedidaId = 4, UnidadMedida = "Metro"},
			new UnidadesMedida { UnidadMedidaId = 5, UnidadMedida = "Libra"}
		});
	}
}