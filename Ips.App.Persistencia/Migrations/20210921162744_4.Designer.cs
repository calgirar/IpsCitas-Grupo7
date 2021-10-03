﻿// <auto-generated />
using System;
using Ips.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ips.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210921162744_4")]
    partial class _4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ips.App.Dominio.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CiudadSedeId")
                        .HasColumnType("int");

                    b.Property<int?>("ConsultorioId")
                        .HasColumnType("int");

                    b.Property<int?>("DireccionSedeId")
                        .HasColumnType("int");

                    b.Property<int?>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<int?>("FechaHorarioId")
                        .HasColumnType("int");

                    b.Property<int?>("NombreDoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("NombrePacienteId")
                        .HasColumnType("int");

                    b.Property<int?>("NombreSedeId")
                        .HasColumnType("int");

                    b.Property<int?>("TelefonoSedeId")
                        .HasColumnType("int");

                    b.Property<string>("TipoCita")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CiudadSedeId");

                    b.HasIndex("ConsultorioId");

                    b.HasIndex("DireccionSedeId");

                    b.HasIndex("EspecialidadId");

                    b.HasIndex("FechaHorarioId");

                    b.HasIndex("NombreDoctorId");

                    b.HasIndex("NombrePacienteId");

                    b.HasIndex("NombreSedeId");

                    b.HasIndex("TelefonoSedeId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Ips.App.Dominio.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Consultorio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Eps")
                        .HasColumnType("bit");

                    b.Property<int?>("EspecialidadId")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NIT")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadId");

                    b.ToTable("Doctores");
                });

            modelBuilder.Entity("Ips.App.Dominio.Eps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("NombreEps")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonoEps")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Eps");
                });

            modelBuilder.Entity("Ips.App.Dominio.Especialidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Especalidad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("Ips.App.Dominio.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CorreoId")
                        .HasColumnType("int");

                    b.Property<bool>("Descuento")
                        .HasColumnType("bit");

                    b.Property<int?>("FechaId")
                        .HasColumnType("int");

                    b.Property<int?>("NITId")
                        .HasColumnType("int");

                    b.Property<int?>("NombreId")
                        .HasColumnType("int");

                    b.Property<int?>("NombreSedeId")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<int?>("TelefonoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CorreoId");

                    b.HasIndex("FechaId");

                    b.HasIndex("NITId");

                    b.HasIndex("NombreId");

                    b.HasIndex("NombreSedeId");

                    b.HasIndex("TelefonoId");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Ips.App.Dominio.Horario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaHorario")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("Ips.App.Dominio.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<bool>("Eps")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NIT")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("Ips.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NIT")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Ips.App.Dominio.Sede", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CiudadSede")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DireccionSede")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreSede")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonoSede")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sedes");
                });

            modelBuilder.Entity("Ips.App.Dominio.Cita", b =>
                {
                    b.HasOne("Ips.App.Dominio.Sede", "CiudadSede")
                        .WithMany()
                        .HasForeignKey("CiudadSedeId");

                    b.HasOne("Ips.App.Dominio.Doctor", "Consultorio")
                        .WithMany()
                        .HasForeignKey("ConsultorioId");

                    b.HasOne("Ips.App.Dominio.Sede", "DireccionSede")
                        .WithMany()
                        .HasForeignKey("DireccionSedeId");

                    b.HasOne("Ips.App.Dominio.Doctor", "Especialidad")
                        .WithMany()
                        .HasForeignKey("EspecialidadId");

                    b.HasOne("Ips.App.Dominio.Horario", "FechaHorario")
                        .WithMany()
                        .HasForeignKey("FechaHorarioId");

                    b.HasOne("Ips.App.Dominio.Doctor", "NombreDoctor")
                        .WithMany()
                        .HasForeignKey("NombreDoctorId");

                    b.HasOne("Ips.App.Dominio.Paciente", "NombrePaciente")
                        .WithMany()
                        .HasForeignKey("NombrePacienteId");

                    b.HasOne("Ips.App.Dominio.Sede", "NombreSede")
                        .WithMany()
                        .HasForeignKey("NombreSedeId");

                    b.HasOne("Ips.App.Dominio.Sede", "TelefonoSede")
                        .WithMany()
                        .HasForeignKey("TelefonoSedeId");

                    b.Navigation("CiudadSede");

                    b.Navigation("Consultorio");

                    b.Navigation("DireccionSede");

                    b.Navigation("Especialidad");

                    b.Navigation("FechaHorario");

                    b.Navigation("NombreDoctor");

                    b.Navigation("NombrePaciente");

                    b.Navigation("NombreSede");

                    b.Navigation("TelefonoSede");
                });

            modelBuilder.Entity("Ips.App.Dominio.Doctor", b =>
                {
                    b.HasOne("Ips.App.Dominio.Especialidad", "Especialidad")
                        .WithMany()
                        .HasForeignKey("EspecialidadId");

                    b.Navigation("Especialidad");
                });

            modelBuilder.Entity("Ips.App.Dominio.Factura", b =>
                {
                    b.HasOne("Ips.App.Dominio.Paciente", "Correo")
                        .WithMany()
                        .HasForeignKey("CorreoId");

                    b.HasOne("Ips.App.Dominio.Cita", "Fecha")
                        .WithMany()
                        .HasForeignKey("FechaId");

                    b.HasOne("Ips.App.Dominio.Paciente", "NIT")
                        .WithMany()
                        .HasForeignKey("NITId");

                    b.HasOne("Ips.App.Dominio.Paciente", "Nombre")
                        .WithMany()
                        .HasForeignKey("NombreId");

                    b.HasOne("Ips.App.Dominio.Sede", "NombreSede")
                        .WithMany()
                        .HasForeignKey("NombreSedeId");

                    b.HasOne("Ips.App.Dominio.Paciente", "Telefono")
                        .WithMany()
                        .HasForeignKey("TelefonoId");

                    b.Navigation("Correo");

                    b.Navigation("Fecha");

                    b.Navigation("NIT");

                    b.Navigation("Nombre");

                    b.Navigation("NombreSede");

                    b.Navigation("Telefono");
                });
#pragma warning restore 612, 618
        }
    }
}