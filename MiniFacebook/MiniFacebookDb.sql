USE [MiniFacebookDB]
GO
SET IDENTITY_INSERT [dbo].[PostPrivacy] ON 

INSERT [dbo].[PostPrivacy] ([Id], [PrivacyType]) VALUES (1, N'public')
INSERT [dbo].[PostPrivacy] ([Id], [PrivacyType]) VALUES (2, N'friends')
INSERT [dbo].[PostPrivacy] ([Id], [PrivacyType]) VALUES (3, N'only me')
SET IDENTITY_INSERT [dbo].[PostPrivacy] OFF
INSERT [dbo].[Users] ([Id], [UserName], [Email], [Phone]) VALUES (N'437b12b8-aba6-46b1-b411-7eebf15f21fc', N'SaeedSaeed', N'sa.saeed@example.com', N'01009054936')
INSERT [dbo].[Users] ([Id], [UserName], [Email], [Phone]) VALUES (N'63ed1560-289b-4423-8853-9ffcc1014e4f', N'AhmedSaeed', N'as.saeed@example.com', N'01009054936')
INSERT [dbo].[Users] ([Id], [UserName], [Email], [Phone]) VALUES (N'2150584d-9c21-445a-8803-a3caa05d0ab0', N'EslamKhashab', N'e.saeed@example.com', N'01009054936')
INSERT [dbo].[Users] ([Id], [UserName], [Email], [Phone]) VALUES (N'9aebe3c6-1482-4c91-9adb-c7f30218b69f', N'FatenSaeed', N'fa.saeed@example.com', N'01009054936')
INSERT [dbo].[Users] ([Id], [UserName], [Email], [Phone]) VALUES (N'13a7d9dc-6a90-46c1-864a-cead7c553c6a', N'mostafaSaeed', N'mo.saeed@example.com', N'01009054936')
INSERT [dbo].[Users] ([Id], [UserName], [Email], [Phone]) VALUES (N'9986b4d9-2914-4581-8be1-d0541b66221c', N'Howida', N'Howida@example.com', N'01029100607')
INSERT [dbo].[Users] ([Id], [UserName], [Email], [Phone]) VALUES (N'1e9806a1-8219-420f-8a5f-de1d000f7349', N'Nahla', N'Nahla@example.com', N'01009054936')
INSERT [dbo].[Users] ([Id], [UserName], [Email], [Phone]) VALUES (N'351a835c-a6a9-472d-9bda-edfdc3d0a518', N'Eslam', N'e.sad@example.com', N'01009054936')
INSERT [dbo].[Posts] ([Id], [IsArchive], [CreatedDate], [ModifiedDate], [ImageUrl], [Text], [UserId], [PostPrivacyId]) VALUES (N'a2bfd38a-31f2-429d-2c99-08d83b18d562', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-08-07T21:28:31.7539079' AS DateTime2), N'0dc63618-ca59-4886-82c3-46d6ce4e5028.jpg', N'This My Second Post', N'1e9806a1-8219-420f-8a5f-de1d000f7349', 2)
INSERT [dbo].[Posts] ([Id], [IsArchive], [CreatedDate], [ModifiedDate], [ImageUrl], [Text], [UserId], [PostPrivacyId]) VALUES (N'c08a9a90-8237-4ce8-9e67-08d83b7d9d73', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-08-08T09:29:57.0818537' AS DateTime2), N'9330210a-b045-43a8-9071-5871993fb7dc.jpg', N'Eslam Test', N'1e9806a1-8219-420f-8a5f-de1d000f7349', 2)
INSERT [dbo].[Posts] ([Id], [IsArchive], [CreatedDate], [ModifiedDate], [ImageUrl], [Text], [UserId], [PostPrivacyId]) VALUES (N'05b0759e-7a3b-4f9f-9e68-08d83b7d9d73', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-08-08T09:30:14.8896192' AS DateTime2), N'bd5f85ca-3b8d-4d58-bd95-006c85f38f2b.jpg', N'Eslam Test 1', N'1e9806a1-8219-420f-8a5f-de1d000f7349', 2)
INSERT [dbo].[Posts] ([Id], [IsArchive], [CreatedDate], [ModifiedDate], [ImageUrl], [Text], [UserId], [PostPrivacyId]) VALUES (N'dacc6b68-d778-490c-166f-08d83b7f6d94', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-08-08T09:42:42.0832862' AS DateTime2), N'81c7ab90-1d4a-4925-b251-b6698fbdc7ee.jpg', N'Test File Manger', N'1e9806a1-8219-420f-8a5f-de1d000f7349', 2)
INSERT [dbo].[Posts] ([Id], [IsArchive], [CreatedDate], [ModifiedDate], [ImageUrl], [Text], [UserId], [PostPrivacyId]) VALUES (N'0b46251e-17d7-4d09-bcaf-08d83b8bbb79', 0, CAST(N'2020-08-08T11:11:00.4472231' AS DateTime2), CAST(N'2020-08-08T11:11:00.4456319' AS DateTime2), N'de37ee23-38dc-4caa-b903-18e8143a540e.jpg', N'Hello There', N'9986b4d9-2914-4581-8be1-d0541b66221c', 2)
INSERT [dbo].[Posts] ([Id], [IsArchive], [CreatedDate], [ModifiedDate], [ImageUrl], [Text], [UserId], [PostPrivacyId]) VALUES (N'edf93479-22d6-4c3e-8c47-9ee6ea55a719', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-08-07T21:28:31.7539079' AS DateTime2), N'0dc63618-ca59-4886-82c3-46d6ce4e5028.jpg', N'This My Second Post', N'2150584d-9c21-445a-8803-a3caa05d0ab0', 2)
INSERT [dbo].[Posts] ([Id], [IsArchive], [CreatedDate], [ModifiedDate], [ImageUrl], [Text], [UserId], [PostPrivacyId]) VALUES (N'dd574fbb-7d1b-45ae-8852-a993ec5e030b', 0, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), CAST(N'2020-08-07T21:28:31.7539079' AS DateTime2), N'0dc63618-ca59-4886-82c3-46d6ce4e5028.jpg', N'This My Second Post', N'2150584d-9c21-445a-8803-a3caa05d0ab0', 2)
INSERT [dbo].[UserFriends] ([UserId], [FriendId], [IsAccept]) VALUES (N'63ed1560-289b-4423-8853-9ffcc1014e4f', N'13a7d9dc-6a90-46c1-864a-cead7c553c6a', 1)
INSERT [dbo].[UserFriends] ([UserId], [FriendId], [IsAccept]) VALUES (N'2150584d-9c21-445a-8803-a3caa05d0ab0', N'437b12b8-aba6-46b1-b411-7eebf15f21fc', 0)
INSERT [dbo].[UserFriends] ([UserId], [FriendId], [IsAccept]) VALUES (N'2150584d-9c21-445a-8803-a3caa05d0ab0', N'63ed1560-289b-4423-8853-9ffcc1014e4f', 0)
INSERT [dbo].[UserFriends] ([UserId], [FriendId], [IsAccept]) VALUES (N'2150584d-9c21-445a-8803-a3caa05d0ab0', N'9aebe3c6-1482-4c91-9adb-c7f30218b69f', 0)
INSERT [dbo].[UserFriends] ([UserId], [FriendId], [IsAccept]) VALUES (N'2150584d-9c21-445a-8803-a3caa05d0ab0', N'13a7d9dc-6a90-46c1-864a-cead7c553c6a', 0)
INSERT [dbo].[UserFriends] ([UserId], [FriendId], [IsAccept]) VALUES (N'9986b4d9-2914-4581-8be1-d0541b66221c', N'2150584d-9c21-445a-8803-a3caa05d0ab0', 1)
INSERT [dbo].[UserFriends] ([UserId], [FriendId], [IsAccept]) VALUES (N'9986b4d9-2914-4581-8be1-d0541b66221c', N'1e9806a1-8219-420f-8a5f-de1d000f7349', 0)
INSERT [dbo].[UserFriends] ([UserId], [FriendId], [IsAccept]) VALUES (N'1e9806a1-8219-420f-8a5f-de1d000f7349', N'2150584d-9c21-445a-8803-a3caa05d0ab0', 1)
SET IDENTITY_INSERT [dbo].[Logs] ON 

INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (1, CAST(N'2020-08-07T01:48:36.107' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (2, CAST(N'2020-08-07T15:53:33.113' AS DateTime), N'Object reference not set to an instance of an object.', N'   at MiniFacebook.Shared.Helper.MethodsHelper.GetCurrentUserId()
   at MiniFacebook.ViewModel.FriendRequestDto..ctor() in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.ViewModel\FriendRequestDto.cs:line 8
   at MiniFacebook.Orchestrator.Services.AuthenticateService.AuthenticateService.SendFriendRequset(Guid Id) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Services\Services\AuthenticateService\AuthenticateService.cs:line 137
   at MiniFacebook.API.Controllers.AuthenticateController.SendFrinedRequset(Guid Id) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Controllers\AuthenticateController.cs:line 71
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context)
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext)', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (3, CAST(N'2020-08-07T18:02:42.263' AS DateTime), N'The From phone number +15017122661 is not a valid, SMS-capable inbound phone number or short code for your account.', N'   at Twilio.Clients.TwilioRestClient.ProcessResponse(Response response)
   at Twilio.Clients.TwilioRestClient.Request(Request request)
   at Twilio.Rest.Api.V2010.Account.MessageResource.Create(CreateMessageOptions options, ITwilioRestClient client)
   at Twilio.Rest.Api.V2010.Account.MessageResource.Create(PhoneNumber to, String pathAccountSid, PhoneNumber from, String messagingServiceSid, String body, List`1 mediaUrl, Uri statusCallback, String applicationSid, Nullable`1 maxPrice, Nullable`1 provideFeedback, Nullable`1 validityPeriod, Nullable`1 forceDelivery, Nullable`1 smartEncoded, ITwilioRestClient client)
   at MiniFacebook.Orchestrator.Services.AuthenticateService.AuthenticateService.Register(RegisterDto registerDto)
   at MiniFacebook.API.Controllers.AuthenticateController.Register(RegisterDto data) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Controllers\AuthenticateController.cs:line 58
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (4, CAST(N'2020-08-07T18:07:50.357' AS DateTime), N'The From phone number +201285578520 is not a valid, SMS-capable inbound phone number or short code for your account.', N'   at Twilio.Clients.TwilioRestClient.ProcessResponse(Response response)
   at Twilio.Clients.TwilioRestClient.Request(Request request)
   at Twilio.Rest.Api.V2010.Account.MessageResource.Create(CreateMessageOptions options, ITwilioRestClient client)
   at Twilio.Rest.Api.V2010.Account.MessageResource.Create(PhoneNumber to, String pathAccountSid, PhoneNumber from, String messagingServiceSid, String body, List`1 mediaUrl, Uri statusCallback, String applicationSid, Nullable`1 maxPrice, Nullable`1 provideFeedback, Nullable`1 validityPeriod, Nullable`1 forceDelivery, Nullable`1 smartEncoded, ITwilioRestClient client)
   at MiniFacebook.Orchestrator.Services.AuthenticateService.AuthenticateService.Register(RegisterDto registerDto)
   at MiniFacebook.API.Controllers.AuthenticateController.Register(RegisterDto data) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Controllers\AuthenticateController.cs:line 58
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (5, CAST(N'2020-08-07T18:09:04.513' AS DateTime), N'The ''To'' number 201009054936 is not a valid phone number.', N'   at Twilio.Clients.TwilioRestClient.ProcessResponse(Response response)
   at Twilio.Clients.TwilioRestClient.Request(Request request)
   at Twilio.Rest.Api.V2010.Account.MessageResource.Create(CreateMessageOptions options, ITwilioRestClient client)
   at Twilio.Rest.Api.V2010.Account.MessageResource.Create(PhoneNumber to, String pathAccountSid, PhoneNumber from, String messagingServiceSid, String body, List`1 mediaUrl, Uri statusCallback, String applicationSid, Nullable`1 maxPrice, Nullable`1 provideFeedback, Nullable`1 validityPeriod, Nullable`1 forceDelivery, Nullable`1 smartEncoded, ITwilioRestClient client)
   at MiniFacebook.Orchestrator.Services.AuthenticateService.AuthenticateService.Register(RegisterDto registerDto) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Services\Services\AuthenticateService\AuthenticateService.cs:line 96
   at MiniFacebook.API.Controllers.AuthenticateController.Register(RegisterDto data) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Controllers\AuthenticateController.cs:line 58
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (6, CAST(N'2020-08-07T23:22:18.293' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (7, CAST(N'2020-08-07T23:22:18.393' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (8, CAST(N'2020-08-07T23:22:49.017' AS DateTime), N'An error occurred while updating the entries. See the inner exception for details.', N'   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.ExecuteAsync(IEnumerable`1 commandBatches, IRelationalConnection connection, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(IList`1 entriesToSave, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChangesAsync(DbContext _, Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal.SqlServerExecutionStrategy.ExecuteAsync[TState,TResult](TState state, Func`4 operation, Func`4 verifySucceeded, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken)
   at MiniFacebook.Shared.GlobalUOW.UnitOfWork.CompleteAsync() in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\GlobalUOW\UnitOfWork.cs:line 20
   at MiniFacebook.Orchestrator.Services.PostService.PostService.AddPost(AddPostDto Payload) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Services\Services\PostService\PostService.cs:line 34
   at MiniFacebook.API.Controllers.PostController.AddPost(AddPostDto Payload) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Controllers\PostController.cs:line 38
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', N'Microsoft.Data.SqlClient.SqlException (0x80131904): The INSERT statement conflicted with the FOREIGN KEY constraint "FK_Posts_PostPrivacy_PostPrivacyId". The conflict occurred in database "MiniFacebookDB", table "dbo.PostPrivacy", column ''Id''.
The statement has been terminated.
   at Microsoft.Data.SqlClient.SqlCommand.<>c.<ExecuteDbDataReaderAsync>b__164_0(Task`1 result)
   at System.Threading.Tasks.ContinuationResultTaskFromResultTask`2.InnerInvoke()
   at System.Threading.Tasks.Task.<>c.<.cctor>b__274_0(Object obj)
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state)
--- End of stack trace from previous location where exception was thrown ---
   at System.Threading.ExecutionContext.RunInternal(ExecutionContext executionContext, ContextCallback callback, Object state)
   at System.Threading.Tasks.Task.ExecuteWithThreadLocal(Task& currentTaskSlot, Thread threadPoolThread)
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReaderAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReaderAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Storage.RelationalCommand.ExecuteReaderAsync(RelationalCommandParameterObject parameterObject, CancellationToken cancellationToken)
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.ExecuteAsync(IRelationalConnection connection, CancellationToken cancellationToken)
ClientConnectionId:6073e38b-1c6e-44b2-8036-e57582c160e9
Error Number:547,State:0,Class:16', NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (9, CAST(N'2020-08-07T23:27:38.513' AS DateTime), N'Input string was not in a correct format.', N'   at System.Number.ThrowOverflowOrFormatException(ParsingStatus status, TypeCode type)
   at System.Number.ParseInt32(ReadOnlySpan`1 value, NumberStyles styles, NumberFormatInfo info)
   at System.Int32.Parse(String s)
   at MiniFacebook.Orchestrator.Services.PostService.PostService.AddPost(AddPostDto Payload) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Services\Services\PostService\PostService.cs:line 34
   at MiniFacebook.API.Controllers.PostController.AddPost(AddPostDto Payload) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Controllers\PostController.cs:line 38
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.InvokeInnerFilterAsync()
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.InvokeFilterPipelineAsync()
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (10, CAST(N'2020-08-07T23:53:37.803' AS DateTime), N'
Unmapped members were found. Review the types and members below.
Add a custom mapping expression, ignore, add a custom resolver, or modify the source/destination type
For no matching constructor, add a no-arg ctor, add optional arguments, or map all of the constructor parameters
=================================================================================================================================================================================
AutoMapper created this type map for you, but your types cannot be mapped using the current configuration.
EnumerableQuery`1 -> PostDto (Destination member list)
System.Linq.EnumerableQuery`1[[MiniFacebook.Models.Entities.Post, MiniFacebook.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] -> MiniFacebook.ViewModel.PostDto (Destination member list)

Unmapped properties:
Text
ImageUrl
Date
', N'   at lambda_method(Closure , EnumerableQuery`1 , PostDto , ResolutionContext )
   at lambda_method(Closure , Object , Object , ResolutionContext )
   at MiniFacebook.Orchestrator.Services.PostService.PostService.ListMyFriendPosts(Guid UserId, PaginationObject paginationObject) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Services\Services\PostService\PostService.cs:line 85
   at MiniFacebook.API.Controllers.PostController.AddPost(Guid UserId, PaginationObject paginationObject) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Controllers\PostController.cs:line 53
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (11, CAST(N'2020-08-07T23:53:49.313' AS DateTime), N'
Unmapped members were found. Review the types and members below.
Add a custom mapping expression, ignore, add a custom resolver, or modify the source/destination type
For no matching constructor, add a no-arg ctor, add optional arguments, or map all of the constructor parameters
=================================================================================================================================================================================
AutoMapper created this type map for you, but your types cannot be mapped using the current configuration.
EnumerableQuery`1 -> PostDto (Destination member list)
System.Linq.EnumerableQuery`1[[MiniFacebook.Models.Entities.Post, MiniFacebook.Models, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] -> MiniFacebook.ViewModel.PostDto (Destination member list)

Unmapped properties:
Text
ImageUrl
Date
', N'   at lambda_method(Closure , EnumerableQuery`1 , PostDto , ResolutionContext )
   at lambda_method(Closure , Object , Object , ResolutionContext )
   at MiniFacebook.Orchestrator.Services.PostService.PostService.ListMyFriendPosts(Guid UserId, PaginationObject paginationObject) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Services\Services\PostService\PostService.cs:line 85
   at MiniFacebook.API.Controllers.PostController.AddPost(Guid UserId, PaginationObject paginationObject) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Controllers\PostController.cs:line 53
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (12, CAST(N'2020-08-08T12:56:10.467' AS DateTime), N'Another instance of ResponseCachingFeature already exists. Only one instance of ResponseCachingMiddleware can be configured for an application.', N'   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.AddResponseCachingFeature(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (13, CAST(N'2020-08-08T12:57:22.467' AS DateTime), N'Another instance of ResponseCachingFeature already exists. Only one instance of ResponseCachingMiddleware can be configured for an application.', N'   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.AddResponseCachingFeature(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (14, CAST(N'2020-08-08T13:01:57.040' AS DateTime), N'The number  is unverified. Trial accounts cannot send messages to unverified numbers; verify  at twilio.com/user/account/phone-numbers/verified, or purchase a Twilio number to send messages to unverified numbers.', N'   at Twilio.Clients.TwilioRestClient.ProcessResponse(Response response)
   at Twilio.Clients.TwilioRestClient.Request(Request request)
   at Twilio.Rest.Api.V2010.Account.MessageResource.Create(CreateMessageOptions options, ITwilioRestClient client)
   at Twilio.Rest.Api.V2010.Account.MessageResource.Create(PhoneNumber to, String pathAccountSid, PhoneNumber from, String messagingServiceSid, String body, List`1 mediaUrl, Uri statusCallback, String applicationSid, Nullable`1 maxPrice, Nullable`1 provideFeedback, Nullable`1 validityPeriod, Nullable`1 forceDelivery, Nullable`1 smartEncoded, ITwilioRestClient client)
   at MiniFacebook.Orchestrator.Services.AuthenticateService.AuthenticateService.Register(RegisterDto registerDto) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Services\Services\AuthenticateService\AuthenticateService.cs:line 95
   at MiniFacebook.API.Controllers.AuthenticateController.Register(RegisterDto data) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Controllers\AuthenticateController.cs:line 61
   at Microsoft.AspNetCore.Mvc.Infrastructure.ActionMethodExecutor.TaskOfIActionResultExecutor.Execute(IActionResultTypeMapper mapper, ObjectMethodExecutor executor, Object controller, Object[] arguments)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeActionMethodAsync>g__Awaited|12_0(ControllerActionInvoker invoker, ValueTask`1 actionResultValueTask)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeNextActionFilterAsync>g__Awaited|10_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Rethrow(ActionExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker.<InvokeInnerFilterAsync>g__Awaited|13_0(ControllerActionInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeNextResourceFilter>g__Awaited|24_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Rethrow(ResourceExecutedContextSealed context)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.Next(State& next, Scope& scope, Object& state, Boolean& isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeFilterPipelineAsync>g__Awaited|19_0(ResourceInvoker invoker, Task lastTask, State next, Scope scope, Object state, Boolean isCompleted)
   at Microsoft.AspNetCore.Mvc.Infrastructure.ResourceInvoker.<InvokeAsync>g__Awaited|17_0(ResourceInvoker invoker, Task task, IDisposable scope)
   at Microsoft.AspNetCore.Routing.EndpointMiddleware.<Invoke>g__AwaitRequestTask|6_0(Endpoint endpoint, Task requestTask, ILogger logger)
   at MiniFacebook.API.Startup.<>c.<<Configure>b__6_0>d.MoveNext() in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook\Startup.cs:line 129
--- End of stack trace from previous location where exception was thrown ---
   at Microsoft.AspNetCore.ResponseCaching.ResponseCachingMiddleware.Invoke(HttpContext httpContext)
   at Microsoft.AspNetCore.Authorization.AuthorizationMiddleware.Invoke(HttpContext context)
   at Microsoft.AspNetCore.Authentication.AuthenticationMiddleware.Invoke(HttpContext context)
   at Swashbuckle.AspNetCore.SwaggerUI.SwaggerUIMiddleware.Invoke(HttpContext httpContext)
   at Swashbuckle.AspNetCore.Swagger.SwaggerMiddleware.Invoke(HttpContext httpContext, ISwaggerProvider swaggerProvider)
   at MiniFacebook.Shared.Middlewares.CurrentCultureMiddleware.Invoke(HttpContext context) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\CurrentCultureMiddleware.cs:line 28
   at MiniFacebook.Shared.GlobalException.ExceptionMiddleware.InvokeAsync(HttpContext httpContext) in C:\Users\Khashba\Desktop\MiniFacebook\MiniFacebook.Shared\Middlewares\ExceptionMiddleware.cs:line 43', NULL, NULL, N'500')
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (15, CAST(N'2020-08-08T13:03:14.637' AS DateTime), NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Logs] ([Id], [TimeStamp], [Message], [StackTrace], [InnerException], [ErrorId], [ExceptionType]) VALUES (16, CAST(N'2020-08-08T13:03:14.647' AS DateTime), NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Logs] OFF
