# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /source
ARG NUGET_AUTH_TOKEN
ARG NUGET_USER_NAME
ARG CERT_NAME
#ARG CERT_PASSWORD
# copy csproj and restore as distinct layers
COPY src/MaruthiPanShop.UserService/ .
COPY nuget.config .
RUN sed -i -e "s/USER/$NUGET_USER_NAME/g" -e "s/PW/$NUGET_AUTH_TOKEN/g" nuget.config
RUN dotnet restore --use-current-runtime

# copy and publish app and libraries
#COPY . .
RUN dotnet publish -c Release -o /app --use-current-runtime --self-contained false

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
EXPOSE 8080
EXPOSE 8081
ENV ASPNETCORE_URLS="http://+:8080;https://+:8081;"
ENV ASPNETCORE_Kestrel__Certificates__Default__Password=password
ENV ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx
COPY --from=build /app .
ENTRYPOINT ["dotnet", "MaruthiPanShop.UserService.dll"]
