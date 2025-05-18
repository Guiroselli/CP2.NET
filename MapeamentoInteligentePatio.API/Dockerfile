
# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY . .
RUN dotnet restore "./MapeamentoInteligentePatio.API/MapeamentoInteligentePatio.API.csproj"
RUN dotnet publish "./MapeamentoInteligentePatio.API/MapeamentoInteligentePatio.API.csproj" -c Release -o /out

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out ./
ENTRYPOINT ["dotnet", "MapeamentoInteligentePatio.API.dll"]
