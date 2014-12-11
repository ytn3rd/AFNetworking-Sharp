using System;
using System.Drawing;

//using System.ComponentModel;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreFoundation;
using MonoTouch.SystemConfiguration;
using MonoTouch.Security;

namespace AFNetworking
{
    public delegate void AFHttpRequestSuccessCallback(AFHTTPRequestOperation operation,NSObject responseObject);

    public delegate void AFHttpRequestFailureCallback(AFHTTPRequestOperation operation,NSError error);

    public delegate void AFURLConnectionOperationProgressCallback(long bytes,long totalBytes,long totalBytesExpected);

   

    [BaseType(typeof(AFURLConnectionOperation))]
    public partial interface AFHTTPRequestOperation
    {

        [Export("initWithRequest:")]
        IntPtr Constructor(NSUrlRequest request);

        [Export("response")]
        NSUrlResponse Response { get; }

        //AFHTTPResponseSerializer <AFURLResponseSerialization> * responseSerializer;
        //[Export("responseSerializer")]
        //AFHTTPResponseSerializer ResponseSerializer { get; }

        [Export("responseObject")]
        NSObject ResponseObject { get; }


        [Export("setCompletionBlockWithSuccess:failure:")]
        void SetCompletionBlock(AFHttpRequestSuccessCallback success, AFHttpRequestFailureCallback failure);

    }

    [BaseType(typeof(NSObject))] // AFURLSessionManager <NSSecureCoding, NSCopying>
    public partial interface AFHTTPRequestOperationManager
    {
        [Export("baseURL")]
        NSUrl BaseURL { get; }

        // @property (nonatomic, strong) AFHTTPRequestSerializer <AFURLRequestSerialization> * requestSerializer;

        //@property (nonatomic, strong) AFHTTPResponseSerializer <AFURLResponseSerialization> * responseSerializer;

        [Export("operationQueue")]
        NSOperationQueue OperationQueue { get; set; }

        [Export("shouldUseCredentialStorage")]
        bool ShouldUseCredentialStorage { get; set; }

        [Export("credential")]
        NSUrlCredential Credential { get; set; }

        [Export("securityPolicy")]
        AFSecurityPolicy SecurityPolicy { get; set; }

        // @property (readwrite, nonatomic, strong) AFNetworkReachabilityManager *reachabilityManager;

        [Export("reachabilityManager")]
        AFNetworkReachabilityManager ReachabilityManager { get; set; }

        // @property (nonatomic, strong) dispatch_queue_t completionQueue;
        // @property (nonatomic, strong) dispatch_group_t completionGroup;

        [Export("manager")]
        AFHTTPRequestOperationManager Manager { get; }


        //    + (instancetype)manager;


        [Export("initWithBaseURL:")]
        IntPtr Constructor(NSUrl url);
    


        //- (AFHTTPRequestOperation *)HTTPRequestOperationWithRequest:(NSURLRequest *)request
        //success:(void (^)(AFHTTPRequestOperation *operation, id responseObject))success
        //failure:(void (^)(AFHTTPRequestOperation *operation, NSError *error))failure;

        //- (AFHTTPRequestOperation *)GET:(NSString *)URLString
        //parameters:(id)parameters
        //success:(void (^)(AFHTTPRequestOperation *operation, id responseObject))success
        // failure:(void (^)(AFHTTPRequestOperation *operation, NSError *error))failure;


        //- (AFHTTPRequestOperation *)HEAD:(NSString *)URLString
        //parameters:(id)parameters
        //success:(void (^)(AFHTTPRequestOperation *operation))success
        //failure:(void (^)(AFHTTPRequestOperation *operation, NSError *error))failure;

        // - (AFHTTPRequestOperation *)POST:(NSString *)URLString
        // parameters:(id)parameters
        //success:(void (^)(AFHTTPRequestOperation *operation, id responseObject))success
        // failure:(void (^)(AFHTTPRequestOperation *operation, NSError *error))failure;

