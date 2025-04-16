# ProPulse MVP Implementation Plan

## MVP Development Timeline Overview

*   **Total Sprints:** 6
*   **Estimated Duration:** 12 Weeks

This timeline focuses solely on the development tasks required to build the MVP features outlined in the technical specification. Production deployment tasks are excluded.

---

## Sprint 1: Foundation & Setup (Weeks 1-2)

*   **Goal:** Establish the project structure, core dependencies, basic authentication API, logging, and testing setup.
*   **Tasks:**
    *   Task 1.1: Initialize Git repository and solution structure (`/src`, `/test`, `/docs`, `/project`, `/aspire`). (1 day)
    *   Task 1.2: Set up .NET Aspire AppHost and ServiceDefaults projects. (1 day)
    *   Task 1.3: Configure Aspire for local SQL Server and Azurite containers. (1 day)
    *   Task 1.4: Create `ProPulse.DataModel` project, define initial `Article` and `Attachment` entities (as per spec, without relationships yet). (1 day)
    *   Task 1.5: Create `ProPulse.Application` project structure (Vertical Slice placeholders). (0.5 days)
    *   Task 1.6: Create `ProPulse.Web` project (ASP.NET Core base). (0.5 days)
    *   Task 1.7: Integrate Serilog for logging into `ProPulse.Web` and `ProPulse.ServiceDefaults`. Configure basic console and debug sinks. (1 day)
    *   Task 1.8: Integrate ASP.NET Identity into `ProPulse.Web` and configure EF Core for Identity tables using the default schema. (2 days)
    *   Task 1.9: Implement basic user registration endpoint (`POST /api/auth/register`). (1 day)
    *   Task 1.10: Implement basic user login endpoint (`POST /api/auth/login`). (1 day)
    *   Task 1.11: Set up basic testing projects (`ProPulse.Web.Tests`, `ProPulse.Application.Tests`, `ProPulse.DataModel.Tests`) with xUnit. (1 day)

---

## Sprint 2: Core Data & API (Articles) (Weeks 3-4)

*   **Goal:** Implement EF Core persistence for Articles, build core Article API endpoints, and set up integration testing.
*   **Tasks:**
    *   Task 2.1: Configure EF Core DbContext in `ProPulse.DataModel` for `Article`, `Attachment`, and Identity tables, including relationships and automatic `CreatedAt`/`UpdatedAt` value generation (e.g., via interceptors or value converters). (1.5 days)
    *   Task 2.2: Create initial DbUp SQL migration scripts for the database schema (including tables for Articles, Attachments, and Identity). (1 day)
    *   Task 2.3: Create `ProPulse.DbInitializer` console application project. Configure it to run DbUp migrations against the SQL Server database defined in Aspire. (1 day)
    *   Task 2.4: Implement `POST /api/articles` endpoint (Create Article - map basic fields, associate with authenticated AuthorId). (1.5 days)
    *   Task 2.5: Implement `GET /api/articles/{id}` endpoint (Retrieve Article by ID). (1 day)
    *   Task 2.6: Implement `GET /api/articles` endpoint (List Articles - basic retrieval). (1 day)
    *   Task 2.7: Implement `PUT /api/articles/{id}` endpoint (Update Article - basic fields). (1.5 days)
    *   Task 2.8: Implement `DELETE /api/articles/{id}` endpoint (Delete Article). (1 day)
    *   Task 2.9: Add basic integration tests for Article API endpoints using `WebApplicationFactory` and TestContainers (SQL Server). Ensure tests can trigger schema initialization. (2 days)

---

## Sprint 3: Attachments & API Enhancements (Weeks 5-6)

