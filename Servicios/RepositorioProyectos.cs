using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
              Titulo = "Amazon",
              Descripcion = "E-Comerce realizado en ASP.NET Core",
              Link = "https://amazon.com",
              ImagenURL = "/imagen/amazon.jpeg"
            },
                new Proyecto
            {
              Titulo = "New York Times",
              Descripcion = "Pagina de noticias en React",
              Link = "https://nytimes.com",
              ImagenURL = "/imagen/nyt.jpeg"
            },
                new Proyecto
            {
              Titulo = "Reddit",
              Descripcion = "Red social para compartir en comunidades",
              Link = "https://reddit.com",
              ImagenURL = "/imagen/reddit.jpeg"
            },
                new Proyecto
            {
              Titulo = "Steam",
              Descripcion = "Tienda en linea para comprar videojuegos",
              Link = "https://store.steampowered.com",
              ImagenURL = "/imagen/steam.jpeg"
            },
            };
        }
    }
}
