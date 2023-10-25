FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app

COPY . .

RUN dotnet restore /app/Alunos1.csproj
RUN dotnet build -c Release -o out /app/Alunos1.csproj


CMD ["dotnet", "out/Alunos1.dll"]