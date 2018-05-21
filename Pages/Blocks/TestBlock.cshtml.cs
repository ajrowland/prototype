using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webpack_4_quickstart.Pages
{
    public class TestBlock
    {
      public TestBlock()
      {
        Message = "Default value";
      }

      public string Message { get; set; }
    }
}
