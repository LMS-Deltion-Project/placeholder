FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build-env
WORKDIR /lms

EXPOSE 5005

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore
# Build and publish a release
CMD [ "dotnet", "watch" ]

# # Build runtime image
# FROM mcr.microsoft.com/dotnet/aspnet:7.0
# WORKDIR /lms
# COPY --from=build-env /lms/out .
# ENTRYPOINT ["dotnet", "lms.dll"]