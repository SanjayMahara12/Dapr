FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM  mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["MyFrontEnd/MyFrontEnd.csproj", "MyFrontEnd/"]
RUN dotnet restore "MyFrontEnd/MyFrontEnd.csproj"
COPY . .
WORKDIR "/src/MyFrontEnd"
RUN dotnet build "MyFrontEnd.csproj" -c $configuration -o /app/build

FROM build AS publish
RUN dotnet publish "MyFrontEnd.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyFrontEnd.dll"]