*   **Goal:** Implement attachment handling (API and Blob Storage), refine API list operations with OData.
*   **Tasks:**
    *   Task 3.1: Implement Azure Blob Storage integration (Configure service client via Aspire, add necessary configuration). (1 day)
    *   Task 3.2: Implement `POST /api/articles/{id}/attachments` endpoint (Upload: save metadata to SQL, file to Blob Storage). (2 days)
    *   Task 3.3: Implement `GET /api/articles/{id}/attachments` endpoint (List Attachments for an article). (1 day)
    *   Task 3.4: Implement `GET /api/articles/{id}/attachments/{attachmentId}` endpoint (Retrieve Attachment metadata). (1 day)
    *   Task 3.5: Implement `DELETE /api/articles/{id}/attachments/{attachmentId}` endpoint (Delete Attachment metadata from SQL and file from Blob Storage). (1.5 days)
    *   Task 3.6: Add integration tests for Attachment API endpoints. (1.5 days)
    *   Task 3.7: Implement OData query support (`$filter`, `$orderby`, `$top`, `$skip`, `$search`) for `GET /api/articles` and `GET /api/articles/{id}/attachments` using a library like `Microsoft.AspNetCore.OData`. (2 days)

---

## Sprint 4: Frontend (Authoring - Blazor) (Weeks 7-8)

*   **Goal:** Build the Blazor Web App components for authentication and article creation/editing, including the Markdown editor.
*   **Tasks:**
    *   Task 4.1: Set up Blazor Web App structure within `ProPulse.Web`. (1 day)
    *   Task 4.2: Create Blazor pages/components for Login and Registration, integrating with `/api/auth` endpoints. (2 days)
    *   Task 4.3: Create Blazor page for listing the authenticated user's articles (calls `GET /api/articles` with appropriate filter). (1.5 days)
    *   Task 4.4: Create Blazor page/component for creating a new article (form, calls `POST /api/articles`). (1.5 days)
    *   Task 4.5: Create Blazor page/component for editing an existing article (loads data via `GET /api/articles/{id}`, saves via `PUT /api/articles/{id}`). (2 days)
    *   Task 4.6: Integrate a Blazor Markdown editor component (potentially wrapping Markdig or using a pre-built component) into the create/edit pages. (2 days)

---

## Sprint 5: Frontend (Attachments & Public View - MVC) (Weeks 9-10)

*   **Goal:** Add attachment management to the Blazor UI and build the public-facing MVC site for browsing/reading articles.
*   **Tasks:**
    *   Task 5.1: Implement attachment upload UI in Blazor create/edit article pages (calls `POST /api/articles/{id}/attachments`). (2 days)
    *   Task 5.2: Implement attachment listing and deletion UI in Blazor edit article page (calls `GET /api/articles/{id}/attachments` and `DELETE .../{attachmentId}`). (1.5 days)
    *   Task 5.3: Set up ASP.NET Core MVC structure within `ProPulse.Web` for public views. (1 day)
    *   Task 5.4: Create MVC Controller and View for the public homepage (lists published articles, calls `GET /api/articles`). (1.5 days)
    *   Task 5.5: Create MVC Controller and View for displaying a single article (calls `GET /api/articles/{id}`). (1.5 days)
    *   Task 5.6: Implement rendering of Markdown article content to HTML (using Markdig) in the MVC article view. (1 day)
    *   Task 5.7: Implement display of associated attachments in the MVC article view. (1.5 days)

---

## Sprint 6: Refinements & Testing (Weeks 11-12)

*   **Goal:** Implement optimistic concurrency, basic profile management, UI testing foundation, and improve overall test coverage.
*   **Tasks:**
    *   Task 6.1: Implement RFC9110 conditional headers (`If-Match` using `Version` rowversion) for `PUT` and `DELETE` operations on Articles and Attachments API endpoints. (2 days)
    *   Task 6.2: Update Blazor edit/delete flows to fetch the latest version and send the `If-Match` header, handling potential concurrency conflicts (412 Precondition Failed). (1.5 days)
    *   Task 6.3: Implement basic author profile management UI in Blazor (view/edit basic Identity user fields). (1.5 days)
    *   Task 6.4: Set up Playwright for UI testing within the solution structure. (1 day)
    *   Task 6.5: Write initial Playwright tests for core Blazor authoring flows (login, create article, view article list). (2 days)
    *   Task 6.6: Write initial Playwright tests for core MVC public flows (view homepage, view article). (1 day)
    *   Task 6.7: Review and increase unit/integration test coverage across projects, aiming towards the 75% goal (excluding Aspire/test projects). (1 day)
