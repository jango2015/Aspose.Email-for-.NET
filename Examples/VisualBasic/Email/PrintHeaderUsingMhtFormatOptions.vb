﻿Imports Aspose.Email.Mail

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email
    Class PrintHeaderUsingMhtFormatOptions
        Public Shared Sub Run()
            ' ExStart:PrintHeaderUsingMhtFormatOptions
            ' The path to the File directory.
            Dim dataDir As String = RunExamples.GetDataDir_Email()

            Dim options As New MailMessageLoadOptions()
            options.MessageFormat = MessageFormat.Eml
            ' This will Preserve the TNEF attachment as it is, file contains the TNEF attachment
            options.FileCompatibilityMode = FileCompatibilityMode.PreserveTnefAttachments
            Dim eml As MailMessage = MailMessage.Load(dataDir & Convert.ToString("Attachments.eml"), options)
            For Each attachment As Attachment In eml.Attachments
                Console.WriteLine(attachment.Name)
            Next
            ' ExEnd:PrintHeaderUsingMhtFormatOptions
        End Sub
    End Class
End Namespace