﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models {
	public class OfficeAssignment {
		[Key]
		[ForeignKey("Instrutor")]
		public int InstructorID { get; set; }
		[StringLength(50)]
		[Display(Name = "Office Location")]
		public string Location { get; set; }

		public virtual Instructor Instructor { get; set; }
	}
}