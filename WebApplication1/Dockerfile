# Use official .NET 9.0 Preview runtime image
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS base
WORKDIR /app
EXPOSE 8080

# Use .NET 9.0 Preview SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /src

# Copy the .csproj first and restore dependencies
COPY WebApplication1.csproj ./
RUN dotnet restore WebApplication1.csproj

# Copy everything else and publish
COPY . .
RUN dotnet publish WebApplication1.csproj -c Release -o /app/publish

# Build runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

# Start the app
ENTRYPOINT ["dotnet", "WebApplication1.dll"]
