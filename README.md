[![](https://img.shields.io/nuget/v/soenneker.resend.openapi.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.resend.openapi.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.resend.openapi.suite/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.resend.openapi.suite/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.resend.openapi.suite.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.resend.openapi.suite/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.resend.openapi.suite/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.resend.openapi.suite/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Resend.OpenApi.Suite

Provides one registration point for the Resend email sending, batching, retrieval, and scheduled-cancellation helper.

## Installation

```bash
dotnet add package Soenneker.Resend.OpenApi.Suite
```

## Configuration

```json
{
  "Resend": {
    "ApiKey": "re_xxxxxxxxx"
  }
}
```

## Usage

```csharp
using Soenneker.Resend.OpenApi.Suite.Registrars;

services.AddResendOpenApiSuiteAsSingleton();
```

This currently registers `IResendEmailsUtil` and its authenticated client dependencies. Use `AddResendOpenApiSuiteAsScoped()` when the email helper itself should be scoped; its underlying API client provider remains shared.
