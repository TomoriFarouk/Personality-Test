using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Models
{
	public class SectionC
	{
		public int Id { get; set; }
		public int Shaper3 { get; set; }
		public int Coordinator3 { get; set; }
		public int Planter3 { get; set; }
		public int Resource3 { get; set; }
		public int Monitor3 { get; set; }
		public int Implementer3 { get; set; }
		public int Teamwork3 { get; set; }
		public int Finisher3 { get; set; }
		public SectionH sectionHs { get; set; }
		public ICollection<SectionB> sectionBs { get; set; }
		public ICollection<SectionF> sectionFs { get; set; }
		public SectionE sectionEs { get; set; }
		public SectionD sectionD { get; set; }
		public SectionA sectionA { get; set; }
		public SectionG sectionG { get; set; }
		public string AspNetUsersId { get; set; }


	}
}
