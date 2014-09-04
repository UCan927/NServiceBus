#pragma warning disable 1591
// ReSharper disable UnusedParameter.Global

namespace NServiceBus
{
    using System;

    [ObsoleteEx(
        Replacement = "Use configuration.EnableCriticalTimePerformanceCounter() or configuration.EnableSLAPerformanceCounter(TimeSpan), where configuration is an instance of type BusConfiguration", 
        RemoveInVersion = "6.0", 
        TreatAsErrorFromVersion = "5.0")]
    public static class MonitoringConfig
    {
        [ObsoleteEx(
            Replacement = "Use configuration.EnableSLAPerformanceCounter(TimeSpan), where configuration is an instance of type BusConfiguration", 
            RemoveInVersion = "6.0", 
            TreatAsErrorFromVersion = "5.0")]
        public static Configure SetEndpointSLA(this Configure config, TimeSpan sla)
        {
            throw new NotImplementedException();
        }


        [ObsoleteEx(Replacement = "Use configuration.EnableCriticalTimePerformanceCounter(), where configuration is an instance of type BusConfiguration", 
            RemoveInVersion = "6.0",
            TreatAsErrorFromVersion = "5.0")]
        public static Configure EnablePerformanceCounters(this Configure config)
        {
            throw new NotImplementedException();
        }


    }
}