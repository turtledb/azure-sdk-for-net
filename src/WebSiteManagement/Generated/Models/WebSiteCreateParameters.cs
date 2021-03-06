// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites.Models
{
    /// <summary>
    /// Parameters supplied to the Create Web Site operation.
    /// </summary>
    public partial class WebSiteCreateParameters
    {
        private Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteComputeMode? _computeMode;
        
        /// <summary>
        /// This value should be Shared for the Free or Paid Shared offerings,
        /// or Dedicated for the Standard offering. The default value is
        /// Shared. If you set ComputeMode to Dedicated, you must specify a
        /// value for the ServerFarm element.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteComputeMode? ComputeMode
        {
            get { return this._computeMode; }
            set { this._computeMode = value; }
        }
        
        private IList<string> _hostNames;
        
        /// <summary>
        /// Required. The fully qualified domain name for website. Only one
        /// hostname can be specified in the azurewebsites.net domain. The
        /// hostname should match the name of the website. Custom domains can
        /// only be specified for Shared or Standard websites.
        /// </summary>
        public IList<string> HostNames
        {
            get { return this._hostNames; }
            set { this._hostNames = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. The name of the website. This should match the hostname
        /// in the default domain.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _serverFarm;
        
        /// <summary>
        /// The name of the Server Farm associated with this website. This is a
        /// required value for Standard mode.
        /// </summary>
        public string ServerFarm
        {
            get { return this._serverFarm; }
            set { this._serverFarm = value; }
        }
        
        private Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteMode? _siteMode;
        
        /// <summary>
        /// This value is limited for the Free offering Basic for the Paid
        /// Shared offering. The default value is Limited. Note: Standard mode
        /// does not use the SiteMode setting; it uses the ComputeMode
        /// setting. For more information, see Upgrade or Downgrade a Web Site.
        /// </summary>
        public Microsoft.WindowsAzure.Management.WebSites.Models.WebSiteMode? SiteMode
        {
            get { return this._siteMode; }
            set { this._siteMode = value; }
        }
        
        private WebSiteCreateParameters.WebSpaceDetails _webSpace;
        
        /// <summary>
        /// Information about the web space to create.
        /// </summary>
        public WebSiteCreateParameters.WebSpaceDetails WebSpace
        {
            get { return this._webSpace; }
            set { this._webSpace = value; }
        }
        
        private string _webSpaceName;
        
        /// <summary>
        /// The name of the webspace
        /// </summary>
        public string WebSpaceName
        {
            get { return this._webSpaceName; }
            set { this._webSpaceName = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the WebSiteCreateParameters class.
        /// </summary>
        public WebSiteCreateParameters()
        {
            this._hostNames = new List<string>();
        }
        
        /// <summary>
        /// Information about the web space to create.
        /// </summary>
        public partial class WebSpaceDetails
        {
            private string _geoRegion;
            
            /// <summary>
            /// Required. The geographical region of the webspace that will be
            /// created.
            /// </summary>
            public string GeoRegion
            {
                get { return this._geoRegion; }
                set { this._geoRegion = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Required. The name of the webspace.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private string _plan;
            
            /// <summary>
            /// Required. This value must be VirtualDedicatedPlan.
            /// </summary>
            public string Plan
            {
                get { return this._plan; }
                set { this._plan = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the WebSpaceDetails class.
            /// </summary>
            public WebSpaceDetails()
            {
            }
        }
    }
}
