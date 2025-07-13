Imports System.Net
Imports System.Net.HttpListener
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Threading.Tasks
Imports System.IO


Public Class Form1

    Private listener As HttpListener
    Private listenerTask As Task
    Private selectedIP As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbSchede.Items.Clear()
        CheckBox1.Checked = My.Settings.enter
        chkKeyboard.Checked = My.Settings.sendoutput
        chkKeyboard.Checked = My.Settings.csvsave
        For Each nic In NetworkInterface.GetAllNetworkInterfaces()
            If nic.OperationalStatus = OperationalStatus.Up AndAlso
               (nic.NetworkInterfaceType = NetworkInterfaceType.Ethernet OrElse
                nic.NetworkInterfaceType = NetworkInterfaceType.Wireless80211) Then
                For Each ipInfo In nic.GetIPProperties().UnicastAddresses
                    If ipInfo.Address.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                        cmbSchede.Items.Add($"{nic.Name} - {ipInfo.Address}")
                    End If
                Next
            End If
        Next
        cmbSchede.SelectedIndex = cmbSchede.SelectedItem
        If cmbSchede.Items.Count > 0 Then cmbSchede.SelectedIndex = 0
        lblConn.Text = "Server non avviato"
        lblConn.BackColor = Color.LightGray
    End Sub
    Private Sub btnAvvia_Click(sender As Object, e As EventArgs) Handles btnAvvia.Click
        Try
            If cmbSchede.SelectedItem Is Nothing Then
                MessageBox.Show("Seleziona una scheda di rete.")
                Return
            End If
            cmbSchede.Enabled = False
            selectedIP = cmbSchede.SelectedItem.ToString().
                         Split("-"c).Last().Trim()
            lblIP.Text = $"IP: {selectedIP}"
            listener = New HttpListener()
            listener.Prefixes.Add($"http://{selectedIP}:8080/")
            listener.Start()

            listenerTask = Task.Run(AddressOf StartListener)

            lblConn.Text = $"Server in ascolto sulla porta 8080"
            lblConn.BackColor = Color.LightGreen
            btnAvvia.Enabled = False
        Catch ex As Exception
            MessageBox.Show($"Errore avvio server: {ex.Message}")
        End Try
    End Sub
    Private Sub StartListener()
        While listener IsNot Nothing AndAlso listener.IsListening
            Try
                Dim context = listener.GetContext()
                Dim barcode = context.Request.QueryString("data")

                If Not String.IsNullOrEmpty(barcode) Then
                    Me.Invoke(Sub() HandleBarcode(barcode))
                End If
                Dim buffer = Encoding.UTF8.GetBytes("OK")
                context.Response.ContentLength64 = buffer.Length
                context.Response.OutputStream.Write(buffer, 0, buffer.Length)
                context.Response.Close()
            Catch ex As HttpListenerException
                Exit While
            Catch
            End Try
        End While
    End Sub
    Private Sub HandleBarcode(code As String)
        lblRicevuto.Text = $"Ultimo codice: {code}"
        lblRicevuto.BackColor = Color.Yellow
        Timer1.Start()
        If CheckBox2.Checked Then
            Try
                File.AppendAllText("log.csv",
                                   $"{DateTime.Now:yyyy-MM-dd HH:mm:ss};{code}{Environment.NewLine}")
            Catch ex As Exception

            End Try
        End If

        If chkKeyboard.Checked Then
            Try
                SendKeys.SendWait(code & "{ENTER}")
            Catch ex As Exception
                MessageBox.Show($"Errore simulazione tastiera: {ex.Message}")
            End Try
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblRicevuto.BackColor = SystemColors.Control
        Timer1.Stop()
    End Sub
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        Try
            listener?.Stop()
            listener?.Close()
        Catch
        End Try
        MyBase.OnFormClosing(e)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        My.Settings.enter = CheckBox1.Checked
    End Sub

    Private Sub chkKeyboard_CheckedChanged(sender As Object, e As EventArgs) Handles chkKeyboard.CheckedChanged
        My.Settings.sendoutput = chkKeyboard.Checked
    End Sub

    Private Sub cmbSchede_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSchede.SelectedIndexChanged
        My.Settings.schedaeth = cmbSchede.SelectedItem
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        My.Settings.csvsave = chkKeyboard.Checked
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/pannisco/barcodetopc")
    End Sub
End Class