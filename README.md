# MAUIWithHttpClientFactory

This is a sample .net 7 MAUI application that uses IHttpClientFactory injected to its IoC, with special class "Pagecollection" that holds the IHttpClientFactory object in place that is also injected in its IoC.

This setup will make IHttpClientFactory avalable to all ContentPages  
