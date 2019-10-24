namespace Tic_Tac_Toe.Models
{
    public class Cell
    {
        public int Id { get; set; }
        public virtual Row Row {get;set;}
    }
}