﻿// <auto-generated />
using System;
using Elsa.EntityFrameworkCore.Modules.Management;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Elsa.EntityFrameworkCore.Sqlite.Migrations.Management
{
    [DbContext(typeof(ManagementElsaDbContext))]
    [Migration("20240229205101_V3_1")]
    partial class V3_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.14");

            modelBuilder.Entity("Elsa.Workflows.Management.Entities.WorkflowDefinition", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("BinaryData")
                        .HasColumnType("BLOB");

                    b.Property<string>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLatest")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsReadonly")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MaterializerContext")
                        .HasColumnType("TEXT");

                    b.Property<string>("MaterializerName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderName")
                        .HasColumnType("TEXT");

                    b.Property<string>("StringData")
                        .HasColumnType("TEXT");

                    b.Property<string>("ToolVersion")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("UsableAsActivity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IsLatest")
                        .HasDatabaseName("IX_WorkflowDefinition_IsLatest");

                    b.HasIndex("IsPublished")
                        .HasDatabaseName("IX_WorkflowDefinition_IsPublished");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowDefinition_Name");

                    b.HasIndex("UsableAsActivity")
                        .HasDatabaseName("IX_WorkflowDefinition_UsableAsActivity");

                    b.HasIndex("Version")
                        .HasDatabaseName("IX_WorkflowDefinition_Version");

                    b.HasIndex("DefinitionId", "Version")
                        .IsUnique()
                        .HasDatabaseName("IX_WorkflowDefinition_DefinitionId_Version");

                    b.ToTable("WorkflowDefinitions");
                });

            modelBuilder.Entity("Elsa.Workflows.Management.Entities.WorkflowInstance", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CorrelationId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .HasColumnType("TEXT");

                    b.Property<string>("DataCompressionAlgorithm")
                        .HasColumnType("TEXT");

                    b.Property<string>("DefinitionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("DefinitionVersionId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FinishedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("IncidentCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SubStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedAt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CorrelationId")
                        .HasDatabaseName("IX_WorkflowInstance_CorrelationId");

                    b.HasIndex("CreatedAt")
                        .HasDatabaseName("IX_WorkflowInstance_CreatedAt");

                    b.HasIndex("DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_DefinitionId");

                    b.HasIndex("FinishedAt")
                        .HasDatabaseName("IX_WorkflowInstance_FinishedAt");

                    b.HasIndex("Name")
                        .HasDatabaseName("IX_WorkflowInstance_Name");

                    b.HasIndex("Status")
                        .HasDatabaseName("IX_WorkflowInstance_Status");

                    b.HasIndex("SubStatus")
                        .HasDatabaseName("IX_WorkflowInstance_SubStatus");

                    b.HasIndex("UpdatedAt")
                        .HasDatabaseName("IX_WorkflowInstance_UpdatedAt");

                    b.HasIndex("Status", "DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_Status_DefinitionId");

                    b.HasIndex("Status", "SubStatus")
                        .HasDatabaseName("IX_WorkflowInstance_Status_SubStatus");

                    b.HasIndex("SubStatus", "DefinitionId")
                        .HasDatabaseName("IX_WorkflowInstance_SubStatus_DefinitionId");

                    b.HasIndex("Status", "SubStatus", "DefinitionId", "Version")
                        .HasDatabaseName("IX_WorkflowInstance_Status_SubStatus_DefinitionId_Version");

                    b.ToTable("WorkflowInstances");
                });
#pragma warning restore 612, 618
        }
    }
}
