using AHAS.PO.INFRA.CROSS.GLOBALIZING;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Specification.Feriado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.LOGIC.DOMAIN.Validator.Feriado
{
    public class FeriadoValidate
    {
        private readonly IFeriadoRepository repository;
        private readonly Entities.Feriado feriado;

        public FeriadoValidate(IFeriadoRepository _feriadoRepository, Entities.Feriado _feriado)
        {
            repository = _feriadoRepository;
            feriado = _feriado;
        }

        public bool AlterarFeriadoNaoValido()
        {
            feriado.Sucesso = true;
            feriado.MensagemValidacao.Add(Resources.Validacao_Feriado_Editar_Sucesso);

            return false;
        }

        public bool NovoFeriadoNaoValido()
        {
            if (!new FeriadoUnicoSpecification(repository).IsSatisfied(feriado))
            {
                feriado.Sucesso = false;
                feriado.MensagemValidacao.Add(Resources.Validacao_Feriado_Repetido);
                return true;
            }

            feriado.Sucesso = true;
            feriado.MensagemValidacao.Add(Resources.Validacao_Feriado_Novo_Sucesso);

            return false;
        }
    }
}
