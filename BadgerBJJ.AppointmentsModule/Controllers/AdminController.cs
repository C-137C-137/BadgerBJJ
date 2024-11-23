using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Records;

namespace BadgerBJJ.AppointmentsModule.Controllers
{
    public class AdminController : Controller
    {
        private readonly IContentManager _contentManager;
        private readonly ISession _session;

        public AdminController(IContentManager contentManager, ISession session)
        {
            _contentManager = contentManager;
            _session = session;
        }

        //public async Task<IActionResult> Index()
        //{
        //    var schedules = await _session.Query<ContentItem, ContentItemIndex>()
        //        .Where(x => x.ContentType == "BJJSchedule")
        //        .ListAsync();

        //    return View(schedules);
        //}

    }
}
