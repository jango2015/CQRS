﻿#region Copyright
// -----------------------------------------------------------------------
// <copyright company="Chinchilla Software Limited">
//     Copyright Chinchilla Software Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion

using System;
using System.Runtime.Serialization;

namespace Cqrs.Services
{
	/// <summary>
	/// A request message envelope that holds authentication and correlation information used when making public API requests.
	/// </summary>
	/// <typeparam name="TAuthenticationToken">The <see cref="Type">type</see> of authentication token used.</typeparam>
	[Serializable]
	[DataContract]
	public class ServiceRequest<TAuthenticationToken> : IServiceRequest<TAuthenticationToken>
	{
		/// <summary>
		/// The authentication token used to identify the requester.
		/// </summary>
		[DataMember]
		public TAuthenticationToken AuthenticationToken { get; set; }

		/// <summary>
		/// The correlation id used to group together events and notifications.
		/// </summary>
		[DataMember]
		public Guid CorrelationId { get; set; }
	}
}