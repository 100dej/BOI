Imports System.Net
Module NPIConnect
    Public CBIT60a As String = "Provider=SQLOLEDB;Server=172.20.76.29;Integrated Security=SSPI;Database=MISDB"
    Public CBIT60 As String = "Provider=SQLOLEDB;Server=172.20.76.29;UID=MISDB02;PWD=MISDB02RY;Database=MISDB"
    Public NPIRYSV62FootBall As String = "Provider=SQLOLEDB;Server=172.31.195.13;UID=sa;PWD=sqlrayong;Database=DBFootBallNPI"
    Public NPIRYSV62DWH As String = "Provider=SQLOLEDB;Server=172.31.195.13;UID=sa;PWD=sqlrayong;Database=DBWMS"
    Public NPIRYSV62PlanningS As String = "Provider=SQLOLEDB;Server=172.31.195.13;UID=sa;PWD=sqlrayong;Database=PlanningS"
    Public NPIRYSV62BOI As String = "Provider=SQLOLEDB;Server=172.31.195.13;UID=sa;PWD=sqlrayong;Database=BOI"
    Public LocalMe As String = "Provider=SQLOLEDB;Server=NPIR-08101-1107;UID=SA;PWD=passcon;Database=MISDB"
    Public Uname As String = Environ("UserName")
    Public hostname As String = Dns.GetHostName()
    Public ipaddress As String = CType(Dns.GetHostByName(hostname).AddressList.GetValue(0), IPAddress).ToString
End Module
