namespace Classes.Models
{
    public class ProcedimentosModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string dataProcedimento {  get; set; }
        public int? ValorCobrado { get; set; }
        public VeterinariosModel Veterinario { get; set; }
        public AnimaisModel Animal { get; set; } 
    }
}
