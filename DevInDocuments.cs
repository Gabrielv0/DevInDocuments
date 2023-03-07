namespace devindocuments
{

    public class DevInDocuments
    {
        public int CodigoDocumento {get;set;}
        public string DataCadastroSistema {get;set;}

        public DateTime DataUltimaAlteracao {get;set;}
        
        public string NomeEstabelecimento {get;set;}

        public string CNPJ {get;set;}

        public int Status {get;set;}
        
        

        

        
    public DevInDocuments(int CodigoDocumento, string DataCadastroSistema, DateTime DataUltimaAlteracao,
                          string NomeEstabelecimento, string CNPJ, int Status)
                          {
                            this.CodigoDocumento = CodigoDocumento;
                            this.DataCadastroSistema = DataCadastroSistema;  
                            this.DataUltimaAlteracao = DataUltimaAlteracao;                          
                            this.NomeEstabelecimento = NomeEstabelecimento;
                            this.CNPJ = CNPJ;
                            this.Status = Status;
                          }

 

 

    
} 



}
