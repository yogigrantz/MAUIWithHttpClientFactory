# MAUIWithHttpClientFactory

This is a sample .net 7 MAUI application that uses IHttpClientFactory injected to its IoC. The App class would take it and inject it to AppShell, and AppShell would instantiate the pages with Func object that contains the injected IHttpClientFactory.

This setup will make IHttpClientFactory avalable to all ContentPages  
