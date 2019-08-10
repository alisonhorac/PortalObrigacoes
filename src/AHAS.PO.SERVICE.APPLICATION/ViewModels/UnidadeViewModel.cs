using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AHAS.PO.INFRA.CROSS.GLOBALIZING;

namespace AHAS.PO.SERVICE.APPLICATION.ViewModels
{
    public class UnidadeViewModel
    {
        [Key]
        public long IDUnidade { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [MaxLength(14, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MaxLenght")]
        [MinLength(14, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MinLenght")]
        [DisplayName("Número do CNPJ")]
        public string CNPJ { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [MaxLength(14, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MaxLenght")]
        [MinLength(2, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MinLenght")]
        [DisplayName("Inscrição Estadual")]
        public string InscricaoEstadual { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_Required")]
        [MaxLength(200, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MaxLenght")]
        [MinLength(2, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "Global_MinLenght")]
        [DisplayName("Nome da Unidade")]
        public string Nome { get; set; }

        [DisplayName("Data Última Atualização")]
        public DateTime DataAtualizacao { get; set; }

        [DisplayName("Data do Cadastro")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo")]
        public bool FlagAtivo { get; set; }

        public List<string> MensagemValidacao { get; set; }

        public bool Sucesso { get; set; }
    }
}
