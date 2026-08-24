Imports System.Xml

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ConfigObject As New Config(Application.StartupPath & "\AppConfig.xml")
        Dim Parameters As New Config.Configuration

        Parameters.Company = "Company Name"
        Parameters.Solution = "Solution Name"
        Parameters.Project = "Project Name"
        Parameters.Version = "1"
        Parameters.Section = "Section Name"
        Parameters.User = "A Username"
        Parameters.Setting = "A Setting"
        Parameters.DefaultValue = "[Blank]"

        Console.WriteLine("Value in " & Parameters.Setting & " is " & ConfigObject.GetSettingValue(Parameters))


    End Sub
End Class
