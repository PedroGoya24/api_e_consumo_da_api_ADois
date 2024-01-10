using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_adois.Models;
using Microsoft.EntityFrameworkCore;

namespace api_adois.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Destinos> Destinos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Destinos>().HasData(
                new Destinos { IdDes = 1, NomeDes = "Rio de Janeiro", ImgDestino = "https://blog.123milhas.com/wp-content/uploads/2023/03/aniversario-do-rio-de-janeiro-conheca-quatro-curiosidades-sobre-a-cidade-conexao123.jpg", PrecoDest = 300 },
                new Destinos { IdDes = 2, NomeDes = "Salvador", ImgDestino = "https://revistaazul.voeazul.com.br/wp-content/uploads/2023/03/conheca-salvador-e-se-apaixone-pela-capital-baiana.jpeg", PrecoDest = 300 },
                new Destinos { IdDes = 3, NomeDes = "Foz do Iguaçu", ImgDestino = "https://wordpress-network.prod.aws.skyscnr.com/wp-content/uploads/2018/05/GettyImages-488388458.jpg", PrecoDest = 350 },
                new Destinos { IdDes = 4, NomeDes = "Guarujá", ImgDestino = "https://www.falandodeviagem.com.br/imagens22/Guaruja.jpg", PrecoDest = 100 },
                new Destinos { IdDes = 5, NomeDes = "Londres", ImgDestino = "https://media.tacdn.com/media/attractions-splice-spp-674x446/09/93/6a/89.jpg", PrecoDest = 1000 },
                new Destinos { IdDes = 6, NomeDes = "Nova York", ImgDestino = "https://www.remessaonline.com.br/blog/wp-content/uploads/2022/06/morar-em-nova-york-1170x777.jpg.webp", PrecoDest = 2300 },
                new Destinos { IdDes = 7, NomeDes = "Bali", ImgDestino = "https://www.kayak.com.br/rimg/himg/4f/2d/0e/leonardo-2672017-DPSHA_4636182078_O-333430.jpg?width=1366&height=768&crop=true", PrecoDest = 2000 },
                new Destinos { IdDes = 8, NomeDes = "Dubai", ImgDestino = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRq5O8R9NyYOH6bOyYwCCMj4cu7ymj6PMLd1M1ySCdUfesRAZs6_ZyM-6GVV003r8JwZO0&usqp=CAU", PrecoDest = 3300 },
                new Destinos { IdDes = 9, NomeDes = "Japão", ImgDestino = "https://blog.123milhas.com/wp-content/uploads/2023/08/brasileiros-na%CC%83o-precisam-mais-de-visto-para-turismo-no-japa%CC%83o-monte-fuji-conexa%CC%83o123.jpg", PrecoDest = 1500 },
                new Destinos { IdDes = 10, NomeDes = "Veneza", ImgDestino = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSo1wwNTG-MmPHGs2qVivurSlcz1LFNeYyg4BwhVwNcm2-wRWqrLwzkr5SVmEufdSQEuIg&usqp=CAU", PrecoDest = 2000 },
                new Destinos { IdDes = 11, NomeDes = "Paris", ImgDestino = "https://www.passagenspromo.com.br/blog/wp-content/uploads/2019/04/viagem-para-paris.jpg", PrecoDest = 1500 },
                new Destinos { IdDes = 12, NomeDes = "Egito", ImgDestino = "https://blog.abreutur.com.br/wp-content/uploads/2022/01/CAPA_Egito.jpg", PrecoDest = 900 },
                new Destinos { IdDes = 13, NomeDes = "Indonésia", ImgDestino = "https://www.adventureclub.com.br/wp-content/uploads/2022/06/Bali-Indonesia-topo.jpg", PrecoDest = 1500 },
                new Destinos { IdDes = 14, NomeDes = "Maldivas", ImgDestino = "https://dynl.mktgcdn.com/p/PdKIFm42x4ilTlmQqIo-hn9SeaU0eEOojHALpH1XPwc/540x450.jpg", PrecoDest = 3300 },
                new Destinos { IdDes = 15, NomeDes = "Austrália", ImgDestino = "https://www.remessaonline.com.br/blog/wp-content/uploads/2022/03/abrir-uma-empresa-na-Australia-1-2-1200x675.jpg", PrecoDest = 2300 }

            );
        }
    }
}