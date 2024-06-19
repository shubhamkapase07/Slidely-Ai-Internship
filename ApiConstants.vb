Module ApiConstants
    ' Base URL for the backend server
    Public Const BaseUrl As String = "http://localhost:3000"
    ' Endpoint URLs
    Public Const SubmitUrl As String = BaseUrl & "/submit"
    Public Const ReadUrl As String = BaseUrl & "/read"
    Public Const PingUrl As String = BaseUrl & "/ping"
End Module
