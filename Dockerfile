FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /App

# Copy everything
COPY . ./

WORKDIR /App/MexicanoFrontend
# Restore as distinct layers
RUN dotnet restore
RUN dotnet publish -c Release -o out

WORKDIR /App
FROM nginx:1.23.0-alpine
EXPOSE 8080
COPY nginx.conf /etc/nginx/nginx.conf
COPY --from=build /App/MexicanoFrontend/out/wwwroot /usr/share/nginx/html
