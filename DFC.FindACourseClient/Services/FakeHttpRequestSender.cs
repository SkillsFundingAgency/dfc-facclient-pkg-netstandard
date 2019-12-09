﻿using DFC.FindACourseClient.Contracts;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace DFC.FindACourseClient.Services
{
    [ExcludeFromCodeCoverage]
    public class FakeHttpRequestSender : IFakeHttpRequestSender
    {
        public HttpResponseMessage Send(HttpRequestMessage request)
        {
            throw new NotImplementedException("Now we can setup this method with our mocking framework");
        }
    }
}