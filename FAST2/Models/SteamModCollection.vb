Imports System.Configuration
Imports System.Runtime.Serialization

Namespace Models
    <SettingsSerializeAs(SettingsSerializeAs.Xml)>
    Public Class SteamModCollection
        Public Property Mods As List(Of SteamMod)

        Public Sub New()
            Mods = New List(Of SteamMod)
        End Sub

        Public Sub New(info As SerializationInfo, ctxt As StreamingContext)
            Mods = info.GetValue("SteamMods", GetType(List(Of SteamMod)))
        End Sub

        Public Function Count()
            Return Mods.Count()
        End Function

    End Class
End Namespace