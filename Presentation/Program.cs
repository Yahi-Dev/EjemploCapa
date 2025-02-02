using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BD;

class Program
{
    static void Main(string[] args)
    {
        var builder = Host.CreateDefaultBuilder(args)
             .ConfigureServices((context, services) =>
             {
                 services.Connection(); 
                 services.AddScoped<CarroServiceDB>(); 
             })
             .Build();

        var carroService = builder.Services.GetRequiredService<CarroServiceDB>();

        carroService.AddCarro(new Entidades.CarroDTO
        {
            Marca = "Toyota",
            Modelo = "Corolla",
            Ano = 2020,
            Tipo = "Sedán"
        });

        var carros = carroService.GetCarros();
        foreach (var carro in carros)
        {
            Console.WriteLine($"Marca: {carro.Marca}, Modelo: {carro.Modelo}, Año: {carro.Ano}, Tipo: {carro.Tipo}");
        }
    }
}
