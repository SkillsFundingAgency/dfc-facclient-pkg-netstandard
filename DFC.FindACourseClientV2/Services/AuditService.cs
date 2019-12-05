﻿using DFC.FindACourseClientV2.Contracts;
using DFC.FindACourseClientV2.Contracts.CosmosDb;
using DFC.FindACourseClientV2.Models.CosmosDb;
using System;
using System.Threading.Tasks;

namespace DFC.FindACourseClientV2.Services
{
    public class AuditService : IAuditService
    {
        private readonly ICosmosRepository<ApiAuditRecordCourse> auditRepository;

        public AuditService(ICosmosRepository<ApiAuditRecordCourse> auditRepository)
        {
            this.auditRepository = auditRepository;
        }

        public async Task CreateAudit(object request, object response, Guid? correlationId = null)
        {
            var auditRecord = new ApiAuditRecordCourse
            {
                DocumentId = Guid.NewGuid(),
                CorrelationId = correlationId ?? Guid.NewGuid(),
                Request = request,
                Response = response,
            };

            await auditRepository.UpsertAsync(auditRecord).ConfigureAwait(false);
        }
    }
}