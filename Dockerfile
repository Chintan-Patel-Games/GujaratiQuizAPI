
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY GujaratiTestApi.csproj ./
RUN dotnet restore GujaratiTestApi.csproj

COPY . .
RUN dotnet publish GujaratiTestApi.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "GujaratiTestApi.dll"]