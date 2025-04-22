// See https://aka.ms/new-console-template for more information
using CreativeMinds.PRHData.RestApi;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");

var serviceProvider = new ServiceCollection()
			.AddSingleton<IPRHSearchEngine, PRHSearchEngine>()
			.AddHttpClient()
			.BuildServiceProvider();

CancellationToken cancellationToken = new CancellationToken();

var search = serviceProvider.GetService<IPRHSearchEngine>();

var data = search.SearchForCompanyByNameAsync("food folk suomi", 1, cancellationToken).Result;

String temp = "";
