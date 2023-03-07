namespace devindocuments
{
    public class LicencasFuncionamento : DevInDocuments
    {
        public string Endereco { get; set; }
        public int AreaAtuacao { get; set; }



        public LicencasFuncionamento(int CodigoDocumento, string DataCadastroSistema, DateTime DataUltimaAlteracao,
                               string NomeEstabelecimento, string CNPJ, int Status, string Endereco, int AreaAtuacao)
                               : base(CodigoDocumento, DataCadastroSistema,DataUltimaAlteracao, NomeEstabelecimento, CNPJ, Status)
        {
            this.Endereco = Endereco;
            this.AreaAtuacao = AreaAtuacao;

        }

         public void AdicionaLista(LicencasFuncionamento licenca)
        {
            Lists.Licencas.Add(licenca);
        }
    }
}