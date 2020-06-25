Imports System.Configuration
Imports System.Runtime.Serialization

Namespace Models
    <SettingsSerializeAs(SettingsSerializeAs.Xml)>
    Public Class LocalModCollection
        Public Property Mods As List(Of LocalMod)

        Public Sub New()
            Mods = New List(Of LocalMod)
        End Sub

        Public Sub New(info As SerializationInfo, ctxt As StreamingContext)
            Mods = info.GetValue("LocalMods", GetType(List(Of LocalMod)))
        End Sub

    End Class
End Namespace