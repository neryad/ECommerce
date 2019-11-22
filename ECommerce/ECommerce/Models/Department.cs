using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
	public class Department
	{
		[Key]
		public int DepartmentId { get; set; }
		[Required(ErrorMessage ="This filed {0} is required")]
		[MaxLength(50, ErrorMessage ="the filed {0} must be a leat {1} character lenght")]
		[Display(Name ="Deparment")]
		public string Name { get; set; }

		public virtual ICollection<City> Cities { get; set; }
	}
}