using PersonalityTest.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Models
{
	public class SectionA

	{
		public int Id { get; set; }
		public int Shaper1 { get; set; }
		public int Coordinator1 { get; set; }
		public int Planter1 { get; set; }
		public int Resource1 { get; set; }
		public int Monitor1 { get; set; }
		public int Implementer1 { get; set; }
		public int Teamwork1 { get; set; }
		public int Finisher1 { get; set; }
		public string AspNetUsersId { get; set; }
		public SectionG sectionGs { get; set; }
		public ICollection<SectionB> SectionBs { get; set; }
		public ICollection<SectionC> SectionCs { get; set; }
		public ICollection<SectionD> sectionDs { get; set; }
		public ICollection<SectionE> sectionEs { get; set; }
		public SectionF sectionFs { get; set; }
		public SectionH sectionH { get; set; }
	}
}
