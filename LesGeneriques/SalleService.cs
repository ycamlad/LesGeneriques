using System.Collections.Generic;

namespace LesGeneriques
{
    public class SalleService : IDao<Salle>
    {
        private readonly List<Salle> _lesSalles;

        public SalleService()
        {
            _lesSalles = new List<Salle>();
        }
        

        public void Create(Salle o)
        {
            _lesSalles.Add(o);
        }

        public bool Delete(Salle o)
        {
          return _lesSalles.Remove(o); 
        }

        public bool Update(Salle o)
        {
            foreach (Salle s in _lesSalles)
            {
                if (s.Id == o.Id)
                {
                    s.Code = o.Code;
                    s.Libelle = o.Libelle;
                    return true;
                }
            }
            return false;
        }

        public Salle FindById(int id)
        {
            foreach (Salle s in _lesSalles)
            {
                if (s.Id == id)
                    return s;
            }
            return null;
        }

        public List<Salle> FindAll()
        {
            return _lesSalles;
        }
    }
}