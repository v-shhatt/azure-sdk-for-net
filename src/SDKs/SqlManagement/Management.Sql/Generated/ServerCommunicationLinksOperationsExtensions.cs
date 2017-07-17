// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ServerCommunicationLinksOperations.
    /// </summary>
    public static partial class ServerCommunicationLinksOperationsExtensions
    {
            /// <summary>
            /// Deletes a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            public static void Delete(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, communicationLinkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, communicationLinkName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            public static ServerCommunicationLink Get(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName)
            {
                return operations.GetAsync(resourceGroupName, serverName, communicationLinkName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerCommunicationLink> GetAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, communicationLinkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating a server communication link.
            /// </param>
            public static ServerCommunicationLink CreateOrUpdate(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLink parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, communicationLinkName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating a server communication link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerCommunicationLink> CreateOrUpdateAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLink parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, communicationLinkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of server communication links.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            public static IEnumerable<ServerCommunicationLink> ListByServer(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of server communication links.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<ServerCommunicationLink>> ListByServerAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating a server communication link.
            /// </param>
            public static ServerCommunicationLink BeginCreateOrUpdate(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLink parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, communicationLinkName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a server communication link.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='communicationLinkName'>
            /// The name of the server communication link.
            /// </param>
            /// <param name='parameters'>
            /// The required parameters for creating a server communication link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ServerCommunicationLink> BeginCreateOrUpdateAsync(this IServerCommunicationLinksOperations operations, string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLink parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, communicationLinkName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}