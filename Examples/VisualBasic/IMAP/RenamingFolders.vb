﻿Imports System.IO
Imports Aspose.Email.Mail
Imports Aspose.Email.Outlook
Imports Aspose.Email.Pop3
Imports Aspose.Email
Imports Aspose.Email.Mime
Imports Aspose.Email.Imap
Imports System.Configuration
Imports System.Data
Imports Aspose.Email.Mail.Bounce
Imports Aspose.Email.Exchange

Namespace Aspose.Email.Examples.VisualBasic.Email.IMAP

    Public Class RenamingFolders
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_IMAP()
            Dim dstEmail As String = dataDir & Convert.ToString("1234.eml")

            'Create an instance of the ImapClient class
            Dim client As New ImapClient()

            'Specify host, username and password for your client
            client.Host = "imap.gmail.com"

            ' Set username
            client.Username = "your.username@gmail.com"

            ' Set password
            client.Password = "your.password"

            ' Set the port to 993. This is the SSL port of IMAP server
            client.Port = 993

            ' Enable SSL
            client.SecurityOptions = SecurityOptions.Auto

            Try
                ' Rename a folder
                client.RenameFolder("Aspose", "Client")

                'Disconnect to the remote IMAP server

                client.Dispose()
            Catch ex As Exception
                System.Console.Write(Environment.NewLine + ex.ToString())
            End Try

            Console.WriteLine(Environment.NewLine + "Renamed folders on IMAP server.")
        End Sub
    End Class
End Namespace