#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Zhaoxi.AspNetCore31.DockerProject/Zhaoxi.AspNetCore31.DockerProject.csproj", "Zhaoxi.AspNetCore31.DockerProject/"]
RUN dotnet restore "Zhaoxi.AspNetCore31.DockerProject/Zhaoxi.AspNetCore31.DockerProject.csproj"
COPY . .
WORKDIR "/src/Zhaoxi.AspNetCore31.DockerProject"
RUN dotnet build "Zhaoxi.AspNetCore31.DockerProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Zhaoxi.AspNetCore31.DockerProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Zhaoxi.AspNetCore31.DockerProject.dll"]

#通篇下来，就是准备基础镜像--cope代码--编译---发布---dotnet
