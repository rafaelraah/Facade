namespace DesignPatterns
{
    public class Pagamento
    {
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public MeioPagamento MeioPagamento { get; set; }

        // Apenas para exemplificar, os possiveis meios de pagamento foram implementados direto 
        // na classe de pagamento por questões de brevidade do exemplo
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public string ConfirmacaoTransferencia { get; set; }
    }
}