        // - (AFHTTPRequestOperation *)POST:(NSString *)URLString
        // parameters:(id)parameters
        //  constructingBodyWithBlock:(void (^)(id <AFMultipartFormData> formData))block
        //  success:(void (^)(AFHTTPRequestOperation *operation, id responseObject))success
        //  failure:(void (^)(AFHTTPRequestOperation *operation, NSError *error))failure;


        // - (AFHTTPRequestOperation *)PUT:(NSString *)URLString
        //parameters:(id)parameters
        //success:(void (^)(AFHTTPRequestOperation *operation, id responseObject))success
        //failure:(void (^)(AFHTTPRequestOperation *operation, NSError *error))failure;

        //  - (AFHTTPRequestOperation *)PATCH:(NSString *)URLString
        //    parameters:(id)parameters
        //   success:(void (^)(AFHTTPRequestOperation *operation, id responseObject))success
        //   failure:(void (^)(AFHTTPRequestOperation *operation, NSError *error))failure;

        //  - (AFHTTPRequestOperation *)DELETE:(NSString *)URLString
        //parameters:(id)parameters
        //  success:(void (^)(AFHTTPRequestOperation *operation, id responseObject))success
        // failure:(void (^)(AFHTTPRequestOperation *operation, NSError *error))failure;

    }


    [BaseType(typeof(AFURLSessionManager))] // AFURLSessionManager <NSSecureCoding, NSCopying>
    public partial interface AFHTTPSessionManager
    {
        [Export("baseURL")]
        NSUrl BaseURL { get; }

        //property (nonatomic, strong) AFHTTPRequestSerializer <AFURLRequestSerialization> * requestSerializer;

        //@property (nonatomic, strong) AFHTTPResponseSerializer <AFURLResponseSerialization> * responseSerializer;

        [Export("manager")]
        AFHTTPSessionManager Manager { get; }

        [Export("initWithBaseURL:")]
        IntPtr Constructor(NSUrl url);

        [Export("initWithBaseURL:sessionConfiguration:")]
        IntPtr Constructor(NSUrl url, NSUrlSessionConfiguration configuration);

        //- (NSURLSessionDataTask *)GET:(NSString *)URLString
        //parameters:(id)parameters
        //success:(void (^)(NSURLSessionDataTask *task, id responseObject))success
        //failure:(void (^)(NSURLSessionDataTask *task, NSError *error))failure;

        // - (NSURLSessionDataTask *)HEAD:(NSString *)URLString
        // parameters:(id)parameters
        // success:(void (^)(NSURLSessionDataTask *task))success
        // failure:(void (^)(NSURLSessionDataTask *task, NSError *error))failure;

        //- (NSURLSessionDataTask *)POST:(NSString *)URLString
        //parameters:(id)parameters
        //success:(void (^)(NSURLSessionDataTask *task, id responseObject))success
        //failure:(void (^)(NSURLSessionDataTask *task, NSError *error))failure;


        //- (NSURLSessionDataTask *)POST:(NSString *)URLString
        //parameters:(id)parameters
        //constructingBodyWithBlock:(void (^)(id <AFMultipartFormData> formData))block
        //success:(void (^)(NSURLSessionDataTask *task, id responseObject))success
        //failure:(void (^)(NSURLSessionDataTask *task, NSError *error))failure;

        //- (NSURLSessionDataTask *)PUT:(NSString *)URLString
        //parameters:(id)parameters
        //success:(void (^)(NSURLSessionDataTask *task, id responseObject))success
        //failure:(void (^)(NSURLSessionDataTask *task, NSError *error))failure;

        //- (NSURLSessionDataTask *)PATCH:(NSString *)URLString
        //parameters:(id)parameters
        //success:(void (^)(NSURLSessionDataTask *task, id responseObject))success
        //failure:(void (^)(NSURLSessionDataTask *task, NSError *error))failure;

        //- (NSURLSessionDataTask *)DELETE:(NSString *)URLString
        //parameters:(id)parameters
        //success:(void (^)(NSURLSessionDataTask *task, id responseObject))success
        //failure:(void (^)(NSURLSessionDataTask *task, NSError *error))failure;
    }

