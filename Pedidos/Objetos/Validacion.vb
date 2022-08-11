Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices

Module Validacion
    Sub ValidateObj(ByVal obj As Object)

        If obj Is Nothing Then Return

        Dim properties As PropertyInfo() = obj.[GetType]().GetProperties()

        For Each propertyInfo In properties

            If Not propertyInfo.CanWrite Then Continue For

            If propertyInfo.PropertyType = GetType(String) Then
                Dim att As StringLengthAttribute = Nothing
                Dim attArr = propertyInfo.GetCustomAttributes(GetType(StringLengthAttribute), False)

                If attArr IsNot Nothing AndAlso attArr.Length > 0 Then
                    att = If(CType(attArr(0), StringLengthAttribute), Nothing)
                End If

                Dim lenght = Convert.ToInt32(If(att?.MaximumLength, 0))

                If lenght > 0 Then
                    propertyInfo.SetValue(obj, If(propertyInfo.GetValue(obj), "").ToString().Trim().Truncate(lenght))
                Else
                    propertyInfo.SetValue(obj, If(propertyInfo.GetValue(obj), "").ToString().Trim())
                End If

                Continue For
            End If

            'TIPOS NULOS
            If (Nullable.GetUnderlyingType(propertyInfo.PropertyType) IsNot Nothing) Then
                If propertyInfo.PropertyType.GenericTypeArguments(0) = GetType(Decimal) Then
                    If (propertyInfo.GetValue(obj) Is Nothing) Then
                        propertyInfo.SetValue(obj, 0D)
                    End If
                    Continue For
                End If

                If propertyInfo.PropertyType.GenericTypeArguments(0) = GetType(Single) Then
                    If (propertyInfo.GetValue(obj) Is Nothing) Then
                        propertyInfo.SetValue(obj, 0F)
                    End If
                    Continue For
                End If

                If propertyInfo.PropertyType.GenericTypeArguments(0) = GetType(Double) Then
                    If (propertyInfo.GetValue(obj) Is Nothing) Then
                        propertyInfo.SetValue(obj, 0#)
                    End If
                    Continue For
                End If

                If propertyInfo.PropertyType.GenericTypeArguments(0) = GetType(Integer) Then
                    If (propertyInfo.GetValue(obj) Is Nothing) Then
                        propertyInfo.SetValue(obj, 0%)
                    End If
                    Continue For
                End If

                If propertyInfo.PropertyType.GenericTypeArguments(0) = GetType(DateTime) Then
                    If (propertyInfo.GetValue(obj) Is Nothing) Then
                        propertyInfo.SetValue(obj, New DateTime(2000, 1, 1))
                    End If
                    Continue For
                End If

                If propertyInfo.PropertyType.GenericTypeArguments(0) = GetType(Char) Then
                    If (propertyInfo.GetValue(obj) Is Nothing) Then
                        propertyInfo.SetValue(obj, " "c)
                    End If
                    Continue For
                End If

                If propertyInfo.PropertyType.GenericTypeArguments(0) = GetType(Boolean) Then
                    If (propertyInfo.GetValue(obj) Is Nothing) Then
                        propertyInfo.SetValue(obj, False)
                    End If
                    Continue For
                End If

            Else
                'TIPOS NO NULOS
                If propertyInfo.PropertyType = GetType(Decimal) AndAlso propertyInfo.GetValue(obj).ToString().ToDecimal() = 0D Then
                    propertyInfo.SetValue(obj, 0D)
                    Continue For
                End If

                If propertyInfo.PropertyType = GetType(Single) AndAlso propertyInfo.GetValue(obj).ToString().ToDecimal() = 0F Then
                    propertyInfo.SetValue(obj, 0F)
                    Continue For
                End If

                If propertyInfo.PropertyType = GetType(Double) AndAlso propertyInfo.GetValue(obj).ToString().ToDecimal() = 0# Then
                    propertyInfo.SetValue(obj, 0#)
                    Continue For
                End If

                If propertyInfo.PropertyType = GetType(Integer) AndAlso propertyInfo.GetValue(obj).ToString().ToDecimal() = 0% Then
                    propertyInfo.SetValue(obj, 0%)
                    Continue For
                End If

                If propertyInfo.PropertyType = GetType(DateTime) Then
                    If propertyInfo.GetValue(obj).ToString().ToDateTime() < New DateTime(1901, 1, 1) Then
                        propertyInfo.SetValue(obj, New DateTime(2000, 1, 1))
                    End If
                    Continue For
                End If

                If propertyInfo.PropertyType = GetType(Char) AndAlso propertyInfo.GetValue(obj).ToString() = "" Then
                    propertyInfo.SetValue(obj, " "c)
                    Continue For
                End If

                If propertyInfo.PropertyType = GetType(Boolean) Then
                    Console.WriteLine(propertyInfo.GetValue(obj))
                    If propertyInfo.GetValue(obj) Is Nothing Or CBool(propertyInfo.GetValue(obj)) <> True Then
                        propertyInfo.SetValue(obj, False)
                        Continue For
                    End If
                End If
            End If
        Next
    End Sub

    <Extension()>
    Function Truncate(ByVal texto As String, ByVal largoMaximo As Integer) As String
        If String.IsNullOrEmpty(texto) Then texto = ""
        texto = If(texto.Length <= largoMaximo, texto, texto.Substring(0, largoMaximo))
        Return texto.Trim()
    End Function

    <Extension()>
    Function ToText(ByVal num As Decimal) As String
        Return num.ToString("G29")
    End Function

    <Extension()>
    Function ToText(ByVal num As Integer) As String
        Return num.ToString("G29")
    End Function

    <Extension()>
    Function ToDateTime(ByVal text As String) As DateTime
        Dim result = New DateTime(2000, 1, 1)
        DateTime.TryParse(text, result)
        Return result
    End Function
End Module


