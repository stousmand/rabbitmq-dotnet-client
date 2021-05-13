/*
 *  1.0.0               20210315            shirhan.apache@gmail.com                Payload that is used to send information to
 *                                                                                  the listener.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace RabbitMQ.Client.Diagnostics
{
    public class DiagnosticAPMPayload
    {
        public string Action { get; set; }
        public string ActionType { get; set; }
        public Guid? CorrelationId { get; set; }
        public long TimeElapsed { get; set; }
        public string Details { get; set; }
    }
}
