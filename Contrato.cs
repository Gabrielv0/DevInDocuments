namespace devindocuments
{
    public class Contrato : DevInDocuments
    {
        public string Finalidade { get; set; }

        public string Testemunhas { get; set; }

        public string DataExpiracao { get; set; }



        public Contrato(int CodigoDocumento, string DataCadastroSistema,DateTime DataUltimaAlteracao,
                              string NomeEstabelecimento, string CNPJ, int Status, string Finalidade, string Testemunhas, string DataExpiracao) :
                              base(CodigoDocumento, DataCadastroSistema,DataUltimaAlteracao, NomeEstabelecimento, CNPJ, Status)
        {
            this.Finalidade = Finalidade;
            this.Testemunhas = Testemunhas;
            this.DataExpiracao = DataExpiracao;
        }

        public void AdicionaLista(Contrato contrato)
        {
            Lists.Contrato.Add(contrato);
        }
    }


}