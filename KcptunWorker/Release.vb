Imports System.Net
'{
'    "listen": ":29900",
'    "target": "127.0.0.1:8388",
'    "key": "test",
'    "crypt": "salsa20",
'    "mode": "fast2",
'    "mtu": 1350,
'    "sndwnd": 1024,
'    "rcvwnd": 1024,
'    "datashard": 70,
'    "parityshard": 30,
'    "dscp": 46,
'    "nocomp": false,
'    "acknodelay": false,
'    "nodelay": 0,
'    "interval": 40,
'    "resend": 0,
'    "nc": 0,
'    "sockbuf": 4194304,
'    "keepalive": 10
'}
Public Class Release
    Property Name As String
    Property ExefilePath As String
    Property Paramenters As String
    Property EnableLogging As Boolean
    Property AutoRestart As Boolean
    Property Enabled As Boolean
End Class
