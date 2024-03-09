# Dapr
Dapr Sample
Added one basic console application to show Dapr Statestore connect on 
default Dapr Redis store
Added one MyFrontEnd project
Added one MyBackEnd project 

Dapr includes service discovery, automatic retries, message encryption (using mTLS), and improved observability
To use Dapr building blocks from inside a containerized application, you’ll need to add the Dapr sidecars containers to your Compose file.
RUN:

  dapr run --app-id backend  --app-port 5000 --dapr-http-port 3500 -- dotnet run   
  //makes available at 5000 and 3500 port
  dapr run --app-id backend  --app-port 5000 -- dotnet run                    
      //makes available only at 5000 port
	  
  dapr run --app-id frontend --app-port 5005 --dapr-http-port 3600 -- dotnet run
  //
  dapr run --app-id frontend --app-port 5005 -- dotnet run                 
 //running on one port 5005

