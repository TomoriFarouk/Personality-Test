using PersonalityTest.Data;
using PersonalityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Repository
{
	public class QuestionRepository
	{
		private readonly ApplicationDbContext _context;

		public QuestionRepository(ApplicationDbContext context)
		{
			_context = context;
		}

		public void Create(SectionA sectionA)
		{
			_context.Set<SectionA>().AddAsync(sectionA);
			_context.SaveChanges();
		}

	}
}
