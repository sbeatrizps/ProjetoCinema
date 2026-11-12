using CinemaApp.Cadastros;
using CinemaApp.Models;
using CinemaDomain;
using AutoMapper;
using CinemaRepository.Base;
using CinemaRepository.Context;
using CinemaService.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;

namespace CinemaApp.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection Services;
        public static IServiceProvider ServiceProvider;
        public static void Configure()
        {
            Services = new ServiceCollection();

            #region Banco de Dados Injeção de Dependência            
            var strCon = File.ReadAllText("Config/ConfigDB.txt");
            Services.AddDbContext<MyDBContext>(options => options.UseNpgsql(strCon));
            #endregion

            #region Repositórios Injeção de Dependência
            Services.AddScoped<IBaseRepository<Genero>, BaseRepository<Genero>>();
            Services.AddScoped<IBaseRepository<Filme>, BaseRepository<Filme>>();
            Services.AddScoped<IBaseRepository<Sala>, BaseRepository<Sala>>();
            Services.AddScoped<IBaseRepository<Sessao>, BaseRepository<Sessao>>();
            Services.AddScoped<IBaseRepository<Ingresso>, BaseRepository<Ingresso>>();
            #endregion

            #region Serviços Injeção de Dependência
            Services.AddScoped<IBaseService<Genero>, BaseService<Genero>>();
            Services.AddScoped<IBaseService<Filme>, BaseService<Filme>>();
            Services.AddScoped<IBaseService<Sala>, BaseService<Sala>>();
            Services.AddScoped<IBaseService<Sessao>, BaseService<Sessao>>();
            Services.AddScoped<IBaseService<Ingresso>, BaseService<Ingresso>>();
            #endregion

            #region AutoMapper Injeção de Dependência
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Genero, GeneroViewModel>().ReverseMap();
                config.CreateMap<Filme, FilmeViewModel>()
                    .ForMember(dest => dest.GeneroId, opt => opt.MapFrom(src => src.Genero.Id))
                    .ForMember(dest => dest.GeneroNome, opt => opt.MapFrom(src => src.Genero.Nome));
                config.CreateMap<Sala, SalaViewModel>().ReverseMap();
                config.CreateMap<Sessao, SessaoViewModel>()
                    .ForMember(dest => dest.FilmeId, opt => opt.MapFrom(src => src.Filme.Id))
                    .ForMember(dest => dest.FilmeNome, opt => opt.MapFrom(src => src.Filme.Nome))
                    .ForMember(dest => dest.SalaId, opt => opt.MapFrom(src => src.Sala.Id))
                    .ForMember(dest => dest.SalaNumero, opt => opt.MapFrom(src => src.Sala.Numero))
                    .ForMember(dest => dest.Data, opt => opt.MapFrom(src => src.Data.ToLocalTime()));
                config.CreateMap<Ingresso, IngressoViewModel>()
                    .ForMember(dest => dest.SessaoId, opt => opt.MapFrom(src => src.Sessao.Id))
                    .ForMember(dest => dest.FilmeNome, opt => opt.MapFrom(src => src.Sessao.Filme.Nome))
                    .ForMember(dest => dest.SessaoData, opt => opt.MapFrom(src => src.Sessao != null ? src.Sessao.Data.ToLocalTime() : default))
                    .ForMember(dest => dest.SalaNumero, opt => opt.MapFrom(src => src.Sessao.Sala.Numero))
                    .ForMember(dest => dest.DataCompra, opt => opt.MapFrom(src => src.DataCompra.ToLocalTime()))
                    .ForMember(dest => dest.Quantidade, opt => opt.MapFrom(src => src.IngressoItens != null ? src.IngressoItens.Count : 0));
                config.CreateMap<IngressoItem, IngressoItemViewModel>().ReverseMap();
            }, NullLoggerFactory.Instance);

            Services.AddSingleton(mapperConfig.CreateMapper());

            #endregion

            #region Injeção de Dependência de Formulários
            Services.AddTransient<CadastroGenero, CadastroGenero>();
            Services.AddTransient<CadastroFilme, CadastroFilme>();
            Services.AddTransient<CadastroSala, CadastroSala>();
            Services.AddTransient<CadastroSessao, CadastroSessao>();
            Services.AddTransient<CadastroIngresso, CadastroIngresso>();
            #endregion

            ServiceProvider = Services.BuildServiceProvider();
        }
    }
}