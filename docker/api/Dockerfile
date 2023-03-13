# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /api

# copy csproj and restore as distinct layers
# COPY *.sln .
# COPY aspnetapp/*.csproj ./aspnetapp/
# RUN dotnet restore

COPY ./services/api ./

RUN dotnet tool install --global dotnet-ef

RUN PATH="$PATH:/root/.dotnet/tools"

CMD [ "dotnet", "watch" ]