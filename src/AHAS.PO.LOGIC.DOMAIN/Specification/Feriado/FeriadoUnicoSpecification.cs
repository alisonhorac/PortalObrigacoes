using AHAS.PO.LOGIC.DOMAIN.Entities;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AHAS.PO.LOGIC.DOMAIN.Specification.Feriado
{
    public class FeriadoUnicoSpecification : ISpecification<Entities.Feriado>
    {
        private readonly IFeriadoRepository _feriadoRepository;

        public FeriadoUnicoSpecification(IFeriadoRepository feriadoRepository)
        {
            _feriadoRepository = feriadoRepository;
        }

        public bool IsSatisfied(Entities.Feriado entity)
        {
            return _feriadoRepository.ValidarFeriadoExiste(entity.DataDe, entity.DataAte, entity.FlagFeriadoFixo, entity.IDAbrangencia, entity.IDEstado) == null;
        }
    }
}
