# GraphQL
GraphQL is a query language for APIs and a runtime for executing those queries with your existing data. It was developed by Facebook and released as an open-source project in 2015. GraphQL provides a more flexible and efficient alternative to traditional REST APIs.

 - Clients ask exactly for the data they need.
 - All data is accessed through one URL, unlike REST which uses multiple endpoints.
 - The schema defines what queries are allowed and what types of data exist.
 - The client controls the shape and structure of the response.
 - Solves Overfetching → Clients get only the fields they request, not 		extra data.
 - Solves Underfetching → Clients can fetch related data in a single request, avoiding multiple round trips.
 - Acts like a smart BFF (Backend For Frontend) → One flexible API that serves multiple frontends (web, mobile, etc.) with different data needs.
 
 ## ✅ Advantages of GraphQL
 - 🔄 **Flexibility in queries**
 - 📉 **Reducing API calls**  
 - 🧾 **Strong typing and automatic documentation**  
 - 📡 **Support for real-time (Subscriptions)**  
 - 🚀 **API evolution without breaking clients**  
 - 📶 **Bandwidth usage efficiency**

 ## ⚠️ Disadvantages of GraphQL
 - ⚙️ **Complexity in implementation**  
 - 📘 **Learning curve**  
 - 🧠 **Server overload risk**  
 - ❌ **Lacks native HTTP cache support**
 
  ## ✅ Operations
  
|  Operation| GraphQL  | REST  | 
| - | - | - | 
| Read  | Query  | GET | 
| Write| Mutations | POST , PUT ,DELETE , PATCH | 
| Events | Subscription  | N/A | 

        query GetAssets($first: Int) {
      assets(first: $first) {
        nodes {
          name
        }
      }
    }
  ## ✅ Transport Agnostic
 -   HTTP POST (most common)
 -   HTTP GET for Queries
 -   WebSockets for Subscriptions
 -   SSE for Subscriptions
 -   gRPC used in some instances
 
 ## ✅ Nugget package 
 - **GraphQL.Server.All**  => This will install all the dependency. Only GraphQL and GraphQL.Server.Transport will do the work
 - **Hot Chocolate**
 
  ## ✅ First GraphQL Server(Using Hot chocolate)
  **Step1:Create a project**
 - dotnet new web -n FirstGraphQL
 - dotnet sln .\ASP.NET-API-GraphQL.sln add .\FirstGraphQL\
 
 **Step2: Add nugget Package**

 - dotnet add package HotChocolate.AspNetCore

  **Step3: Go to the graphQl Server**

 - https://localhost:7112/graphql/
 
 **Step4: Code**
 Code:

     var builder = WebApplication.CreateBuilder(args);  
    builder.Services  
      .AddGraphQLServer()  
     .AddQueryType<Query>();  
    var app = builder.Build();  
    app.MapGraphQL();  
    app.MapGet("/", () => "Hello World!");  
    app.Run();  
    public class Query  
    {  
      public string SayHello(string name = "GraphQL") => $"Hello,{name} !";  
    }
   Request :
   

 

  
  

 ## ✅ Future Learning Scope
 - [ ] Banana Cake pop



> Written with [StackEdit](https://stackedit.io/).
<!--stackedit_data:
eyJoaXN0b3J5IjpbLTEwNzAwMTAyNjgsMTIzODA4MjI0MiwxNj
c0NzA1MjQyLC0xNDg5NDQ0NjE2LDQ5MDAyOTQ0MCw4OTc4MjQ1
OTAsMTc4NDYyMDc5OSwxNzM0MTQ3MTk2LC01MDM4NzEyNzMsND
E4ODU1MDcsODMwNjE4OTMzLDE3NzA0MTg5MDAsNzMwOTk4MTE2
XX0=
-->