namespace clientesPFePJ

{

    public class PessoaJuridica:Pessoa;
    {
        public string cnpj {get;set;}


    public bool ValidarCNPJ (string cnpj) {
                
        if (cnpj.Length >= 14 && cnpj.Substring( cnpj.Length-4 ) == "0001") {
           return true;

        } else {
            return false;

        }
    }
        public string razaoSocial {get;set;}


    }
}