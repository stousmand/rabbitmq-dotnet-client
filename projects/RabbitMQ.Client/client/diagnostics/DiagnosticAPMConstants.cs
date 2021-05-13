/*
 *  1.0.0               20210315            shirhan.apache@gmail.com                Certain constants that are used to define events
 *                                                                                  to be identified by the tracing instrumentation (in Elastic APM)
 *                                                                                  Diagnostic source is implemented in RabbitMq client classes.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Client.Diagnostics
{
    public enum DiagnosticAPMConstants
    {
        EXCEPTION = 0,
        CREATE_CONNECTION_START = 11,
        CREATE_CONNECTION_END = 12,
        BASIC_PUBLISH_START = 13,
        BASIC_PUBLISH_END = 14,
        BASIC_CONSUME_START = 15,
        BASIC_CONSUME_END = 16
    }

    public static class DiagnosticConstants
    {
        public static string DIAGNOSTIC_SOURCE_NAME = "RabbitMQ.Client.DiagnosticListener";
    }
}
