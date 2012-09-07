using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class FooEditModel
    {
        public string Message { get; set; }
        public Foo Foo { get; set; }
    }
}