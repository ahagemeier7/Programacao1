namespace Cheque.Models
{
    public class Numero
    {
        public string[] unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        public string[] dezenas = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        public string[] especiais = { "", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove","cem","mil" };
        public string[] centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seicentos", "setecentos", "oitocentos", "novecentos" };
        public string[] milhares = { "", "mil" };
    }
}
