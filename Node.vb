﻿Public Class Node

    'Dependecny on arcs


    'Node properties
    Public Property ID As String
    Public Property ArcIn As List(Of Arc)
    Public Property ArcOut As List(Of Arc)
    Public Property Demand As Decimal

    'Constructor
    Public Sub New()

    End Sub

    'Paramatized Constructor
    Public Sub New(nodeid As String)
        ID = nodeid
        ArcIn = New List(Of Arc)
        ArcOut = New List(Of Arc)

    End Sub

    'Override ToString Function
    Public Overrides Function ToString() As String
        Return "Node: " & ID & ", Demand: " & Demand
    End Function



End Class
