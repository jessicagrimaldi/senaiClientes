using System;

namespace clientesPFePJ

{

    class Program

    {
        static void Main(string)[] args)

        {   //PARA PESSOA FÍSICA
            Endereco end = new Endereco();
            end.logradouro = "Rua Mario";
            end.numero = 30;
            end.complemento = "Próximo ao Mercado Extra"
            end.enderecoComercial = false;

            PessoaFisica novapf = new PessoaFísica();
            novapf.endereco = end;
            novapf.cpf = "85618590473"
            novapf.dataNascimento =new DateTime(1994,05,19);
            novapf.nome = "Pessoa Física"
            
            //console.Writeline(novapf.endereco.logradouro)
            //console.Writeline(novapf.endereco.numero)

            console.Writeline($"Rua: {novapf.endereco.logradouro}, {novapf.endereco.numero}");

            PessoaFisica pf =  new PessoaFisica();
            // console.Writeline(pf.ValidarDataNascimento(pf.dataNascimento));

            bool idadeValida = pf.ValidarDataNascimento(novapf.dataNascimento);
            console.Writeline(idadeValida);

            if (idadeValida == true)

            {
                System.console.Writeline($"Cadastro Aprovado");

            }


            else { 
                console.Writeline($"Cadastro Reprovado")
            }

            //PARA PESSOA JURIDICA

            Endereco end = new Endereco();
            end.logradouro = "Rua Mario";
            end.numero = 30;
            end.complemento = "Próximo ao Mercado Extra"
            end.enderecoComercial = true;

            PessoaJuridica novapj = new PessoaJuridica();
            novapj.endereco = end;
            novapj.cnpj = "12345678990001";
            novapj.razaoSocial = "LTDA";

            
            if (pj.ValidarCNPJ(novacnpj.cnpj)) 
            {
                console.Writeline("CNPJ Válido");
             }
             else
             {
                 console.Writeline("CNPJ Inválido")
             }
            
        }

    }
}