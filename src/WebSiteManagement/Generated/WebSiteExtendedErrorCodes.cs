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
using System.Linq;

namespace Microsoft.WindowsAzure.Management.WebSites
{
    /// <summary>
    /// In addition to standard HTTP status codes, the Windows Azure Web Sites
    /// Management REST API returns extended error codes and error messages.
    /// The extended codes do not replace the standard HTTP status codes, but
    /// provide additional, actionable information that can be used in
    /// conjunction with the standard HTTP status codes. For example, an HTTP
    /// 404 error can occur for numerous reasons, so having the additional
    /// information in the extended message can assist with problem
    /// resolution. (For more information on the standard HTTP codes returned
    /// by the REST API, see Service Management Status and Error Codes.)  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166968.aspx for
    /// more information)
    /// </summary>
    public static partial class WebSiteExtendedErrorCodes
    {
        /// <summary>
        /// Access is denied.
        /// </summary>
        public const string AccessDenied = "01001";
        
        /// <summary>
        /// Command resource object is not present in the request body.
        /// </summary>
        public const string CommandResourceNotPresent = "01002";
        
        /// <summary>
        /// Invalid name {0}.
        /// </summary>
        public const string InvalidName = "01003";
        
        /// <summary>
        /// Cannot understand command verb {0}.
        /// </summary>
        public const string UnknownCommandVerb = "01004";
        
        /// <summary>
        /// The service is currently in read only mode.
        /// </summary>
        public const string IsInReadOnlyMode = "01005";
        
        /// <summary>
        /// The {0} parameter is not specified.
        /// </summary>
        public const string ParameterIsNotSpecified = "01006";
        
        /// <summary>
        /// Parameter {0} has invalid value.
        /// </summary>
        public const string InvalidParameterValue = "01007";
        
        /// <summary>
        /// {0} object is not present in the request body.
        /// </summary>
        public const string InvalidRequest = "01008";
        
        /// <summary>
        /// The from value in the query string is bigger than or equal to the
        /// to value.
        /// </summary>
        public const string IncorrectDateTimeRange = "01009";
        
        /// <summary>
        /// Required parameter {0} is missing.
        /// </summary>
        public const string RequiredParameterMissing = "01010";
        
        /// <summary>
        /// Name of the web quota cannot change.
        /// </summary>
        public const string ResourceNameCannotChange = "01011";
        
        /// <summary>
        /// The value of the query string parameter cannot be converted to
        /// Boolean.
        /// </summary>
        public const string FailedToConvertParameterValue = "01012";
        
        /// <summary>
        /// Parameter with name {0} already exists in the request.
        /// </summary>
        public const string ParameterNameAlreadyExists = "01013";
        
        /// <summary>
        /// Parameter name cannot be empty.
        /// </summary>
        public const string ParameterNameIsEmpty = "01014";
        
        /// <summary>
        /// Not ready
        /// </summary>
        public const string NotReady = "01015";
        
        /// <summary>
        /// Ready
        /// </summary>
        public const string Ready = "01016";
        
        /// <summary>
        /// Update is not allowed for the {0} field.
        /// </summary>
        public const string UpdateForFieldNotAllowed = "01017";
        
        /// <summary>
        /// Web Service does not support Command {0}. Only supported command(s)
        /// is {1}.
        /// </summary>
        public const string NotSupportedCommand = "01018";
        
        /// <summary>
        /// Invalid data ({0}).
        /// </summary>
        public const string InvalidData = "01019";
        
        /// <summary>
        /// There was a conflict. {0}
        /// </summary>
        public const string GenericConflict = "01020";
        
        /// <summary>
        /// Internal server error occurred. {0}
        /// </summary>
        public const string InternalServerError = "01021";
        
        /// <summary>
        /// Number of sites exceeds the maximum allowed.
        /// </summary>
        public const string NumberOfSitesLimit = "03001";
        
