# Dapr
Dapr Sample
Added one basic console application to show Dapr Statestore connect on 
default Dapr Redis store
Added one MyFrontEnd project
Added one MyBackEnd project 

Dapr includes service discovery, automatic retries, message encryption (using mTLS), and improved observability
To use Dapr building blocks from inside a containerized application, you’ll need to add the Dapr sidecars containers to your Compose file.
RUN:
----------------------------------
  Project Backend 
----------------------------------
dapr run --app-id backend  --app-port 5000 --dapr-http-port 3500 -- dotnet run   
dapr run --app-id backend  --app-port 5000 -- dotnet run                    

----------------------------------
  Project WebUi(FrontEnd that would consume backend services)
----------------------------------
dapr run --app-id frontend --app-port 5005 --dapr-http-port 3600 -- dotnet run
dapr run --app-id frontend --app-port 5005 -- dotnet run                 

----------------------------------
 Dapr Dashboard
----------------------------------
run command "dapr dashboard"
//this is to get a dapr UI interface to view and control the dapr sidecar apps

----------------------------------
 Tye
----------------------------------