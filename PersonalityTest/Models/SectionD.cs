using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Models
{
	public class SectionD
	{
		public int Id { get; set; }
		public int Shaper4 { get; set; }
		public int Coordinator4 { get; set; }
		public int Planter4 { get; set; }
		public int Resource4 { get; set; }
		public int Monitor4 { get; set; }
		public int Implementer4 { get; set; }
		public int Teamwork4 { get; set; }
		public int Finisher4 { get; set; }
		public ICollection<SectionH> sectionHs { get; set; }
		public ICollection<SectionB> sectionBs { get; set; }
		public ICollection<SectionF> sectionFs { get; set; }
		public ICollection<SectionE> sectionEs { get; set; }
		public ICollection <SectionD> sectionD { get; set; }
		public SectionA sectionA { get; set; }
		public SectionG sectionG { get; set; }
		public string AspNetUsersId { get; set; }
	}
}
