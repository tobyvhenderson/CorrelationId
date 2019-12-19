﻿using System;

namespace CorrelationId
{
    /// <summary>
    /// Options for correlation ids.
    /// </summary>
    public class CorrelationIdOptions
    {
        private const string DefaultHeader = "X-Correlation-ID";

        /// <summary>
        /// The name of the header from which the Correlation ID is read/written.
        /// </summary>
        public string Header { get; set; } = DefaultHeader;

        /// <summary>
        /// <para>
        /// Ignore request header.
        /// When true the TraceIdentifier for the current request ignores the header from request.
        /// </para>
        /// <para>Default: false</para>
        /// </summary>
        public bool IgnoreRequestHeader { get; set; } = false;

        /// <summary>
        /// <para>
        /// Controls whether the correlation ID is returned in the response headers.
        /// </para>
        /// <para>Default: true</para>
        /// </summary>
        public bool IncludeInResponse { get; set; } = true;

        /// <summary>
        /// <para>
        /// Controls whether the ASP.NET Core TraceIdentifier will be set to match the CorrelationId.
        /// </para>
        /// <para>Default: true</para>
        /// </summary>
        public bool UpdateTraceIdentifier { get; set; } = true;

        /// <summary>
        /// <para>
        /// Controls whether a GUID will be used in cases where no correlation ID is retrieved from the request header.
        /// When false the TraceIdentifier for the current request will be used.
        /// </para>
        /// <para> Default: false.</para>
        /// </summary>
        public bool UseGuidForCorrelationId { get; set; } = false;

        /// <summary>
        /// A function that returns the correlation id in cases where no correlation ID is retrieved from the request header. It can be used to customize the correlation id generation.
        /// For example, it can return sequential guids such as those provided by https://github.com/richardtallent/RT.Comb
        /// options.CorrelationIdGenerator = () => RT.Comb.Provider.PostgreSql.Create().ToString("N");
        /// </summary>
        public Func<string> CorrelationIdGenerator { get; set; }
    }
}
