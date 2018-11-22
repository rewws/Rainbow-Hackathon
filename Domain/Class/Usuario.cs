using System.Collections.Generic;

namespace Domain
{
    public class Usuario
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<Local> Locais { get; set; }
    }
}
