Imports System.IO

Public Class StarTable

    Shared Function vacuumTable() As DataTable

        Dim table As New DataTable
        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\Primary Stats\vacuum.txt")
        Dim line As String = sr.ReadLine()
        Dim row As DataRow

        table.Columns.Add("Spectral Type", GetType(String))
        table.Columns.Add("Mass", GetType(Decimal))
        table.Columns.Add("Luminosity", GetType(Decimal))
        table.Columns.Add("Inner Life Distance", GetType(Decimal))
        table.Columns.Add("Outer Life Distance", GetType(Decimal))

        Do

            line = sr.ReadLine()
            While String.IsNullOrEmpty(line) = False AndAlso line.StartsWith("#") = True

                line = sr.ReadLine()

            End While
            row = table.NewRow()
            row.ItemArray = Split(line, ", ")
            table.Rows.Add(row)

        Loop While Not line = String.Empty

        Return table

    End Function

    Shared Function traceTable() As DataTable

        Dim table As New DataTable
        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\Primary Stats\trace.txt")
        Dim line As String = sr.ReadLine()
        Dim row As DataRow

        table.Columns.Add("Spectral Type", GetType(String))
        table.Columns.Add("Mass", GetType(Decimal))
        table.Columns.Add("Luminosity", GetType(Decimal))
        table.Columns.Add("Inner Life Distance", GetType(Decimal))
        table.Columns.Add("Outer Life Distance", GetType(Decimal))

        Do

            line = sr.ReadLine()
            While String.IsNullOrEmpty(line) = False AndAlso line.StartsWith("#") = True

                line = sr.ReadLine()

            End While
            row = table.NewRow()
            row.ItemArray = Split(line, ", ")
            table.Rows.Add(row)

        Loop While Not line = String.Empty

        Return table

    End Function

    Shared Function thinTable() As DataTable

        Dim table As New DataTable
        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\Primary Stats\thin.txt")
        Dim line As String = sr.ReadLine()
        Dim row As DataRow

        table.Columns.Add("Spectral Type", GetType(String))
        table.Columns.Add("Mass", GetType(Decimal))
        table.Columns.Add("Luminosity", GetType(Decimal))
        table.Columns.Add("Inner Life Distance", GetType(Decimal))
        table.Columns.Add("Outer Life Distance", GetType(Decimal))

        Do

            line = sr.ReadLine()
            While String.IsNullOrEmpty(line) = False AndAlso line.StartsWith("#") = True

                line = sr.ReadLine()

            End While
            row = table.NewRow()
            row.ItemArray = Split(line, ", ")
            table.Rows.Add(row)

        Loop While Not line = String.Empty

        Return table

    End Function

    Shared Function standardTable() As DataTable

        Dim table As New DataTable
        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\Primary Stats\standard.txt")
        Dim line As String = sr.ReadLine()
        Dim row As DataRow

        table.Columns.Add("Spectral Type", GetType(String))
        table.Columns.Add("Mass", GetType(Decimal))
        table.Columns.Add("Luminosity", GetType(Decimal))
        table.Columns.Add("Inner Life Distance", GetType(Decimal))
        table.Columns.Add("Outer Life Distance", GetType(Decimal))
        table.Columns.Add("Habitability", GetType(Integer))

        Do

            line = sr.ReadLine()
            While String.IsNullOrEmpty(line) = False AndAlso line.StartsWith("#") = True

                line = sr.ReadLine()

            End While
            row = table.NewRow()
            row.ItemArray = Split(line, ", ")
            table.Rows.Add(row)

        Loop While Not line = String.Empty

        Return table

    End Function

    Shared Function highTable() As DataTable

        Dim table As New DataTable
        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\Primary Stats\high.txt")
        Dim line As String = sr.ReadLine()
        Dim row As DataRow

        table.Columns.Add("Spectral Type", GetType(String))
        table.Columns.Add("Mass", GetType(Decimal))
        table.Columns.Add("Luminosity", GetType(Decimal))
        table.Columns.Add("Inner Life Distance", GetType(Decimal))
        table.Columns.Add("Outer Life Distance", GetType(Decimal))

        Do

            line = sr.ReadLine()
            While String.IsNullOrEmpty(line) = False AndAlso line.StartsWith("#") = True

                line = sr.ReadLine()

            End While
            row = table.NewRow()
            row.ItemArray = Split(line, ", ")
            table.Rows.Add(row)

        Loop While Not line = String.Empty

        Return table

    End Function

    Shared Function veryhighTable() As DataTable

        Dim table As New DataTable
        Dim sr As New StreamReader(My.Application.Info.DirectoryPath & "\Primary Stats\very high.txt")
        Dim line As String = sr.ReadLine()
        Dim row As DataRow

        table.Columns.Add("Spectral Type", GetType(String))
        table.Columns.Add("Mass", GetType(Decimal))
        table.Columns.Add("Luminosity", GetType(Decimal))
        table.Columns.Add("Inner Life Distance", GetType(Decimal))
        table.Columns.Add("Outer Life Distance", GetType(Decimal))

        Do

            line = sr.ReadLine()
            While String.IsNullOrEmpty(line) = False AndAlso line.StartsWith("#") = True

                line = sr.ReadLine()

            End While
            row = table.NewRow()
            row.ItemArray = Split(line, ", ")
            table.Rows.Add(row)

        Loop While Not line = String.Empty

        Return table

    End Function

End Class
