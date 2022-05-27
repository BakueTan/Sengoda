Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports SecuGen.FDxSDKPro.Windows


Public Class scana
    Public m_FPM As SGFingerPrintManager
    Dim m_LedOn As Boolean
    Dim m_ImageWidth As Int32
    Dim m_ImageHeight As Int32
    Dim m_RegMin1(400) As Byte
    Dim m_RegMin2(400) As Byte
    Dim m_VrfMin(400) As Byte
    Dim m_DevList() As SGFPMDeviceList
    Dim pinfo As SGFPMDeviceInfoParam
    Public img_qlty As Int32
    Public enum_device As String



    Public Sub init()
        ' m_LedOn = False
        ' comboBoxSecuLevel_R.SelectedIndex = 4
        ' comboBoxSecuLevel_V.SelectedIndex = 3
        ' EnableButtons(False)
        cnctera = False
        getinfoera = False
        drawera = False
        nodev_era = False

        Dim iError As Int32

        Dim i As Int32

        '  comboBoxDeviceName.Items.Clear()
        m_FPM = New SGFingerPrintManager
        ' Enumerate Device
        iError = m_FPM.EnumerateDevice()

        'Get enumeration info into SGFPMDeviceList
        ReDim m_DevList(m_FPM.NumberOfDevice)


        For i = 0 To m_FPM.NumberOfDevice - 1

            m_DevList(i) = New SGFPMDeviceList
            m_FPM.GetEnumDeviceInfo(i, m_DevList(i))

            enum_device = m_DevList(i).DevName.ToString() + " : " + Convert.ToString(m_DevList(i).DevID)
            ' comboBoxDeviceName.Items.Add(enum_device)

            ' If (comboBoxDeviceName.Items.Count > 0) Then
            'comboBoxDeviceName.SelectedIndex = 0
            ' End If

        Next


        ' EnumerateBtn_Click(sender, e)
    End Sub

    Public Sub open_device()
        Dim iError As Int32
        Dim device_name As SGFPMDeviceName
        Dim device_id As Int32

        If m_FPM.NumberOfDevice = 0 Then
            nodev_era = True
        Else
            nodev_era = False
        End If
        ' m_FPM = New SGFingerPrintManager
        ' device_name = SGFPMDeviceName.DEV_FDU03
        ' device_id = 0

        Try
            device_name = m_DevList(0).DevName
            device_id = m_DevList(0).DevID
        Catch ex As Exception

        End Try


        iError = m_FPM.Init(device_name)
        iError = m_FPM.OpenDevice(device_id)

        If (iError = SGFPMError.ERROR_NONE) Then
            ' get_info()
            '  GetBtn_Click(sender, e)
            ' StatusBar.Text = "Initialization Success"
            ' EnableButtons(True)

            ' FDU03 or FDU04 only
            If ((device_name = SGFPMDeviceName.DEV_FDU03) Or (device_name = SGFPMDeviceName.DEV_FDU04)) Then


                'CheckBoxAutoOn.Enabled = True
            Else
                ' CheckBoxAutoOn.Enabled = False
            End If

        Else
            ' MsgBox("Failed to open device")
            cnctera = True
            ' Exit Sub

        End If
    End Sub

    Public Sub DrawImage(ByVal imgData() As Byte, ByVal picBox As PictureBox)
        Dim colorval As Int32
        Dim bmp As Bitmap
        Dim i, j As Int32
        Try
            bmp = New Bitmap(m_ImageWidth, m_ImageHeight)
            picBox.Image = bmp

            For i = 0 To bmp.Width - 1
                For j = 0 To bmp.Height - 1
                    colorval = imgData((j * m_ImageWidth) + i)
                    bmp.SetPixel(i, j, Color.FromArgb(colorval, colorval, colorval))
                Next j
            Next i

        Catch ex As Exception
            drawera = True
        End Try

        picBox.Refresh()
    End Sub

    Public Function get_info() As Byte()
        Dim fp_image() As Byte
        Dim iError As Int32


        ' m_FPM = New SGFingerPrintManager

        pinfo = New SGFPMDeviceInfoParam
        iError = m_FPM.GetDeviceInfo(pinfo)

        If (iError = SGFPMError.ERROR_NONE) Then
            m_ImageWidth = pinfo.ImageWidth
            m_ImageHeight = pinfo.ImageHeight

        End If

        ReDim fp_image(m_ImageWidth * m_ImageHeight)

        iError = m_FPM.GetImage(fp_image)

        If iError = SGFPMError.ERROR_NONE Then
            '  DrawImage(fp_image, PictureBoxR1)
            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, img_qlty)
            ' progressBar_R1.Value = img_qlty
            iError = m_FPM.CreateTemplate(fp_image, m_RegMin1)
            temp1 = m_RegMin1

            If (iError = SGFPMError.ERROR_NONE) Then
                ' MsgBox("First image is captured")
            Else
                MsgBox("CreateTemplate", iError)
            End If
        Else
            getinfoera = True
        End If
        Return fp_image
    End Function


    Public Function get_info2() As Byte()
        Dim fp_image() As Byte
        Dim iError As Int32
        Dim img_qlty As Int32

        ' m_FPM = New SGFingerPrintManager

        pinfo = New SGFPMDeviceInfoParam
        iError = m_FPM.GetDeviceInfo(pinfo)

        If (iError = SGFPMError.ERROR_NONE) Then
            m_ImageWidth = pinfo.ImageWidth
            m_ImageHeight = pinfo.ImageHeight

        End If

        ReDim fp_image(m_ImageWidth * m_ImageHeight)

        iError = m_FPM.GetImage(fp_image)

        If iError = SGFPMError.ERROR_NONE Then
            '  DrawImage(fp_image, PictureBoxR1)
            m_FPM.GetImageQuality(m_ImageWidth, m_ImageHeight, fp_image, img_qlty)
            ' progressBar_R1.Value = img_qlty
            iError = m_FPM.CreateTemplate(fp_image, m_RegMin2)
            temp2 = m_RegMin2

            If (iError = SGFPMError.ERROR_NONE) Then
                ' MsgBox("First image is captured")
            Else
                MsgBox("CreateTemplate", iError)
            End If
        Else
            MsgBox("error")
        End If
        Return fp_image
    End Function




End Class
