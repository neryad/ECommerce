using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
	public class City
	{
		[Key]
		public int CityId { get; set; }

		[Required(ErrorMessage = "This filed {0} is required")]
		[MaxLength(50, ErrorMessage = "the filed {0} must be a leat {1} character lenght")]
		[Display(Name = "City")]
		public string Name { get; set; }

		[Required(ErrorMessage = "This filed {0} is required")]
		public int DepartmentId { get; set; }

		public virtual Department Department { get; set; }
	}
}