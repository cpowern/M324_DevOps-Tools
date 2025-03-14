# --- Stage 1: Build the project ---
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything (solution and projects) into container
COPY . .

# Restore and publish in Release mode
RUN dotnet restore ./ToDoApp.sln
RUN dotnet publish ./ToDoApp.sln -c Release -o /app/out

# --- Stage 2: Final runtime image ---
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app

# Copy published output from build stage
COPY --from=build /app/out .

# This is a console app, so we run the DLL
ENTRYPOINT ["dotnet", "ToDoApp.dll"]
