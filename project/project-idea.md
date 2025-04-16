# Introduction

ProPulse is a content publishing and marketing platform that can be considered a combination of [Medium](https://medium.com) and [Buffer](https://buffer.com) with a healthy injection of generative AI that makes the entire workflow of publishing content much easier. 

## Technology stack

This application will be built with the latest technologies for dotnet 9:

* .NET Aspire for local orchestration.
* ASP.NET Core for web and API capabilities.
* ASP.NET Identity for username and password authentication.
* Entity Framework Core for database access.
* DbUp for database migrations.
* xUnit, FluentAssertions, NSubstitute, and TestContainers for testing.

For production, we will host the application on Azure, using Azure platform services where possible to simplify the architecture.  The service will be deployed using Azure Developer CLI, Bicep, and Azure Verified Modules.

## Features

### Authors

Authors can publish articles on this platform. All articles are stored as Markdown and combine narrative and images. For the MVP, authors will be able to write articles using a visual editor and upload their own images. Follow on capabilities include adding tags to the article for better organization and generative AI capabilities to generate images, automatically provide excerpts, and provide a writing coach copilot.  (AI Use Case: Marketing / AI-enabled marketing content generation).

### Publishing

Authors can schedule that there article is published at a specific time (and retired at a specific time) in the MVP.  In future phases, ProPulse will generate relevant metadata (such as tags, blog featured image, and related articles and/or documentation links based on public information)  (AI Use Case: Marketing / AI-enabled content generation).

### Reading

In the MVP, ProPulse will provide the anonymous user an index page together with the ability to read an article.  Future capabilities include the ability for authenticated users to comment and rate articles which then drive additional functionality like top posts on the index page.  The front page will, in the future, also learn from the customer reading habits so that the most relevant articles are presented first (AI Use Case: Marking / Continuous customer micro-segmentation).

With customer preferences in mind, we will add (post-MVP) a search capability that provides relevant search results based on natural language queries.

When readers comment on posts, ProPulse can apply content moderation to the search results, preventin not just "against the ToS" comments but also irrelevant comments.  If the comment is answered by other materials, it can suggest further reading instead. (AI Use Case: DPO / Document and workflow automation).  Comment sentiment can be used as a driver for the index page.

### Marketing

Marketing will not be covered in the MVP, but handled in a follow-on phase.  As a post is published, an appropriate summary and hashtags is generated based on the needs of the social media channel.  For instance, the post on X (formerly Twitter) is 160 characters and allows multiple hashtags, whereas the post on Threads only allows one hashtag.  Posts for LinkedIn can be longer.






