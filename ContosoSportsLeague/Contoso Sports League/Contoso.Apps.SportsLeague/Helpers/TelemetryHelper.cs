using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Contoso.Apps.SportsLeague.Web.ViewModels;
using Microsoft.ApplicationInsights;

namespace Contoso.Apps.SportsLeague.Web.Helpers
{
    /// <summary>
    /// Helper methods for writing Application Insights Events.
    /// </summary>
    public sealed class TelemetryHelper
    {
        private static readonly TelemetryClient telemetryClient;
       
        static TelemetryHelper()
        {
            telemetryClient = new TelemetryClient();
        }

        // All methods are static, so this can be private.
        private TelemetryHelper()
        { }

        /// <summary>
        /// Writes the passed in Exception as a tracked exception in Application Insights.
        /// </summary>
        /// <param name="exc"></param>
        public static void TrackException(Exception exc)
        {
            telemetryClient.TrackException(exc);
        }

        /// <summary>
        /// Allows you to report events that can be searched and tracked in Application Insights.
        /// </summary>
        /// <param name="eventName"></param>
        /// <param name="properties"></param>
        public static void TrackEvent(string eventName, Dictionary<string, string> properties)
        {
            telemetryClient.TrackEvent(eventName, properties);
        }
    }
}