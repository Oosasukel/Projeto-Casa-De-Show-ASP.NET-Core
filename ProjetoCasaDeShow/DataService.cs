using ProjetoCasaDeShow.Models;
using ProjetoCasaDeShow.Repositories;

namespace ProjetoCasaDeShow
{
    public interface IDataService
    {
        void TestaDB();
        IEventoRepository GetEventoRepository();
        ICasaDeShowRepository GetCasaDeShowRepository();
    }

    public class DataService : IDataService
    {
        private IEventoRepository eventoRepository;
        private ICasaDeShowRepository casaDeShowRepository;

        private AppContext contexto;

        public DataService(IEventoRepository eventoRepository, ICasaDeShowRepository casaDeShowRepository, AppContext contexto)
        {
            this.eventoRepository = eventoRepository;
            this.casaDeShowRepository = casaDeShowRepository;
            this.contexto = contexto;
        }

        public ICasaDeShowRepository GetCasaDeShowRepository()
        {
            return casaDeShowRepository;
        }

        public IEventoRepository GetEventoRepository()
        {
            return eventoRepository;
        }

        public void TestaDB()
        {
            
        }
    }
}