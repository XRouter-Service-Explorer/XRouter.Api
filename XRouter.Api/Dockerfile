FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 8082

FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /src
COPY ["XRouter.Api/XRouter.Api.csproj", "XRouter.Api/"]
RUN dotnet restore "XRouter.Api/XRouter.Api.csproj"
COPY . .
WORKDIR "/src/XRouter.Api"
RUN dotnet build "XRouter.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "XRouter.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "XRouter.Api.dll"]