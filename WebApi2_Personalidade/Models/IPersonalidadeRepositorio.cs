using System.Collections.Generic;

namespace WebApi2_Personalidade.Models
{
    interface IPersonalidadeRepositorio
    {
        IEnumerable<Personalidade> GetAll();
        Personalidade GetById(long id);
        Personalidade Add(Personalidade pers);
        void Remove(long id);
        bool Update(Personalidade pers);
    }
}
