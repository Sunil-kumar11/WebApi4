using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApi4.Models;
using System.Net.Http;

namespace WebApi4
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IEnumerable<Product> ptobj = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44371/api/");
            var consumeapi = hc.GetAsync("product");
            consumeapi.Wait();

            var readdata = consumeapi.Result;

            if (readdata.IsSuccessStatusCode)
            {
                var displayrecords = readdata.Content.ReadAsAsync <IList<Product>>();
                displayrecords.Wait();
                ptobj = displayrecords.Result;
                gridview.DataSource = ptobj;
                gridview.DataBind();
            }



        }
    }
}