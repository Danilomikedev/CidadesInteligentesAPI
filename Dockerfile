# Use uma imagem base do .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copia os arquivos do projeto para o container
COPY . ./

# Restaura dependências
RUN dotnet restore

# Compila a aplicação
RUN dotnet publish -c Release -o out

# Use uma imagem base do .NET Runtime para rodar a aplicação
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Copia os arquivos da pasta 'out' do estágio de build
COPY --from=build-env /app/out .

# Define a porta que será exposta
EXPOSE 80

# Comando para rodar a aplicação
ENTRYPOINT ["dotnet", "CidadesInteligentesAPI.dll"]
