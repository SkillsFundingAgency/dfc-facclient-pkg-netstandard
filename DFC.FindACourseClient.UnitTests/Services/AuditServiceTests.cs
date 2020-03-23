using FakeItEasy;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using Xunit;

namespace DFC.FindACourseClient.UnitTests.Services
{
    public class AuditServiceTests
    {
        private const string DummyRequest = "Some Sample request";
        private const string DummyResponse = "Some Sample response";
        private readonly Guid correlationId = Guid.NewGuid();

        private readonly ILogger<AuditService> logger;

        public AuditServiceTests()
        {
            logger = A.Fake<ILogger<AuditService>>();
        }

        //[Fact]
        //public void CreateAuditUpsertsToDatabase()
        //{
        //    // Arrange
        //    var repository = A.Fake<ICosmosRepository<ApiAuditRecordCourse>>();
        //    var auditService = new AuditService(repository, logger);

        //    // Act
        //    auditService.CreateAudit(DummyRequest, DummyResponse, correlationId);

        //    // Assert
        //    A.CallTo(() => repository.UpsertAsync(A<ApiAuditRecordCourse>.Ignored)).MustHaveHappenedOnceExactly();
        //}

        //[Fact]
        //public void CreateAuditLogsErrorWithoutWaitingOnException()
        //{
        //    // Arrange
        //    var repository = A.Fake<ICosmosRepository<ApiAuditRecordCourse>>();
        //    var auditService = new AuditService(repository, logger);

        //    A.CallTo(() => repository.UpsertAsync(A<ApiAuditRecordCourse>.Ignored)).Throws<Exception>();

        //    // Act
        //    auditService.CreateAudit(DummyRequest, DummyResponse, correlationId);
        //    Thread.Sleep(1000);

        //    A.CallTo(() => logger.Log(LogLevel.Error, 0, A<object>.Ignored, A<Exception>.Ignored, A<Func<object, Exception, string>>.Ignored)).MustHaveHappenedOnceExactly();
        //}
    }
}