using System;
using System.Collections.Generic;
using System.Text;

namespace XamBootCamp
{
    public class MockApplicationVersionService : IApplicationVersionService
    {
        public MockApplicationVersionService()
        {
            ApplicationVersion = "2.3";
            ApplicationBuildNumber = "42";
        }

        #region IApplicationVersionService Members

        public string ApplicationVersion { get; set; }
        public string ApplicationBuildNumber { get; set; }

        #endregion
    }
}
