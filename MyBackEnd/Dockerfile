FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5273

ENV ASPNETCORE_URLS=http://+:5273

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["MyBackEnd/MyBackEnd.csproj", "MyBackEnd/"]
RUN dotnet restore "MyBackEnd/MyBackEnd.csproj"
COPY . .
WORKDIR "/src/MyBackEnd"
RUN dotnet build "MyBackEnd.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "MyBackEnd.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyBackEnd.dll"]
