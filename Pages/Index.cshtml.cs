using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DotNetCore50Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Task.Run(async () =>
            {
                var started = DateTime.UtcNow;
                await Task.Delay(TimeSpan.FromMinutes(10));

                Environment.FailFast($"{DateTime.UtcNow:s} Failfast intentionally since app started at {started:s}");
            });
        }
    }
}
