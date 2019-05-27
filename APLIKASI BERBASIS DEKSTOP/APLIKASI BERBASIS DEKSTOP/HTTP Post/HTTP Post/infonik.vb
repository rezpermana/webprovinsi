Imports System.Net
Imports System.Text
Imports System.IO
Imports Newtonsoft.Json
Public Class infonik

    Dim logincookie As CookieContainer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Dim postData As String = kotak_provinsi1.Text
        Dim tempCookies As New CookieContainer
        Dim encoding As New UTF8Encoding
        Dim byteData As Byte() = encoding.GetBytes(postData)

        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create(" http://localhost/api_infonik/infonik/post.php?nik=" + postData), HttpWebRequest)
        postReq.Method = "POST"
        postReq.KeepAlive = True
        postReq.CookieContainer = tempCookies
        postReq.ContentType = "application/x-ww-form-urlencoded"
        postReq.Referer = " http://localhost/api_infonik/infonik/"
        postReq.UserAgent = "Mozila/5.0 (Windows NT 6.1; WOW64; rv:26.0) Gecko/20100101 Firefox/26.0"
        postReq.ContentLength = byteData.Length

        Dim postreqstream As Stream = postReq.GetRequestStream()
        postreqstream.Write(byteData, 0, byteData.Length)
        postreqstream.Close()
        Dim postrespon As HttpWebResponse

        postrespon = DirectCast(postReq.GetResponse(), HttpWebResponse)
        tempCookies.Add(postrespon.Cookies)
        logincookie = tempCookies
        Dim postreqreader As New StreamReader(postrespon.GetResponseStream())

        Dim thepage As String = postreqreader.ReadToEnd

        Dim jsontext As String = thepage

        Dim readingJson = Newtonsoft.Json.Linq.JObject.Parse(jsontext)

        With readingJson
            kotak_namaprov.Text = .Item("provinsi").ToString
            kotak_namaibukota.Text = .Item("ibukota").ToString
            kotak_wisata.Text = .Item("tempatwisata").ToString
            kotak_makanankhas.Text = .Item("wisatakuliner").ToString
        End With

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_reset.Click
        kotak_namaprov.Text = ""
        kotak_namaibukota.Text = ""
        kotak_makanankhas.Text = ""
    End Sub


End Class
