using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Models
{
	public class SectionE
	{
		public int Id { get; set; }
		public int Shaper5 { get; set; }
		public int Coordinator5 { get; set; }
		public int Planter5 { get; set; }
		public int Resource5 { get; set; }
		public int Monitor5 { get; set; }
		public int Implementer5 { get; set; }
		public int Teamwork5 { get; set; }
		public int Finisher5 { get; set; }
		public ICollection<SectionH> sectionHs { get; set; }
		public ICollection<SectionB> sectionBs { get; set; }
		public ICollection<SectionF> sectionFs { get; set; }
		public ICollection<SectionC> sectionCs { get; set; }
		public SectionD sectionD { get; set; }
		public SectionA sectionA { get; set; }
		public SectionG sectionG { get; set; }
		public string AspNetUsersId { get; set; }
	}
}
