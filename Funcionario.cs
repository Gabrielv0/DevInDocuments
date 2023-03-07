namespace devindocuments
{
    public class Funcionario
    {
        private string codigo;
        private string nome; 
        private string endereco;
        private string dataNascimento;
        private string filiacao;
        private DateTime dataAdmissao;
    

    public Funcionario(string codigo, string nome, string endereco,
                        string dataNascimento, string filiacao, DateTime dataAdmissao)
    {
        this.codigo = codigo;
        this.nome = nome;
        this.endereco = endereco;
        this.dataNascimento = dataNascimento;
        this.filiacao = filiacao;
        this.dataAdmissao = dataAdmissao;
    }

    public string getNome(){
        return this.nome;
    }
}
}