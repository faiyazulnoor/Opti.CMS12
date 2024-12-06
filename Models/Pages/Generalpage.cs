using System.ComponentModel.DataAnnotations;

namespace Opti.CMS12.Models.Pages
{
    [ContentType(DisplayName = "Generalpage",
        Description = "Generalpage",
        GUID = "a0d7cfb1-6a32-4c40-be10-d56739d7bb8e",
        GroupName = "General Content")]
    public class Generalpage : AbstractPageContent
    {


        [Display(Name = "Headline",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string? Headline { get; set; }

        [Display(Name = "HeadlineSlug",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string? HeadlineSlug { get; set; }

        [Display(Name = "Body",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString? Body { get; set; }
    }
}
