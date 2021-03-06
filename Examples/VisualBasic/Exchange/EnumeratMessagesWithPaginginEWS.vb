﻿Imports System.Collections.Generic
Imports Aspose.Email.Exchange

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email.Exchange
	Class EnumeratMessagesWithPaginginEWS
		Public Shared Sub Run()
			' ExStart:EnumeratMessagesWithPaginginEWS
			' Create instance of ExchangeWebServiceClient class by giving credentials
			Dim client As IEWSClient = EWSClient.GetEWSClient("https://outlook.office365.com/ews/exchange.asmx", "Shabir.haider@studentpartner.com", "LoveAir1993")

			' Call ListMessages method to list messages info from Inbox
			Dim msgCollection As ExchangeMessageInfoCollection = client.ListMessages(client.GetMailboxInfo().InboxUri)

			Try
				Dim itemsPerPage As Integer = 5
				Dim pages As New List(Of ExchangeMessageInfoCollection)()
				Dim pagedMessageInfoCol As ExchangeMessageInfoCollection = client.ListMessages(client.MailboxInfo.InboxUri, itemsPerPage)
				pages.Add(pagedMessageInfoCol)

				While Not pagedMessageInfoCol.LastPage
					pagedMessageInfoCol = client.ListMessages(client.MailboxInfo.InboxUri, itemsPerPage, pagedMessageInfoCol.LastItemOffset.Value + 1)
					pages.Add(pagedMessageInfoCol)
				End While

				pagedMessageInfoCol = client.ListMessages(client.MailboxInfo.InboxUri, itemsPerPage)

				While Not pagedMessageInfoCol.LastPage
					client.ListMessages(client.MailboxInfo.InboxUri, pagedMessageInfoCol, itemsPerPage, pagedMessageInfoCol.LastItemOffset.Value + 1)
				End While

			Finally
			End Try
			' ExEnd:EnumeratMessagesWithPaginginEWS
		End Sub
	End Class
End Namespace