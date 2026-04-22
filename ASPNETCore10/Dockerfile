# Build stage — uses the full SDK image
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy csproj and restore first — Docker caches this layer
# so restore only re-runs when dependencies change
COPY *.csproj .
COPY Directory.Packages.props .
RUN dotnet restore

# Copy everything else and publish
COPY . .
RUN dotnet publish -c Release -o /app/publish --no-restore

# Runtime stage — much smaller image, no SDK
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
COPY --from=build /src/content ./content

# ASP.NET Core listens on 8080 by default in containers
EXPOSE 8080
ENTRYPOINT ["dotnet", "RencherDesign.dll"]