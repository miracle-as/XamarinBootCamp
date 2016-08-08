using Android.Content;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamBootCamp
{
    public class ApplicationVersionService : IApplicationVersionService
    {
        private Context _applicationContext;

        public ApplicationVersionService(Context applicationContext)
        {
            _applicationContext = applicationContext;
        }

        #region IApplicationVersionService Members

        public string ApplicationVersion
        {
            get
            {
                string v = _applicationContext
                    .PackageManager.GetPackageInfo(_applicationContext.PackageName, 0)
                    .VersionName;
                return v;
            }
        }

        public string ApplicationBuildNumber
        {
            get
            {
                string v = _applicationContext
                    .PackageManager.GetPackageInfo(_applicationContext.PackageName, 0)
                    .VersionCode.ToString();
                return v;
            }
        }

        #endregion
    }
}
