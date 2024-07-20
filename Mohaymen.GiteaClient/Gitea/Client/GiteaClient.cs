﻿using System;
using Mohaymen.GiteaClient.Gitea.Branch.Common.Facade.Abstractions;
using Mohaymen.GiteaClient.Gitea.Client.Abstractions;
using Mohaymen.GiteaClient.Gitea.Repository.Common.Facade.Abstractions;

namespace Mohaymen.GiteaClient.Gitea.Client;

internal class GiteaClient : IGiteaClient
{
    public IRepositoryFacade RepositoryClient { get; }
    public IBranchFacade BranchClient { get; }

    public GiteaClient(IRepositoryFacade repositoryFacade, IBranchFacade branchClient)
    {
        RepositoryClient = repositoryFacade ?? throw new ArgumentNullException(nameof(repositoryFacade));
        BranchClient = branchClient ?? throw new ArgumentNullException(nameof(branchClient));
    }
}