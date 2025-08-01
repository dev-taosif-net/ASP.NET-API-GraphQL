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

 
 ## ✅ Nugget package 
 - **GraphQL.Server.All**  => This will install all the dependency. Only GraphQL and GraphQL.Server.Transport will do the work

 ## ✅ Future Learning Scope
 - [ ] Hot Chocolate Nugget package 
 - [ ] Banana Cake pop



> Written with [StackEdit](https://stackedit.io/).
<!--stackedit_data:
eyJoaXN0b3J5IjpbMTc4NDYyMDc5OSwxNzM0MTQ3MTk2LC01MD
M4NzEyNzMsNDE4ODU1MDcsODMwNjE4OTMzLDE3NzA0MTg5MDAs
NzMwOTk4MTE2XX0=
-->