        /// <summary>
        /// NumberOfWorkers exceeds the maximum allowed.
        /// </summary>
        public const string NumberOfWorkersLimit = "03002";
        
        /// <summary>
        /// There is not enough space on the disk.
        /// </summary>
        public const string NoStorageVolumeAvailable = "03003";
        
        /// <summary>
        /// WebSpace with name {0} already exists for subscription {1}.
        /// </summary>
        public const string WebSpaceAlreadyExists = "03004";
        
        /// <summary>
        /// Cannot find webspace {0} for subscription {1}
        /// </summary>
        public const string WebSpaceNotFound = "03005";
        
        /// <summary>
        /// Web space contains resources.
        /// </summary>
        public const string WebSpaceContainsResources = "03006";
        
        /// <summary>
        /// The file storage capacity exceeds the limit.
        /// </summary>
        public const string FileStorageLimit = "03007";
        
        /// <summary>
        /// Failed to delete web space {0}: {1}
        /// </summary>
        public const string WebSpaceDeleteError = "03008";
        
        /// <summary>
        /// Not enough available Standard Instance servers to satisfy this
        /// request.
        /// </summary>
        public const string NoWorkersAvailable = "03009";
        
        /// <summary>
        /// Failed to create web space {0} on storage volume {1}: {2}
        /// </summary>
        public const string WebSpaceCreateError = "03010";
        
        /// <summary>
        /// Directory already exists for site {0}.
        /// </summary>
        public const string DirectoryAlreadyExists = "04001";
        
        /// <summary>
        /// Failed to delete directory {0}.
        /// </summary>
        public const string DirectoryDeleteError = "04002";
        
        /// <summary>
        /// Invalid host name {0}.
        /// </summary>
        public const string InvalidHostName = "04003";
        
        /// <summary>
        /// NumberOfWorkers value must be more than zero.
        /// </summary>
        public const string InvalidNumberOfWorkers = "04004";
        
        /// <summary>
        /// Hostname '{0}' already exists.
        /// </summary>
        public const string HostNameAlreadyExists = "04005";
        
        /// <summary>
        /// No CNAME pointing from {0} to a site in a default DNS zone (or too
        /// many).
        /// </summary>
        public const string InvalidCustomHostNameValidation = "04006";
        
        /// <summary>
        /// There are no hostnames which could be used for validation.
        /// </summary>
        public const string InvalidCustomHostNameValidationNoBaseHostName = "04007";
        
        /// <summary>
        /// Site with name {0} already exists.
        /// </summary>
        public const string SiteAlreadyExists = "04008";
        
        /// <summary>
        /// Cannot find site {0}.
        /// </summary>
        public const string SiteNotFound = "04009";
        
        /// <summary>
        /// The external URL "{0}" specified on request header "{1}" is invalid.
        /// </summary>
        public const string InvalidExternalUriHeader = "04010";
        
        /// <summary>
        /// Failed to delete file {0}.
        /// </summary>
        public const string FileDeleteError = "04011";
        
        /// <summary>
        /// Number of workers for this site exceeds the maximum allowed.
        /// </summary>
        public const string NumberOfWorkersPerSiteLimit = "04012";
        
        /// <summary>
        /// WebSiteManager.CreateWebSite: Creating Site using storageVolume {0}.
        /// </summary>
        public const string TraceWebSiteStorageVolume = "04013";
        
        /// <summary>
        /// Cannot delete repository with name {0}.
        /// </summary>
        public const string RepositoryDeleteError = "05001";
        
        /// <summary>
        /// Development site already exists in the repository for site {0}.
        /// </summary>
        public const string RepositoryDevSiteAlreadyExists = "05002";
        
        /// <summary>
        /// Development site does not exist in the repository for site {0}.
        /// </summary>
        public const string RepositoryDevSiteNotExist = "05003";
        
        /// <summary>
        /// Site {0} already has repository created for it.
        /// </summary>
        public const string RepositorySiteAlreadyExists = "05004";
        
