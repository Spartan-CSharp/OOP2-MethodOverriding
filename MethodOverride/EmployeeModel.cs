using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
