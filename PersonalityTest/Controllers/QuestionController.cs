using Microsoft.AspNetCore.Mvc;
using PersonalityTest.Data;
using PersonalityTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalityTest.Controllers
{
	public class QuestionController : Controller
	{
		private ApplicationDbContext _context;

		public QuestionController(ApplicationDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult SectionA()
		{
			return View();
		}
		[HttpGet]
		public IActionResult SectionB()
		{
			return View();
		}
		[HttpGet]
		public IActionResult SectionC()
		{
			return View();
		}
		[HttpGet]
		public IActionResult SectionD()
		{
			return View();
		}
		[HttpGet]
		public IActionResult SectionE()
		{
			return View();
		}
		[HttpGet]
		public IActionResult SectionF()
		{
			return View();
		}
		[HttpGet]
		public IActionResult SectionG()
		{
			return View();
		}
		[HttpGet]
		public IActionResult SectionH()
		{
			return View();
		}
		[HttpPost]
		[HttpGet]
		public IActionResult Error()
		{
			return View();
		}
	
		public IActionResult SectionA([FromForm] SectionA secA, string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			var test = User.Claims.ToList()
			.Where(u => u.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"))
			.FirstOrDefault().Value;
			var Ans = secA.Shaper1 + secA.Coordinator1 + secA.Planter1 + secA.Monitor1 + secA.Resource1 + secA.Implementer1 + secA.Teamwork1 + secA.Finisher1;
			if (Ans != 10)
			{
				return RedirectToAction("Error", "Question");
			}
			SectionA section = new SectionA
			{
				Shaper1 = secA.Shaper1,
				Coordinator1 = secA.Coordinator1,
				Planter1 = secA.Planter1,
				Monitor1 = secA.Monitor1,
				Resource1 = secA.Resource1,
				Implementer1 = secA.Implementer1,
				Teamwork1 = secA.Teamwork1,
				Finisher1 = secA.Finisher1,
				AspNetUsersId = test
			};
			_context.Set<SectionA>().AddAsync(section);
			_context.SaveChanges();
			return RedirectToAction("SectionB", "Question");
		}
		[HttpPost]
		public IActionResult SectionB([FromForm] SectionB secB, string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			var test = User.Claims.ToList()
			.Where(u => u.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"))
			.FirstOrDefault().Value;
			var Ans = secB.Shaper2 + secB.Coordinator2 + secB.Planter2 + secB.Monitor2 + secB.Resource2 + secB.Implementer2 + secB.Teamwork2 + secB.Finisher2;
			if (Ans != 10)
			{
				return RedirectToAction("Error", "Question");
			}
			SectionB section = new SectionB
			{
				Shaper2 = secB.Shaper2,
				Coordinator2 = secB.Coordinator2,
				Planter2 = secB.Planter2,
				Monitor2 = secB.Monitor2,
				Resource2 = secB.Resource2,
				Implementer2 = secB.Implementer2,
				Teamwork2 = secB.Teamwork2,
				Finisher2 = secB.Finisher2,
				AspNetUsersId = test
			};
			_context.Set<SectionB>().AddAsync(section);
			_context.SaveChanges();
			return RedirectToAction("SectionC", "Question");
		}
		[HttpPost]
		public IActionResult SectionC([FromForm] SectionC secC, string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			var test = User.Claims.ToList()
			.Where(u => u.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"))
			.FirstOrDefault().Value;
			var Ans = secC.Shaper3 + secC.Coordinator3 + secC.Planter3 + secC.Monitor3 + secC.Resource3 + secC.Implementer3 + secC.Teamwork3 + secC.Finisher3;
			if (Ans != 10)
			{
				return RedirectToAction("Error", "Question");
			}
			SectionC section = new SectionC
			{
				Shaper3 = secC.Shaper3,
				Coordinator3 = secC.Coordinator3,
				Planter3 = secC.Planter3,
				Monitor3 = secC.Monitor3,
				Resource3 = secC.Resource3,
				Implementer3 = secC.Implementer3,
				Teamwork3 = secC.Teamwork3,
				Finisher3 = secC.Finisher3,
				AspNetUsersId = test
			};
			_context.Set<SectionC>().AddAsync(section);
			_context.SaveChanges();
			return RedirectToAction("SectionD", "Question");
		}
		[HttpPost]
		public IActionResult SectionD([FromForm] SectionD secD, string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			var test = User.Claims.ToList()
			.Where(u => u.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"))
			.FirstOrDefault().Value;
			var Ans = secD.Shaper4 + secD.Coordinator4 + secD.Planter4 + secD.Monitor4 + secD.Resource4 + secD.Implementer4 + secD.Teamwork4 + secD.Finisher4;
			if (Ans != 10)
			{
				return RedirectToAction("Error", "Question");
			}
			SectionD section = new SectionD
			{
				Shaper4 = secD.Shaper4,
				Coordinator4 = secD.Coordinator4,
				Planter4 = secD.Planter4,
				Monitor4 = secD.Monitor4,
				Resource4 = secD.Resource4,
				Implementer4 = secD.Implementer4,
				Teamwork4 = secD.Teamwork4,
				Finisher4 = secD.Finisher4,
				AspNetUsersId = test
			};
			_context.Set<SectionD>().AddAsync(section);
			_context.SaveChanges();
			return RedirectToAction("SectionE", "Question");
		}
		[HttpPost]
		public IActionResult SectionE([FromForm] SectionE secE, string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			var test = User.Claims.ToList()
			.Where(u => u.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"))
			.FirstOrDefault().Value;
			var Ans = secE.Shaper5 + secE.Coordinator5 + secE.Planter5 + secE.Monitor5 + secE.Resource5 + secE.Implementer5 + secE.Teamwork5 + secE.Finisher5;
			if (Ans != 10)
			{
				return RedirectToAction("Error", "Question");
			}
			SectionE section = new SectionE
			{
				Shaper5 = secE.Shaper5,
				Coordinator5 = secE.Coordinator5,
				Planter5 = secE.Planter5,
				Monitor5 = secE.Monitor5,
				Resource5 = secE.Resource5,
				Implementer5 = secE.Implementer5,
				Teamwork5 = secE.Teamwork5,
				Finisher5 = secE.Finisher5,
				AspNetUsersId = test
			};
			_context.Set<SectionE>().AddAsync(section);
			_context.SaveChanges();
			return RedirectToAction("SectionF", "Question");
		}
		[HttpPost]
		public IActionResult SectionF([FromForm] SectionF secF, string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			var test = User.Claims.ToList()
			.Where(u => u.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"))
			.FirstOrDefault().Value;
			var Ans = secF.Shaper6 + secF.Coordinator6 + secF.Planter6 + secF.Monitor6 + secF.Resource6 + secF.Implementer6 + secF.Teamwork6 + secF.Finisher6;
			if (Ans != 10)
			{
				return RedirectToAction("Error", "Question");
			}
			SectionF section = new SectionF
			{
				Shaper6 = secF.Shaper6,
				Coordinator6 = secF.Coordinator6,
				Planter6 = secF.Planter6,
				Monitor6 = secF.Monitor6,
				Resource6 = secF.Resource6,
				Implementer6 = secF.Implementer6,
				Teamwork6 = secF.Teamwork6,
				Finisher6 = secF.Finisher6,
				AspNetUsersId = test
			};
			_context.Set<SectionF>().AddAsync(section);
			_context.SaveChanges();
			return RedirectToAction("SectionG", "Question");
		}
		[HttpPost]
		public IActionResult SectionG([FromForm] SectionG secG, string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			var test = User.Claims.ToList()
			.Where(u => u.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"))
			.FirstOrDefault().Value;
			var Ans = secG.Shaper7 + secG.Coordinator7 + secG.Planter7 + secG.Monitor7 + secG.Resource7 + secG.Implementer7 + secG.Teamwork7 + secG.Finisher7;
			if (Ans != 10)
			{
				return RedirectToAction("Error", "Question");
			}
			SectionG section = new SectionG
			{
				Shaper7 = secG.Shaper7,
				Coordinator7 = secG.Coordinator7,
				Planter7 = secG.Planter7,
				Monitor7 = secG.Monitor7,
				Resource7 = secG.Resource7,
				Implementer7 = secG.Implementer7,
				Teamwork7 = secG.Teamwork7,
				Finisher7 = secG.Finisher7,
				AspNetUsersId = test
			};
			_context.Set<SectionG>().AddAsync(section);
			_context.SaveChanges();
			return RedirectToAction("Result", "Question");
		}
		public IActionResult Result(SectionB secB, SectionA secA, SectionC secC, SectionD secD, SectionE secE, SectionF secF, SectionG secG)
		{

			var test = User.Claims.ToList()
			.Where(u => u.Type.Equals("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"))
			.FirstOrDefault().Value;

			var query = _context.Set<SectionA>().Where(x => x.AspNetUsersId == test).ToList();
			var query1 = _context.Set<SectionB>().Where(x => x.AspNetUsersId == test).ToList();
			var query2 = _context.Set<SectionC>().Where(x => x.AspNetUsersId == test).ToList();
			var query3 = _context.Set<SectionD>().Where(x => x.AspNetUsersId == test).ToList();
			var query4 = _context.Set<SectionE>().Where(x => x.AspNetUsersId == test).ToList();
			var query5 = _context.Set<SectionF>().Where(x => x.AspNetUsersId == test).ToList();
			var query6 = _context.Set<SectionG>().Where(x => x.AspNetUsersId == test).ToList();
			foreach (var item in query)
			{
				var secA1 = item.Shaper1;
				var SecA2 = item.Coordinator1;
				var SecA3 = item.Planter1;
				var secA4 = item.Resource1;
				var secA5 = item.Monitor1;
				var secA6 = item.Implementer1;
				var secA7 = item.Teamwork1;
				var secA8 = item.Finisher1;
				foreach (var item1 in query1)
				{
					var secB1 = secA1 + item1.Shaper2;
					var secB2 = SecA2 + item1.Coordinator2;
					var secB3 = SecA3 + item1.Planter2;
					var secB4 = secA4 + item1.Resource2;
					var secB5 = secA5 + item1.Monitor2;
					var secB6 = secA6 + item1.Implementer2;
					var secB7 = secA7 + item1.Teamwork2;
					var secB8 = secA8 + item1.Finisher2;

					foreach (var item2 in query2)
					{
						var secC1 = secB1 + item2.Shaper3;
						var secC2 = secB2 + item2.Coordinator3;
						var secC3 = secB3 + item2.Planter3;
						var secC4 = secB4 + item2.Resource3;
						var secC5 = secB5 + item2.Monitor3;
						var secC6 = secB6 + item2.Implementer3;
						var secC7 = secB7 + item2.Teamwork3;
						var secC8 = secB8 + item2.Finisher3;

						foreach (var item3 in query3)
						{
							var secD1 = secC1 + item3.Shaper4;
							var secD2 = secC2 + item3.Coordinator4;
							var secD3 = secC3 + item3.Planter4;
							var secD4 = secC4 + item3.Resource4;
							var secD5 = secC5 + item3.Monitor4;
							var secD6 = secC6 + item3.Implementer4;
							var secD7 = secC7 + item3.Teamwork4;
							var secD8 = secC8 + item3.Finisher4;
							foreach (var item4 in query4)
							{
								var secE1 = secD1 + item4.Shaper5;
								var secE2 = secD2 + item4.Coordinator5;
								var secE3 = secD3 + item4.Planter5;
								var secE4 = secD4 + item4.Resource5;
								var secE5 = secD5 + item4.Monitor5;
								var secE6 = secD6 + item4.Implementer5;
								var secE7 = secD7 + item4.Teamwork5;
								var secE8 = secD8 + item4.Finisher5;

								foreach (var item5 in query5)
								{
									var secF1 = secE1 + item5.Shaper6;
									var secF2 = secE2 + item5.Coordinator6;
									var secF3 = secE3 + item5.Planter6;
									var secF4 = secE4 + item5.Resource6;
									var secF5 = secE5 + item5.Monitor6;
									var secF6 = secE6 + item5.Implementer6;
									var secF7 = secE7 + item5.Teamwork6;
									var secF8 = secE8 + item5.Finisher6;

									foreach (var item6 in query6)
									{
										var secG1 = secF1 + item6.Shaper7;
										var secG2 = secF2 + item6.Coordinator7;
										var secG3 = secF3 + item6.Planter7;
										var secG4 = secF4 + item6.Resource7;
										var secG5 = secF5 + item6.Monitor7;
										var secG6 = secF6 + item6.Implementer7;
										var secG7 = secF7 + item6.Teamwork7;
										var secG8 = secF8 + item6.Finisher7;
										int[] array = { secG1, secG2, secG3, secG4, secG5, secG6, secG7, secG8 };
										var max = array.Max();
										var secondHighest = (from number in array orderby number descending select number).Distinct().Skip(1).First();
										if (max == 0)
										{
											ViewBag.result1 = "Empty";
										}
										else if (max == secG1)
										{
											ViewBag.result1 = "Shaper";
										}
										else if (max == secG2)
										{
											ViewBag.result1 = "Coordinator";
										}
										else if (max == secG3)
										{
											ViewBag.result1 = "Planter";
										}
										else if (max == secG4)
										{
											ViewBag.result1 = "Resource";
										}
										else if (max == secG5)
										{
											ViewBag.result1 = "Monitor";
										}
										else if (max == secG6)
										{
											ViewBag.result1 = "Implementer";
										}
										else if (max == secG7)
										{
											ViewBag.result1 = "TeamWork";
										}
										else if (max == secG8)
										{
											ViewBag.result1 = "Finisher";
										}
										if (secondHighest == 0)
										{
											ViewBag.result2 = "Empty";
										}
										else if (secondHighest == secG1)
										{
											ViewBag.result2 = "Shaper";
										}
										else if (secondHighest == secG2)
										{
											ViewBag.result2 = "Coordinator";
										}
										else if (secondHighest == secG3)
										{
											ViewBag.result2 = "Planter";
										}
										else if (secondHighest == secG4)
										{
											ViewBag.result2 = "Resource";
										}
										else if (secondHighest == secG5)
										{
											ViewBag.result2 = "Monitor";
										}
										else if (secondHighest == secG6)
										{
											ViewBag.result2 = "Implementer";
										}
										else if (secondHighest == secG7)
										{
											ViewBag.result2 = "TeamWork";
										}
										else if (secondHighest == secG8)
										{
											ViewBag.result2 = "Finisher";
										}
										return View();
									}
								}
							}
						}


					}
				}
			}
				
				
				return View();
			
		}
	}
}
