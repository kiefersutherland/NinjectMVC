using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectMVC.Service
{
    public class TestService : ITestService
    {
        public string GetMessage(string aString)
        {
            return "--------------" + (String.IsNullOrEmpty(aString) ? String.Empty : aString) + "--------------";
        }
    }
}