namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Cmdlets
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>Deletes a configuration store.</summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.Remove, @"AzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName", HelpUri = "Deletes a configuration store.", SupportsShouldProcess = true)]
    [System.Management.Automation.OutputType(typeof(bool))]
    public class RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName : System.Management.Automation.PSCmdlet, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener
    {
        /// <summary>A unique id generatd for the this cmdlet when it is instantiated.</summary>
        private string __correlationId = System.Guid.NewGuid().ToString();
        /// <summary>A copy of the Invocation Info (necessary to allow asJob to clone this cmdlet)</summary>
         private System.Management.Automation.InvocationInfo __invocationInfo;
        /// <summary>A unique id generatd for the this cmdlet when ProcessRecord() is called.</summary>
         private string __processRecordId;
        /// <summary>The <see cref="System.Threading.CancellationTokenSource" /> for this operation.</summary>
        private System.Threading.CancellationTokenSource _cancellationTokenSource = new System.Threading.CancellationTokenSource();
        /// <summary>when specified, runs this cmdlet as a PowerShell job</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "Run the command as a job")]
        public System.Management.Automation.SwitchParameter AsJob {get;set;}
        /// <summary>Wait for .NET debugger to attach</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow= true, HelpMessage = "Wait for .NET debugger to attach")]
        public System.Management.Automation.SwitchParameter Break {get;set;}
        /// <summary>The reference to the client API class.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.AppConfiguration Client => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Module.Instance.ClientAPI;
        /// <summary>Backing field for <see cref="ConfigStoreName" /> property.</summary>
        private string _configStoreName;

        /// <summary>The name of the configuration store.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the configuration store.")]
        public string ConfigStoreName
        {
            get
            {
                return this._configStoreName;
            }
            set
            {
                this._configStoreName = value;
            }
        }
        /// <summary>
        /// The credentials, account, tenant, and subscription used for communication with Azure
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The credentials, account, tenant, and subscription used for communication with Azure.")]
        [System.Management.Automation.ValidateNotNull]
        [System.Management.Automation.Alias("AzureRMContext", "AzureCredential")]
        public object DefaultProfile {get;set;}
        /// <summary>SendAsync Pipeline Steps to be appended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow= true, HelpMessage = "SendAsync Pipeline Steps to be appended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[] HttpPipelineAppend {get;set;}
        /// <summary>SendAsync Pipeline Steps to be prepended to the front of the pipeline</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow= true, HelpMessage = "SendAsync Pipeline Steps to be prepended to the front of the pipeline")]
        [System.Management.Automation.ValidateNotNull]
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[] HttpPipelinePrepend {get;set;}
        /// <summary>Accessor for our copy of the InvocationInfo.</summary>
        public System.Management.Automation.InvocationInfo InvocationInformation
        {
            get
            {
                return __invocationInfo = __invocationInfo ?? this.MyInvocation ;
            }
            set
            {
                __invocationInfo = value;
            }
        }
        /// <summary>
        /// <see cref="IEventListener" /> cancellation delegate. Stops the cmdlet when called.
        /// </summary>
         System.Action Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener.Cancel => _cancellationTokenSource.Cancel;
        /// <summary><see cref="IEventListener" /> cancellation token.</summary>
         System.Threading.CancellationToken Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener.Token => _cancellationTokenSource.Token;
        /// <summary>
        /// When specified, PassThru will force the cmdlet return a 'bool' given that there isn't a return type by default.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "When specified, PassThru will force the cmdlet return a 'bool' given that there isn't a return type by default.")]
        public System.Management.Automation.SwitchParameter PassThru {get;set;}
        /// <summary>
        /// The instance of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.HttpPipeline" /> that the remote call will use.
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.HttpPipeline Pipeline {get;set;}
        /// <summary>The URI for the proxy server to use</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow= true, HelpMessage = "The URI for the proxy server to use")]
        public System.Uri Proxy {get;set;}
        /// <summary>Credentials for a proxy server to use for the remote call</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow= true, HelpMessage = "Credentials for a proxy server to use for the remote call")]
        [System.Management.Automation.ValidateNotNull]
        public System.Management.Automation.PSCredential ProxyCredential {get;set;}
        /// <summary>Use the default credentials for the proxy</summary>
        [System.Management.Automation.Parameter(Mandatory = false, DontShow= true, HelpMessage = "Use the default credentials for the proxy")]
        public System.Management.Automation.SwitchParameter ProxyUseDefaultCredentials {get;set;}
        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group to which the container registry belongs.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name of the resource group to which the container registry belongs.")]
        public string ResourceGroupName
        {
            get
            {
                return this._resourceGroupName;
            }
            set
            {
                this._resourceGroupName = value;
            }
        }
        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The Microsoft Azure subscription ID.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The Microsoft Azure subscription ID.")]
        public string SubscriptionId
        {
            get
            {
                return this._subscriptionId;
            }
            set
            {
                this._subscriptionId = value;
            }
        }
        /// <summary>
        /// (overrides the default BeginProcessing method in System.Management.Automation.PSCmdlet)
        /// </summary>

        protected override void BeginProcessing()
        {
            Module.Instance.SetProxyConfiguration(Proxy, ProxyCredential, ProxyUseDefaultCredentials);
            if (Break)
            {
                System.AttachDebugger.Break();
            }
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletBeginProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }
        /// <summary>Creates a duplicate instance of this cmdlet (via JSON serialization).</summary>
        /// <returns>
        /// a duplicate instance of RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Cmdlets.RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName Clone()
        {
            var clone = FromJson(this.ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeAll));
            clone.HttpPipelinePrepend = this.HttpPipelinePrepend;
            clone.HttpPipelineAppend = this.HttpPipelineAppend;
            return clone;
        }
        /// <summary>Performs clean-up after the command execution</summary>

        protected override void EndProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletEndProcessing).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
        }
        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" /> into a new instance of this class.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Cmdlets.RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json ? new RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName(json) : null;
        }
        /// <summary>
        /// Creates a new instance of this cmdlet, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this cmdlet.</param>
        /// <returns>
        /// returns a new instance of the <see cref="RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName" />
        /// cmdlet
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Cmdlets.RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName FromJsonString(string jsonText) => string.IsNullOrEmpty(jsonText) ? null : FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject.Parse(jsonText));
        /// <summary>Handles/Dispatches events during the call to the REST service.</summary>
        /// <param name="id">The message id</param>
        /// <param name="token">The message cancellation token. When this call is cancelled, this should be <c>true</c></param>
        /// <param name="messageData">Detailed message data for the message event.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the message is completed.
        /// </returns>
         async System.Threading.Tasks.Task Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener.Signal(string id, System.Threading.CancellationToken token, System.Func<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.EventData> messageData)
        {
            using( NoSynchronizationContext )
            {
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                switch ( id )
                {
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Verbose:
                    {
                        WriteVerbose($"{messageData().Message ?? System.String.Empty}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Warning:
                    {
                        WriteWarning($"{messageData().Message ?? System.String.Empty}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Information:
                    {
                        var data = messageData();
                        WriteInformation(data, new[] { data.Message });
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Debug:
                    {
                        WriteDebug($"{messageData().Message ?? System.String.Empty}");
                        return ;
                    }
                    case Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Error:
                    {
                        WriteError(new System.Management.Automation.ErrorRecord( new System.Exception(messageData().Message), string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null ) );
                        return ;
                    }
                }
                await Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Module.Instance.Signal(id, token, messageData, (i,t,m) => ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(i,t,()=> Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.EventDataConverter.ConvertFrom( m() ) as Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.EventData ), InvocationInformation, this.ParameterSetName, __correlationId, __processRecordId, null );
                if (token.IsCancellationRequested)
                {
                    return ;
                }
                WriteDebug($"{id}: {messageData().Message ?? System.String.Empty}");
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletProcessRecordStart).Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
            __processRecordId = System.Guid.NewGuid().ToString();
            try
            {
                // work
                if (ShouldProcess($"Call remote 'ConfigurationStores_Delete' operation"))
                {
                    if (true == MyInvocation?.BoundParameters?.ContainsKey("AsJob"))
                    {
                        var instance = this.Clone();
                        var job = new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.PowerShell.AsyncJob(instance, this.MyInvocation.Line, this.MyInvocation.MyCommand.Name, this._cancellationTokenSource.Token, this._cancellationTokenSource.Cancel);
                        JobRepository.Add(job);
                        var task = instance.ProcessRecordAsync();
                        job.Monitor(task);
                        WriteObject(job);
                    }
                    else
                    {
                        using( var asyncCommandRuntime = new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.PowerShell.AsyncCommandRuntime(this, ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token) )
                        {
                            asyncCommandRuntime.Wait( ProcessRecordAsync(),((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token);
                        }
                    }
                }
            }
            catch (System.AggregateException aggregateException)
            {
                // unroll the inner exceptions to get the root cause
                foreach( var innerException in aggregateException.Flatten().InnerExceptions )
                {
                    ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletException, $"{innerException.GetType().Name} - {innerException.Message} : {innerException.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    // Write exception out to error channel.
                    WriteError( new System.Management.Automation.ErrorRecord(innerException,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
                }
            }
            catch (System.Exception exception) when ((exception as System.Management.Automation.PipelineStoppedException)!= null && (exception as System.Management.Automation.PipelineStoppedException).InnerException == null)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                ThrowTerminatingError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            catch (System.Exception exception)
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletException, $"{exception.GetType().Name} - {exception.Message} : {exception.StackTrace}").Wait(); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                // Write exception out to error channel.
                WriteError( new System.Management.Automation.ErrorRecord(exception,string.Empty, System.Management.Automation.ErrorCategory.NotSpecified, null) );
            }
            finally
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletProcessRecordEnd).Wait();
            }
        }
        /// <summary>Performs execution of the command, working asynchronously if required.</summary>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        protected async System.Threading.Tasks.Task ProcessRecordAsync()
        {
            using( NoSynchronizationContext )
            {
                await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletProcessRecordAsyncStart); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletGetPipeline); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                Pipeline = Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Module.Instance.CreatePipeline(InvocationInformation, __correlationId, __processRecordId);
                Pipeline.Prepend(HttpPipelinePrepend);
                Pipeline.Append(HttpPipelineAppend);
                // get the client instance
                try
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletBeforeAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                    await this.Client.ConfigurationStoresDelete(SubscriptionId, ResourceGroupName, ConfigStoreName, onOK, onNoContent, onDefault, this, Pipeline);
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletAfterAPICall); if( ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Token.IsCancellationRequested ) { return; }
                }
                finally
                {
                    await ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.CmdletProcessRecordAsyncEnd);
                }
            }
        }
        /// <summary>
        /// Intializes a new instance of the <see cref="RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName"
        /// /> cmdlet class.
        /// </summary>
        public RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName()
        {
        }
        /// <summary>Constructor for deserialization.</summary>
        /// <param name="json">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject" /> to deserialize from.</param>
        internal RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json)
        {
            // deserialize the contents
            _subscriptionId = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("SubscriptionId"), out var __jsonSubscriptionId) ? (string)__jsonSubscriptionId : (string)SubscriptionId;
            _resourceGroupName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("ResourceGroupName"), out var __jsonResourceGroupName) ? (string)__jsonResourceGroupName : (string)ResourceGroupName;
            _configStoreName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("ConfigStoreName"), out var __jsonConfigStoreName) ? (string)__jsonConfigStoreName : (string)ConfigStoreName;
        }
        /// <summary>Interrupts currently running code within the command.</summary>

        protected override void StopProcessing()
        {
            ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener)this).Cancel();
            base.StopProcessing();
        }
        /// <summary>
        /// Serializes the state of this cmdlet to a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" /> object.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="RemoveAzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName" /> as a
        /// <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode serializationMode)
        {
            // serialization method
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject();
            AddIf( null != (((object)SubscriptionId)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(SubscriptionId.ToString()) : null, "SubscriptionId" ,container.Add );
            AddIf( null != (((object)ResourceGroupName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(ResourceGroupName.ToString()) : null, "ResourceGroupName" ,container.Add );
            AddIf( null != (((object)ConfigStoreName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(ConfigStoreName.ToString()) : null, "ConfigStoreName" ,container.Add );
            return container;
        }
        /// <summary>
        /// a delegate that is called when the remote service returns default (any response code not handled elsewhere).
        /// </summary>
        /// <param name="responseMessage">the raw response message as an System.Net.Http.HttpResponseMessage.</param>
        /// <param name="response">the body result as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError"
        /// /> from the remote call</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async System.Threading.Tasks.Task onDefault(System.Net.Http.HttpResponseMessage responseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError> response)
        {
            using( NoSynchronizationContext )
            {
                // Error Response : default
                var code = (await response).Code;;
                var message = (await response).Message;;
                if ((null == code || null == message))
                {
                    // Unrecognized Response. Create an error record based on what we have.
                    WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"The service encountered an unexpected result: {responseMessage.StatusCode}\nBody: {await responseMessage.Content.ReadAsStringAsync()}"), responseMessage.StatusCode.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId,ResourceGroupName,ConfigStoreName}));
                }
                else
                {
                    WriteError(new System.Management.Automation.ErrorRecord(new System.Exception($"[{code}] : {message}"), code?.ToString(), System.Management.Automation.ErrorCategory.InvalidOperation, new { SubscriptionId,ResourceGroupName,ConfigStoreName}));
                }
            }
        }
        /// <summary>a delegate that is called when the remote service returns 204 (NoContent).</summary>
        /// <param name="responseMessage">the raw response message as an System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async System.Threading.Tasks.Task onNoContent(System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                // onNoContent - response for 204 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }
        /// <summary>a delegate that is called when the remote service returns 200 (OK).</summary>
        /// <param name="responseMessage">the raw response message as an System.Net.Http.HttpResponseMessage.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the method is completed.
        /// </returns>
        private async System.Threading.Tasks.Task onOK(System.Net.Http.HttpResponseMessage responseMessage)
        {
            using( NoSynchronizationContext )
            {
                // onOK - response for 200 /
                if (true == MyInvocation?.BoundParameters?.ContainsKey("PassThru"))
                {
                    WriteObject(true);
                }
            }
        }
    }
}