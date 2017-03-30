using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NinjectMVC.Service
{
    public interface ITestService
    {
        string GetMessage(string aString);
    }
}