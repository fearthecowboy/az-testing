namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>
    /// Low-level API implementation for the AppConfiguration service.
    /// </summary>
    public class AppConfiguration
    {

        /// <summary>Checks whether the configuration store name is available for use.</summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="body">The object containing information for the availability request.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresCheckNameAvailability(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ICheckNameAvailabilityParameters body, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.INameAvailabilityStatus>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            string apiVersion = @"2019-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.AppConfiguration/checkNameAvailability"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(apiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresCheckNameAvailability_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>
        /// Actual wire call for <see cref="ConfigurationStoresCheckNameAvailability" /> method.
        /// </summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresCheckNameAvailability_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.INameAvailabilityStatus>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.NameAvailabilityStatus.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Error.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresCheckNameAvailability" /> method. Call this like the actual call,
        /// but you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="body">The object containing information for the availability request.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresCheckNameAvailability_Validate(string subscriptionId, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ICheckNameAvailabilityParameters body, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
        /// <summary>Creates a configuration store with the specified parameters.</summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for creating a configuration store.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresCreate(string subscriptionId, string resourceGroupName, string configStoreName, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore body, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            string apiVersion = @"2019-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.AppConfiguration/configurationStores/"
                        + System.Uri.EscapeDataString(configStoreName)
                        + ""
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(apiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Put, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresCreate_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresCreate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresCreate_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    while (_response.StatusCode == System.Net.HttpStatusCode.Created || _response.StatusCode == System.Net.HttpStatusCode.Accepted )
                    {

                        // get the delay before polling.
                        if (!int.TryParse( _response.GetFirstHeader(@"RetryAfter"), out int delay))
                        {
                            delay = 30;
                        }
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.DelayBeforePolling, $"Delaying {delay} seconds before polling.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // start the delay timer (we'll await later...)
                        var waiting = System.Threading.Tasks.Task.Delay(delay * 1000, eventListener.Token );

                        // while we wait, let's grab the headers and get ready to poll.
                        var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        var location = _response.GetFirstHeader(@"Location");
                        var _uri = System.String.IsNullOrEmpty(asyncOperation) ? System.String.IsNullOrEmpty(location) ? _originalUri : location : asyncOperation;
                        request = request.CloneAndDispose(new System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = _response.Content.ReadAsStringAsync();
                        await waiting;

                        // check for cancellation
                        if( eventListener.Token.IsCancellationRequested ) { return; }
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Polling, $"Polling {_uri}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);

                        if( _response.StatusCode == System.Net.HttpStatusCode.OK && string.IsNullOrEmpty(asyncOperation))
                        {
                            try {
                                // we have a 200, and a should have a provisioning state.
                                if( Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json)
                                {
                                    var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("provisioningState");
                                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Polling, $"Polled {_uri} provisioning state  {state}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }
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
                            request = request.CloneAndDispose(new System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Get);

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
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ConfigurationStore.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Error.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresCreate" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for creating a configuration store.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresCreate_Validate(string subscriptionId, string resourceGroupName, string configStoreName, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore body, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertNotNull(nameof(configStoreName),configStoreName);
                await eventListener.AssertMinimumLength(nameof(configStoreName),configStoreName,5);
                await eventListener.AssertMaximumLength(nameof(configStoreName),configStoreName,50);
                await eventListener.AssertRegEx(nameof(configStoreName),configStoreName,@"^[a-zA-Z0-9_-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
        /// <summary>Deletes a configuration store.</summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onNoContent">a delegate that is called when the remote service returns 204 (NoContent).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresDelete(string subscriptionId, string resourceGroupName, string configStoreName, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task> onNoContent, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            string apiVersion = @"2019-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.AppConfiguration/configurationStores/"
                        + System.Uri.EscapeDataString(configStoreName)
                        + ""
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(apiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Delete, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
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
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresDelete_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task> onNoContent, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    while (_response.StatusCode == System.Net.HttpStatusCode.Created || _response.StatusCode == System.Net.HttpStatusCode.Accepted )
                    {

                        // get the delay before polling.
                        if (!int.TryParse( _response.GetFirstHeader(@"RetryAfter"), out int delay))
                        {
                            delay = 30;
                        }
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.DelayBeforePolling, $"Delaying {delay} seconds before polling.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // start the delay timer (we'll await later...)
                        var waiting = System.Threading.Tasks.Task.Delay(delay * 1000, eventListener.Token );

                        // while we wait, let's grab the headers and get ready to poll.
                        var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        var location = _response.GetFirstHeader(@"Location");
                        var _uri = System.String.IsNullOrEmpty(asyncOperation) ? System.String.IsNullOrEmpty(location) ? _originalUri : location : asyncOperation;
                        request = request.CloneAndDispose(new System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = _response.Content.ReadAsStringAsync();
                        await waiting;

                        // check for cancellation
                        if( eventListener.Token.IsCancellationRequested ) { return; }
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Polling, $"Polling {_uri}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);

                        if( _response.StatusCode == System.Net.HttpStatusCode.OK && string.IsNullOrEmpty(asyncOperation))
                        {
                            try {
                                // we have a 200, and a should have a provisioning state.
                                if( Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json)
                                {
                                    var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("provisioningState");
                                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Polling, $"Polled {_uri} provisioning state  {state}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }
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
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response);
                            break;
                        }
                        case System.Net.HttpStatusCode.NoContent:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onNoContent(_response);
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Error.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresDelete" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresDelete_Validate(string subscriptionId, string resourceGroupName, string configStoreName, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertNotNull(nameof(configStoreName),configStoreName);
                await eventListener.AssertMinimumLength(nameof(configStoreName),configStoreName,5);
                await eventListener.AssertMaximumLength(nameof(configStoreName),configStoreName,50);
                await eventListener.AssertRegEx(nameof(configStoreName),configStoreName,@"^[a-zA-Z0-9_-]*$");
            }
        }
        /// <summary>Gets the properties of the specified configuration store.</summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresGet(string subscriptionId, string resourceGroupName, string configStoreName, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            string apiVersion = @"2019-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.AppConfiguration/configurationStores/"
                        + System.Uri.EscapeDataString(configStoreName)
                        + ""
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(apiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresGet_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresGet" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresGet_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ConfigurationStore.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Error.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresGet" /> method. Call this like the actual call, but you will get validation
        /// events back.
        /// </summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresGet_Validate(string subscriptionId, string resourceGroupName, string configStoreName, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertNotNull(nameof(configStoreName),configStoreName);
                await eventListener.AssertMinimumLength(nameof(configStoreName),configStoreName,5);
                await eventListener.AssertMaximumLength(nameof(configStoreName),configStoreName,50);
                await eventListener.AssertRegEx(nameof(configStoreName),configStoreName,@"^[a-zA-Z0-9_-]*$");
            }
        }
        /// <summary>Lists the configuration stores for a given subscription.</summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresList(string subscriptionId, string SkipToken, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            string apiVersion = @"2019-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(subscriptionId)
                        + "/providers/Microsoft.AppConfiguration/configurationStores"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(SkipToken) ? System.String.Empty : "$skipToken=" + System.Uri.EscapeDataString(SkipToken))
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresList_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Lists the configuration stores for a given resource group.</summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresListByResourceGroup(string subscriptionId, string resourceGroupName, string SkipToken, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            string apiVersion = @"2019-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.AppConfiguration/configurationStores"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(SkipToken) ? System.String.Empty : "$skipToken=" + System.Uri.EscapeDataString(SkipToken))
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Get, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
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
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresListByResourceGroup_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ConfigurationStoreListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Error.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresListByResourceGroup" /> method. Call this like the actual call, but
        /// you will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresListByResourceGroup_Validate(string subscriptionId, string resourceGroupName, string SkipToken, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertNotNull(nameof(SkipToken),SkipToken);
            }
        }
        /// <summary>Lists the access key for the specified configuration store.</summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresListKeys(string subscriptionId, string resourceGroupName, string configStoreName, string SkipToken, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKeyListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            string apiVersion = @"2019-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.AppConfiguration/configurationStores/"
                        + System.Uri.EscapeDataString(configStoreName)
                        + "/ListKeys"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(apiVersion)
                        + "&"
                        + (string.IsNullOrEmpty(SkipToken) ? System.String.Empty : "$skipToken=" + System.Uri.EscapeDataString(SkipToken))
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresListKeys_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresListKeys" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresListKeys_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKeyListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ApiKeyListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Error.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresListKeys" /> method. Call this like the actual call, but you will
        /// get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresListKeys_Validate(string subscriptionId, string resourceGroupName, string configStoreName, string SkipToken, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertNotNull(nameof(configStoreName),configStoreName);
                await eventListener.AssertMinimumLength(nameof(configStoreName),configStoreName,5);
                await eventListener.AssertMaximumLength(nameof(configStoreName),configStoreName,50);
                await eventListener.AssertRegEx(nameof(configStoreName),configStoreName,@"^[a-zA-Z0-9_-]*$");
                await eventListener.AssertNotNull(nameof(SkipToken),SkipToken);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresList" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresList_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreListResult>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ConfigurationStoreListResult.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Error.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresList" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="SkipToken">A skip token is used to continue retrieving items after an operation returns a partial result.
        /// If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter
        /// that specifies a starting point to use for subsequent calls.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresList_Validate(string subscriptionId, string SkipToken, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(SkipToken),SkipToken);
            }
        }
        /// <summary>Regenerates an access key for the specified configuration store.</summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for regenerating an access key.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresRegenerateKey(string subscriptionId, string resourceGroupName, string configStoreName, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IRegenerateKeyParameters body, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            string apiVersion = @"2019-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.AppConfiguration/configurationStores/"
                        + System.Uri.EscapeDataString(configStoreName)
                        + "/RegenerateKey"
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(apiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Post, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresRegenerateKey_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresRegenerateKey" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresRegenerateKey_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    var _contentType = _response.Content.Headers.ContentType?.MediaType;
                    switch ( _response.StatusCode )
                    {
                        case System.Net.HttpStatusCode.OK:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ApiKey.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Error.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresRegenerateKey" /> method. Call this like the actual call, but you
        /// will get validation events back.
        /// </summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for regenerating an access key.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresRegenerateKey_Validate(string subscriptionId, string resourceGroupName, string configStoreName, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IRegenerateKeyParameters body, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertNotNull(nameof(configStoreName),configStoreName);
                await eventListener.AssertMinimumLength(nameof(configStoreName),configStoreName,5);
                await eventListener.AssertMaximumLength(nameof(configStoreName),configStoreName,50);
                await eventListener.AssertRegEx(nameof(configStoreName),configStoreName,@"^[a-zA-Z0-9_-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
        /// <summary>Updates a configuration store with the specified parameters.</summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for updating a configuration store.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        public async System.Threading.Tasks.Task ConfigurationStoresUpdate(string subscriptionId, string resourceGroupName, string configStoreName, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreUpdateParameters body, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            string apiVersion = @"2019-02-01-preview";
            // Constant Parameters
            using( NoSynchronizationContext )
            {
                // construct URL
                var _url = new System.Uri((
                        "https://management.azure.com//subscriptions/"
                        + System.Uri.EscapeDataString(subscriptionId)
                        + "/resourceGroups/"
                        + System.Uri.EscapeDataString(resourceGroupName)
                        + "/providers/Microsoft.AppConfiguration/configurationStores/"
                        + System.Uri.EscapeDataString(configStoreName)
                        + ""
                        + "?"
                        + "api-version=" + System.Uri.EscapeDataString(apiVersion)
                        ).TrimEnd('?','&'));

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.URLCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                // generate request object
                var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Patch, _url);
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.RequestCreated, _url); if( eventListener.Token.IsCancellationRequested ) { return; }

                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.HeaderParametersAdded, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // set body content
                request.Content = new System.Net.Http.StringContent(null != body ? body.ToJson(null).ToString() : @"{}", System.Text.Encoding.UTF8);
                request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");
                await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BodyContentSet, _url); if( eventListener.Token.IsCancellationRequested ) { return; }
                // make the call
                await this.ConfigurationStoresUpdate_Call(request,onOK,onDefault,eventListener,sender);
            }
        }
        /// <summary>Actual wire call for <see cref="ConfigurationStoresUpdate" /> method.</summary>
        /// <param name="request">the prepared HttpRequestMessage to send.</param>
        /// <param name="onOK">a delegate that is called when the remote service returns 200 (OK).</param>
        /// <param name="onDefault">a delegate that is called when the remote service returns default (any response code not handled
        /// elsewhere).</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <param name="sender">an instance of an Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync pipeline to use to make the request.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresUpdate_Call(System.Net.Http.HttpRequestMessage request, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore>, System.Threading.Tasks.Task> onOK, System.Func<System.Net.Http.HttpResponseMessage, System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError>, System.Threading.Tasks.Task> onDefault, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.ISendAsync sender)
        {
            using( NoSynchronizationContext )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeCall, request); if( eventListener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request, eventListener);
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.ResponseCreated, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                    // this operation supports x-ms-long-running-operation
                    var _originalUri = request.RequestUri.AbsoluteUri;
                    while (_response.StatusCode == System.Net.HttpStatusCode.Created || _response.StatusCode == System.Net.HttpStatusCode.Accepted )
                    {

                        // get the delay before polling.
                        if (!int.TryParse( _response.GetFirstHeader(@"RetryAfter"), out int delay))
                        {
                            delay = 30;
                        }
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.DelayBeforePolling, $"Delaying {delay} seconds before polling.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // start the delay timer (we'll await later...)
                        var waiting = System.Threading.Tasks.Task.Delay(delay * 1000, eventListener.Token );

                        // while we wait, let's grab the headers and get ready to poll.
                        var asyncOperation = _response.GetFirstHeader(@"Azure-AsyncOperation");
                        var location = _response.GetFirstHeader(@"Location");
                        var _uri = System.String.IsNullOrEmpty(asyncOperation) ? System.String.IsNullOrEmpty(location) ? _originalUri : location : asyncOperation;
                        request = request.CloneAndDispose(new System.Uri(_uri), Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Get);

                        // and let's look at the current response body and see if we have some information we can give back to the listener
                        var content = _response.Content.ReadAsStringAsync();
                        await waiting;

                        // check for cancellation
                        if( eventListener.Token.IsCancellationRequested ) { return; }
                        await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Polling, $"Polling {_uri}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }

                        // drop the old response
                        _response?.Dispose();

                        // make the polling call
                        _response = await sender.SendAsync(request, eventListener);

                        if( _response.StatusCode == System.Net.HttpStatusCode.OK && string.IsNullOrEmpty(asyncOperation))
                        {
                            try {
                                // we have a 200, and a should have a provisioning state.
                                if( Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(await _response.Content.ReadAsStringAsync()) is Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json)
                                {
                                    var state = json.Property("properties")?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("provisioningState");
                                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Polling, $"Polled {_uri} provisioning state  {state}.", _response); if( eventListener.Token.IsCancellationRequested ) { return; }
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
                            request = request.CloneAndDispose(new System.Uri(_originalUri), Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Method.Get);

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
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onOK(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ConfigurationStore.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                        default:
                        {
                            await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.BeforeResponseDispatch, _response); if( eventListener.Token.IsCancellationRequested ) { return; }
                            await onDefault(_response,_response.Content.ReadAsStringAsync().ContinueWith( body => Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.Error.FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(body.Result)) ));
                            break;
                        }
                    }
                }
                finally
                {
                    // finally statements
                    await eventListener.Signal(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Events.Finally, request, _response);
                    _response?.Dispose();
                    request?.Dispose();
                }
            }
        }
        /// <summary>
        /// Validation method for <see cref="ConfigurationStoresUpdate" /> method. Call this like the actual call, but you will get
        /// validation events back.
        /// </summary>
        /// <param name="subscriptionId">The Microsoft Azure subscription ID.</param>
        /// <param name="resourceGroupName">The name of the resource group to which the container registry belongs.</param>
        /// <param name="configStoreName">The name of the configuration store.</param>
        /// <param name="body">The parameters for updating a configuration store.</param>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when handling of the response is completed.
        /// </returns>
        internal async System.Threading.Tasks.Task ConfigurationStoresUpdate_Validate(string subscriptionId, string resourceGroupName, string configStoreName, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreUpdateParameters body, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            using( NoSynchronizationContext )
            {
                await eventListener.AssertNotNull(nameof(subscriptionId),subscriptionId);
                await eventListener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
                await eventListener.AssertNotNull(nameof(configStoreName),configStoreName);
                await eventListener.AssertMinimumLength(nameof(configStoreName),configStoreName,5);
                await eventListener.AssertMaximumLength(nameof(configStoreName),configStoreName,50);
                await eventListener.AssertRegEx(nameof(configStoreName),configStoreName,@"^[a-zA-Z0-9_-]*$");
                await eventListener.AssertNotNull(nameof(body), body);
                await eventListener.AssertObjectIsValid(nameof(body), body);
            }
        }
    }
}