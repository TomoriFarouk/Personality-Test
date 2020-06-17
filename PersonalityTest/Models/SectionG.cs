using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Models
{
	public class SectionG
	{
		public int Id { get; set; }
		public int Shaper7 { get; set; }
		public int Coordinator7 { get; set; }
		public int Planter7 { get; set; }
		public int Resource7 { get; set; }
		public int Monitor7 { get; set; }
		public int Implementer7 { get; set; }
		public int Teamwork7 { get; set; }
		public int Finisher7 { get; set; }
		public ICollection<SectionH> sectionHs { get; set; }
		public ICollection<SectionB> sectionBs { get; set; }
		public ICollection<SectionF> sectionFs { get; set; }
		public ICollection<SectionE> sectionEs { get; set; }
		public ICollection <SectionD> sectionD { get; set; }
		public ICollection <SectionA> sectionA { get; set; }
		public ICollection <SectionC> sectionc { get; set; }
		public string AspNetUsersId { get; set; }
	}
}
