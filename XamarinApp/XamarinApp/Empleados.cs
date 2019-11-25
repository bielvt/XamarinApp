using SQLite;

namespace XamarinApp
{    public class Empleados

    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Salario { get; set; }
    }
}

