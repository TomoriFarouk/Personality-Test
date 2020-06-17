
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Models
{
	public class SectionH
	{
		public int Id { get; set; }
		public int Shaper8 { get; set; }
		public int Coordinator8 { get; set; }
		public int Planter8 { get; set; }
		public int Resource8 { get; set; }
		public int Monitor8 { get; set; }
		public int Implementer8 { get; set; }
		public int Teamwork8 { get; set; }
		public int Finisher8 { get; set; }
		public ICollection<SectionC> sectionCs { get; set; }
		public ICollection <SectionB> sectionBs { get; set; }
		public SectionF sectionFs { get; set; }
		public SectionE sectionEs { get; set; }
		public SectionD sectionD { get; set; }
		public ICollection <SectionA> sectionA { get; set; }
		public SectionG sectionG { get; set; }
	}
}
