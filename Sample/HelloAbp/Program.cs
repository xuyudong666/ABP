using HelloAbp;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp;

var application = AbpApplicationFactory.Create<HelloAbpModule>();
application.Initialize();


var service = application.ServiceProvider.GetService<HelloWorldService>();
service.Run();
