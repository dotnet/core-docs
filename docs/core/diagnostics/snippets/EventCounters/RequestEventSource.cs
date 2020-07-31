﻿using System;
using System.Diagnostics.Tracing;

public class RequestEventSource : EventSource
{
    public static RequestEventSource Log { get; } = new RequestEventSource();

    private IncrementingPollingCounter _requestRateCounter;
    private int _requestCount = 0;

    private RequestEventSource() =>
        _requestRateCounter = new IncrementingPollingCounter("request-rate", this, () => _requestCount)
        {
            DisplayName = "Request Rate",
            DisplayRateTimeScale = TimeSpan.FromSeconds(1)
        };

    public void AddRequest() => ++ _requestCount;

    protected override void Dispose(bool disposing)
    {
        _requestRateCounter?.Dispose();
        _requestRateCounter = null;

        base.Dispose(disposing);
    }
}