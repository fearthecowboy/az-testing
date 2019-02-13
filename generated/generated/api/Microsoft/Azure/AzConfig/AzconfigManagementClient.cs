namespace Microsoft.Azure.AzConfig
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>
    /// Low-level API implementation for the AzconfigManagementClient service.
    /// </summary>
    public class AzconfigManagementClient
    {

        /// <summary>Creates a configuration store with the specified parameters.</summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for creating a configuration store.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresCreate(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, Microsoft.Azure.AzConfig.Models.IConfigurationStore body, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(SubscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(ResourceGroupName)
                        + "/providers/Microsoft.Azconfig/configurationStores/"
                        + System.Uri.EscapeDataString(ConfigStoreName)
                        + ""
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresCreate_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresCreate_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    while (_response.StatusCode == System.Net.HttpStatusCode.Created || _response.StatusCode == System.Net.HttpStatusCode.Accepted )
                    {

                        // get the delay before polling.
                        if (!int.TryParse( _response.GetFirstHeader(@"RetryAfter"), out int delay))
                        {
                            delay = 30;
                        }
                        await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.DelayBeforePolling, $"Delaying {delay} seconds before polling.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // start the delay timer (we'll await later...)
                        var waiting = System.Threading.Tasks.Task.Delay(delay * 1000, eventListener.Token );

                        // while we wait, let's grab the headers and get ready to poll.
                        var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        var location = _response.GetFirstHeader(@"Location");
                        var _uri = System.String.IsNullOrEmpty(asyncOperation) ? System.String.IsNullOrEmpty(location) ? _originalUri : location : asyncOperation;
                        request = request.CloneAndDispose(new System.Uri(_uri), Microsoft.Azure.AzConfig.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = _response.Content.ReadAsStringAsync();
                        await waiting;

                        // check for cancellation
                        if( eventListener.Token.IsCancellationRequested ) { return; }
                        await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Polling, $"Polling {_uri}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);

                        if( _response.StatusCode == System.Net.HttpStatusCode.OK && string.IsNullOrEmpty(asyncOperation))
                        {
                            try {
                                // we have a 200, and a should have a provisioning state.
                                if( Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.AzConfig.Runtime.Json.JsonObject json)
                                {
                                    var state = json.Property("properties")?.PropertyT<Microsoft.Azure.AzConfig.Runtime.Json.JsonString>("provisioningState");
                                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Polling, $"Polled {_uri} provisioning state  {state}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                                    if( state?.ToString() != "Succeeded")
                                    {
                                        _response.StatusCode = System.Net.HttpStatusCode.Created;
                                    }
                                }
                            } catch {
                                // um.. whatever.
                            }
                        }

                        // check for terminal status code
                        if (_response.StatusCode != System.Net.HttpStatusCode.Created && _response.StatusCode != System.Net.HttpStatusCode.Accepted )
                        {
                            // we're done polling, do a request on final target?
                            // declared final-state-via: default
                            // final get on the original URI
                            request = request.CloneAndDispose(new System.Uri(_originalUri), Microsoft.Azure.AzConfig.Runtime.Method.Get);

                            // drop the old response
                            _response?.Dispose();

                            // make the final call
                            _response = await sender.SendAsync(request,  eventListener);
                            break;
                        }
                    }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.ConfigurationStore.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresCreate" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for creating a configuration store.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresCreate_Validate(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, Microsoft.Azure.AzConfig.Models.IConfigurationStore body, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SubscriptionId),SubscriptionId);
                await eventListener.AssertNotNull(nameof(ResourceGroupName),ResourceGroupName);
                await eventListener.AssertNotNull(nameof(ConfigStoreName),ConfigStoreName);
                await eventListener.AssertMinimumLength(nameof(ConfigStoreName),ConfigStoreName,5);
                await eventListener.AssertMaximumLength(nameof(ConfigStoreName),ConfigStoreName,50);
                await eventListener.AssertRegEx(nameof(ConfigStoreName),ConfigStoreName,@"^[a-zA-Z0-9_-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
        /// <summary>Deletes a configuration store.</summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresDelete(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task> onNoContent, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(SubscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(ResourceGroupName)
                        + "/providers/Microsoft.Azconfig/configurationStores/"
                        + System.Uri.EscapeDataString(ConfigStoreName)
                        + ""
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresDelete_Call(request,onOK,onNoContent,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresDelete" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresDelete_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task> onNoContent, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    while (_response.StatusCode == System.Net.HttpStatusCode.Created || _response.StatusCode == System.Net.HttpStatusCode.Accepted )
                    {

                        // get the delay before polling.
                        if (!int.TryParse( _response.GetFirstHeader(@"RetryAfter"), out int delay))
                        {
                            delay = 30;
                        }
                        await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.DelayBeforePolling, $"Delaying {delay} seconds before polling.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // start the delay timer (we'll await later...)
                        var waiting = System.Threading.Tasks.Task.Delay(delay * 1000, eventListener.Token );

                        // while we wait, let's grab the headers and get ready to poll.
                        var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        var location = _response.GetFirstHeader(@"Location");
                        var _uri = System.String.IsNullOrEmpty(asyncOperation) ? System.String.IsNullOrEmpty(location) ? _originalUri : location : asyncOperation;
                        request = request.CloneAndDispose(new System.Uri(_uri), Microsoft.Azure.AzConfig.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = _response.Content.ReadAsStringAsync();
                        await waiting;

                        // check for cancellation
                        if( eventListener.Token.IsCancellationRequested ) { return; }
                        await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Polling, $"Polling {_uri}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);

                        if( _response.StatusCode == System.Net.HttpStatusCode.OK && string.IsNullOrEmpty(asyncOperation))
                        {
                            try {
                                // we have a 200, and a should have a provisioning state.
                                if( Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.AzConfig.Runtime.Json.JsonObject json)
                                {
                                    var state = json.Property("properties")?.PropertyT<Microsoft.Azure.AzConfig.Runtime.Json.JsonString>("provisioningState");
                                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Polling, $"Polled {_uri} provisioning state  {state}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                                    if( state?.ToString() != "Succeeded")
                                    {
                                        _response.StatusCode = System.Net.HttpStatusCode.Created;
                                    }
                                }
                            } catch {
                                // um.. whatever.
                            }
                        }

                        // check for terminal status code
                        if (_response.StatusCode != System.Net.HttpStatusCode.Created && _response.StatusCode != System.Net.HttpStatusCode.Accepted )
                        {
                            // we're done polling, do a request on final target?
                            // declared final-state-via: default
                            // final get on the the Location header, if present
                            var finalLocation = _response.GetFirstHeader(@"Location");
                        }
                    }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response);
                            break;
                        }
                        case System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresDelete" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresDelete_Validate(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SubscriptionId),SubscriptionId);
                await eventListener.AssertNotNull(nameof(ResourceGroupName),ResourceGroupName);
                await eventListener.AssertNotNull(nameof(ConfigStoreName),ConfigStoreName);
                await eventListener.AssertMinimumLength(nameof(ConfigStoreName),ConfigStoreName,5);
                await eventListener.AssertMaximumLength(nameof(ConfigStoreName),ConfigStoreName,50);
                await eventListener.AssertRegEx(nameof(ConfigStoreName),ConfigStoreName,@"^[a-zA-Z0-9_-]*$");
            }
        }
        /// <summary>Gets the properties of the specified configuration store.</summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresGet(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(SubscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(ResourceGroupName)
                        + "/providers/Microsoft.Azconfig/configurationStores/"
                        + System.Uri.EscapeDataString(ConfigStoreName)
                        + ""
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresGet_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresGet_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.ConfigurationStore.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresGet_Validate(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SubscriptionId),SubscriptionId);
                await eventListener.AssertNotNull(nameof(ResourceGroupName),ResourceGroupName);
                await eventListener.AssertNotNull(nameof(ConfigStoreName),ConfigStoreName);
                await eventListener.AssertMinimumLength(nameof(ConfigStoreName),ConfigStoreName,5);
                await eventListener.AssertMaximumLength(nameof(ConfigStoreName),ConfigStoreName,50);
                await eventListener.AssertRegEx(nameof(ConfigStoreName),ConfigStoreName,@"^[a-zA-Z0-9_-]*$");
            }
        }
        /// <summary>Lists the configuration stores for a given subscription.</summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresList(string SubscriptionId, string SkipToken, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStoreListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(SubscriptionId)
                        + "/providers/Microsoft.Azconfig/configurationStores"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(SkipToken) ? System.String.Empty : "$skipToken=" + System.Uri.EscapeDataString(SkipToken))
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresList_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Lists the configuration stores for a given resource group.</summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresListByResourceGroup(string SubscriptionId, string ResourceGroupName, string SkipToken, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStoreListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(SubscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(ResourceGroupName)
                        + "/providers/Microsoft.Azconfig/configurationStores"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(SkipToken) ? System.String.Empty : "$skipToken=" + System.Uri.EscapeDataString(SkipToken))
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresListByResourceGroup_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>
        /// Actual wire call for <see cref="ConfigurationStoresListByResourceGroup" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresListByResourceGroup_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStoreListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.ConfigurationStoreListResult.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresListByResourceGroup" /> method. Call this like the actual call, but
        /// you will get validation events back.
        /// </summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresListByResourceGroup_Validate(string SubscriptionId, string ResourceGroupName, string SkipToken, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SubscriptionId),SubscriptionId);
                await eventListener.AssertNotNull(nameof(ResourceGroupName),ResourceGroupName);
                await eventListener.AssertNotNull(nameof(SkipToken),SkipToken);
            }
        }
        /// <summary>Lists the access key for the specified configuration store.</summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresListKeys(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, string SkipToken, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IApiKeyListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(SubscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(ResourceGroupName)
                        + "/providers/Microsoft.Azconfig/configurationStores/"
                        + System.Uri.EscapeDataString(ConfigStoreName)
                        + "/ListKeys"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(SkipToken) ? System.String.Empty : "$skipToken=" + System.Uri.EscapeDataString(SkipToken))
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresListKeys_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresListKeys" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresListKeys_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IApiKeyListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.ApiKeyListResult.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresListKeys" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresListKeys_Validate(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, string SkipToken, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SubscriptionId),SubscriptionId);
                await eventListener.AssertNotNull(nameof(ResourceGroupName),ResourceGroupName);
                await eventListener.AssertNotNull(nameof(ConfigStoreName),ConfigStoreName);
                await eventListener.AssertMinimumLength(nameof(ConfigStoreName),ConfigStoreName,5);
                await eventListener.AssertMaximumLength(nameof(ConfigStoreName),ConfigStoreName,50);
                await eventListener.AssertRegEx(nameof(ConfigStoreName),ConfigStoreName,@"^[a-zA-Z0-9_-]*$");
                await eventListener.AssertNotNull(nameof(SkipToken),SkipToken);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresList_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStoreListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.ConfigurationStoreListResult.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresList" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresList_Validate(string SubscriptionId, string SkipToken, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SubscriptionId),SubscriptionId);
                await eventListener.AssertNotNull(nameof(SkipToken),SkipToken);
            }
        }
        /// <summary>Regenerates an access key for the specified configuration store.</summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for regenerating an access key.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresRegenerateKey(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, Microsoft.Azure.AzConfig.Models.IRegenerateKeyParameters body, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IApiKey>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(SubscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(ResourceGroupName)
                        + "/providers/Microsoft.Azconfig/configurationStores/"
                        + System.Uri.EscapeDataString(ConfigStoreName)
                        + "/RegenerateKey"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresRegenerateKey_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresRegenerateKey" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresRegenerateKey_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IApiKey>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.ApiKey.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresRegenerateKey" /> method. Call this like the actual call, but you
        /// will get validation events back.
        /// </summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for regenerating an access key.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresRegenerateKey_Validate(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, Microsoft.Azure.AzConfig.Models.IRegenerateKeyParameters body, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SubscriptionId),SubscriptionId);
                await eventListener.AssertNotNull(nameof(ResourceGroupName),ResourceGroupName);
                await eventListener.AssertNotNull(nameof(ConfigStoreName),ConfigStoreName);
                await eventListener.AssertMinimumLength(nameof(ConfigStoreName),ConfigStoreName,5);
                await eventListener.AssertMaximumLength(nameof(ConfigStoreName),ConfigStoreName,50);
                await eventListener.AssertRegEx(nameof(ConfigStoreName),ConfigStoreName,@"^[a-zA-Z0-9_-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
        /// <summary>Updates a configuration store with the specified parameters.</summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for updating a configuration store.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresUpdate(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters body, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(SubscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(ResourceGroupName)
                        + "/providers/Microsoft.Azconfig/configurationStores/"
                        + System.Uri.EscapeDataString(ConfigStoreName)
                        + ""
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresUpdate_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresUpdate_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    while (_response.StatusCode == System.Net.HttpStatusCode.Created || _response.StatusCode == System.Net.HttpStatusCode.Accepted )
                    {

                        // get the delay before polling.
                        if (!int.TryParse( _response.GetFirstHeader(@"RetryAfter"), out int delay))
                        {
                            delay = 30;
                        }
                        await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.DelayBeforePolling, $"Delaying {delay} seconds before polling.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // start the delay timer (we'll await later...)
                        var waiting = System.Threading.Tasks.Task.Delay(delay * 1000, eventListener.Token );

                        // while we wait, let's grab the headers and get ready to poll.
                        var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        var location = _response.GetFirstHeader(@"Location");
                        var _uri = System.String.IsNullOrEmpty(asyncOperation) ? System.String.IsNullOrEmpty(location) ? _originalUri : location : asyncOperation;
                        request = request.CloneAndDispose(new System.Uri(_uri), Microsoft.Azure.AzConfig.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = _response.Content.ReadAsStringAsync();
                        await waiting;

                        // check for cancellation
                        if( eventListener.Token.IsCancellationRequested ) { return; }
                        await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Polling, $"Polling {_uri}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);

                        if( _response.StatusCode == System.Net.HttpStatusCode.OK && string.IsNullOrEmpty(asyncOperation))
                        {
                            try {
                                // we have a 200, and a should have a provisioning state.
                                if( Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.AzConfig.Runtime.Json.JsonObject json)
                                {
                                    var state = json.Property("properties")?.PropertyT<Microsoft.Azure.AzConfig.Runtime.Json.JsonString>("provisioningState");
                                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Polling, $"Polled {_uri} provisioning state  {state}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                                    if( state?.ToString() != "Succeeded")
                                    {
                                        _response.StatusCode = System.Net.HttpStatusCode.Created;
                                    }
                                }
                            } catch {
                                // um.. whatever.
                            }
                        }

                        // check for terminal status code
                        if (_response.StatusCode != System.Net.HttpStatusCode.Created && _response.StatusCode != System.Net.HttpStatusCode.Accepted )
                        {
                            // we're done polling, do a request on final target?
                            // declared final-state-via: default
                            // final get on the original URI
                            request = request.CloneAndDispose(new System.Uri(_originalUri), Microsoft.Azure.AzConfig.Runtime.Method.Get);

                            // drop the old response
                            _response?.Dispose();

                            // make the final call
                            _response = await sender.SendAsync(request,  eventListener);
                            break;
                        }
                    }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.ConfigurationStore.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresUpdate" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="ResourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="ConfigStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for updating a configuration store.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresUpdate_Validate(string SubscriptionId, string ResourceGroupName, string ConfigStoreName, Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters body, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SubscriptionId),SubscriptionId);
                await eventListener.AssertNotNull(nameof(ResourceGroupName),ResourceGroupName);
                await eventListener.AssertNotNull(nameof(ConfigStoreName),ConfigStoreName);
                await eventListener.AssertMinimumLength(nameof(ConfigStoreName),ConfigStoreName,5);
                await eventListener.AssertMaximumLength(nameof(ConfigStoreName),ConfigStoreName,50);
                await eventListener.AssertRegEx(nameof(ConfigStoreName),ConfigStoreName,@"^[a-zA-Z0-9_-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
        /// <summary>Checks whether the configuration store name is available for use.</summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="body">The object containing information for the availability request.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task OperationsCheckNameAvailability(string SubscriptionId, Microsoft.Azure.AzConfig.Models.ICheckNameAvailabilityParameters body, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.INameAvailabilityStatus>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(SubscriptionId)
                        + "/providers/Microsoft.Azconfig/checkNameAvailability"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsCheckNameAvailability_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="OperationsCheckNameAvailability" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task OperationsCheckNameAvailability_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.INameAvailabilityStatus>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.NameAvailabilityStatus.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="OperationsCheckNameAvailability" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="SubscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="body">The object containing information for the availability request.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task OperationsCheckNameAvailability_Validate(string SubscriptionId, Microsoft.Azure.AzConfig.Models.ICheckNameAvailabilityParameters body, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SubscriptionId),SubscriptionId);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
        /// <summary>Lists the operations available from this provider.</summary>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task OperationsList(string SkipToken, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IOperationDefinitionListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            string ApiVersion = @"2018-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//providers/Microsoft.Azconfig/operations"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(ApiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(SkipToken) ? System.String.Empty : "$skipToken=" + System.Uri.EscapeDataString(SkipToken))
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.AzConfig.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.OperationsList_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="OperationsList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.AzConfig.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task OperationsList_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IOperationDefinitionListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.AzConfig.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener, Microsoft.Azure.AzConfig.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.OperationDefinitionListResult.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.AzConfig.Models.Error.FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.AzConfig.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="OperationsList" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task OperationsList_Validate(string SkipToken, Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(SkipToken),SkipToken);
            }
        }
    }
}