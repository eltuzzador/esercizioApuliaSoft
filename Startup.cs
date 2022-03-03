
using esercizio1.Models.Services.Application;
using Esercizio1.Models.Services.Application;
using Microsoft.Extensions.DependencyInjection;
namespace esercizio1{
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {services.AddMvc(options => options.EnableEndpointRouting = false);
        //services.AddMvc(); //aggiungo i servizi necessari al funzionamento di Mvc

        //con Esercizio1Service posso istanziare dato che sto trattando una
    services.AddTransient<IEsercizio1Service,Esercizio1Service>();//nel caso in cui ci sia un componente che ha una dipendenza da questa interfaccia costruirò un Esercizio1Service
    
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())//se sono in ambiente di sviluppo
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        
        app.UseStaticFiles();
/*
        app.UseRouting();
app.UseHttpsRedirection();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
        });
        */
        
        
        app.UseMvc(routeBuilder=>{
    /*
    definisco la struttura dei percorsi che posso comprendere tramite {controller}/{action}/{id}
    dovrà costruitre un controller di nome "controller" (se manca usa Home) la cui action si chiamerà "action" (default:Index) passando eventualmente un id(che è opzionale quindi "?")
    */
    routeBuilder.MapRoute("default","{controller=Home}/{action=Index}/{id?}");
});

//per sintetizzare app.UseMvc ---> //app.UseMvcWithDefaultRoute(); stabilire una route di default
    }
}
}