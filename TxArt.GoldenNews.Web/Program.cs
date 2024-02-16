using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TxArt.GoldenNews.Data.Contexto;
using TxArt.GoldenNews.Data.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Registar Contexto
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

#region: Identity
builder.Services.AddIdentity<Usuario, IdentityRole>(options =>
{
    // Password settings
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;

}).AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<UserManager<Usuario>>();
#endregion

#region:Register Dependencies

//Autenticação e Autorização
//builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();

////Gestão de Comunicação
//builder.Services.AddScoped<ICategoriaNoticiaRepository, CategoriaNoticiaRepository>();
//builder.Services.AddScoped<IComentarioRepository, ComentarioRepository>();
//builder.Services.AddScoped<IConversaRepository, ConversaRepository>();
//builder.Services.AddScoped<IMensagemRepository, MensagemRepository>();
//builder.Services.AddScoped<INoticiaRepository, NoticiaRepository>();
//builder.Services.AddScoped<IParticipanteConversaRepository, ParticipanteConversaRepository>();
//builder.Services.AddScoped<ITipoNoticiaRepository, TipoNoticiaRepository>();

////Gestão de Recursos Humanos
//builder.Services.AddScoped<ICargoRepository, CargoRepository>();
//builder.Services.AddScoped<IContratoFuncionarioRepository, ContratoFuncionarioRepository>();
//builder.Services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
//builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
//builder.Services.AddScoped<IFuncionarioRepository, FuncionarioRepository>();
//builder.Services.AddScoped<ITipoContratoFuncionarioRepository, TipoContratoFuncionarioRepository>();

////Gestão Documental
//builder.Services.AddScoped<IDiretorioRepository, DiretorioRepository>();
//builder.Services.AddScoped<IFicheiroRepository, FicheiroRepository>();
//builder.Services.AddScoped<IPermissaoRepository, PermissaoRepository>();
//builder.Services.AddScoped<IPermissaoDiretorioRepository, PermissaoDiretorioRepository>();
//builder.Services.AddScoped<IPermissaoFicheiroRepository, PermissaoFicheiroRepository>();

////Gestão De Eventos
//builder.Services.AddScoped<IEventoRepository, EventoRepository>();
//builder.Services.AddScoped<IEstadoEventoRepository, EstadoEventoRepository>();
//builder.Services.AddScoped<ITipoEventoRepository, TipoEventoRepository>();

////Multiple constructors for controllers
//builder.Services.AddScoped(sp => ActivatorUtilities.CreateInstance<EgateIntranet.Web.Areas.Admin.Controllers.EventosController>(sp));
//builder.Services.AddScoped(sp => ActivatorUtilities.CreateInstance<EgateIntranet.Web.Areas.Admin.Controllers.NoticiasController>(sp));
//builder.Services.AddScoped(sp => ActivatorUtilities.CreateInstance<EgateIntranet.Web.Controllers.NoticiasController>(sp));
//builder.Services.AddScoped(sp => ActivatorUtilities.CreateInstance<EgateIntranet.Web.Areas.Funcionarios.Controllers.DepartamentosController>(sp));
//builder.Services.AddScoped(sp => ActivatorUtilities.CreateInstance<EgateIntranet.Web.Controllers.HomeController>(sp));
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
