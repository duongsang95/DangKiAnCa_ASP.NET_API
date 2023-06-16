namespace Presentations.Models
{
    public class MealRegisters
    {
        public int MealRegisterId { get; set; }
        public int RegistedbyUserId { get; set; }
        public int RegistedforUserId { get; set; }
        public int MealId { get; set; }
        public int RegisterQuantity { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
