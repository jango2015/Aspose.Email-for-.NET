﻿Imports Aspose.Email.Exchange

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email.Exchange
	Class GetMailboxInformationFromExchangeServer
		Public Shared Sub Run()
			' ExStart:GetMailboxInformationFromExchangeServer 
			' Create instance of ExchangeClient class by giving credentials
			Dim client As New ExchangeClient("https://MachineName/exchange/Username", "Username", "password", "domain")

			' Get mailbox size, exchange mailbox info, Mailbox, Inbox folder, Sent Items folder URI , Drafts folder URI
			Console.WriteLine("Mailbox size: " + client.GetMailboxSize() + " bytes")
			Dim mailboxInfo As ExchangeMailboxInfo = client.GetMailboxInfo()
			Console.WriteLine("Mailbox URI: " + mailboxInfo.MailboxUri)
			Console.WriteLine("Inbox folder URI: " + mailboxInfo.InboxUri)
			Console.WriteLine("Sent Items URI: " + mailboxInfo.SentItemsUri)
			Console.WriteLine("Drafts folder URI: " + mailboxInfo.DraftsUri)
			' ExEnd:GetMailboxInformationFromExchangeServer
		End Sub
	End Class
End Namespace