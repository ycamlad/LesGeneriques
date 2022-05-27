

namespace LesGeneriques
{
    public class Salle
    {
        private int _id;
        private string _code;
        private string _libelle;
        private static int _counter = 1;

        public Salle( string code, string libelle)
        {
            _id = _counter++;
            _code = code;
            _libelle = libelle;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Code
        {
            get => _code;
            set => _code = value;
        }

        public string Libelle
        {
            get => _libelle;
            set => _libelle = value;
        }

        public static int Counter
        {
            get => _counter;
            set => _counter = value;
        }

        public override string ToString()
        {
            return "\nID: " + _id + "\nCode: " + _code + "\nLibelle: " + _libelle;
        }
        
        
    }
   
}