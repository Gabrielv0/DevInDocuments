namespace devindocuments
{
    public class NotaFiscal : DevInDocuments
    {
        public double ValorTotal { get; set; }
        public string NomeProduto { get; set; }

        public int TipoImposto { get; set; }

        public double ValorTotalImposto { get; set; }

        

        


        public NotaFiscal(int CodigoDocumento, string DataCadastroSistema, DateTime DataUltimaAlteracao,
                              string NomeEstabelecimento, string CNPJ, int Status, double ValorTotal, string NomeProduto, int TipoImposto, double ValorTotalImposto)
                              : base(CodigoDocumento, DataCadastroSistema, DataUltimaAlteracao, NomeEstabelecimento, CNPJ,Status)
        {
            this.ValorTotal = ValorTotal;
            this.NomeProduto = NomeProduto;
            this.TipoImposto = TipoImposto;
            this.ValorTotalImposto = ValorTotalImposto;
        }


         public void AdicionaLista(NotaFiscal notafiscal)
        {
            Lists.NotaFiscal.Add(notafiscal);
        }

        
    }
}