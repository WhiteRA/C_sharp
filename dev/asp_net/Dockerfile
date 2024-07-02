# Базовый образ
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Образ для сборки
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["StoreApp/StoreApp.csproj", "StoreApp/"]
RUN dotnet restore "StoreApp/StoreApp.csproj"
COPY . .
WORKDIR "/src/StoreApp"
RUN dotnet build "StoreApp.csproj" -c Release -o /app/build

# Образ для публикации
FROM build AS publish
RUN dotnet publish "StoreApp.csproj" -c Release -o /app/publish

# Окончательный образ
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "StoreApp.dll"]
