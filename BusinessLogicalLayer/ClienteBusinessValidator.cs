using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    class ClienteBusinessValidator
    {
        public string Validar(Cliente cliente)
        {
            string erros = "";

            cliente.Nome = Normatization.NormatizeString(cliente.Nome);
            erros += CommonValidations.IsValidNome(cliente.Nome);

            erros += CommonValidations.IsEmail(cliente.Email, true);


            cliente.CPF = cliente.CPF?.Trim().Replace("-", "").Replace(".", "");
            erros += CommonValidations.IsCpf(cliente.CPF);

            cliente.Rua = Normatization.NormatizeString(cliente.Rua);
            erros += CommonValidations.IsValidRua(cliente.Rua);

            cliente.Bairro = Normatization.NormatizeString(cliente.Bairro);
            erros += CommonValidations.IsValidBairro(cliente.Bairro);

            cliente.Complemento = Normatization.NormatizeString(cliente.Complemento);
            erros += CommonValidations.IsValidComplementoNumero(cliente.Complemento, cliente.Numero);

            cliente.CEP = cliente.CEP?.Trim().Replace("-", "");
            erros += CommonValidations.IsValidCEP(cliente.CEP);

            cliente.Telefone = Normatization.NormatizeString(cliente.Telefone);
            erros += CommonValidations.IsValidTelefone(cliente.Telefone);

            cliente.EstadoCivil = Normatization.NormatizeString(cliente.EstadoCivil);
            erros += CommonValidations.IsValidEstadoCivil(cliente.EstadoCivil);

            cliente.Genero = Normatization.NormatizeString(cliente.Genero);
            erros += CommonValidations.IsValidGenero(cliente.Genero);

            erros += CommonValidations.IsValidAge(cliente.DataNascimento);

            if (erros != "")
            {
                return erros;
            }

            //Se chegou aqui, podemos jogar no banco de dados!

            return "";
        }
        

    }
}
