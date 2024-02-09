namespace MethodOverride
{
	public class CommissionEmployeeModel : EmployeeModel
	{
		public decimal CommissionAmount
		{
			get; set;
		}

		public override decimal PaycheckAmount(int hoursWorked)
		{
			decimal basepay = base.PaycheckAmount(hoursWorked);

			return basepay + CommissionAmount;
		}
	}
}
