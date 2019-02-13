namespace Microsoft.Azure.AzConfig
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    using SendAsyncStepDelegate = System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>;
    using PipelineChangeDelegate = System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>;
    using GetParameterDelegate = System.Func<string, string, System.Management.Automation.InvocationInfo, string, string, object>;
    using ModuleLoadPipelineDelegate = System.Action<string, string, System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>, System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>>;
    using NewRequestPipelineDelegate = System.Action<System.Management.Automation.InvocationInfo, string, string, System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>, System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>>;
    using ArgumentCompleterDelegate = System.Func<string, System.Management.Automation.InvocationInfo, string, string[], string[], string[]>;
    using SignalDelegate = System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>;
    using EventListenerDelegate = System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Management.Automation.InvocationInfo, string, string, string, System.Exception, System.Threading.Tasks.Task>;
    using NextDelegate = System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>;
    /// <summary>A class that contains the module-common code and data.</summary>
    public partial class Module
    {
        /// <summary>FIXME: Field _handler is MISSING DESCRIPTION</summary>
        public System.Net.Http.HttpClientHandler _handler = new System.Net.Http.HttpClientHandler();
        /// <summary>the ISendAsync pipeline instance</summary>
         private Microsoft.Azure.AzConfig.Runtime.HttpPipeline _pipeline;
        /// <summary>the ISendAsync pipeline instance (when proxy is enabled)</summary>
         private Microsoft.Azure.AzConfig.Runtime.HttpPipeline _pipelineWithProxy;
        /// <summary>FIXME: Field _webProxy is MISSING DESCRIPTION</summary>
        public System.Net.WebProxy _webProxy = new System.Net.WebProxy();
        /// <summary>Gets completion data for azure specific fields</summary>
        public ArgumentCompleterDelegate ArgumentCompleter {get;set;}
        /// <summary>The instance of the Client API</summary>
        public Microsoft.Azure.AzConfig.AzconfigManagementClient ClientAPI {get;set;}
        /// <summary>A delegate that gets called for each signalled event</summary>
        public EventListenerDelegate EventListener {get;set;}
        /// <summary>The delegate to call to get parameter data from a common module.</summary>
        public GetParameterDelegate GetParameterValue {get;set;}
        /// <summary>Backing field for <see cref="Instance" /> property.</summary>
        private static Microsoft.Azure.AzConfig.Module _instance;

        /// <summary>the singleton of this module class</summary>
        public static Microsoft.Azure.AzConfig.Module Instance => Microsoft.Azure.AzConfig.Module._instance?? (Microsoft.Azure.AzConfig.Module._instance = new Microsoft.Azure.AzConfig.Module());
        /// <summary>The Name of this module</summary>
        public string Name => @"AzconfigManagement";
        /// <summary>The delegate to call when this module is loaded (supporting a commmon module).</summary>
        public ModuleLoadPipelineDelegate OnModuleLoad {get;set;}
        /// <summary>The delegate to call before each new request (supporting a commmon module).</summary>
        public NewRequestPipelineDelegate OnNewRequest {get;set;}
        /// <summary>The ResourceID for this module (azure arm).</summary>
        public string ResourceId => @"AzconfigManagement";
        /// <summary>FIXME: Method AfterCreatePipeline is MISSING DESCRIPTION</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>
        partial void AfterCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref Microsoft.Azure.AzConfig.Runtime.HttpPipeline pipeline);
        /// <summary>FIXME: Method BeforeCreatePipeline is MISSING DESCRIPTION</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="pipeline">The HttpPipeline for the request</param>
        partial void BeforeCreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, ref Microsoft.Azure.AzConfig.Runtime.HttpPipeline pipeline);
        /// <summary>FIXME: Method CustomInit is MISSING DESCRIPTION</summary>

        partial void CustomInit();
        /// <summary>Creates an instance of the HttpPipeline for each call.</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="correlationId">the cmdlet's correlation id.</param>
        /// <param name="processRecordId">the cmdlet's process record correlation id.</param>
        /// <returns>An instance of Microsoft.Azure.AzConfig.Runtime.HttpPipeline for the remote call.</returns>
        public Microsoft.Azure.AzConfig.Runtime.HttpPipeline CreatePipeline(System.Management.Automation.InvocationInfo invocationInfo, string correlationId, string processRecordId)
        {
            Microsoft.Azure.AzConfig.Runtime.HttpPipeline pipeline = null;
            BeforeCreatePipeline(invocationInfo, ref pipeline);
            pipeline = (pipeline ?? (_handler.UseProxy ? _pipelineWithProxy : _pipeline)).Clone();
            AfterCreatePipeline(invocationInfo, ref pipeline);
            OnNewRequest?.Invoke( invocationInfo, correlationId,processRecordId, (step)=> { pipeline.Prepend(step); } , (step)=> { pipeline.Append(step); } );
            return pipeline;
        }
        /// <summary>Gets parameters from a common module.</summary>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="correlationId">the cmdlet's correlation id.</param>
        /// <param name="parameterName">The name of the parameter to get the value for.</param>
        /// <returns>
        /// The parameter value from the common module. (Note: this should be type converted on the way back)
        /// </returns>
        public object GetParameter(System.Management.Automation.InvocationInfo invocationInfo, string correlationId, string parameterName) => GetParameterValue?.Invoke( ResourceId, Name, invocationInfo, correlationId,parameterName );
        /// <summary>Initialization steps performed after the module is loaded.</summary>

        public void Init()
        {
            OnModuleLoad?.Invoke( ResourceId, Name ,(step)=> { _pipeline.Prepend(step); } , (step)=> { _pipeline.Append(step); } );
            OnModuleLoad?.Invoke( ResourceId, Name ,(step)=> { _pipelineWithProxy.Prepend(step); } , (step)=> { _pipelineWithProxy.Append(step); } );
            CustomInit();
        }
        /// <summary>Creates the module instance.</summary>
        private Module()
        {
            /// constructor
            ClientAPI = new Microsoft.Azure.AzConfig.AzconfigManagementClient();
            _handler.Proxy = _webProxy;
            _pipeline = new Microsoft.Azure.AzConfig.Runtime.HttpPipeline(new Microsoft.Azure.AzConfig.Runtime.HttpClientFactory(new System.Net.Http.HttpClient()));
            _pipelineWithProxy = new Microsoft.Azure.AzConfig.Runtime.HttpPipeline(new Microsoft.Azure.AzConfig.Runtime.HttpClientFactory(new System.Net.Http.HttpClient(_handler)));
        }
        /// <summary>FIXME: Method SetProxyConfiguration is MISSING DESCRIPTION</summary>
        /// <param name="proxy">The HTTP Proxy to use.</param>
        /// <param name="proxyCredential">The HTTP Proxy Credentials</param>
        /// <param name="proxyUseDefaultCredentials">True if the proxy should use default credentials</param>
        public void SetProxyConfiguration(System.Uri proxy, System.Management.Automation.PSCredential proxyCredential, bool proxyUseDefaultCredentials)
        {
            // set the proxy configuration
            _webProxy.Address = proxy;
            _webProxy.BypassProxyOnLocal = false;
            _webProxy.Credentials = proxyCredential ?.GetNetworkCredential();
            _webProxy.UseDefaultCredentials = proxyUseDefaultCredentials;
            _handler.UseProxy = proxy != null;
        }
        /// <summary>Called to dispatch events to the common module listener</summary>
        /// <param name="id">The ID of the event </param>
        /// <param name="token">The cancellation token for the event </param>
        /// <param name="getEventData">A delegate to get the detailed event data</param>
        /// <param name="signal">The callback for the event dispatcher </param>
        /// <param name="invocationInfo">The <see cref="System.Management.Automation.InvocationInfo" /> from the cmdlet</param>
        /// <param name="parameterSetName">the cmdlet's parameterset name.</param>
        /// <param name="correlationId">the cmdlet's correlation id.</param>
        /// <param name="processRecordId">the cmdlet's process record correlation id.</param>
        /// <param name="exception">the exception that is being thrown (if available)</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the event is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Signal(string id, System.Threading.CancellationToken token, System.Func<System.EventArgs> getEventData, SignalDelegate signal, System.Management.Automation.InvocationInfo invocationInfo, string parameterSetName, string correlationId, string processRecordId, System.Exception exception)
        {
            using( NoSynchronizationContext )
            {
                await EventListener?.Invoke(id,token,getEventData, signal, invocationInfo, parameterSetName, correlationId,processRecordId,exception);
            }
        }
    }
}