namespace Domain
{
    public class Aviso
    {
        public TipoAviso TipoAviso { get; set; }
        public string Descricao { get; set; }
        public Local Local { get; set; }
        public Chat Chat { get; set; }
    }
}