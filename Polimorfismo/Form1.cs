
namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        private void InitializeComponent()
        {
            Nombre = new TextBox();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.Location = new Point(124, 145);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(100, 23);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(Nombre);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
    // Clase base abstracta para todos los empleados
    public abstract class Empleado
    {
        public string Nombre { get; set; }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        // Método abstracto para calcular el salario, implementado en las clases derivadas
        public abstract double CalcularSalario();
    }

    // Clase para Docentes por Hora
    public class DocentePorHora : Empleado
    {
        public int HorasTrabajadas { get; set; }
        private const double TarifaPorHora = 800;

        public DocentePorHora(string nombre, int horasTrabajadas) : base(nombre)
        {
            HorasTrabajadas = horasTrabajadas;
        }

        // Implementación del cálculo del salario para docentes por hora
        public override double CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }

    // Clase para Docentes de Contrato Fijo
    public class DocenteFijo : Empleado
    {
        public double SalarioBase { get; set; }
        public bool AlcanzoMeta { get; set; }

        public DocenteFijo(string nombre, double salarioBase, bool alcanzoMeta) : base(nombre)
        {
            SalarioBase = salarioBase;
            AlcanzoMeta = alcanzoMeta;
        }

        // Implementación del cálculo del salario para docentes fijos
        public override double CalcularSalario()
        {
            return AlcanzoMeta ? SalarioBase : SalarioBase / 2;
        }
    }

    // Clase para Empleados Administrativos
    public class Administrativo : Empleado
    {
        public double SalarioBase { get; set; }
        public bool AlcanzoMeta { get; set; }

        public Administrativo(string nombre, double salarioBase, bool alcanzoMeta) : base(nombre)
        {
            SalarioBase = salarioBase;
            AlcanzoMeta = alcanzoMeta;
        }

        // Implementación del cálculo del salario para empleados administrativos
        public override double CalcularSalario()
        {
            return AlcanzoMeta ? SalarioBase : SalarioBase / 2;
        }
    
    }
}

