FROM mcr.microsoft.com/dotnet/runtime:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["SurpassDataPopulator/SurpassDataPopulator.csproj", "SurpassDataPopulator/"]
RUN dotnet restore "SurpassDataPopulator/SurpassDataPopulator.csproj"
COPY . .
WORKDIR "/src/SurpassDataPopulator"
RUN dotnet build "SurpassDataPopulator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SurpassDataPopulator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SurpassDataPopulator.dll"]
