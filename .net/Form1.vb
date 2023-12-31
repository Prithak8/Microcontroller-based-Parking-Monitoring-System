﻿'Desktop Application Framework code'

Imports System.IO                  'Importing the required libraries'
Imports System.IO.Ports

Public Class Parking_Lot_Status

    Dim value1 As Integer           'Set value1 as a ineger'

    'THIS FUNCTION GIVES THE SETUP OF SERIALPORT1'
    Private Sub Parking_Lot_Status_Load(sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        SerialPort1.Close()
        SerialPort1.PortName = "COM3"               'SET THE NAME OF SERIAL PORT'
        SerialPort1.BaudRate = "9600"               'SET THE BAUD RATE'
        SerialPort1.DataBits = 8                    'NUMBER OF BITS TO BE TRANSMITTED TO DESDKTOP APP'
        SerialPort1.Parity = Parity.None            'NO PARITY'
        SerialPort1.StopBits = StopBits.One         'STOP BITS SET TO ONE'
        SerialPort1.Handshake = Handshake.None      'NO HANDSHAKE'
        SerialPort1.Encoding = System.Text.Encoding.Default           'TEXT ENCODING SET TO DEFAULT'
        SerialPort1.Open()
    End Sub

    'THE FOLLOWING CODE EXECUTES EVERY TWO SECONDS'
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim s As String     'STORAGE OF COMPLETE MESSAGE IS DONE IN VARIABLE S'
        s = TextBox1.Text + "," + "," + "," + "," + "," + "," + ""

        Dim somestring() As String
        ' Split string based on comma
        somestring = s.Split(New Char() {","c})     'ENTIRE MESSAGE WILL SPLIT INTO SIX STRINGS'

        'EACH SPLITTED STRING WILL BE DISPLAYED IN THE CORRESPONDING TEXTBOX'
        TextBox2.Text = somestring(0)
        TextBox3.Text = somestring(1)
        TextBox_4.Text = somestring(2)
        TextBox5.Text = somestring(3)
        TextBox6.Text = somestring(4)
        TextBox7.Text = somestring(5)
        TextBox1.Text = ""

    End Sub


    'THE PURPOSE OF THIS FUNCTION IS TO READ THE SERIAL PORT AND STORE THE MESSAGE TO TEXTBOX 1'
    Private Sub DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim mydata As String = ""
            mydata = SerialPort1.ReadExisting()

            If TextBox1.InvokeRequired Then
                TextBox1.Invoke(DirectCast(Sub() TextBox1.Text &= mydata, MethodInvoker))
            Else
                TextBox1.Text &= mydata
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    'ALL THE FOLLOWING SUB-FUNCTION CHECKS IF THE VEHICLE IS IN-FRONT OF THE SENSOR OR NOT'
    'FOR EG IF P1S1ON IS SENT FROM ARDUINO TO DESKTOP APP THEN THERE IS CAR IN FRONT OF THE SENSOR ORELSE THERE ISN'T'
    'IF THE CONDITION IS SATISFIED THEN ITS RESPECTIVE CHECKBOXES ARE CHECKED OR ELSE IT IS UNCHECKED'
    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If InStr(TextBox2.Text, "p1s1on") Then
            chkp1slot1.Checked = True
        End If

        If InStr(TextBox2.Text, "p1s1off") Then
            chkp1slot1.Checked = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If InStr(TextBox3.Text, "p1s2on") Then
            chkp1slot2.Checked = True
        End If

        If InStr(TextBox3.Text, "p1s2off") Then
            chkp1slot2.Checked = False
        End If
    End Sub

    Private Sub TextBox_4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox_4.TextChanged
        If InStr(TextBox_4.Text, "p1s3on") Then
            chkp1slot3.Checked = True
        End If

        If InStr(TextBox_4.Text, "p1s3off") Then
            chkp1slot3.Checked = False
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        If InStr(TextBox5.Text, "p2s1on") Then
            chkp2slot1.Checked = True
        End If

        If InStr(TextBox5.Text, "p2s1off") Then
            chkp2slot1.Checked = False
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        If InStr(TextBox6.Text, "p2s2on") Then
            chkp2slot2.Checked = True
        End If

        If InStr(TextBox6.Text, "p2s2off") Then
            chkp2slot2.Checked = False
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged
        If InStr(TextBox7.Text, "p2s3on") Then
            chkp2slot3.Checked = True
        End If

        If InStr(TextBox7.Text, "p2s3off") Then
            chkp2slot3.Checked = False
        End If
    End Sub
End Class