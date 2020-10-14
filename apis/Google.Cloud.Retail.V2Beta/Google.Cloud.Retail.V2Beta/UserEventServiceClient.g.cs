// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using ga = Google.Api;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Retail.V2Beta
{
    /// <summary>Settings for <see cref="UserEventServiceClient"/> instances.</summary>
    public sealed partial class UserEventServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserEventServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserEventServiceSettings"/>.</returns>
        public static UserEventServiceSettings GetDefault() => new UserEventServiceSettings();

        /// <summary>Constructs a new <see cref="UserEventServiceSettings"/> object with default settings.</summary>
        public UserEventServiceSettings()
        {
        }

        private UserEventServiceSettings(UserEventServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            WriteUserEventSettings = existing.WriteUserEventSettings;
            CollectUserEventSettings = existing.CollectUserEventSettings;
            PurgeUserEventsSettings = existing.PurgeUserEventsSettings;
            PurgeUserEventsOperationsSettings = existing.PurgeUserEventsOperationsSettings.Clone();
            ImportUserEventsSettings = existing.ImportUserEventsSettings;
            ImportUserEventsOperationsSettings = existing.ImportUserEventsOperationsSettings.Clone();
            ExportUserEventsSettings = existing.ExportUserEventsSettings;
            ExportUserEventsOperationsSettings = existing.ExportUserEventsOperationsSettings.Clone();
            RejoinUserEventsSettings = existing.RejoinUserEventsSettings;
            RejoinUserEventsOperationsSettings = existing.RejoinUserEventsOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(UserEventServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.WriteUserEvent</c> and <c>UserEventServiceClient.WriteUserEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WriteUserEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.CollectUserEvent</c> and <c>UserEventServiceClient.CollectUserEventAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CollectUserEventSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.PurgeUserEvents</c> and <c>UserEventServiceClient.PurgeUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PurgeUserEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UserEventServiceClient.PurgeUserEvents</c> and
        /// <c>UserEventServiceClient.PurgeUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings PurgeUserEventsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.ImportUserEvents</c> and <c>UserEventServiceClient.ImportUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportUserEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UserEventServiceClient.ImportUserEvents</c> and
        /// <c>UserEventServiceClient.ImportUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ImportUserEventsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.ExportUserEvents</c> and <c>UserEventServiceClient.ExportUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportUserEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UserEventServiceClient.ExportUserEvents</c> and
        /// <c>UserEventServiceClient.ExportUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ExportUserEventsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserEventServiceClient.RejoinUserEvents</c> and <c>UserEventServiceClient.RejoinUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RejoinUserEventsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>UserEventServiceClient.RejoinUserEvents</c> and
        /// <c>UserEventServiceClient.RejoinUserEventsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RejoinUserEventsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserEventServiceSettings"/> object.</returns>
        public UserEventServiceSettings Clone() => new UserEventServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserEventServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class UserEventServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserEventServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserEventServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref UserEventServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserEventServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserEventServiceClient Build()
        {
            UserEventServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserEventServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserEventServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserEventServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserEventServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<UserEventServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserEventServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => UserEventServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => UserEventServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserEventServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>UserEventService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting end user actions on the customer website.
    /// </remarks>
    public abstract partial class UserEventServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserEventService service, which is a host of "retail.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "retail.googleapis.com:443";

        /// <summary>The default UserEventService scopes.</summary>
        /// <remarks>
        /// The default UserEventService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="UserEventServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserEventServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserEventServiceClient"/>.</returns>
        public static stt::Task<UserEventServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserEventServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserEventServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserEventServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserEventServiceClient"/>.</returns>
        public static UserEventServiceClient Create() => new UserEventServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserEventServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserEventServiceSettings"/>.</param>
        /// <returns>The created <see cref="UserEventServiceClient"/>.</returns>
        internal static UserEventServiceClient Create(grpccore::CallInvoker callInvoker, UserEventServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserEventService.UserEventServiceClient grpcClient = new UserEventService.UserEventServiceClient(callInvoker);
            return new UserEventServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC UserEventService client</summary>
        public virtual UserEventService.UserEventServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UserEvent WriteUserEvent(WriteUserEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserEvent> WriteUserEventAsync(WriteUserEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UserEvent> WriteUserEventAsync(WriteUserEventRequest request, st::CancellationToken cancellationToken) =>
            WriteUserEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel and
        /// Google Tag Manager. Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody CollectUserEvent(CollectUserEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel and
        /// Google Tag Manager. Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> CollectUserEventAsync(CollectUserEventRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel and
        /// Google Tag Manager. Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> CollectUserEventAsync(CollectUserEventRequest request, st::CancellationToken cancellationToken) =>
            CollectUserEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PurgeUserEventsResponse, PurgeMetadata> PurgeUserEvents(PurgeUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeMetadata>> PurgeUserEventsAsync(PurgeUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeMetadata>> PurgeUserEventsAsync(PurgeUserEventsRequest request, st::CancellationToken cancellationToken) =>
            PurgeUserEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PurgeUserEvents</c>.</summary>
        public virtual lro::OperationsClient PurgeUserEventsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PurgeUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PurgeUserEventsResponse, PurgeMetadata> PollOncePurgeUserEvents(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeUserEventsResponse, PurgeMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PurgeUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeMetadata>> PollOncePurgeUserEventsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PurgeUserEventsResponse, PurgeMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PurgeUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportUserEventsResponse, ImportMetadata> ImportUserEvents(ImportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(ImportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(ImportUserEventsRequest request, st::CancellationToken cancellationToken) =>
            ImportUserEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportUserEvents</c>.</summary>
        public virtual lro::OperationsClient ImportUserEventsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportUserEventsResponse, ImportMetadata> PollOnceImportUserEvents(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportUserEventsResponse, ImportMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> PollOnceImportUserEventsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportUserEventsResponse, ImportMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Export of user events.
        /// 
        /// Operation.response is of type ExportResponse.
        /// Operation.metadata is of type ExportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportUserEventsResponse, ExportMetadata> ExportUserEvents(ExportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export of user events.
        /// 
        /// Operation.response is of type ExportResponse.
        /// Operation.metadata is of type ExportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportUserEventsResponse, ExportMetadata>> ExportUserEventsAsync(ExportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export of user events.
        /// 
        /// Operation.response is of type ExportResponse.
        /// Operation.metadata is of type ExportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportUserEventsResponse, ExportMetadata>> ExportUserEventsAsync(ExportUserEventsRequest request, st::CancellationToken cancellationToken) =>
            ExportUserEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportUserEvents</c>.</summary>
        public virtual lro::OperationsClient ExportUserEventsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportUserEventsResponse, ExportMetadata> PollOnceExportUserEvents(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportUserEventsResponse, ExportMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportUserEventsResponse, ExportMetadata>> PollOnceExportUserEventsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportUserEventsResponse, ExportMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Triggers a user event rejoin operation with latest catalog data. Events
        /// will not be annotated with detailed catalog information if catalog item is
        /// missing at the time the user event is ingested, and these events are stored
        /// as unjoined events with a limited usage on training and serving. This API
        /// can be used to trigger a 'join' operation on specified events with latest
        /// version of catalog items. It can also be used to correct events joined with
        /// wrong catalog items.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata> RejoinUserEvents(RejoinUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers a user event rejoin operation with latest catalog data. Events
        /// will not be annotated with detailed catalog information if catalog item is
        /// missing at the time the user event is ingested, and these events are stored
        /// as unjoined events with a limited usage on training and serving. This API
        /// can be used to trigger a 'join' operation on specified events with latest
        /// version of catalog items. It can also be used to correct events joined with
        /// wrong catalog items.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata>> RejoinUserEventsAsync(RejoinUserEventsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers a user event rejoin operation with latest catalog data. Events
        /// will not be annotated with detailed catalog information if catalog item is
        /// missing at the time the user event is ingested, and these events are stored
        /// as unjoined events with a limited usage on training and serving. This API
        /// can be used to trigger a 'join' operation on specified events with latest
        /// version of catalog items. It can also be used to correct events joined with
        /// wrong catalog items.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata>> RejoinUserEventsAsync(RejoinUserEventsRequest request, st::CancellationToken cancellationToken) =>
            RejoinUserEventsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RejoinUserEvents</c>.</summary>
        public virtual lro::OperationsClient RejoinUserEventsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RejoinUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata> PollOnceRejoinUserEvents(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RejoinUserEventsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RejoinUserEvents</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata>> PollOnceRejoinUserEventsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RejoinUserEventsOperationsClient, callSettings);
    }

    /// <summary>UserEventService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting end user actions on the customer website.
    /// </remarks>
    public sealed partial class UserEventServiceClientImpl : UserEventServiceClient
    {
        private readonly gaxgrpc::ApiCall<WriteUserEventRequest, UserEvent> _callWriteUserEvent;

        private readonly gaxgrpc::ApiCall<CollectUserEventRequest, ga::HttpBody> _callCollectUserEvent;

        private readonly gaxgrpc::ApiCall<PurgeUserEventsRequest, lro::Operation> _callPurgeUserEvents;

        private readonly gaxgrpc::ApiCall<ImportUserEventsRequest, lro::Operation> _callImportUserEvents;

        private readonly gaxgrpc::ApiCall<ExportUserEventsRequest, lro::Operation> _callExportUserEvents;

        private readonly gaxgrpc::ApiCall<RejoinUserEventsRequest, lro::Operation> _callRejoinUserEvents;

        /// <summary>
        /// Constructs a client wrapper for the UserEventService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserEventServiceSettings"/> used within this client.</param>
        public UserEventServiceClientImpl(UserEventService.UserEventServiceClient grpcClient, UserEventServiceSettings settings)
        {
            GrpcClient = grpcClient;
            UserEventServiceSettings effectiveSettings = settings ?? UserEventServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            PurgeUserEventsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PurgeUserEventsOperationsSettings);
            ImportUserEventsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportUserEventsOperationsSettings);
            ExportUserEventsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportUserEventsOperationsSettings);
            RejoinUserEventsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RejoinUserEventsOperationsSettings);
            _callWriteUserEvent = clientHelper.BuildApiCall<WriteUserEventRequest, UserEvent>(grpcClient.WriteUserEventAsync, grpcClient.WriteUserEvent, effectiveSettings.WriteUserEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callWriteUserEvent);
            Modify_WriteUserEventApiCall(ref _callWriteUserEvent);
            _callCollectUserEvent = clientHelper.BuildApiCall<CollectUserEventRequest, ga::HttpBody>(grpcClient.CollectUserEventAsync, grpcClient.CollectUserEvent, effectiveSettings.CollectUserEventSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCollectUserEvent);
            Modify_CollectUserEventApiCall(ref _callCollectUserEvent);
            _callPurgeUserEvents = clientHelper.BuildApiCall<PurgeUserEventsRequest, lro::Operation>(grpcClient.PurgeUserEventsAsync, grpcClient.PurgeUserEvents, effectiveSettings.PurgeUserEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callPurgeUserEvents);
            Modify_PurgeUserEventsApiCall(ref _callPurgeUserEvents);
            _callImportUserEvents = clientHelper.BuildApiCall<ImportUserEventsRequest, lro::Operation>(grpcClient.ImportUserEventsAsync, grpcClient.ImportUserEvents, effectiveSettings.ImportUserEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportUserEvents);
            Modify_ImportUserEventsApiCall(ref _callImportUserEvents);
            _callExportUserEvents = clientHelper.BuildApiCall<ExportUserEventsRequest, lro::Operation>(grpcClient.ExportUserEventsAsync, grpcClient.ExportUserEvents, effectiveSettings.ExportUserEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportUserEvents);
            Modify_ExportUserEventsApiCall(ref _callExportUserEvents);
            _callRejoinUserEvents = clientHelper.BuildApiCall<RejoinUserEventsRequest, lro::Operation>(grpcClient.RejoinUserEventsAsync, grpcClient.RejoinUserEvents, effectiveSettings.RejoinUserEventsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRejoinUserEvents);
            Modify_RejoinUserEventsApiCall(ref _callRejoinUserEvents);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_WriteUserEventApiCall(ref gaxgrpc::ApiCall<WriteUserEventRequest, UserEvent> call);

        partial void Modify_CollectUserEventApiCall(ref gaxgrpc::ApiCall<CollectUserEventRequest, ga::HttpBody> call);

        partial void Modify_PurgeUserEventsApiCall(ref gaxgrpc::ApiCall<PurgeUserEventsRequest, lro::Operation> call);

        partial void Modify_ImportUserEventsApiCall(ref gaxgrpc::ApiCall<ImportUserEventsRequest, lro::Operation> call);

        partial void Modify_ExportUserEventsApiCall(ref gaxgrpc::ApiCall<ExportUserEventsRequest, lro::Operation> call);

        partial void Modify_RejoinUserEventsApiCall(ref gaxgrpc::ApiCall<RejoinUserEventsRequest, lro::Operation> call);

        partial void OnConstruction(UserEventService.UserEventServiceClient grpcClient, UserEventServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserEventService client</summary>
        public override UserEventService.UserEventServiceClient GrpcClient { get; }

        partial void Modify_WriteUserEventRequest(ref WriteUserEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CollectUserEventRequest(ref CollectUserEventRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PurgeUserEventsRequest(ref PurgeUserEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportUserEventsRequest(ref ImportUserEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportUserEventsRequest(ref ExportUserEventsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RejoinUserEventsRequest(ref RejoinUserEventsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UserEvent WriteUserEvent(WriteUserEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteUserEventRequest(ref request, ref callSettings);
            return _callWriteUserEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Writes a single user event.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UserEvent> WriteUserEventAsync(WriteUserEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteUserEventRequest(ref request, ref callSettings);
            return _callWriteUserEvent.Async(request, callSettings);
        }

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel and
        /// Google Tag Manager. Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody CollectUserEvent(CollectUserEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CollectUserEventRequest(ref request, ref callSettings);
            return _callCollectUserEvent.Sync(request, callSettings);
        }

        /// <summary>
        /// Writes a single user event from the browser. This uses a GET request to
        /// due to browser restriction of POST-ing to a 3rd party domain.
        /// 
        /// This method is used only by the Recommendations AI JavaScript pixel and
        /// Google Tag Manager. Users should not call this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> CollectUserEventAsync(CollectUserEventRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CollectUserEventRequest(ref request, ref callSettings);
            return _callCollectUserEvent.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>PurgeUserEvents</c>.</summary>
        public override lro::OperationsClient PurgeUserEventsOperationsClient { get; }

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PurgeUserEventsResponse, PurgeMetadata> PurgeUserEvents(PurgeUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeUserEventsResponse, PurgeMetadata>(_callPurgeUserEvents.Sync(request, callSettings), PurgeUserEventsOperationsClient);
        }

        /// <summary>
        /// Deletes permanently all user events specified by the filter provided.
        /// Depending on the number of events specified by the filter, this operation
        /// could take hours or days to complete. To test a filter, use the list
        /// command first.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PurgeUserEventsResponse, PurgeMetadata>> PurgeUserEventsAsync(PurgeUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PurgeUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<PurgeUserEventsResponse, PurgeMetadata>(await _callPurgeUserEvents.Async(request, callSettings).ConfigureAwait(false), PurgeUserEventsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportUserEvents</c>.</summary>
        public override lro::OperationsClient ImportUserEventsOperationsClient { get; }

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportUserEventsResponse, ImportMetadata> ImportUserEvents(ImportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportUserEventsResponse, ImportMetadata>(_callImportUserEvents.Sync(request, callSettings), ImportUserEventsOperationsClient);
        }

        /// <summary>
        /// Bulk import of User events. Request processing might be
        /// synchronous. Events that already exist are skipped.
        /// Use this method for backfilling historical user events.
        /// 
        /// Operation.response is of type ImportResponse. Note that it is
        /// possible for a subset of the items to be successfully inserted.
        /// Operation.metadata is of type ImportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportUserEventsResponse, ImportMetadata>> ImportUserEventsAsync(ImportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportUserEventsResponse, ImportMetadata>(await _callImportUserEvents.Async(request, callSettings).ConfigureAwait(false), ImportUserEventsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportUserEvents</c>.</summary>
        public override lro::OperationsClient ExportUserEventsOperationsClient { get; }

        /// <summary>
        /// Export of user events.
        /// 
        /// Operation.response is of type ExportResponse.
        /// Operation.metadata is of type ExportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportUserEventsResponse, ExportMetadata> ExportUserEvents(ExportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportUserEventsResponse, ExportMetadata>(_callExportUserEvents.Sync(request, callSettings), ExportUserEventsOperationsClient);
        }

        /// <summary>
        /// Export of user events.
        /// 
        /// Operation.response is of type ExportResponse.
        /// Operation.metadata is of type ExportMetadata.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportUserEventsResponse, ExportMetadata>> ExportUserEventsAsync(ExportUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<ExportUserEventsResponse, ExportMetadata>(await _callExportUserEvents.Async(request, callSettings).ConfigureAwait(false), ExportUserEventsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RejoinUserEvents</c>.</summary>
        public override lro::OperationsClient RejoinUserEventsOperationsClient { get; }

        /// <summary>
        /// Triggers a user event rejoin operation with latest catalog data. Events
        /// will not be annotated with detailed catalog information if catalog item is
        /// missing at the time the user event is ingested, and these events are stored
        /// as unjoined events with a limited usage on training and serving. This API
        /// can be used to trigger a 'join' operation on specified events with latest
        /// version of catalog items. It can also be used to correct events joined with
        /// wrong catalog items.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata> RejoinUserEvents(RejoinUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RejoinUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata>(_callRejoinUserEvents.Sync(request, callSettings), RejoinUserEventsOperationsClient);
        }

        /// <summary>
        /// Triggers a user event rejoin operation with latest catalog data. Events
        /// will not be annotated with detailed catalog information if catalog item is
        /// missing at the time the user event is ingested, and these events are stored
        /// as unjoined events with a limited usage on training and serving. This API
        /// can be used to trigger a 'join' operation on specified events with latest
        /// version of catalog items. It can also be used to correct events joined with
        /// wrong catalog items.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata>> RejoinUserEventsAsync(RejoinUserEventsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RejoinUserEventsRequest(ref request, ref callSettings);
            return new lro::Operation<RejoinUserEventsResponse, RejoinUserEventsMetadata>(await _callRejoinUserEvents.Async(request, callSettings).ConfigureAwait(false), RejoinUserEventsOperationsClient);
        }
    }

    public static partial class UserEventService
    {
        public partial class UserEventServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}