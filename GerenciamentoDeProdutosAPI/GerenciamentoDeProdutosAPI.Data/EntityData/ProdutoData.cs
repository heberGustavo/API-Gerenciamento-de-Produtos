using Dapper.Contrib.Extensions;

namespace GerenciamentoDeProdutosAPI.Data.EntityData
{
    [Table("TB_PRODUTO")]
    public class ProdutoData
    {
        [Key]
        public int ProId { get; set; }
        public string ProNome { get; set; }
        public string ProDescricao { get; set; }
        public decimal ProPreco { get; set; }
        public bool ProSituacao { get; set; }
        public int CatId { get; set; }
    }
}
