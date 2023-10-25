FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /app

COPY . .

RUN dotnet restore Alunos1_Backup.csproj
RUN dotnet restore Alunos1.csproj
RUN dotnet build -c Release -o out Alunos1.csproj


CMD ["dotnet", "out/SeuApp.dll"]