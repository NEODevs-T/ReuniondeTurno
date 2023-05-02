namespace ReunionWeb.DTOs
{
    public class CalendarioTrabajoDTO
    {
        public int IdReuDia { get; set; }
        public string? RdcodEq { get; set; }
        public string? Rddisc { get; set; }
        public string? RdcodDis { get; set; }
    
        public string? Rdtiempo { get; set; }
        public string? Rdstatus { get; set; }
        public string? Rdodt { get; set; }

        public string? RdnumDis { get; set; }

        public DateTime RdfecReu { get; set; }

        public DateTime RdfecTra { get; set; }

  
    }
}