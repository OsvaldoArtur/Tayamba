﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class GestHorarioEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=GestHorarioEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property Administrador_tb() As DbSet(Of Administrador_tb)
    Public Property Ano_tb() As DbSet(Of Ano_tb)
    Public Property Cadeira_tb() As DbSet(Of Cadeira_tb)
    Public Property Criar_Horario_tb() As DbSet(Of Criar_Horario_tb)
    Public Property Cusos_tb() As DbSet(Of Cusos_tb)
    Public Property Departamento_tb() As DbSet(Of Departamento_tb)
    Public Property Docente_tb() As DbSet(Of Docente_tb)
    Public Property Faculdade_tb() As DbSet(Of Faculdade_tb)
    Public Property Horario_tb() As DbSet(Of Horario_tb)
    Public Property Horas_tb() As DbSet(Of Horas_tb)
    Public Property Licenca_tb() As DbSet(Of Licenca_tb)
    Public Property Periodo_tb() As DbSet(Of Periodo_tb)
    Public Property Salas_tb() As DbSet(Of Salas_tb)
    Public Property Semana_tb() As DbSet(Of Semana_tb)
    Public Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Property Usuario_tb() As DbSet(Of Usuario_tb)
    Public Property View_Horario() As DbSet(Of View_Horario)
    Public Property View_ListaHorario() As DbSet(Of View_ListaHorario)

End Class
