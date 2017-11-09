Imports System.Xml

Public Class PlanetsXML

    Private Shared ReadOnly r As New Random()

    Private Sub XMLTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbPlanets.Items.Clear()
        Dim xr As XmlReader = XmlReader.Create(My.Application.Info.DirectoryPath & "\Planets\planetsTemplate.xml")
        Do While xr.Read()

            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "name" Then

                cbPlanets.Items.Add(xr.ReadElementContentAsString)
                cbPlanets.Sorted = True
                cbPlanets.SelectedIndex = 0

            Else

                xr.Read()

            End If

        Loop
        xr.Close()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim objectPlanets As New objPlanets

    End Sub

End Class
