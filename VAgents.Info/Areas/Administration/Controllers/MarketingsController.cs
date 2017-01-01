namespace VAgents.Info.Areas.Administration.Controllers
{
    using System.Data.Entity;
    using System.Threading.Tasks;
    using System.Net;
    using System.Web.Mvc;
    using Vagents.Info.Data;
    using VAgents.Info.Model;

    public class MarketingsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Administration/Marketings
        public async Task<ActionResult> Index()
        {
            return View(await db.Marketings.ToListAsync());
        }

        // GET: Administration/Marketings/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marketing marketing = await db.Marketings.FindAsync(id);
            if (marketing == null)
            {
                return HttpNotFound();
            }
            return View(marketing);
        }

        // GET: Administration/Marketings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Marketings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name,StartTime,EndTime,Description,PointId")] Marketing marketing)
        {
            if (ModelState.IsValid)
            {
                db.Marketings.Add(marketing);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(marketing);
        }

        // GET: Administration/Marketings/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marketing marketing = await db.Marketings.FindAsync(id);
            if (marketing == null)
            {
                return HttpNotFound();
            }
            return View(marketing);
        }

        // POST: Administration/Marketings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name,StartTime,EndTime,Description,PointId")] Marketing marketing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marketing).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(marketing);
        }

        // GET: Administration/Marketings/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marketing marketing = await db.Marketings.FindAsync(id);
            if (marketing == null)
            {
                return HttpNotFound();
            }
            return View(marketing);
        }

        // POST: Administration/Marketings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Marketing marketing = await db.Marketings.FindAsync(id);
            db.Marketings.Remove(marketing);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
