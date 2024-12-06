using System.ComponentModel.DataAnnotations;

namespace Opti.CMS12.Models.Pages
{
    public  abstract class AbstractPageContent: PageData
    {
        [Display(Name = "PageTitle",
           GroupName = SystemTabNames.Settings,
           Order = 5)]
        public virtual string ? PageTitle { get; set; }
    }
}