    [BaseType(typeof(NSObject))] 
    public partial interface AFNetworkReachabilityManager
    {
        [Export("networkReachabilityStatus")]
        AFNetworkReachabilityStatus NetworkReachabilityStatus { get; }

        //getter = isReachable
        [Export("reachable")]
        bool reachable { get; }

        //getter = isReachableViaWWAN
        [Export("reachableViaWWAN")]
        bool reachableViaWWAN { get; }

        //getter = isReachableViaWiFi
        [Export("reachableViaWiFi")]
        bool reachableViaWiFi { get; }

        //property (nonatomic, strong) AFHTTPRequestSerializer <AFURLRequestSerialization> * requestSerializer;

        //@property (nonatomic, strong) AFHTTPResponseSerializer <AFURLResponseSerialization> * responseSerializer;

        [Export("sharedManager")]
        AFNetworkReachabilityManager SharedManager { get; }

        [Export("managerForDomain:")]
        AFNetworkReachabilityManager ManagerForDomain(string domain);

        // (instancetype)managerForAddress:(const void *)address;
        //[Export("managerForAddress:")]
        //IntPtr Constructor(string address);

        //- (instancetype)initWithReachability:(SCNetworkReachabilityRef)reachability;
        //[Export("initWithReachability:")]
        //IntPtr Constructor(SCNetworkReachability reachability);

        [Export("startMonitoring")]
        void StartMonitoring();

        [Export("stopMonitoring")]
        void StopMonitoring();

        [Export("localizedNetworkReachabilityStatusString")]
        string GetLocalizedNetworkReachabilityStatus();

        //- (void)setReachabilityStatusChangeBlock:(void (^)(AFNetworkReachabilityStatus status))block;

        //extern NSString * const AFNetworkingReachabilityDidChangeNotification;
        //extern NSString * const AFNetworkingReachabilityNotificationStatusItem;
        //extern NSString * AFStringFromNetworkReachabilityStatus(AFNetworkReachabilityStatus status);




    }


    [BaseType(typeof(NSObject))] 
    public partial interface AFSecurityPolicy
    {
        [Export("SSLPinningMode")]
        AFSSLPinningMode SSLPinningMode { get; }

        [Export("validatesCertificateChain")]
        bool ValidatesCertificateChain { get; set; }

        [Export("pinnedCertificates")]
        NSArray PinnedCertificates { get; set; }

        [Export("allowInvalidCertificates")]
        bool AllowInvalidCertificates { get; set; }

        [Export("validatesDomainName")]
        bool ValidatesDomainName { get; set; }

        [Export("runLoopModes")]
        NSSet RunLoopModes { get; set; }

        //[Export("evaluateServerTrust:forDomain:")]
        //bool EvaluateServerTrust(SecTrust serverTrust, string domain);


        /*
        + (instancetype)defaultPolicy;

        + (instancetype)policyWithPinningMode:(AFSSLPinningMode)pinningMode;
        */
    }

    [BaseType(typeof(NSOperation))]
    public partial interface AFURLConnectionOperation
    {

        [Export("runLoopModes")]
        NSSet RunLoopModes { get; set; }

        [Export("request")]
        NSUrlRequest Request { get; }

        //[Export("response")]
        //NSUrlResponse Response { get; }

        [Export("error")]
        NSError Error { get; }

        [Export("responseData")]
        NSData ResponseData { get; }

        [Export("responseString")]
        string ResponseString { get; }

        [Export("responseStringEncoding")]
        NSStringEncoding ResponseStringEncoding { get; }

        [Export("shouldUseCredentialStorage")]
        bool ShouldUseCredentialStorage { get; set; }

        [Export("credential")]
        NSUrlCredential Credential { get; set; }

        [Export("securityPolicy")]
        AFSecurityPolicy SecurityPolicy { get; set; }

        [Export("inputStream")]
        NSInputStream InputStream { get; set; }

        [Export("outputStream")]
        NSOutputStream OutputStream { get; set; }

        //do not know how to make a signature for MonoTouch.CoreFoundation.DispatchGroup
        //[Export("completionQueue")]
        //DispatchQueue CompletionQueue { get; set; }

