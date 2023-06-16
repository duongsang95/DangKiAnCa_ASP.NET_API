namespace Presentations.Models
{
    public class Meals
    {
        public int MealId { get; set; }
        public string? MealName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
