//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ahmed_nawar.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web;

    public partial class Article
    {
        public int id { get; set; }
        public string PDF { get; set; }
        public HttpPostedFileBase file { get; set; }
        public string PDFSummry { get; set; }
    }
}
