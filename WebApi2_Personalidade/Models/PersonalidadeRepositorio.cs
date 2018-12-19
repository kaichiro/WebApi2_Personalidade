using System;
using System.Collections.Generic;

namespace WebApi2_Personalidade.Models
{
    public class PersonalidadeRepositorio : IPersonalidadeRepositorio
    {
        private List<Personalidade> personalidades = new List<Personalidade>();
        private int _nextId = 1;

        public PersonalidadeRepositorio()
        {
            Add(new Personalidade { Nome = "João José", Nascimento = new DateTime(1968, 01, 22), Sexo = "M" });
            Add(new Personalidade { Nome = "Antônia Maria", Nascimento = new DateTime(1971, 12, 15), Sexo = "F" });
            Add(new Personalidade { Nome = "Franciso Nascimento", Nascimento = new DateTime(1986, 10, 23), Sexo = "M" });
            Add(new Personalidade { Nome = "Joana Vicente", Nascimento = new DateTime(2002, 12, 14), Sexo = "F" });
        }

        public Personalidade Add(Personalidade pers)
        {
            if (null == pers) { throw new ArgumentNullException("pers"); }
            pers.Id = _nextId++;
            personalidades.Add(pers);
            return pers;
        }

        public Personalidade GetById(long id) => personalidades.Find(p => p.Id == id);

        public IEnumerable<Personalidade> GetAll() => personalidades;

        public void Remove(long id) => personalidades.RemoveAll(p => p.Id == id);

        public bool Update(Personalidade pers)
        {
            if (null == pers) { throw new ArgumentNullException("pers"); }

            int index = personalidades.FindIndex(p => p.Id == pers.Id);

            if (-1 == index) { return false; }

            personalidades.RemoveAt(index);
            personalidades.Add(pers);
            return true;
        }
    }
}