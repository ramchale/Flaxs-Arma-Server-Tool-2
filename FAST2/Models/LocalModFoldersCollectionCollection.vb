Imports System.Configuration
Imports System.Runtime.Serialization

Namespace Models
    <SettingsSerializeAs(SettingsSerializeAs.Xml)>
    Public Class LocalModFolderCollection
        Public Property Folders As List(Of String)

        Public Sub New()
            Folders = New List(Of String)
        End Sub

        Public Sub New(info As SerializationInfo, ctxt As StreamingContext)
            Folders = info.GetValue("LocalModFolders", GetType(List(Of SteamMod)))
        End Sub

        Public Function Count()
            Return Folders.Count()
        End Function

    End Class
End Namespace