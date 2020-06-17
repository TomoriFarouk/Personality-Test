using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Models
{
	public class SectionF

	{
		public int Id { get; set; }
		public int Shaper6 { get; set; }
		public int Coordinator6 { get; set; }
		public int Planter6 { get; set; }
		public int Resource6 { get; set; }
		public int Monitor6 { get; set; }
		public int Implementer6 { get; set; }
		public int Teamwork6 { get; set; }
		public int Finisher6 { get; set; }
		public ICollection<SectionH> sectionHs { get; set; }
		public ICollection<SectionB> sectionBs { get; set; }
		public  SectionC sectionCs { get; set; }
		public SectionE sectionEs { get; set; }
		public SectionD sectionD { get; set; }
		public ICollection <SectionA> sectionA { get; set; }
		public SectionG sectionG { get; set; }
		public string AspNetUsersId { get; set; }
	}
}
