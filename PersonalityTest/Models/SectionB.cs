using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Models
{
	public class SectionB
	{
		public int Id { get; set; }
		public int Shaper2 { get; set; }
		public int Coordinator2 { get; set; }
		public int Planter2 { get; set; }
		public int Resource2 { get; set; }
		public int Monitor2 { get; set; }
		public int Implementer2 { get; set; }
		public int Teamwork2 { get; set; }
		public int Finisher2 { get; set; }
		public SectionH sectionH { get; set; }
		public  SectionF sectionF { get; set; }
		public SectionC sectionC { get; set; }
		public SectionD sectionD { get; set; }
		public SectionA sectionA { get; set; }
		public SectionG sectionG { get; set; }
		public SectionE sectionE { get; set; }
		public string AspNetUsersId { get; set; }
	}
}