        //[Export("completionGroup")]
        //DispatchGroup CompletionGroup { get; set; }

        [Export("userInfo")]
        NSDictionary UserInfo { get; set; }

        [Export("initWithRequest:")]
        IntPtr Constructor(NSUrlRequest urlRequest);

        [Export("pause")]
        void Pause();

        [Export("isPaused")]
        bool IsPaused();

        [Export("resume")]
        void Resume();

        /*#if defined(__IPHONE_OS_VERSION_MIN_REQUIRED) && !defined(AF_APP_EXTENSIONS)
- (void)setShouldExecuteAsBackgroundTaskWithExpirationHandler:(void (^)(void))handler;
#endif
*/
        [Export("setUploadProgressBlock:")]
        void SetUploadProgressBlock(AFURLConnectionOperationProgressCallback block);

        [Export("setDownloadProgressBlock:")]
        void SetDownloadProgressBlock(AFURLConnectionOperationProgressCallback block);

        //- (void)setWillSendRequestForAuthenticationChallengeBlock:(void (^)(NSURLConnection *connection, NSURLAuthenticationChallenge *challenge))block;

        //[Export ("setRedirectResponseBlock:")]
        //void SetRedirectResponseBlock ([unmapped: blockpointer: BlockPointer] block);
        //- (void)setRedirectResponseBlock:(NSURLRequest * (^)(NSURLConnection *connection, NSURLRequest *request, NSURLResponse *redirectResponse))block;

        //- (void)setCacheResponseBlock:(NSCachedURLResponse * (^)(NSURLConnection *connection, NSCachedURLResponse *cachedResponse))block;
        //[Export ("setCacheResponseBlock:")]
        //void SetCacheResponseBlock ([unmapped: blockpointer: BlockPointer] block);

        //+ (NSArray *)batchOfRequestOperations:(NSArray *)operations
        // progressBlock:(void (^)(NSUInteger numberOfFinishedOperations, NSUInteger totalNumberOfOperations))progressBlock
        // completionBlock:(void (^)(NSArray *operations))completionBlock;

        [Notification]
        [Field("AFNetworkingOperationDidStartNotification", "__Internal")]
        NSString AFNetworkingOperationDidStartNotification { get; }

        [Notification]
        [Field("AFNetworkingOperationDidFinishNotification", "__Internal")]
        NSString AFNetworkingOperationDidFinishNotification { get; }
    }

    [BaseType(typeof(NSObject))]
    public partial interface AFURLRequestSerialization
    {

    }

    [BaseType(typeof(NSObject))]
    public partial interface AFURLResponseSerialization
    {

    }

    [BaseType(typeof(NSObject))]
    public partial interface AFURLSessionManager
    {

    }





