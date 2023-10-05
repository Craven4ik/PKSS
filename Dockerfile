#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

LABEL version="1.0"
LABEL description="Куппа Максим Николаевич ИКБО-10-20"

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["PKSS.csproj", "."]
RUN dotnet restore "./PKSS.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "PKSS.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PKSS.csproj" -c Release -o /app/publish /p:UseAppHost=false

RUN curl -O https://www.mirea.ru/upload/medialibrary/80f/MIREA_Gerb_Colour.png

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ONBUILD CMD ["Сборка и запуск произведены. Автор: Куппа М.Н."]
ENTRYPOINT ["dotnet", "PKSS.dll"]