namespace WaterIntake
{
    public class WaterIntakeTableRecord
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Litres { get; set; }

        public override string ToString()
            => $"Id: {Id}, Date: {Date:dd-MMM-yyyy}, Litres: {Litres}";
    }
}