    /*
    public delegate void AFImageRequestCallback(UIImage image);

    public delegate UIImage AFImageRequestImageProcessingCallback(UIImage image);

    public delegate void AFImageRequestDetailedCallback(NSUrlRequest request,NSHttpUrlResponse response,UIImage image);

    public delegate void AFImageRequestFailedCallback(NSUrlRequest request,NSHttpUrlResponse response,NSError error);


    [BaseType(typeof(NSObject))]
    public partial interface AFHTTPClient
    {
        
        [Export("baseURL")]
        NSUrl BaseURL { get; }

        [Export("stringEncoding")]
        NSStringEncoding StringEncoding { get; set; }

        [Export("parameterEncoding")]
        AFHTTPClientParameterEncoding ParameterEncoding { get; set; }

        [Export("operationQueue")]
        NSOperationQueue OperationQueue { get; }

        [Static, Export("clientWithBaseURL:")]
        AFHTTPClient ClientWithBaseURL(NSUrl url);

        [Export("initWithBaseURL:")]
        NSObject Constructor(NSUrl url);

        [Export("registerHTTPOperationClass:")]
        bool RegisterHTTPOperationClass(Class operationClass);

        [Export("unregisterHTTPOperationClass:")]
        void UnregisterHTTPOperationClass(Class operationClass);

        [Export("defaultValueForHeader:")]
        string DefaultValueForHeader(string header);

        [Export("setDefaultHeader:value:")]
        void SetDefaultHeader(string header, string value);

        [Export("setAuthorizationHeaderWithUsername:password:")]
        void SetAuthorizationHeaderWithUsername(string username, string password);

        [Export("setAuthorizationHeaderWithToken:")]
        void SetAuthorizationHeaderWithToken(string token);

        [Export("clearAuthorizationHeader")]
        void ClearAuthorizationHeader();

        [Export("setDefaultCredential:")]
        void SetDefaultCredential(NSUrlCredential credential);

        [Export("requestWithMethod:path:parameters:")]
        NSMutableUrlRequest RequestWithMethod(string method, string path, [NullAllowed] NSDictionary parameters);
        
        //[Export ("multipartFormRequestWithMethod:path:parameters:constructingBodyWithBlock:")]
        //NSMutableURLRequest MultipartFormRequestWithMethod (string method, string path, NSDictionary parameters, [unmapped: blockpointer: BlockPointer] block);
        
        //[Export ("HTTPRequestOperationWithRequest:success:failure:")]
        //AFHTTPRequestOperation HTTPRequestOperationWithRequest (NSURLRequest urlRequest, [unmapped: blockpointer: BlockPointer] success, [unmapped: blockpointer: BlockPointer] failure);
        
        [Export("enqueueHTTPRequestOperation:")]
        void EnqueueHTTPRequestOperation(AFHTTPRequestOperation operation);

        [Export("cancelAllHTTPOperationsWithMethod:path:")]
        void CancelAllHTTPOperationsWithMethod(string method, string path);
        
        //[Export ("enqueueBatchOfHTTPRequestOperationsWithRequests:progressBlock:completionBlock:")]
        //void EnqueueBatchOfHTTPRequestOperationsWithRequests (NSArray urlRequests, [unmapped: blockpointer: BlockPointer] progressBlock, [unmapped: blockpointer: BlockPointer] completionBlock);
        
        //[Export ("enqueueBatchOfHTTPRequestOperations:progressBlock:completionBlock:")]
        //void EnqueueBatchOfHTTPRequestOperations (NSArray operations, [unmapped: blockpointer: BlockPointer] progressBlock, [unmapped: blockpointer: BlockPointer] completionBlock);
        
        [Export("getPath:parameters:success:failure:")]
        void GetPath(string path, [NullAllowed] NSDictionary parameters, Action<AFHTTPRequestOperation, NSObject> success, [NullAllowed] Action<AFHTTPRequestOperation, NSError> failure);

        [Export("postPath:parameters:success:failure:")]
        void PostPath(string path, NSDictionary parameters, Action<AFHTTPRequestOperation, NSObject> success, [NullAllowed] Action<AFHTTPRequestOperation, NSError> failure);

        [Export("putPath:parameters:success:failure:")]
        void PutPath(string path, NSDictionary parameters, Action<AFHTTPRequestOperation, NSObject> success, [NullAllowed] Action<AFHTTPRequestOperation, NSError> failure);

        [Export("deletePath:parameters:success:failure:")]
        void DeletePath(string path, NSDictionary parameters, Action<AFHTTPRequestOperation, NSObject> success, [NullAllowed] Action<AFHTTPRequestOperation, NSError> failure);

        [Export("patchPath:parameters:success:failure:")]
        void PatchPath(string path, NSDictionary parameters, Action<AFHTTPRequestOperation, NSObject> success, [NullAllowed] Action<AFHTTPRequestOperation, NSError> failure);
        
        //[Field ("kAFUploadStream3GSuggestedPacketSize", "__Internal")]
        //uint kAFUploadStream3GSuggestedPacketSize { get; }
        
        [Field("kAFUploadStream3GSuggestedDelay", "__Internal")]
        double kAFUploadStream3GSuggestedDelay { get; }
    }

    [Model]
    public partial interface AFMultipartFormData
    {
        
        [Export("appendPartWithFileURL:name:error:")]
        bool AppendPartWithFileURL(NSUrl fileURL, string name, out NSError error);

        [Export("appendPartWithFileURL:name:fileName:mimeType:error:")]
        bool AppendPartWithFileURL(NSUrl fileURL, string name, string fileName, string mimeType, out NSError error);

        [Export("appendPartWithFileData:name:fileName:mimeType:")]
        void AppendPartWithFileData(NSData data, string name, string fileName, string mimeType);

        [Export("appendPartWithFormData:name:")]
        void AppendPartWithFormData(NSData data, string name);

        [Export("appendPartWithHeaders:body:")]
        void AppendPartWithHeaders(NSDictionary headers, NSData body);

        [Export("throttleBandwidthWithPacketSize:delay:")]
        void ThrottleBandwidthWithPacketSize(uint numberOfBytes, double delay);
    }
    */
    /*

    [BaseType(typeof(AFHTTPRequestOperation))]
    public partial interface AFImageRequestOperation
    {
		
        [Export("responseImage")]
        UIImage ResponseImage { get; }

        [Static, Export("imageRequestOperationWithRequest:success:")]
        AFImageRequestOperation ImageRequestOperationWithRequest(NSUrlRequest urlRequest, AFImageRequestCallback success);

        [Static, Export("imageRequestOperationWithRequest:imageProcessingBlock:success:failure:")]
        AFImageRequestOperation ImageRequestOperationWithRequest(NSUrlRequest urlRequest, AFImageRequestImageProcessingCallback imageProcessingBlock, AFImageRequestDetailedCallback success, AFImageRequestFailedCallback failed);
    }

    [BaseType(typeof(AFHTTPRequestOperation))]
    public partial interface AFJSONRequestOperation
    {
		
        [Export("responseJSON")]
        NSObject ResponseJSON { get; }
		
        //[Export ("JSONReadingOptions")]
		//NSJSONReadingOptions JSONReadingOptions { get; set; }
		
        //[Static, Export ("JSONRequestOperationWithRequest:success:failure:")]
		//instancetype JSONRequestOperationWithRequest (NSURLRequest urlRequest, [unmapped: blockpointer: BlockPointer] success, [unmapped: blockpointer: BlockPointer] failure);
    }

    [BaseType(typeof(AFHTTPRequestOperation))]
    public partial interface AFPropertyListRequestOperation
    {
		
        [Export("responsePropertyList")]
        NSObject ResponsePropertyList { get; }

        [Export("propertyListReadOptions")]
        NSPropertyListReadOptions PropertyListReadOptions { get; set; }
		
        [Static, Export ("propertyListRequestOperationWithRequest:success:failure:")]
		instancetype PropertyListRequestOperationWithRequest (NSURLRequest urlRequest, [unmapped: blockpointer: BlockPointer] success, [unmapped: blockpointer: BlockPointer] failure);
    }



    [BaseType(typeof(AFHTTPRequestOperation))]
    public partial interface AFXMLRequestOperation
    {
		
        //[Export ("responseXMLParser")]
		//NSXMLParser ResponseXMLParser { get; }
		
		//[Export ("responseXMLDocument")]
		//NSXMLDocument ResponseXMLDocument { get; }
		
        //Static, Export ("XMLParserRequestOperationWithRequest:success:failure:")]
		//instancetype XMLParserRequestOperationWithRequest (NSURLRequest urlRequest, [unmapped: blockpointer: BlockPointer] success, [unmapped: blockpointer: BlockPointer] failure);
		
		//[Static, Export ("XMLDocumentRequestOperationWithRequest:success:failure:")]
		//instancetype XMLDocumentRequestOperationWithRequest (NSURLRequest urlRequest, [unmapped: blockpointer: BlockPointer] success, [unmapped: blockpointer: BlockPointer] failure);
    }

    [BaseType(typeof(UIImageView))]
    [Category]
    interface AFNetworkingImageExtras
    {
        [Export("setImageWithURL:")]
        void SetImageUrl(NSUrl url);

        [Export("setImageWithURL:placeholderImage:")]
        void SetImageUrl(NSUrl url, UIImage placeholderImage);
    }
    */

}

