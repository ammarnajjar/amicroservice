FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src

COPY amicroservice.csproj amicroservice/
RUN dotnet restore amicroservice/amicroservice.csproj
WORKDIR /src/amicroservice
COPY . .
RUN dotnet build amicroservice.csproj -c Release -o /app

FROM build as publish
RUN dotnet publish amicroservice.csproj -c Release -o /app

FROM base AS final
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "amicroservice.dll"]
