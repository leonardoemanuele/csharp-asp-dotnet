using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace onGET_onPOST.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string RequestMethod
        { get; set; }

        public string RequestValues
        { get; set; }

        /*Binding properties assume that the submitted form values are set to their corresponding properties*/
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public DateTime Date { get; set; }
        [BindProperty]
        public string Body { get; set; }

        public async Task OnGetAsync()
        {
            // For debugging
            RequestMethod = "GET";
            RequestValues = "n/a";

            // Assign property values here
            Title = "Cuban Midnight Sandwich";
            Date = new DateTime(2000, 3, 24);
            Body = "This sandwich is called a 'Media Noche' which translates to 'Midnight.' It makes a wonderful dinner sandwich because it is served hot. A nice side dish is black bean soup or black beans and rice, and plaintain chips.";

            // Asynchronous task
            using (StreamWriter writer = new StreamWriter("log.txt", append: true))
            {
                await writer.WriteLineAsync($"OnGetAsync() called at {DateTime.Now}.");
            }
        }

        // Define OnPostAsync() here

        public async Task OnPostAsync()
        {
            // For debugging
            RequestMethod = "POST";
            RequestValues = GetFormValues();

            /*asynchronously write to a text file within the same folder of this project*/
            using (StreamWriter writer = new StreamWriter("log.txt", append: true))
            {
                await writer.WriteLineAsync($"OnPostAsync() called at {DateTime.Now}.");
            }
        }

        // For debugging
        private string GetFormValues(bool ignoreRequestVerificationToken = true)
        {
            string formData = "";
            string separator = " | ";

            foreach (var pair in this.Request.Form)
            {
                if (ignoreRequestVerificationToken && pair.Key == "__RequestVerificationToken")
                {
                    continue;
                }
                else
                {
                    formData += pair.Key + ": " + Request.Form[pair.Key] + separator;
                }
            }

            if (formData.EndsWith(separator))
            {
                formData = formData.Substring(0, formData.Length - separator.Length);
            }

            return formData;
        }
    }
}
