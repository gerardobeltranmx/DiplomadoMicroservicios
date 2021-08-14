#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["APIWebEmpleados/APIWebEmpleados.csproj", "APIWebEmpleados/"]
RUN dotnet restore "APIWebEmpleados/APIWebEmpleados.csproj"
COPY . .
WORKDIR "/src/APIWebEmpleados"
RUN dotnet build "APIWebEmpleados.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "APIWebEmpleados.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "APIWebEmpleados.dll"]