using Foundation;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamBootCamp
{
    public class ApplicationVersionService : IApplicationVersionService
    {
        #region IApplicationVersionService Members

        public string ApplicationVersion
        {
            get 
            {
                string v = NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"].Description;
                return v;
            }
        }

        public string ApplicationBuildNumber
        {
            get
            {
                string v = NSBundle.MainBundle.InfoDictionary["CFBundleVersion"].Description;
                return v;
            }
        }

        #endregion
    }
}
