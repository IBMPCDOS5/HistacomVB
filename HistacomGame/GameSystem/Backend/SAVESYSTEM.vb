Public Class SaveBlock
    Public name As String
    Public MainStr As String
    Public Properties As New List(Of SaveProperty)
    Public Blocks As New List(Of SaveBlock)
    Dim i As Integer
    Dim ldFrom As String
    Dim InBlock As Boolean
    Dim InBlockI As New List(Of Integer)
    Public Sub AddProperty(ByVal name As String, ByVal value As Object)
        Dim newProp As New SaveProperty
        newProp.Name = name
        newProp.Value = value
        Properties.Add(newProp)
        MainStr &= """" & name & """:""" & value & """" & vbCrLf
    End Sub

    Public Sub AddBlock(ByVal name As String, ByVal block As SaveBlock)
        block.name = name
        Blocks.Add(block)

        'This bit adds tabs to all the things
        Dim tmpStr As String() = block.MainStr.Split(vbCrLf)
        Dim extraStr As String = ""
        Dim i As Integer
        Do Until i = tmpStr.Count
            tmpStr(i) = vbTab & tmpStr(i)
            extraStr = extraStr & tmpStr(i) & vbCrLf
            i += 1
        Loop

        MainStr &= name & " {" & vbCrLf & extraStr & "}" & vbCrLf
    End Sub

    Public Function FindProperty(ByVal name As String) As SaveProperty
        Dim DefProperty As New SaveProperty
        i = 0
        Dim csavep As SaveProperty = Nothing
        Do Until i = Properties.Count
            If Properties(i).Name = name Then
                csavep = Properties(i)
                Return csavep
                Exit Function
            End If
            i += 1
        Loop
        csavep = DefProperty
        Return csavep
    End Function

    Public Function FindBlock(ByVal name As String) As SaveBlock
        Dim DefBlock As New SaveBlock
        i = 0
        Dim csaveb As SaveBlock = Nothing
        Do Until i = Blocks.Count
            If Blocks(i).name = name Then
                csaveb = Blocks(i)
                Return csaveb
                Exit Function
            End If
            i += 1
        Loop
        csaveb = DefBlock
        Return csaveb
    End Function

    Public Sub SaveToFile(ByVal filename As String)
        FileOpen(1, filename, OpenMode.Output)
        PrintLine(1, MainStr)
        PrintLine(1, "--END--")
        FileClose(1)
    End Sub

    Public Sub LoadFromFile(ByVal filename As String)
        i = 0
        Dim EachSide As String() = Nothing
        FileOpen(1, filename, OpenMode.Input)
        Do Until i = -1
            Try
                ldFrom = LineInput(1)
                ldFrom.Replace(vbTab, "")
                If ldFrom = "--END--" Then
                    Exit Do
                Else
                    If ldFrom.StartsWith("""") Then 'If it is a property
                        Try
                            EachSide = ldFrom.Split(":")
                            EachSide(0) = EachSide(0).Replace("""", "")
                            EachSide(1) = EachSide(1).Replace("""", "")
                            If InBlock = True Then
                                Blocks(InBlockI(InBlockI.Count - 1)).AddProperty(EachSide(0), EachSide(1))
                            Else
                                AddProperty(EachSide(0), EachSide(1))
                            End If

                            Array.Clear(EachSide, 0, EachSide.Length)
                        Catch ex As Exception
                            Array.Clear(EachSide, 0, EachSide.Length)
                        End Try
                    ElseIf ldFrom.EndsWith("{") Then 'If it is a block!
                        Try
                            Dim nblock As New SaveBlock
                            nblock.name = ldFrom.Substring(0, ldFrom.Length - 2)
                            InBlock = True
                            Blocks.Add(nblock)
                            InBlockI.Add(Blocks.Count - 1)
                            Array.Clear(EachSide, 0, EachSide.Length)
                        Catch ex As Exception
                            Array.Clear(EachSide, 0, EachSide.Length)
                        End Try
                    ElseIf ldFrom.StartsWith("}") Then
                        InBlockI.Remove(InBlockI.Count - 1)
                        If InBlockI.Count = 0 Then
                            InBlock = False
                        End If
                    End If

                End If
            Catch ex As Exception
                Exit Do
            End Try

        Loop
        FileClose(1)
        MainStr = ""
    End Sub
End Class

Public Class SaveProperty
    Public Name As String
    Public Value As Object
End Class
