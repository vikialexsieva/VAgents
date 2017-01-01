namespace VAgencyes.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web;
    using System.Web.Mvc;

    public class ReleaseHistoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [AllowHtml]
        [DataType("tinymce_full")]
        [UIHint("tinymce_full")]
        public string Description { get; set; }
        public DateTime CreatioTime { get; set; }
    }
}
