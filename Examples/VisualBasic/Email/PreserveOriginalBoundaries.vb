﻿Imports System.IO
Imports Aspose.Email.Mail

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email
	Class PreserveOriginalBoundaries
		Public Shared Sub Run()
			' ExStart:PreservOriginalBoundaries
			' The path to the File directory.
			Dim dataDir As String = RunExamples.GetDataDir_Email()

			Dim mailMessage__1 As MailMessage = MailMessage.Load(dataDir & Convert.ToString("Attachments.eml"))

			' Save as eml with preserved original boundares
            Dim emlSaveOptions As New EmlSaveOptions(MailMessageSaveType.EmlFormat) With { _
                .PreserveOriginalBoundaries = True _
            }
			mailMessage__1.Save(dataDir & Convert.ToString("PreserveOriginalBoundaries_out.eml"), emlSaveOptions)
			' ExEnd:PreservOriginalBoundaries
		End Sub
	End Class
End Namespace