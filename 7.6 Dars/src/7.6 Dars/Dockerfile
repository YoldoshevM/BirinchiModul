FROM mcr.microsoft.com/dotnet/aspnet:10.0-preview AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:10.0-preview AS build
WORKDIR /src
COPY ["src/7.6 Dars/7.6 Dars.csproj", "src/7.6 Dars/"]
RUN dotnet restore "src/7.6 Dars/7.6 Dars.csproj"
COPY . .
WORKDIR "/src/src/7.6 Dars"
RUN dotnet build "7.6 Dars.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "7.6 Dars.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "7.6 Dars.dll"]