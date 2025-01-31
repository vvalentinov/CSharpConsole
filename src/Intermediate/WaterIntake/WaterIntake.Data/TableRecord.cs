namespace WaterIntake.Data
{
    public class TableRecord
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public decimal Litres { get; set; }

        public override string ToString()
            => $"Id: {Id}, Date: {Date.ToString(DbConstants.TableDateColumnFormat)}, Litres: {Litres}";
    }
}
