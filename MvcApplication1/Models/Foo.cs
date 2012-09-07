using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Foo
    {
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date1 { get; set; }

    }
}