        /// <summary>
        /// Repository does not exist for site {0}.
        /// </summary>
        public const string RepositorySiteNotExist = "05005";
        
        /// <summary>
        /// Failed to create a development site.
        /// </summary>
        public const string TraceFailedToCreateDevSite = "05006";
        
        /// <summary>
        /// User {0} has been rejected.
        /// </summary>
        public const string AuthenticatedFailed = "06001";
        
        /// <summary>
        /// User {0} has been successfully authenticated.
        /// </summary>
        public const string AuthenticatedPassed = "06002";
        
        /// <summary>
        /// User {0} has been rejected.
        /// </summary>
        public const string AuthorizationFailed = "06003";
        
        /// <summary>
        /// User {0} has been authorized.
        /// </summary>
        public const string AuthorizationPassed = "06004";
        
        /// <summary>
        /// Publishing credentials have to be trimmed from white characters.
        /// </summary>
        public const string PublishingCredentialsNotTrimmed = "06005";
        
        /// <summary>
        /// Publishing password cannot be empty.
        /// </summary>
        public const string PublishingPasswordIsEmpty = "06006";
        
        /// <summary>
        /// Publishing password must be specified.
        /// </summary>
        public const string PublishingPasswordNotSpecified = "06007";
        
        /// <summary>
        /// Publishing username {0} is already used. Specify a different
        /// publishing username.
        /// </summary>
        public const string PublishingUserNameAlreadyExists = "06008";
        
        /// <summary>
        /// Publishing user name cannot be empty.
        /// </summary>
        public const string PublishingUserNameIsEmpty = "06009";
        
        /// <summary>
        /// An error occurred when adding the {0} entry: {1}
        /// </summary>
        public const string ErrorAdding = "51001";
        
        /// <summary>
        /// An error occurred when deleting the {0} entry: {1}
        /// </summary>
        public const string ErrorDeleting = "51002";
        
        /// <summary>
        /// An error occurred when updating the {0} entry: {1}
        /// </summary>
        public const string ErrorUpdating = "51003";
        
        /// <summary>
        /// Cannot find {0} with name {1}.
        /// </summary>
        public const string CannotFindEntity = "51004";
        
        /// <summary>
        /// Subscription with specified name already exists.
        /// </summary>
        public const string SubscriptionConflict = "52001";
        
        /// <summary>
        /// Subscripton Name cannot be null or empty.
        /// </summary>
        public const string SubscriptionNonEmpty = "52002";
        
        /// <summary>
        /// Subscription {0} not found.
        /// </summary>
        public const string SubscriptionNotFound = "52003";
        
        /// <summary>
        /// Subscription {0} is Suspended.
        /// </summary>
        public const string SubscriptionSuspended = "52004";
        
        /// <summary>
        /// Subscription contains WebSpaces.
        /// </summary>
        public const string NonEmptySubscription = "52005";
        
        /// <summary>
        /// WebSpace with specified name already exists.
        /// </summary>
        public const string WebSpaceConflict = "53001";
        
        /// <summary>
        /// WebSpace Name cannot be null or empty.
        /// </summary>
        public const string WebSpaceNonEmpty = "53002";
        
        /// <summary>
        /// WebSpace contains web sites.
        /// </summary>
        public const string NonEmptyWebSpace = "53003";
        
        /// <summary>
        /// An Error occurred when picking Stamp for WebSpace {0}.
        /// </summary>
        public const string ErrorPickingStamp = "53004";
        
        /// <summary>
        /// Web site with given name {0} already exists in the specified
        /// Subscription and Webspace.
        /// </summary>
        public const string WebSiteConflict = "54001";
        
        /// <summary>
        /// WebSiteName cannot be null or empty.
        /// </summary>
        public const string WebSiteNonEmpty = "54002";
        
        /// <summary>
        /// Specified Host Name {0} is already taken by another site.
        /// </summary>
        public const string HostNameConflict = "54003";
    }
}
