FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["KeyVault.Poc/KeyVault.Poc.csproj", "KeyVault.Poc/"]
RUN dotnet restore "KeyVault.Poc/KeyVault.Poc.csproj"
COPY . .
WORKDIR "/src/KeyVault.Poc"
RUN dotnet build "KeyVault.Poc.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KeyVault.Poc.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KeyVault.Poc.dll"]