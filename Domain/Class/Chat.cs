using System.Collections.Generic;

namespace Domain
{
    public class Chat
    {
        public string Descricao { get; set; }
        public Local Local { get; set; }
        public List<string> Mensagens { get; set; }
    }
}