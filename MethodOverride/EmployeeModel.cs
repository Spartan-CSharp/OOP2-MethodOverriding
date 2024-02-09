namespace MethodOverride
{
	public class EmployeeModel : PersonModel
	{
		public decimal HourlyPayRate
		{
			get; set;
		}

		public virtual decimal PaycheckAmount(int hoursWorked)
		{
			return hoursWorked * HourlyPayRate;
		}
	}
}
