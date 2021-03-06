﻿Imports System.IO
Imports Aspose.Email.Mail
Imports Aspose.Email.Outlook

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email
	Class CreatingTNEFFromMSG
		Public Shared Sub Run()
			' ExStart:CreatingTNEFFromMSG
			' The path to the File directory.
			Dim dataDir As String = RunExamples.GetDataDir_Email()

			Dim msg As MapiMessage = MapiMessage.FromFile(dataDir & Convert.ToString("Message.msg"))
			Dim mi As MailMessageInterpretor = MailMessageInterpretorFactory.Instance.GetIntepretor(msg.MessageClass)
			Dim eml As MailMessage = mi.InterpretAsTnef(msg)
			' ExEnd:CreatingTNEFFromMSG
		End Sub
	End Class
End Namespace