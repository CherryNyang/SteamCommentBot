using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Steam
{
    public static class HtmlUtil
    {
        public static void AlertBlock(RemoteWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("\r\n\t\t\twindow.alertMessage='';\r\n\t\t\twindow.alert = function alert(msg) {\r\n\t\t\t\tconsole.log('Hidden Alert ' + msg);\r\n\t\t\t\twindow.alertMessage=msg;\r\n\t\t\t};", new object[0]);
        }

        public static string GetAlertMessage(RemoteWebDriver driver)
        {
            return (string)((IJavaScriptExecutor)driver).ExecuteScript("\r\n\t\t\t\tvar ret = window.alertMessage;\r\n\t\t\t\twindow.alertMessage='';\r\n\t\t\t\treturn ret;\r\n\t\t\t", new object[0]);
        }

        public static void Remove(RemoteWebDriver driver, string elementId)
        {
            string ex = string.Concat(string.Format("var element = document.getElementById('{0}');", elementId), "element.parentNode.removeChild(element);");
            ((IJavaScriptExecutor)driver).ExecuteScript(ex, new object[0]);
        }

        public static void Scroll(RemoteWebDriver driver)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollBy(0, 1000);", new object[0]);
        }
    }
}
