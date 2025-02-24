using SQLite;

namespace MeuAPPMinhas_Compras.Models
{
    public class Produto

    { 
        [PrimaryKey, AutoIncrement]
    
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public double Preço { get; set; }


    }
}
