Sub CreateMail()
 
    Dim objOutlook As Object
    Dim objMail As Object
    Dim rngTo As Range
    Dim rngSubject As Range
    Dim rngBody As Range
    Dim rngAttach As Range
 
    Set objOutlook = CreateObject("Outlook.Application")
    Set objMail = objOutlook.CreateItem(0)
 
    With ActiveSheet
        Set rngTo = .Range("B1")
        Set rngSubject = .Range("B2")
        Set rngBody = .Range("B3")
    End With
 
    With objMail
        .to = rngTo.Value
        .Subject = rngSubject.Value
        .Body = rngBody.Value
        .Display 'Instead of .Display, you can use .Send to send the email _
                    or .Save to save a copy in the drafts folder
    End With
 
    Set objOutlook = Nothing
    Set objMail = Nothing
    Set rngTo = Nothing
    Set rngSubject = Nothing
    Set rngBody = Nothing
    Set rngAttach = Nothing
 
End Sub