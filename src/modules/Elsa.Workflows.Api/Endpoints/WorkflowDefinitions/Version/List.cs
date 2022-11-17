﻿using Elsa.Common.Models;
using Elsa.Workflows.Management.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Http;

namespace Elsa.Workflows.Api.Endpoints.WorkflowDefinitions.Version;

public class ListVersions : EndpointWithoutRequest
{
    private readonly IWorkflowDefinitionStore _store;
    
    public ListVersions(IWorkflowDefinitionStore store)
    {
        _store = store;
    }

    public override void Configure()
    {
        Get("workflow-definitions/{definitionId}/versions");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var definitionId = Route<string>("definitionId")!;

        var result = await _store.FindManyByDefinitionIdAsync(definitionId, VersionOptions.All, ct);
        if (!result.Any())
        {
            await SendNotFoundAsync(ct);
            return;
        }

        await SendAsync(result, StatusCodes.Status200OK, ct);
    }
}