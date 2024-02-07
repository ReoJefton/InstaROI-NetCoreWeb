using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InstaRoi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using InstaRoi.Data;

namespace InstaRoi.Controllers
{
    //[Authorize]
    public class DashboardController : Controller
    {
        private readonly InstaROIContext _context;

        public DashboardController(InstaROIContext context)
        {
            _context = context;    
        }

        // GET: Dashboard
        public async Task<IActionResult> Index()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }


        // GET: Dashboard/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marketingElements = await _context.MarketingElements
                .SingleOrDefaultAsync(m => m.ElementId == id);
            if (marketingElements == null)
            {
                return NotFound();
            }

            return View(marketingElements);
        }
        public async Task<IActionResult> IndexSocial()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexDirectMail()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexEmail()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexEvents()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexNewspaper()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexOnlineads()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexOther()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexOutdoor()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexPromotions()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexRadio()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexSponsor()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexTv()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexVideo()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }
        public async Task<IActionResult> IndexWebsite()
        {
            return View(await _context.MarketingElements.ToListAsync());
        }

        // GET: Dashboard/Create
        public IActionResult Create(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            //int i1 = Convert.ToInt32(_context.MarketingCampaign
            //        .Include(r => r.NumberOfLeads));
            //int i2 = Convert.ToInt32(_context.MarketingCampaign
            //        .Include(r => r.NumberOfLeads));
            //int sum = i1 + i2;
            List<string> cType = new List<string>();

            cType.Add("Events");
            cType.Add("Social Media");
            cType.Add("Online Ads");
            cType.Add("Website");
            cType.Add("Promotions");
            cType.Add("E-mail");
            cType.Add("Newspaper/Magazine");
            cType.Add("Radio Advertising");
            cType.Add("TV Advertising");
            cType.Add("Outdoor Advertising");
            cType.Add("Sponsorship");
            cType.Add("Video / Mobile Marketing");
            cType.Add("Direct Mail");
            cType.Add("Other / Miscellaneous");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 13)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }

        public IActionResult CreateSocial(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSocial([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateEvents(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEvents([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateDirectMail(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDirectMail([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateEmail(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEmail([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateNewspaper(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNewspaper([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateOnlineads(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOnlineads([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateOther(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }
        public IActionResult CreateOutdoor(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOutdoor([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreatePromotions(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePromotions([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOther([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateRadio(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRadio([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateSponsor(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSponsor([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateTv(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTv([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateVideo(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVideo([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }
        public IActionResult CreateWebsite(Int32 id)
        {
            var i1 = _context.MarketingElements
                   .Include(r => r.NumberOfLeads);
            List<string> cType = new List<string>();

            cType.Add("Facebook");
            cType.Add("Instagram");
            cType.Add("LinkedIn");
            cType.Add("Twitter");
            cType.Add("Other");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 4)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View();
        }

        // POST: Dashboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateWebsite([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (ModelState.IsValid)
            {
                _context.Add(marketingElements);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketingElements);
        }

        // GET: Dashboard/Edit/5
        //[Authorize(Roles="Administrator")]
        public async Task<IActionResult> Edit(Int32 id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marketingElements = await _context.MarketingElements.SingleOrDefaultAsync(m => m.ElementId == id);
            if (marketingElements == null)
            {
                return NotFound();
            }
            List<string> cType = new List<string>();

            cType.Add("Events");
            cType.Add("Social Media");
            cType.Add("Online Ads");
            cType.Add("Website");
            cType.Add("Promotions");
            cType.Add("E-mail");
            cType.Add("Newspaper/Magazine");
            cType.Add("Radio Advertising");
            cType.Add("TV Advertising");
            cType.Add("Outdoor Advertising");
            cType.Add("Sponsorship");
            cType.Add("Video / Mobile Marketing");
            cType.Add("Direct Mail");
            cType.Add("Other / Miscellaneous");
            //ViewData["CampaignType"] = new SelectList(cType);
            if (id >= 0 && id <= 13)
            {
                string s = cType.ElementAt(id);
                //ViewData["CampaignType"] = new SelectList(_context.MarketingCampaign, "CampaignType", "CampaignType", s);
                ViewData["CampaignType"] = new SelectList(cType, s);
            }
            else
            {
                ViewData["CampaignType"] = new SelectList(cType);
            }
            return View(marketingElements);
        }

        // POST: Dashboard/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit([Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        public async Task<IActionResult> Edit(int id, [Bind("ElementId,UserId,UserName,ElementName,ElementType,ElementDescription,StartDate,EndDate,InvestmentField,Investment1,Investment2,Investment3,Investment4,Investment5,Investment6,NumberOfLeads,ConversionPercentage,ConversionValue,Profit,Roi,RoiPercentage")] MarketingElements marketingElements)
        {
            if (id != marketingElements.ElementId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(marketingElements);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarketingElementsExists(marketingElements.ElementId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
                //return RedirectToAction(nameof(Index));
            }
            return View(marketingElements);
        }

        // GET: Dashboard/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var marketingElements = await _context.MarketingElements
                .SingleOrDefaultAsync(m => m.ElementId == id);
            if (marketingElements == null)
            {
                return NotFound();
            }

            return View(marketingElements);
        }

        // POST: Dashboard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var marketingElements = await _context.MarketingElements.SingleOrDefaultAsync(m => m.ElementId == id);
            _context.MarketingElements.Remove(marketingElements);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool MarketingElementsExists(int id)
        {
            return _context.MarketingElements.Any(e => e.ElementId == id);
        }
    }
}
