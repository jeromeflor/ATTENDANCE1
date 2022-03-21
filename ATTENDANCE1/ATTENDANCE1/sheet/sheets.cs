using System.ComponentModel.DataAnnotations;
namespace ATTENDANCE1.sheet
{
    public class sheets
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime TimeIn { get; set; }
        public string Purpose { get; set; } = string.Empty;
        public decimal TimeOut { get; set; }
    }
}
