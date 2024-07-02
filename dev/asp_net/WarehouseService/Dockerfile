# Базовый образ
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Образ для сборки
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WarehouseService/WarehouseService.csproj", "WarehouseService/"]
RUN dotnet restore "WarehouseService/WarehouseService.csproj"
COPY . .
WORKDIR "/src/WarehouseService"
RUN dotnet build "WarehouseService.csproj" -c Release -o /app/build

# Образ для публикации
FROM build AS publish
RUN dotnet publish "WarehouseService.csproj" -c Release -o /app/publish

# Окончательный образ
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WarehouseService.dll"]
