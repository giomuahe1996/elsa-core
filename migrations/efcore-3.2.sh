#!/usr/bin/env bash

# Define the modules to update
mods=("Alterations" "Runtime" "Management" "Identity" "DataSets")

# Define the list of providers
providers=("MySql" "SqlServer" "Sqlite" "PostgreSql")

# Loop through each module
for module in "${mods[@]}"; do
    # Loop through each provider
    for provider in "${providers[@]}"; do
        providerPath="../src/modules/Elsa.EntityFrameworkCore.$provider"
        migrationsPath="Migrations/$module"
    
        echo "Updating migrations for $provider..."
        echo "Provider path: ${providerPath:?}/${migrationsPath}"
        echo "Migrations path: $migrationsPath"
        dotnet ef migrations add V3_2 -c "$module"ElsaDbContext -p "$providerPath"  -o "$migrationsPath"
    done
done